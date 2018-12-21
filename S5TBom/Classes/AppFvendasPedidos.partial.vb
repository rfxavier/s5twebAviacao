Imports CodeFluent.Runtime
Namespace S5T

    Partial Public Class AppFvendasPedidos

        Private Sub OnBeforeSave()
            If Me.pA1_COD = "" Then
                Throw New CodeFluent.Runtime.CodeFluentValidationException("Código Cliente não pode ser nulo")
                Exit Sub
            End If
            If Me.pA1_LOJA = "" Then
                Throw New CodeFluent.Runtime.CodeFluentValidationException("Loja não pode ser nulo")
                Exit Sub
            End If
            If Me.pA3_COD = "" Then
                Throw New CodeFluent.Runtime.CodeFluentValidationException("Vendedor não pode ser nulo")
                Exit Sub
            End If

            If Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Created Then
                If Me.pNumeroPedido = 0 Then
                    Dim objAppFvendasPedidos As S5T.AppFvendasPedidos = S5T.AppFvendasPedidos.LoadMaxNumeroPedido
                    If objAppFvendasPedidos Is Nothing Then
                        Me.pNumeroPedido = 1
                    Else
                        Me.pNumeroPedido = objAppFvendasPedidos.pNumeroPedido + 1
                    End If
                End If
            End If


        End Sub


        Protected Shared Sub GravarPedidoPartial(ByVal parAppFvendasPedido As S5T.AppFvendasPedidos, ByVal parAppFvendasPedidoMov As List(Of S5T.AppFvendasPedidosMov))
            If parAppFvendasPedido Is Nothing Then
                Throw New CodeFluentValidationException("{GravaPedidoPartial} Pedido não informado")
            End If

            parAppFvendasPedido.Save()

            If parAppFvendasPedidoMov IsNot Nothing Then
                S5T.AppFvendasPedidosMov.DeleteByNumeroPedido(parAppFvendasPedido.pNumeroPedido)

                For Each objPedidoItem In parAppFvendasPedidoMov
                    Dim objPedidoMov = New S5T.AppFvendasPedidosMov

                    objPedidoMov.pNumeroPedido = parAppFvendasPedido.pNumeroPedido

                    objPedidoMov.pB1_COD = objPedidoItem.pB1_COD
                    objPedidoMov.pQuantidade = objPedidoItem.pQuantidade
                    objPedidoMov.pObservacao = objPedidoItem.pObservacao

                    objPedidoMov.pB1_DESC = objPedidoItem.pB1_DESC 'Descrição Produto
                    objPedidoMov.pDA1_PRCVEN = objPedidoItem.pDA1_PRCVEN 'Preço Venda
                    objPedidoMov.pB1_CONV = objPedidoItem.pB1_CONV 'Fator de Conversão
                    objPedidoMov.pB1_TIPCONV = objPedidoItem.pB1_TIPCONV 'Tipo Conversão (D=Divide;M=Multiplica)
                    objPedidoMov.pB1_GRUPO = objPedidoItem.pB1_GRUPO 'Grupo do Produto
                    objPedidoMov.pB1_GRUPO_DESC = objPedidoItem.pB1_GRUPO_DESC 'Descrição do grupo do produto
                    objPedidoMov.pB1_ZZPESOP = objPedidoItem.pB1_ZZPESOP 'Peso padrão (queijos)
                    objPedidoMov.pZP_SALDO = objPedidoItem.pZP_SALDO 'Saldo da Cota do Item
                    objPedidoMov.pZP_STATUS = objPedidoItem.pZP_STATUS '1=Utiliza Cota; 2=Não Utiliza Cota

                    objPedidoMov.pValorTotalProduto = objPedidoItem.pValorTotalProduto

                    'INFORMAÇÕES BUSCADAS DO CABEÇALHO DO PEDIDO
                    objPedidoMov.pPed_A1_COD = objPedidoItem.pPed_A1_COD
                    objPedidoMov.pPed_A1_LOJA = objPedidoItem.pPed_A1_LOJA
                    objPedidoMov.pPed_A1_NOME = objPedidoItem.pPed_A1_NOME
                    objPedidoMov.pPed_A1_END = objPedidoItem.pPed_A1_END
                    objPedidoMov.pPed_A3_COD = objPedidoItem.pPed_A3_COD
                    objPedidoMov.pPed_A3_COTA = objPedidoItem.pPed_A3_COTA
                    objPedidoMov.pPed_A3_NOME = objPedidoItem.pPed_A3_NOME
                    objPedidoMov.pPed_DataEmissao = objPedidoItem.pPed_DataEmissao
                    objPedidoMov.pPed_DataEntrega = objPedidoItem.pPed_DataEntrega
                    objPedidoMov.pPed_FlgStatus = objPedidoItem.pPed_FlgStatus
                    objPedidoMov.pPed_Observacao = objPedidoItem.pPed_Observacao
                    objPedidoMov.pPed_NumeroPedidoCliente = objPedidoItem.pPed_NumeroPedidoCliente

                    objPedidoMov.pPed_pCodigoSubVendedor = objPedidoItem.pPed_pCodigoSubVendedor

                    objPedidoMov.Save()
                Next
            End If
        End Sub
    End Class
End Namespace
