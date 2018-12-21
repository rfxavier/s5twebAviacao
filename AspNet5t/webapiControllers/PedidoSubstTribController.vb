Imports System.Web.Http
Imports System.Web.Http.Cors
Imports AspNet5t.PedidoSubstTrib

Namespace webapiControllers
    <Authorize>
    <RoutePrefix("api/PedidoSubstTrib")>
    <EnableCors("*", "*", "*", SupportsCredentials:=True)>
    Public Class PedidoSubstTribController
        Inherits ApiController

        ' GET: api/PedidoSubstTrib
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/PedidoSubstTrib/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/PedidoSubstTrib
        <HttpPost>
        <Route("")>
        Public Function PostValue(<FromBody()> ByVal oPedido As S5TPedido) As IHttpActionResult
            Dim oPedidoProcessado = New S5TPedido

            If oPedido IsNot Nothing Then
                If oPedido.items.Count > 0 Then
                    oPedidoProcessado = ProcessaSubstTribPedido(oPedido)
                End If
            End If

            Return Ok(oPedidoProcessado)
        End Function

        ' PUT: api/PedidoSubstTrib/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/PedidoSubstTrib/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub

    End Class
End Namespace