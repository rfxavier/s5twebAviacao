Public Class stubProducaoPedido
    Public Function getProducaoPedido() As System.Collections.Generic.List(Of AspNet5t.dsProducaoPedido.S5TProducaoPedido)

        getProducaoPedido = AspNet5t.dsProducaoPedido.GetProducaoPedido(False)
    End Function

    Public Sub New()
        Me.getProducaoPedido()
    End Sub

End Class
