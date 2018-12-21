Imports System.Net.Http
Imports AspNet5t.PedidoSubstTrib

Public Class dsAppForcaVendas
    Public Class PedidosMov
        Public Property pB1_COD As String
        Public Property pQuantidade As Double
        Public Property pQuantidadeCaixas As Double
        Public Property pObservacao As String
        Public Property pNumeroPedido As Long
        Public Property pB1_DESC As String
        Public Property pDA1_PRCVEN As Double
        Public Property pB1_CONV As String
        Public Property pB1_TIPCONV As String
        Public Property pB1_GRUPO As String
        Public Property pB1_ZZPESOP As Double
        Public Property pZP_SALDO As Double
        Public Property pZP_STATUS As String
        Public Property pValorTotalProduto As Double
        Public Property pPed_A1_COD As String
        Public Property pPed_A1_LOJA As String
        Public Property pPed_A1_NOME As String
        Public Property pPed_A3_COD As String
        Public Property pPed_A3_COTA As String
        Public Property pPed_A3_NOME As String
        Public Property pPed_DataEmissao As Date
        Public Property pPed_DataEntrega As Date
        Public Property pPed_FlgStatus As String
        Public Property pPed_Observacao As String
        Public Property pB1_GRUPO_DESC As String
        Public Property pPed_NumeroPedidoCliente As String
        Public Property pPed_WsOrcamento_DESCRICAO As String
        Public Property pPed_WsOrcamento_ITENS As String
        Public Property pPed_WsOrcamento_STATUS As String
        Public Property pPed_A1_END As String

        'APURADOS COM O ProcessaPedidoSubstTrib do Shared com o PedidoSubstTribController
        Public Property pPed_pedidoValorSubstTrib As Double
        Public Property pprodValorSubstTrib As Double

        'APURADO POSTERIOR PARA FACILITAR INFORMAÇÃO
        Public Property pPed_ValorTotalProduto As Double
    End Class

    Public Shared Function GetPedidosMov(ByVal parNumeroPedido As Long) As List(Of PedidosMov)

        Dim pedidosMov = New List(Of PedidosMov)

        Dim pedidosMovCollection = S5T.AppFvendasPedidosMovCollection.LoadByNumeroPedido(parNumeroPedido)

        pedidosMov = pedidosMovCollection.Select(Function(x) New PedidosMov With {
                                                                                    .pB1_COD = x.pB1_COD,
                                                                                    .pB1_CONV = x.pB1_CONV,
                                                                                    .pB1_DESC = x.pB1_DESC,
                                                                                    .pB1_GRUPO = x.pB1_GRUPO,
                                                                                    .pB1_GRUPO_DESC = x.pB1_GRUPO_DESC,
                                                                                    .pB1_TIPCONV = x.pB1_TIPCONV,
                                                                                    .pB1_ZZPESOP = x.pB1_ZZPESOP,
                                                                                    .pDA1_PRCVEN = x.pDA1_PRCVEN,
                                                                                    .pNumeroPedido = x.pNumeroPedido,
                                                                                    .pObservacao = x.pObservacao,
                                                                                    .pPed_A1_COD = x.pPed_A1_COD,
                                                                                    .pPed_A1_END = x.pPed_A1_END,
                                                                                    .pPed_A1_LOJA = x.pPed_A1_LOJA,
                                                                                    .pPed_A1_NOME = x.pPed_A1_NOME,
                                                                                    .pPed_A3_COD = x.pPed_A3_COD,
                                                                                    .pPed_A3_COTA = x.pPed_A3_COTA,
                                                                                    .pPed_A3_NOME = x.pPed_A3_NOME,
                                                                                    .pPed_DataEmissao = x.pPed_DataEmissao,
                                                                                    .pPed_DataEntrega = x.pPed_DataEntrega,
                                                                                    .pPed_FlgStatus = x.pPed_FlgStatus,
                                                                                    .pPed_NumeroPedidoCliente = x.pPed_NumeroPedidoCliente,
                                                                                    .pPed_Observacao = x.pPed_Observacao,
                                                                                    .pPed_WsOrcamento_DESCRICAO = x.pPed_WsOrcamento_DESCRICAO,
                                                                                    .pPed_WsOrcamento_ITENS = x.pPed_WsOrcamento_ITENS,
                                                                                    .pPed_WsOrcamento_STATUS = x.pPed_WsOrcamento_STATUS,
                                                                                    .pQuantidade = x.pQuantidade,
                                                                                    .pQuantidadeCaixas = x.pQuantidadeCaixas,
                                                                                    .pValorTotalProduto = x.pValorTotalProduto,
                                                                                    .pZP_SALDO = x.pZP_SALDO,
                                                                                    .pZP_STATUS = x.pZP_STATUS}).ToList


        Dim oPedido As New S5TPedido

        Dim oPedidoItems As New List(Of S5TPedidoItems)

        'Dim ProducaoPedidoProdutoLoteAgrup = parProducaoPedido.GroupBy(Function(k) New With {Key .C6_FILIAL = k.C6_FILIAL, _
        '                                                                                     Key .C6_PRODUTO = k.C6_PRODUTO, _
        '                                                                                     Key .LOTE_AVIACAO_5POS = k.LOTE_AVIACAO_5POS}).Select(Function(y) New S5TProducaoPedidoProdutoAgrup With {.C6_FILIAL = y.Key.C6_FILIAL, _
        '                                                                                                                                                                                               .C6_PRODUTO = y.Key.C6_PRODUTO, _
        '                                                                                                                                                                                               .LOTE_AVIACAO_5POS = y.Key.LOTE_AVIACAO_5POS, _
        '                                                                                                                                                                                               .QTDVEN = Math.Round(y.Sum(Function(group) group.QTDVEN), 2)}).ToList
        oPedidoItems = pedidosMov.Select(function(x) New S5TPedidoItems With {.B1_COD = x.pB1_COD,
                                                                                .prodValorTotal = x.pValorTotalProduto}).ToList

        oPedido = pedidosMov.GroupBy(Function (k) New With {Key .pPed_A1_COD = k.pPed_A1_COD,
                                                            Key .pPed_A1_LOJA = k.pPed_A1_LOJA,
                                                            Key .pPed_A3_COD = k.pPed_A3_COD,
                                                            Key .pNumeroPedido = k.pNumeroPedido}).Select(function (y) New S5TPedido With {.codCliente = y.Key.pPed_A1_COD,
                                                                                                                                            .codLoja = y.Key.pPed_A1_LOJA,
                                                                                                                                            .codVendedor = y.Key.pPed_A3_COD,
                                                                                                                                            .numPedido = y.Key.pNumeroPedido,
                                                                                                                                            .items = oPedidoItems}).ToList.FirstOrDefault

        Dim oPedidoProcessado = ProcessaSubstTribPedido(oPedido)

        For Each objPedidosMov In pedidosMov    
            objPedidosMov.pPed_pedidoValorSubstTrib = oPedidoProcessado.pedidoValorSubstTrib

            objPedidosMov.pPed_ValorTotalProduto = pedidosMov.Sum(Function (x) x.pValorTotalProduto)

            objPedidosMov.pprodValorSubstTrib = 0

            Dim oPedidoProcessadoItemAtual = oPedidoProcessado.items.FindAll(function(x) x.B1_COD = objPedidosMov.pB1_COD).FirstOrDefault

            if oPedidoProcessadoItemAtual IsNot Nothing
                objPedidosMov.pprodValorSubstTrib = oPedidoProcessadoItemAtual.prodValorSubstTrib
            End If
        Next

        Return pedidosMov
    End Function

End Class
