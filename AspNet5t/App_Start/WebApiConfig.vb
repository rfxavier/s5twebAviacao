Imports System.Web.Http
Imports System.Net.Http.Formatting
Imports Newtonsoft.Json.Serialization
Imports System.Web.Http.Cors
Imports Microsoft.Owin.Security.OAuth
Imports System.Net.Http.Headers
Public Class WebApiConfig
    Public Shared Sub Register(config As HttpConfiguration)
        'DEFAULTS TO JSON
        GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear()

        'Web API routes
        config.MapHttpAttributeRoutes()

        ' Web API configuration and services
        Dim cors = New EnableCorsAttribute("*", "*", "DELETE,GET,HEAD,POST,PUT,OPTIONS,TRACE")
        config.EnableCors(cors)

        '// Web API configuration And services
        '// Configure Web API to use only bearer token authentication.
        config.SuppressDefaultHostAuthentication()
        config.Filters.Add(New HostAuthenticationFilter(OAuthDefaults.AuthenticationType))

        'Convention-based routing.
        'config.Routes.MapHttpRoute(name:="DefaultApi", _
        '                           routeTemplate:="api/{controller}/{id}", _
        '                           defaults:=New With {Key .id = RouteParameter.Optional})

        'IN CASE JSON PAYLOAD IS CAMELCASED, UNCOMMENT BELOW
        'Dim jsonFormatter = config.Formatters.OfType(Of JsonMediaTypeFormatter)().First()
        'jsonFormatter.SerializerSettings.ContractResolver = New CamelCasePropertyNamesContractResolver()
    End Sub

End Class
