Imports System.Net
Imports System.Net.Http
Imports System.Security.Claims
Imports System.Security.Cryptography
Imports System.Threading.Tasks
Imports System.Web.Http
Imports System.Web.Http.Cors
Imports AspNet5t.WebAPIServer.Models
Imports AspNet5t.WebAPIServer.Providers
Imports AspNet5t.WebAPIServer.Result
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin.Security
Imports Microsoft.Owin.Security.Cookies
Imports Microsoft.Owin.Security.DataHandler.Serializer
Imports Microsoft.Owin.Security.OAuth

Namespace webapiControllers

    <EnableCors("*", "*", "*", SupportsCredentials:=True)>
    <Authorize>
    <RoutePrefix("api/Account")>
    Public Class AccountController
        Inherits ApiController

        Public Class ExternalLogin
            Public Property Name As String
            Public Property Url As String
            Public Property State As String

        End Class

        Public Class ManageInfo
            Public Property LocalLoginProvider As String
            Public Property Email As String
            Public Property Logins As IEnumerable(Of UserLoginInfo)
            Public Property ExternalLoginProviders As IEnumerable(Of ExternalLogin)

        End Class

        Public Class UserInfo
            Public Property Email As String
            Public Property HasRegistered As Boolean
            Public Property LoginProvider As String

        End Class

        Public Class UserLoginInfo
            Public Property LoginProvider As String
            Public Property ProviderKey As String
        End Class

        Private Const LocalLoginProvider As String = "Local"
        Private _userManager As ApplicationUserManager

        Public Sub New()
        End Sub

        Public Sub New(userManager As ApplicationUserManager, accessTokenFormat As ISecureDataFormat(Of AuthenticationTicket))
            userManager = userManager
            accessTokenFormat = accessTokenFormat
        End Sub

        Public Property UserManager() As ApplicationUserManager
            Get
                Return If(_userManager, Request.GetOwinContext().GetUserManager(Of ApplicationUserManager)())
            End Get
            Private Set
                _userManager = Value
            End Set
        End Property

        Public Property AccessTokenFormat() As ISecureDataFormat(Of AuthenticationTicket)
            Get
                Return m_AccessTokenFormat
            End Get
            Private Set
                m_AccessTokenFormat = Value
            End Set
        End Property
        Private m_AccessTokenFormat As ISecureDataFormat(Of AuthenticationTicket)

        ' GET api/Account/UserInfo
        <HostAuthentication(DefaultAuthenticationTypes.ExternalBearer)>
        <Route("UserInfo")>
        Public Function GetUserInfo() As UserInfo
            Dim externalLogin As ExternalLoginData = ExternalLoginData.FromIdentity(TryCast(User.Identity, ClaimsIdentity))

            Return New UserInfo() With {
            .Email = User.Identity.GetUserName(),
            .HasRegistered = externalLogin Is Nothing,
            .LoginProvider = If(externalLogin IsNot Nothing, externalLogin.LoginProvider, Nothing)
        }
        End Function

        ' POST api/Account/Logout
        <Route("Logout")>
        Public Function Logout() As IHttpActionResult
            Authentication.SignOut(CookieAuthenticationDefaults.AuthenticationType)
            Return Ok()
        End Function

        ' GET api/Account/ManageInfo?returnUrl=%2F&generateState=true
        <Route("ManageInfo")>
        Public Function GetManageInfo(returnUrl As String, Optional generateState As Boolean = False) As ManageInfo
            'Dim user As IdentityUser = UserManager.FindByIdAsync(user.Identity.GetUserId())
            Dim userAux = UserManager.FindByName(User.Identity.GetUserName)

            If userAux Is Nothing Then
                Return Nothing
            End If

            Dim logins As New List(Of UserLoginInfo)

            For Each linkedAccount In userAux.Logins
                logins.Add(New UserLoginInfo With {.LoginProvider = linkedAccount.ProviderName,
                                                   .ProviderKey = linkedAccount.ProviderKey
                                                  })
            Next

            If userAux.Password IsNot Nothing Then
                logins.Add(New UserLoginInfo With {.LoginProvider = LocalLoginProvider,
                                                   .ProviderKey = userAux.UserName
                                                  })
            End If

            Return New ManageInfo With {.LocalLoginProvider = LocalLoginProvider,
                                        .Email = userAux.UserName,
                                        .Logins = logins,
                                        .ExternalLoginProviders = GetExternalLogins(returnUrl, generateState)
                                       }
        End Function

        ' POST api/Account/ChangePassword
        <Route("ChangePassword")>
        Public Function ChangePassword(model As ChangePasswordBindingModel) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            Dim result As IdentityResult = UserManager.ChangePassword(User.Identity.GetUserId(), model.OldPassword, model.NewPassword)

            If Not result.Succeeded Then
                Return GetErrorResult(result)
            End If

            Return Ok()
        End Function

        ' POST api/Account/SetPassword
        <Route("SetPassword")>
        Public Function SetPassword(model As SetPasswordBindingModel) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            Dim result As IdentityResult = UserManager.AddPassword(User.Identity.GetUserId(), model.NewPassword)

            If Not result.Succeeded Then
                Return GetErrorResult(result)
            End If

            Return Ok()
        End Function

        ' POST api/Account/AddExternalLogin
        <Route("AddExternalLogin")>
        Public Function AddExternalLogin(model As AddExternalLoginBindingModel) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            Authentication.SignOut(DefaultAuthenticationTypes.ExternalCookie)

            Dim ticket As AuthenticationTicket = AccessTokenFormat.Unprotect(model.ExternalAccessToken)

            If ticket Is Nothing OrElse ticket.Identity Is Nothing OrElse (ticket.Properties IsNot Nothing AndAlso ticket.Properties.ExpiresUtc.HasValue AndAlso ticket.Properties.ExpiresUtc.Value < DateTimeOffset.UtcNow) Then
                Return BadRequest("External login failure.")
            End If

            Dim externalData As ExternalLoginData = ExternalLoginData.FromIdentity(ticket.Identity)

            If externalData Is Nothing Then
                Return BadRequest("The external login is already associated with an account.")
            End If

            Dim result As IdentityResult = UserManager.AddLogin(User.Identity.GetUserId(), New Microsoft.AspNet.Identity.UserLoginInfo(externalData.LoginProvider, externalData.ProviderKey))

            If Not result.Succeeded Then
                Return GetErrorResult(result)
            End If

            Return Ok()
        End Function

        ' POST api/Account/RemoveLogin
        <Route("RemoveLogin")>
        Public Function RemoveLogin(model As RemoveLoginBindingModel) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            Dim result As IdentityResult

            If model.LoginProvider = LocalLoginProvider Then
                result = UserManager.RemovePassword(User.Identity.GetUserId())
            Else
                result = UserManager.RemoveLogin(User.Identity.GetUserId(), New Microsoft.AspNet.Identity.UserLoginInfo(model.LoginProvider, model.ProviderKey))
            End If

            If Not result.Succeeded Then
                Return GetErrorResult(result)
            End If

            Return Ok()
        End Function

        ' GET api/Account/ExternalLogin
        <OverrideAuthentication>
        <HostAuthentication(DefaultAuthenticationTypes.ExternalCookie)>
        <AllowAnonymous>
        <Route("ExternalLogin", Name:="ExternalLogin")>
        Public Function GetExternalLogin(provider As String, Optional [error] As String = Nothing) As IHttpActionResult
            If [error] IsNot Nothing Then
                Return Redirect(String.Format("{0}#error={1}", Url.Content("~/"), Uri.EscapeDataString([error])))
            End If

            If Not User.Identity.IsAuthenticated Then
                Return New ChallengeResult(provider, Me)
            End If

            Dim externalLogin As ExternalLoginData = ExternalLoginData.FromIdentity(TryCast(User.Identity, ClaimsIdentity))

            If externalLogin Is Nothing Then
                Return InternalServerError()
            End If

            If externalLogin.LoginProvider <> provider Then
                Authentication.SignOut(DefaultAuthenticationTypes.ExternalCookie)
                Return New ChallengeResult(provider, Me)
            End If

            Dim userAux = UserManager.Find(New Microsoft.AspNet.Identity.UserLoginInfo(externalLogin.LoginProvider, externalLogin.ProviderKey))

            Dim hasRegistered As Boolean = userAux IsNot Nothing

            If hasRegistered Then
                Authentication.SignOut(DefaultAuthenticationTypes.ExternalCookie)

                'Dim oAuthIdentity As ClaimsIdentity = userAux.GenerateUserIdentity(UserManager, OAuthDefaults.AuthenticationType)
                'Dim cookieIdentity As ClaimsIdentity = userAux.GenerateUserIdentity(UserManager, CookieAuthenticationDefaults.AuthenticationType)
                Dim oAuthIdentity As ClaimsIdentity = UserManager.CreateIdentity(userAux, OAuthDefaults.AuthenticationType)
                Dim cookieIdentity As ClaimsIdentity = UserManager.CreateIdentity(userAux, CookieAuthenticationDefaults.AuthenticationType)

                Dim properties As AuthenticationProperties = ApplicationOAuthProvider.CreateProperties(userAux.UserName)
                Authentication.SignIn(properties, oAuthIdentity, cookieIdentity)
            Else
                'changed
                Dim claims As IEnumerable(Of Claim) = externalLogin.GetClaims()
                Dim identity As New ClaimsIdentity(claims, OAuthDefaults.AuthenticationType)
                Dim p As New AuthenticationProperties(New Dictionary(Of String, String)())
                Dim s As New PropertiesSerializer()

                'IEnumerable<Claim> claims = externalLogin.GetClaims();
                'ClaimsIdentity identity = new ClaimsIdentity(claims, OAuthDefaults.AuthenticationType);
                'Authentication.SignIn(identity);
                Authentication.SignIn(identity)
            End If

            Return Ok()
        End Function

        ' GET api/Account/ExternalLogins?returnUrl=%2F&generateState=true
        <AllowAnonymous>
        <Route("ExternalLogins")>
        Public Function GetExternalLogins(returnUrl As String, Optional generateState As Boolean = False) As IEnumerable(Of ExternalLogin)
            Dim descriptions As IEnumerable(Of AuthenticationDescription) = Authentication.GetExternalAuthenticationTypes()
            Dim logins As New List(Of ExternalLogin)

            Dim state As String

            If generateState Then
                Const strengthInBits As Integer = 256
                state = RandomOAuthStateGenerator.Generate(strengthInBits)
            Else
                state = Nothing
            End If
            ' added 

            Dim redirectUri As String = If(returnUrl.StartsWith("/"), New Uri(Request.RequestUri, returnUrl).AbsoluteUri, returnUrl)


            For Each description As AuthenticationDescription In descriptions
                ' changed 
                Dim login As New ExternalLogin With {.Name = description.Caption,
                                                     .Url = Url.Route("ExternalLogin", New With {.provider = description.AuthenticationType,
                                                                                                 .response_type = "token",
                                                                                                 .client_id = Startup.PublicClientId,
                                                                                                 .redirect_uri = returnUrl,
                                                                                                 .state = state
                                                                                                }),
                                                     .State = state
                                                    }
                logins.Add(login)
            Next

            Return logins
        End Function

        ' POST api/Account/Register
        <AllowAnonymous>
        <Route("Register")>
        Public Function Register(model As RegisterBindingModel) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            'Dim user = New ApplicationUser With {.UserName = model.Email,
            '                                       .Email = model.Email
            '                                      }

            'Dim result As IdentityResult = UserManager.Create(user, model.Password)

            'If Not result.Succeeded Then
            '    Return GetErrorResult(result)
            'End If


            '*--
            'Dim manager = Context.GetOwinContext().GetUserManager(Of ApplicationUserManager)()

            Dim user = New S5T.IdUser() With {.UserName = model.Email, .Email = model.Email}
            Dim result = UserManager.Create(user, model.Password)

            If Not result.Succeeded Then
                Return GetErrorResult(result)
            End If

            Return Ok()
        End Function

        ' POST api/Account/RegisterExternal
        <OverrideAuthentication>
        <HostAuthentication(DefaultAuthenticationTypes.ExternalBearer)>
        <Route("RegisterExternal")>
        Public Function RegisterExternal(model As RegisterExternalBindingModel) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            Dim info = Authentication.GetExternalLoginInfo()
            If info Is Nothing Then
                Return InternalServerError()
            End If

            'Dim user = New ApplicationUser With {.UserName = model.Email,
            '                                      .Email = model.Email
            '                                    }

            'Dim result As IdentityResult = UserManager.Create(user)
            'If Not result.Succeeded Then
            '    Return GetErrorResult(result)
            'End If

            'result = UserManager.AddLogin(user.Id, info.Login)
            'If Not result.Succeeded Then
            '    Return GetErrorResult(result)
            'End If


            '*--
            Dim user = New S5T.IdUser() With {.UserName = model.Email, .Email = model.Email}
            Dim result = UserManager.Create(user)

            If Not result.Succeeded Then
                Return GetErrorResult(result)
            End If

            result = UserManager.AddLogin(user.Id, info.Login)
            If Not result.Succeeded Then
                Return GetErrorResult(result)
            End If

            Return Ok()
        End Function

        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso _userManager IsNot Nothing Then
                _userManager.Dispose()
                _userManager = Nothing
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Helpers"

        Private ReadOnly Property Authentication() As IAuthenticationManager
            Get
                Return Request.GetOwinContext().Authentication
            End Get
        End Property

        Private Function GetErrorResult(result As IdentityResult) As IHttpActionResult
            If result Is Nothing Then
                Return InternalServerError()
            End If

            If Not result.Succeeded Then
                If result.Errors IsNot Nothing Then
                    For Each [error] As String In result.Errors
                        ModelState.AddModelError("", [error])
                    Next
                End If

                If ModelState.IsValid Then
                    ' No ModelState errors are available to send, so just return an empty BadRequest.
                    Return BadRequest()
                End If

                Return BadRequest(ModelState)
            End If

            Return Nothing
        End Function

        Private Class ExternalLoginData
            Public Property LoginProvider() As String
                Get
                    Return m_LoginProvider
                End Get
                Set
                    m_LoginProvider = Value
                End Set
            End Property
            Private m_LoginProvider As String
            Public Property ProviderKey() As String
                Get
                    Return m_ProviderKey
                End Get
                Set
                    m_ProviderKey = Value
                End Set
            End Property
            Private m_ProviderKey As String
            Public Property UserName() As String
                Get
                    Return m_UserName
                End Get
                Set
                    m_UserName = Value
                End Set
            End Property
            Private m_UserName As String
            'added
            Public Property Email() As String
                Get
                    Return m_Email
                End Get
                Set
                    m_Email = Value
                End Set
            End Property
            Private m_Email As String

            Public Function GetClaims() As IList(Of Claim)
                Dim claims As IList(Of Claim) = New List(Of Claim)()
                claims.Add(New Claim(ClaimTypes.NameIdentifier, ProviderKey, Nothing, LoginProvider))

                If UserName IsNot Nothing Then
                    claims.Add(New Claim(ClaimTypes.Name, UserName, Nothing, LoginProvider))
                End If
                'added
                If Email IsNot Nothing Then
                    claims.Add(New Claim(ClaimTypes.Email, Email, Nothing, LoginProvider))
                End If

                '==
                Return claims
            End Function

            Public Shared Function FromIdentity(identity As ClaimsIdentity) As ExternalLoginData
                If identity Is Nothing Then
                    Return Nothing
                End If

                Dim providerKeyClaim As Claim = identity.FindFirst(ClaimTypes.NameIdentifier)

                If providerKeyClaim Is Nothing OrElse [String].IsNullOrEmpty(providerKeyClaim.Issuer) OrElse [String].IsNullOrEmpty(providerKeyClaim.Value) Then
                    Return Nothing
                End If

                If providerKeyClaim.Issuer = ClaimsIdentity.DefaultIssuer Then
                    Return Nothing
                End If

                'added
                Return New ExternalLoginData() With {.LoginProvider = providerKeyClaim.Issuer,
                                                     .ProviderKey = providerKeyClaim.Value,
                                                     .UserName = identity.FindFirstValue(ClaimTypes.Name),
                                                     .Email = identity.FindFirstValue(ClaimTypes.Email)
                                                    }
            End Function
        End Class

        Private NotInheritable Class RandomOAuthStateGenerator
            Private Sub New()
            End Sub
            Private Shared _random As RandomNumberGenerator = New RNGCryptoServiceProvider()

            Public Shared Function Generate(strengthInBits As Integer) As String
                Const bitsPerByte As Integer = 8

                If strengthInBits Mod bitsPerByte <> 0 Then
                    Throw New ArgumentException("strengthInBits must be evenly divisible by 8.", "strengthInBits")
                End If

                Dim strengthInBytes As Integer = strengthInBits \ bitsPerByte

                Dim data As Byte() = New Byte(strengthInBytes - 1) {}
                _random.GetBytes(data)
                Return HttpServerUtility.UrlTokenEncode(data)
            End Function
        End Class

#End Region
    End Class

End Namespace