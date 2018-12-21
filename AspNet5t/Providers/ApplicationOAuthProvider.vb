
Imports System.Collections.Generic
Imports System.Linq
Imports System.Security.Claims
Imports System.Threading.Tasks
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin.Security
Imports Microsoft.Owin.Security.Cookies
Imports Microsoft.Owin.Security.OAuth

Namespace WebAPIServer.Providers
    Public Class ApplicationOAuthProvider
        Inherits OAuthAuthorizationServerProvider
        Private ReadOnly _publicClientId As String

        Public Sub New(publicClientId As String)
            If publicClientId Is Nothing Then
                Throw New ArgumentNullException("publicClientId")
            End If

            _publicClientId = publicClientId
        End Sub

        Public Overrides Function GrantResourceOwnerCredentials(context As OAuthGrantResourceOwnerCredentialsContext) As Task
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", {"*"})

            Dim userManager = context.OwinContext.GetUserManager(Of ApplicationUserManager)()

            Dim user As S5T.IdUser = userManager.Find(context.UserName, context.Password)

            If user Is Nothing Then
                context.SetError("invalid_grant", "The user name or password is incorrect.")
                Return Task.FromResult(Of Object)(Nothing)
            End If

            Dim oAuthIdentity As ClaimsIdentity = userManager.CreateIdentity(user, OAuthDefaults.AuthenticationType)
            Dim cookiesIdentity As ClaimsIdentity = userManager.CreateIdentity(user, CookieAuthenticationDefaults.AuthenticationType)

            'Dim oAuthIdentity As ClaimsIdentity = user.GenerateUserIdentityAsync(userManager, OAuthDefaults.AuthenticationType)
            'Dim cookiesIdentity As ClaimsIdentity = user.GenerateUserIdentityAsync(userManager, CookieAuthenticationDefaults.AuthenticationType)

            Dim properties As AuthenticationProperties = CreateProperties(user.UserName)
            Dim ticket As New AuthenticationTicket(oAuthIdentity, properties)
            context.Validated(ticket)
            context.Request.Context.Authentication.SignIn(cookiesIdentity)

            Return Task.FromResult(Of Object)(Nothing)
        End Function

        Public Overrides Function TokenEndpoint(context As OAuthTokenEndpointContext) As Task
            For Each [property] As KeyValuePair(Of String, String) In context.Properties.Dictionary
                context.AdditionalResponseParameters.Add([property].Key, [property].Value)
            Next

            Return Task.FromResult(Of Object)(Nothing)
        End Function

        Public Overrides Function ValidateClientAuthentication(context As OAuthValidateClientAuthenticationContext) As Task
            ' Resource owner password credentials does not provide a client ID.
            If context.ClientId Is Nothing Then
                context.Validated()
            End If

            Return Task.FromResult(Of Object)(Nothing)
        End Function

        Public Overrides Function ValidateClientRedirectUri(context As OAuthValidateClientRedirectUriContext) As Task
            'if (context.ClientId == _publicClientId)
            '{
            '    Uri expectedRootUri = new Uri(context.Request.Uri, "/");

            '    if (expectedRootUri.AbsoluteUri == context.RedirectUri)
            '    {
            '        context.Validated();
            '    }
            '}
            If context.ClientId = _publicClientId Then
                context.Validated()
            End If
            Return Task.FromResult(Of Object)(Nothing)
        End Function

        'added

        Public Overrides Function AuthorizationEndpointResponse(context As OAuthAuthorizationEndpointResponseContext) As Task
            '  Add the claims to the return url
            For Each claim In context.Identity.Claims
                If claim.Type = ClaimsIdentity.DefaultNameClaimType Then
                    context.AdditionalResponseParameters.Add("username", claim.Value)
                ElseIf claim.Type = ClaimTypes.Email Then
                    context.AdditionalResponseParameters.Add("email", claim.Value)
                End If
            Next
            Return MyBase.AuthorizationEndpointResponse(context)
        End Function
        '==
        Public Shared Function CreateProperties(userName As String) As AuthenticationProperties
            Dim data As IDictionary(Of String, String) = New Dictionary(Of String, String)() From {
                {"userName", userName}
            }
            Return New AuthenticationProperties(data)
        End Function

    End Class
End Namespace

