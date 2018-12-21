
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Net.Http
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Web.Http

Namespace WebAPIServer.Result
    Public Class ChallengeResult
        Implements IHttpActionResult
        Public Sub New(loginProviderParam As String, controller As ApiController)
            LoginProvider = loginProviderParam
            Request = controller.Request
        End Sub

        Public Property LoginProvider() As String
            Get
                Return m_LoginProvider
            End Get
            Set
                m_LoginProvider = Value
            End Set
        End Property
        Private m_LoginProvider As String
        Public Property Request() As HttpRequestMessage
            Get
                Return m_Request
            End Get
            Set
                m_Request = Value
            End Set
        End Property
        Private m_Request As HttpRequestMessage

        Private Function IHttpActionResult_ExecuteAsync(cancellationToken As CancellationToken) As Task(Of HttpResponseMessage) Implements IHttpActionResult.ExecuteAsync
            Request.GetOwinContext().Authentication.Challenge(LoginProvider)

            Dim response As New HttpResponseMessage(HttpStatusCode.Unauthorized)
            response.RequestMessage = Request
            Return Task.FromResult(response)
        End Function
    End Class
End Namespace

