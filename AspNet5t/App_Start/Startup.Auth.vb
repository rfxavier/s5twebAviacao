Imports System
Imports Microsoft.AspNet.Identity
Imports S5T
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin
Imports Microsoft.Owin.Security.Cookies
Imports Microsoft.Owin.Security.DataProtection
Imports Microsoft.Owin.Security.Google
Imports Owin
Imports Microsoft.Owin.Security.OAuth
Imports AspNet5t.WebAPIServer.Providers

Partial Public Class Startup

    Public Const MicrosoftClientID As String = ""
    Public Const MicrosoftSecret As String = ""

    Public Const FacebookAppID As String = "1430818973893850"
    Public Const FacebookSecret As String = "7342ab8e4669dd12d81bc1196b9cceaa"

    Public Const TwitterKey As String = "" '"ujBJf6SlNxvE7PDQPOHu62uo1" 
    Public Const TwitterSecret As String = "" '"JA2WRDxQvpAzUfvrQlerBX3xpBPxQ8tChRBsD1jwxNTTgmvxQI" 

    Public Const GoogleClientID As String = ""
    Public Const GoogleSecret As String = ""

    Public Shared Property PublicClientId() As String
        Get
            Return m_PublicClientId
        End Get
        Private Set
            m_PublicClientId = Value
        End Set
    End Property
    Private Shared m_PublicClientId As String

    ' For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301883
    Public Sub ConfigureAuth(app As IAppBuilder)
        'Configure the db context, user manager and signin manager to use a single instance per request
        'app.CreatePerOwinContext(AddressOf ApplicationDbContext.Create)
        app.CreatePerOwinContext(Of ApplicationUserManager)(AddressOf ApplicationUserManager.Create)
        app.CreatePerOwinContext(Of ApplicationSignInManager)(AddressOf ApplicationSignInManager.Create)

        ' Enable the application to use a cookie to store information for the signed in user
        app.UseCookieAuthentication(New CookieAuthenticationOptions() With {
            .SlidingExpiration = True,
            .ExpireTimeSpan = TimeSpan.FromDays(2000),
            .CookieName = "AspNetBI4T",
            .AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            .Provider = New CookieAuthenticationProvider() With {
                .OnValidateIdentity = SecurityStampValidator.OnValidateIdentity(Of ApplicationUserManager, IdUser)(
                    validateInterval:=TimeSpan.FromDays(30),
                    regenerateIdentity:=Function(manager, user) manager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie))},
            .LoginPath = New PathString("/LoginRedirect")})
        '.LoginPath = New PathString("/Account/Login")})

        ' Use a cookie to temporarily store information about a user logging in with a third party login provider
        app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie)

        ' Enables the application to temporarily store user information when they are verifying the second factor in the two-factor authentication process.
        app.UseTwoFactorSignInCookie(DefaultAuthenticationTypes.TwoFactorCookie, TimeSpan.FromMinutes(5))

        ' Enables the application to remember the second login verification factor such as phone or email.
        ' Once you check this option, your second step of verification during the login process will be remembered on the device where you logged in from.
        ' This is similar to the RememberMe option when you log in.
        app.UseTwoFactorRememberBrowserCookie(DefaultAuthenticationTypes.TwoFactorRememberBrowserCookie)

        ' Uncomment the following lines to enable logging in with third party login providers
        'app.UseMicrosoftAccountAuthentication(
        '    clientId:= "",
        '    clientSecret:= "")

        'app.UseTwitterAuthentication(
        '   consumerKey:= "",
        '   consumerSecret:= "")

        'app.UseFacebookAuthentication(
        '   appId:= "",
        '   appSecret:= "")

        'app.UseGoogleAuthentication(New GoogleOAuth2AuthenticationOptions() With {
        '   .ClientId = "",
        '   .ClientSecret = ""})

        ' Configure the application for OAuth based flow
        PublicClientId = "self"
        ' In production mode set AllowInsecureHttp = false
        OAuthOptions = New OAuthAuthorizationServerOptions() With {
            .TokenEndpointPath = New PathString("/Token"),
            .Provider = New ApplicationOAuthProvider(PublicClientId),
            .AuthorizeEndpointPath = New PathString("/api/Account/ExternalLogin"),
            .AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
            .AllowInsecureHttp = True
        }

        ' Enable the application to use bearer tokens to authenticate users
        app.UseOAuthBearerTokens(OAuthOptions)
    End Sub
End Class
