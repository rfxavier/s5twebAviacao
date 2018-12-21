Imports System.Net
Imports System.Net.Http
Imports System.Runtime.Serialization
Imports System.Web.Http
Imports System.Web.Http.Cors
Imports CodeFluent.Runtime
Imports Oracle.DataAccess.Client

Namespace webapiControllers
    <Authorize>
    <RoutePrefix("api/Pedido")>
    <EnableCors("*", "*", "*", SupportsCredentials:=True)>
    Public Class PedidoController
        Inherits ApiController

        Private Class S5TVendedor
            Public Property A3_COD As String
            Public Property A3_NOME As String
            Public Property A3_COTA As String
        End Class

        Private Class S5TCliente
            Public Property A1_COD As String
            Public Property A1_LOJA As String
            Public Property A1_CGC As String
            Public Property A1_END As String
            Public Property A1_DDD As String
            Public Property A1_TEL As String
            Public Property A1_MUN As String
            Public Property A1_EST As String
            Public Property A1_NOME As String
            Public Property A1_VEND As String
        End Class

        Private Class S5TProduto
            Public Property B1_COD As String
            Public Property B1_DESC As String
            Public Property DA1_PRCVEN As Double
            Public Property B1_CONV As String '-- Fator de Conversão
            Public Property B1_TIPCONV As String '-- Tipo Conversão (D=Divide;M=Multiplica)
            Public Property B1_GRUPO As String
            Public Property B1_GRUPO_DESC As String
            Public Property B1_ZZPESOP As Double
            Public Property ZP_SALDO As Double
            Public Property ZP_STATUS As String '-- 1=Utiliza Cota; 2=Não Utiliza Cota
            Public Property PRECO_CAIXA As Double
        End Class

        'Pedido para mapear POST
        <DataContract>
        Public Class S5TPedido
            <DataMember>
            Public Property numPedido As Long
            <DataMember>
            Public Property codCliente As String
            <DataMember>
            Public Property codLoja As String
            <DataMember>
            Public Property codVendedor As String
            <DataMember>
            Public Property codSubVendedor As String
            <DataMember>
            Public Property numPedidoCliente As String
            <DataMember>
            Public Property dataEntrega As Date
            <DataMember>
            Public Property observacao As String
            <DataMember>
            Public Property status As String
            <DataMember>
            Public Property items As List(Of S5TPedidoItems)
        End Class

        'Pedido items para mapear POST
        Public Class S5TPedidoItems
            <DataMember>
            Public Property B1_COD As String
            <DataMember>
            Public Property prodQuant As Double
            <DataMember>
            Public Property prodObs As String
        End Class

        'Pedido para mapear GET - Síntese (cabeçalho resumido) para vendedor
        <DataContract>
        Public Class S5TPedidoSintese
            <DataMember>
            Public Property pNumeroPedido As Long
            Public Property pA3_COD As String 'Código do Vendedor
            Public Property pA3_NOME As String 'Nome do Vendedor
            Public Property pA3_COTA As String '1=Utiliza Cota; 2=Não Utiliza Cota
            Public Property pCodigoSubVendedor As String
            Public Property pFlgStatusConcatenadoSubVendedor As String
            <DataMember>
            Public Property pA1_COD As String 'Código do Cliente
            <DataMember>
            Public Property pA1_LOJA As String 'Loja do Cliente
            <DataMember>
            Public Property pA1_NOME As String 'Nome do Cliente
            <DataMember>
            Public Property pA1_END As String 'Endereço do Cliente 
            <DataMember>
            Public Property pDataEmissao As Date
            Public Property pDataEntrega As Date
            <DataMember>
            Public Property pFlgStatus As String
            <DataMember>
            Public Property pNumeroItens As Long
            <DataMember>
            Public Property pObservacao As String
            <DataMember>
            Public Property pObservacaoResumida As String
            <DataMember>
            Public Property pValorTotal As Double

        End Class

        'Pedido para mapear GET - Síntese (cabeçalho resumido) para vendedor
        'Agrupado por Status
        <DataContract>
        Public Class S5TPedidoSinteseGroupByStatus
            <DataMember>
            Public Property pFlgStatus As String
            <DataMember>
            Public Property items As List(Of S5TPedidoSinteseGroupByStatusItems)
        End Class

        Public Class S5TPedidoSinteseGroupByStatusItems
            Implements ICloneable

            <DataMember>
            Public Property pFlgStatus As String
            <DataMember>
            Public Property pNumeroPedido As Long
            Public Property pA3_COD As String 'Código do Vendedor
            Public Property pA3_NOME As String 'Nome do Vendedor
            Public Property pA3_COTA As String '1=Utiliza Cota; 2=Não Utiliza Cota
            Public Property pCodigoSubVendedor As String
            <DataMember>
            Public Property pA1_COD As String 'Código do Cliente
            <DataMember>
            Public Property pA1_LOJA As String 'Loja do Cliente
            <DataMember>
            Public Property pA1_NOME As String 'Nome do Cliente
            <DataMember>
            Public Property pA1_END As String 'Endereço do Cliente
            <DataMember>
            Public Property pDataEmissao As Date
            Public Property pDataEntrega As Date
            <DataMember>
            Public Property pNumeroItens As Long
            <DataMember>
            Public Property pObservacao As String
            <DataMember>
            Public Property pObservacaoResumida As String
            <DataMember>
            Public Property pValorTotal As Double

            Public Function Clone() As Object Implements ICloneable.Clone
                Return Me.MemberwiseClone
            End Function

        End Class

        ' GET: api/Pedido
        <HttpGet>
        <Route("")>
        Public Function GetValuesPedido() As IHttpActionResult
            Return Ok(GetPedidosSintese(Me.Request.GetQueryNameValuePairs().ToList))
        End Function

        Private Function GetPedidosSintese(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As Object
            Dim PedidosSintesePlain = GetPedidosSintesePlain(parOptions)

            GetPedidosSintese = PedidosSintesePlain

            If parOptions IsNot Nothing Then
                Dim groupOptions As List(Of KeyValuePair(Of String, String)) = parOptions.FindAll(Function(x) x.Key = "group.field")

                If groupOptions.Count > 0 Then
                    If groupOptions(0).Value = "pFlgStatus" Then
                        'EXISTE PARÂMETRO group.field = pFlgStatus

                        GetPedidosSintese = GetPedidosSinteseGroupByStatus(PedidosSintesePlain).OrderBy(Function(x) x.pFlgStatus).ToList
                    End If
                End If
            End If

        End Function

        Private Function GetPedidosSinteseGroupByStatus(ByVal parPedidosSintese As List(Of S5TPedidoSintese)) As List(Of S5TPedidoSinteseGroupByStatus)
            Dim ListaPedidosSinteseGroupByStatus = parPedidosSintese.GroupBy(Function(x) New With {Key .pFlgStatus = x.pFlgStatusConcatenadoSubVendedor}).Select(Function(x) x.Key).ToList

            Dim PedidosSinteseGroupByStatus = New List(Of S5TPedidoSinteseGroupByStatus)

            Dim PedidosSinteseGroupByStatusItems = New List(Of S5TPedidoSinteseGroupByStatusItems)
            Dim PedidosSinteseGroupByStatusItemsClone = New List(Of S5TPedidoSinteseGroupByStatusItems)

            For Each objPedidosSinteseGroupByStatus In ListaPedidosSinteseGroupByStatus
                PedidosSinteseGroupByStatusItems = parPedidosSintese.FindAll(Function(x) x.pFlgStatusConcatenadoSubVendedor = objPedidosSinteseGroupByStatus.pFlgStatus).Select(Function(y) New S5TPedidoSinteseGroupByStatusItems With {
                                                                                                                                                                                    .pFlgStatus = y.pFlgStatus,
                                                                                                                                                                                    .pNumeroPedido = y.pNumeroPedido,
                                                                                                                                                                                    .pA3_COD = y.pA3_COD,
                                                                                                                                                                                    .pA3_NOME = y.pA3_NOME,
                                                                                                                                                                                    .pA3_COTA = y.pA3_COTA,
                                                                                                                                                                                    .pCodigoSubVendedor = y.pCodigoSubVendedor,
                                                                                                                                                                                    .pA1_COD = y.pA1_COD,
                                                                                                                                                                                    .pA1_LOJA = y.pA1_LOJA,
                                                                                                                                                                                    .pA1_NOME = y.pA1_NOME,
                                                                                                                                                                                    .pA1_END = y.pA1_END,
                                                                                                                                                                                    .pDataEmissao = y.pDataEmissao,
                                                                                                                                                                                    .pDataEntrega = y.pDataEntrega,
                                                                                                                                                                                    .pNumeroItens = y.pNumeroItens,
                                                                                                                                                                                    .pObservacao = y.pObservacao,
                                                                                                                                                                                    .pObservacaoResumida = y.pObservacaoResumida,
                                                                                                                                                                                    .pValorTotal = y.pValorTotal}).ToList

                PedidosSinteseGroupByStatusItemsClone = PedidosSinteseGroupByStatusItems.Select(Function(x) x.Clone()).Cast(Of S5TPedidoSinteseGroupByStatusItems).ToList

                PedidosSinteseGroupByStatus.Add(New S5TPedidoSinteseGroupByStatus With {.pFlgStatus = objPedidosSinteseGroupByStatus.pFlgStatus, .items = PedidosSinteseGroupByStatusItemsClone})
            Next

            Return PedidosSinteseGroupByStatus
        End Function

        Private Function GetPedidosSintesePlain(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As List(Of S5TPedidoSintese)
            Dim PedidosSintese = New List(Of S5TPedidoSintese)

            Dim varCodigoVendedor = VendedorCodigoFromOptions(parOptions)
            Dim varCodigoSubVendedor = SubVendedorCodigoFromOptions(parOptions)

            'Dim Pedidos = S5T.AppFvendasPedidosCollection.LoadByVendedor(varCodigoVendedor)
            'Dim dataInicial = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 1, 0, 1, 0)
            'Dim dataFinal = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59, 0)

            Dim dataInicial = New DateTime(DateTime.Now.AddDays(-3).Year, DateTime.Now.AddDays(-3).Month, DateTime.Now.AddDays(-3).Day, 1, 0, 1, 0)
            Dim dataFinal = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59, 0)

            Dim Pedidos As S5T.AppFvendasPedidosCollection

            If varCodigoSubVendedor <> "" Then
                Pedidos = S5T.AppFvendasPedidosCollection.LoadBySubVendedorDataEmissao(varCodigoSubVendedor, dataInicial, dataFinal)
            Else
                Pedidos = S5T.AppFvendasPedidosCollection.LoadByVendedorDataEmissao(varCodigoVendedor, dataInicial, dataFinal)
            End If

            PedidosSintese = Pedidos.Select(Function(x) New S5TPedidoSintese With {.pA1_COD = x.pA1_COD,
                                                                                    .pA1_LOJA = x.pA1_LOJA,
                                                                                    .pA1_NOME = x.pA1_NOME,
                                                                                    .pA1_END = x.pA1_END,
                                                                                    .pA3_COD = x.pA3_COD,
                                                                                    .pA3_COTA = x.pA3_COTA,
                                                                                    .pA3_NOME = x.pA3_NOME,
                                                                                    .pCodigoSubVendedor = x.pCodigoSubVendedor,
                                                                                    .pFlgStatusConcatenadoSubVendedor = x.pFlgStatus & IIf(x.pCodigoSubVendedor <> "", " " & x.pCodigoSubVendedor, ""),
                                                                                    .pDataEmissao = x.pDataEmissao,
                                                                                    .pDataEntrega = x.pDataEntrega,
                                                                                    .pFlgStatus = x.pFlgStatus,
                                                                                    .pNumeroItens = x.pNumeroItens,
                                                                                    .pNumeroPedido = x.pNumeroPedido,
                                                                                    .pObservacao = x.pObservacao,
                                                                                    .pObservacaoResumida = x.pObservacaoResumida,
                                                                                    .pValorTotal = x.pValorTotal}).ToList

            Return PedidosSintese
        End Function

        Private Function VendedorCodigoFromOptions(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As String
            VendedorCodigoFromOptions = "000"

            ''DEBUG POR ENQUANTO
            'If parOptions Is Nothing Then Return VendedorCodigoFromOptions

            Dim varWhereClause As String = String.Empty

            Dim FilterElements = parOptions.FindAll(Function(x) x.Key = "filter")

            If FilterElements IsNot Nothing Then
                varWhereClause = " And"

                For Each filterElement In FilterElements
                    If varWhereClause = " And A1_VEND =" Then
                        'ELEMENTO ATUAL É O CONTEÚDO DO CÓDIGO DO VENDEDOR, ACHOU
                        VendedorCodigoFromOptions = filterElement.Value
                    End If

                    If {"="}.Contains(filterElement.Value) Then
                        varWhereClause &= " ="
                    ElseIf {"A1_VEND"}.Contains(filterElement.Value) Then
                        varWhereClause &= " " & filterElement.Value
                    Else
                        varWhereClause &= " '" & filterElement.Value & "'"
                    End If
                Next
            End If
        End Function

        Private Function SubVendedorCodigoFromOptions(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As String
            SubVendedorCodigoFromOptions = ""

            Dim varWhereClause As String = String.Empty

            Dim FilterElements = parOptions.FindAll(Function(x) x.Key = "filter")

            If FilterElements IsNot Nothing Then
                varWhereClause = " And"

                For Each filterElement In FilterElements
                    If varWhereClause = " And codSubVendedor =" Then
                        'ELEMENTO ATUAL É O CONTEÚDO DO CÓDIGO DO SUB VENDEDOR, ACHOU
                        SubVendedorCodigoFromOptions = filterElement.Value
                    End If

                    If {"="}.Contains(filterElement.Value) Then
                        varWhereClause &= " ="
                    ElseIf {"codSubVendedor"}.Contains(filterElement.Value) Then
                        varWhereClause &= " " & filterElement.Value
                    Else
                        varWhereClause &= " '" & filterElement.Value & "'"
                    End If
                Next
            End If
        End Function


        Private Function ClienteCodigoFromOptions(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As String
            ClienteCodigoFromOptions = ""

            ''DEBUG POR ENQUANTO
            'If parOptions Is Nothing Then Return VendedorCodigoFromOptions

            Dim varWhereClause As String = String.Empty

            Dim FilterElements = parOptions.FindAll(Function(x) x.Key = "filter")

            If FilterElements IsNot Nothing Then
                varWhereClause = " And"

                For Each filterElement In FilterElements
                    If varWhereClause = " And pA3_COD =" Then
                        'ELEMENTO ATUAL É O CONTEÚDO DO CÓDIGO DO cliente, ACHOU
                        ClienteCodigoFromOptions = filterElement.Value
                    End If

                    If {"="}.Contains(filterElement.Value) Then
                        varWhereClause &= " ="
                    ElseIf {"pA3_COD"}.Contains(filterElement.Value) Then
                        varWhereClause &= " " & filterElement.Value
                    Else
                        varWhereClause &= " '" & filterElement.Value & "'"
                    End If
                Next
            End If
        End Function

        Private Function LojaCodigoFromOptions(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As String
            LojaCodigoFromOptions = "00"

            ''DEBUG POR ENQUANTO
            'If parOptions Is Nothing Then Return VendedorCodigoFromOptions

            Dim varWhereClause As String = String.Empty

            Dim FilterElements = parOptions.FindAll(Function(x) x.Key = "filter")

            If FilterElements IsNot Nothing Then
                varWhereClause = " And"

                For Each filterElement In FilterElements
                    If varWhereClause = " And pA1_LOJA =" Then
                        'ELEMENTO ATUAL É O CONTEÚDO DO CÓDIGO DA LOJA, ACHOU
                        LojaCodigoFromOptions = filterElement.Value
                    End If

                    If {"="}.Contains(filterElement.Value) Then
                        varWhereClause &= " ="
                    ElseIf {"pA1_LOJA"}.Contains(filterElement.Value) Then
                        varWhereClause &= " " & filterElement.Value
                    Else
                        varWhereClause &= " '" & filterElement.Value & "'"
                    End If
                Next
            End If
        End Function

        ' GET: api/Pedido/5
        <HttpGet>
        <Route("{parNumeroPedido}/")>
        Public Function GetValuePedido(<FromUri> ByVal parNumeroPedido As String) As IHttpActionResult
            Dim objPedido = S5T.AppFvendasPedidos.LoadByNumeroPedido(parNumeroPedido)

            Dim PedidoMovs = S5T.AppFvendasPedidosMovCollection.LoadByNumeroPedido(parNumeroPedido)


            Dim objPedidoApi As S5TPedido

            Dim PedidoItemsApi = New List(Of S5TPedidoItems)

            PedidoItemsApi = PedidoMovs.Select(Function(x) New S5TPedidoItems With {
                                                        .B1_COD = x.pB1_COD,
                                                        .prodQuant = x.pQuantidade,
                                                        .prodObs = x.pObservacao
                                                   }).ToList


            objPedidoApi = New S5TPedido With {
                    .numPedido = objPedido.pNumeroPedido,
                    .codVendedor = objPedido.pA3_COD,
                    .codSubVendedor = objPedido.pCodigoSubVendedor,
                    .codCliente = objPedido.pA1_COD,
                    .codLoja = objPedido.pA1_LOJA,
                    .numPedidoCliente = objPedido.pNumeroPedidoCliente,
                    .dataEntrega = objPedido.pDataEntrega,
                    .observacao = objPedido.pObservacao,
                    .status = objPedido.pFlgStatus,
                    .items = PedidoItemsApi
                }

            Return Ok(objPedidoApi)
        End Function

        Enum statusSucessoErro
            Sucesso
            Erro
        End Enum

        Enum tpInsAlt
            Insercao
            Alteracao
        End Enum

        ' POST: api/Pedido
        <HttpPost>
        <Route("")>
        Public Function PostValue(<FromBody()> ByVal oPedido As S5TPedido) As HttpResponseMessage
            Dim statusOperacao As statusSucessoErro = statusSucessoErro.Sucesso
            Dim tipoOperacao As tpInsAlt = tpInsAlt.Insercao

            Dim response As HttpResponseMessage

            response = New HttpResponseMessage(HttpStatusCode.BadRequest)
            response.Content = New StringContent("Conteúdo de Pedido está incompleto")

            If oPedido IsNot Nothing Then
                If oPedido.items.Count > 0 Then
                    'BUSCA INFORMAÇÕES DE VENDEDOR
                    Dim objVendedor = New S5TVendedor

                    objVendedor = GetVendedor(oPedido.codVendedor)

                    'BUSCA INFORMAÇÕES DE CLIENTE
                    Dim objCliente = New S5TCliente

                    objCliente = GetCliente(oPedido.codVendedor, oPedido.codCliente, oPedido.codLoja)

                    'BUSCA INFORMAÇÕES DE PRODUTOS
                    Dim Produtos = New List(Of S5TProduto)

                    Dim listaCodigosProdutos As List(Of String) = oPedido.items.Select(Function(x) New String(x.B1_COD)).ToList

                    Produtos = GetProdutos(oPedido.codCliente, oPedido.codLoja, oPedido.codVendedor, listaCodigosProdutos)

                    Dim varObservacaoPedido As String = String.Empty

                    Dim scope As System.Transactions.TransactionScope = Nothing
                    Dim numPedido As Long = 0
                    Try
                        Dim options As System.Transactions.TransactionOptions = New System.Transactions.TransactionOptions()
                        scope = New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, options)
                        'SIMULAÇÃO EXCEPTION THROWN
                        'Throw new Exception

                        Dim objPedido As S5T.AppFvendasPedidos

                        If oPedido.numPedido = 0 Then
                            objPedido = New S5T.AppFvendasPedidos
                        Else

                            objPedido = S5T.AppFvendasPedidos.LoadByNumeroPedido(oPedido.numPedido)
                        End If

                        objPedido.pNumeroPedido = oPedido.numPedido

                        objPedido.pA1_COD = oPedido.codCliente
                        objPedido.pA1_LOJA = oPedido.codLoja
                        objPedido.pA3_COD = oPedido.codVendedor
                        objPedido.pNumeroPedidoCliente = oPedido.numPedidoCliente
                        objPedido.pObservacao = oPedido.observacao
                        objPedido.pDataEmissao = DateTime.Now
                        objPedido.pDataEntrega = oPedido.dataEntrega

                        'REGRA RETIRADA - PEDIDO MATHEUS, DIA 17/04/17
                        ''REGRA EMBUTIDA CASO A DATA DE ENTREGA SEJA A MESMA DA DATA DA EMISSÃO, COLOCAR PARA 1 DIA POSTERIOR
                        'If objPedido.pDataEntrega.Date = objPedido.pDataEmissao.Date Then
                        '    objPedido.pDataEntrega = objPedido.pDataEmissao.AddDays(1)
                        'End If

                        objPedido.pFlgStatus = oPedido.status

                        objPedido.pNumeroItens = oPedido.items.Count

                        'INFORMAÇÕES ADICIONAIS BUSCADAS NO SERVIDOR
                        objPedido.pA1_NOME = objCliente.A1_NOME 'Nome do cliente
                        objPedido.pA1_END = objCliente.A1_END 'Endereço do cliente
                        'objPedido.pA1_CGC = objCliente.A1_CGC 'CNPJ do cliente
                        objPedido.pA3_NOME = objVendedor.A3_NOME 'Nome do vendedor
                        objPedido.pA3_COTA = objVendedor.A3_COTA 'Cota do vendedor

                        'SUB-VENDEDOR
                        objPedido.pCodigoSubVendedor = oPedido.codSubVendedor

                        Dim parListAppFvendasPedidosMov As New List(Of S5T.AppFvendasPedidosMov)

                        For Each objPedidoItem In oPedido.items
                            Dim objPedidoMov = New S5T.AppFvendasPedidosMov

                            objPedidoMov.pNumeroPedido = oPedido.numPedido

                            objPedidoMov.pB1_COD = objPedidoItem.B1_COD
                            objPedidoMov.pQuantidade = objPedidoItem.prodQuant
                            objPedidoMov.pObservacao = objPedidoItem.prodObs

                            'INFORMAÇÕES ADICIONAIS BUSCADAS NO SERVIDOR
                            Dim objProduto = Produtos.FirstOrDefault(Function(x) x.B1_COD = objPedidoItem.B1_COD)

                            If objProduto IsNot Nothing Then
                                objPedidoMov.pB1_DESC = objProduto.B1_DESC 'Descrição Produto
                                objPedidoMov.pDA1_PRCVEN = objProduto.DA1_PRCVEN 'Preço Venda
                                objPedidoMov.pB1_CONV = objProduto.B1_CONV 'Fator de Conversão
                                objPedidoMov.pB1_TIPCONV = objProduto.B1_TIPCONV 'Tipo Conversão (D=Divide;M=Multiplica)
                                objPedidoMov.pB1_GRUPO = objProduto.B1_GRUPO 'Grupo do Produto
                                objPedidoMov.pB1_GRUPO_DESC = objProduto.B1_GRUPO_DESC 'Descrição do grupo do produto
                                objPedidoMov.pB1_ZZPESOP = objProduto.B1_ZZPESOP 'Peso padrão (queijos)
                                objPedidoMov.pZP_SALDO = objProduto.ZP_SALDO 'Saldo da Cota do Item
                                objPedidoMov.pZP_STATUS = objProduto.ZP_STATUS '1=Utiliza Cota; 2=Não Utiliza Cota

                                'Buscou o preço de venda, então calcula o pValorTotalProduto
                                objPedidoMov.pValorTotalProduto = objPedidoItem.prodQuant * objProduto.PRECO_CAIXA

                                'INFORMAÇÕES BUSCADAS DO CABEÇALHO DO PEDIDO
                                objPedidoMov.pPed_A1_COD = objPedido.pA1_COD
                                objPedidoMov.pPed_A1_LOJA = objPedido.pA1_LOJA
                                objPedidoMov.pPed_A1_NOME = objPedido.pA1_NOME
                                objPedidoMov.pPed_A1_END = objPedido.pA1_END
                                objPedidoMov.pPed_A3_COD = objPedido.pA3_COD
                                objPedidoMov.pPed_A3_COTA = objPedido.pA3_COTA
                                objPedidoMov.pPed_A3_NOME = objPedido.pA3_NOME
                                objPedidoMov.pPed_DataEmissao = objPedido.pDataEmissao
                                objPedidoMov.pPed_DataEntrega = objPedido.pDataEntrega
                                objPedidoMov.pPed_FlgStatus = objPedido.pFlgStatus
                                objPedidoMov.pPed_NumeroPedidoCliente = objPedido.pNumeroPedidoCliente
                                objPedidoMov.pPed_Observacao = objPedido.pObservacao

                                objPedidoMov.pPed_pCodigoSubVendedor = objPedido.pCodigoSubVendedor
                            End If

                            parListAppFvendasPedidosMov.Add(objPedidoMov)
                        Next

                        'Resolveu a lista de PedidosMov, então calcula o pValorTotal
                        Dim varValorTotalPedido = parListAppFvendasPedidosMov.Sum(Function(x) x.pValorTotalProduto)
                        objPedido.pValorTotal = varValorTotalPedido

                        If objPedido.EntityState = CodeFluentEntityState.Created Then
                            tipoOperacao = tpInsAlt.Insercao
                        ElseIf objPedido.EntityState = CodeFluentEntityState.Modified Then
                            tipoOperacao = tpInsAlt.Alteracao
                        End If

                        S5T.AppFvendasPedidos.GravarPedido(objPedido, parListAppFvendasPedidosMov)
                        numPedido = objPedido.pNumeroPedido


                        If objPedido.pFlgStatus = "E" Then 'And User.Identity.Name <> "admin@4t.com.br" Then
                            'CASO STATUS SEJA E = Enviado, SUBMETE AO WEBSERVICE PARA INTEGRAÇÃO DIRETA AO ERP
                            'CONSUMO - INSERÇÃO NO PROTHEUS WEB SERVICE

                            Dim ServiceOrcamentoProtheusClient As New ServiceOrcamentoProtheusReference.GSINCORCSOAPClient

                            Dim ServiceOrcamentoProtheusGsOrcamento As New ServiceOrcamentoProtheusReference.GSORCAMENTO
                            Dim ServiceOrcamentoProtheusGsItensOrcamento = New ServiceOrcamentoProtheusReference.ARRAYOFGSITEMORC

                            ServiceOrcamentoProtheusGsOrcamento.CLIENTE = objPedido.pA1_COD
                            ServiceOrcamentoProtheusGsOrcamento.LOJA = objPedido.pA1_LOJA
                            ServiceOrcamentoProtheusGsOrcamento.VENDEDOR = objPedido.pA3_COD
                            ServiceOrcamentoProtheusGsOrcamento.NUMERO = objPedido.pNumeroPedido
                            ServiceOrcamentoProtheusGsOrcamento.PEDIDOCLIENTE = objPedido.pNumeroPedidoCliente
                            ServiceOrcamentoProtheusGsOrcamento.OBSERVACAO = removeAcentos( objPedido.pObservacao)
                            ServiceOrcamentoProtheusGsOrcamento.EMISSAO = objPedido.pDataEmissao.ToString("yyyyMMdd")
                            If objPedido.pDataEntrega = DateTime.MinValue Then
                                ServiceOrcamentoProtheusGsOrcamento.ENTREGA = ""
                            Else
                                ServiceOrcamentoProtheusGsOrcamento.ENTREGA = objPedido.pDataEntrega.ToString("yyyyMMdd")
                            End If

                            'ServiceOrcamentoProtheusGsItensOrcamento = oPedido.items.Select(Function(x) New ServiceOrcamentoProtheusReference.GSITEMORC With {
                            '                                                                    .PRODUTO = x.B1_COD,
                            '                                                                    .QUANTIDADE = x.prodQuant,
                            '                                                                    .OBSERVACAO = x.prodObs}).ToList

                            For Each objItem In oPedido.items
                                ServiceOrcamentoProtheusGsItensOrcamento.Add(New ServiceOrcamentoProtheusReference.GSITEMORC With {
                                                                                            .PRODUTO = objItem.B1_COD,
                                                                                            .CAIXAS = objItem.prodQuant,
                                                                                            .OBSERVACAO = removeAcentos(objItem.prodObs)})
                            Next

                            'FORÇAR ERRO
                            'Dim x As Object
                            'Console.WriteLine(x.ToString)

                            ServiceOrcamentoProtheusGsOrcamento.ITENS = ServiceOrcamentoProtheusGsItensOrcamento

                            Dim varResultadoInclui = ServiceOrcamentoProtheusClient.INCLUI(ServiceOrcamentoProtheusGsOrcamento)

                            'RESOLVE O QUE SERÁ O STRING MONTADO EM CIMA DA COLLECTION .ITENS DO RETORNO
                            Dim varResultadoIncluiITENS As String = String.Empty
                            dim varResultadoIncluiITENSResumido As String = String.Empty

                            If varResultadoInclui.ITENS.Count > 0 Then
                                For Each objResultadoIncluiITENS In varResultadoInclui.ITENS
                                    varResultadoIncluiITENS &= " Filial:" & objResultadoIncluiITENS.FILIAL & " Pedido:" & objResultadoIncluiITENS.PEDIDO & " Tipo:" & objResultadoIncluiITENS.TIPO

                                    varResultadoIncluiITENSResumido &= " " & objResultadoIncluiITENS.TIPO & " " & objResultadoIncluiITENS.PEDIDO
                                Next

                                If varResultadoInclui.ITENS.Count = 1 Then
                                    varResultadoIncluiITENS = "1 registro criado: " & varResultadoIncluiITENS

                                Else
                                    varResultadoIncluiITENS = varResultadoInclui.ITENS.Count & " registros criados: " & varResultadoIncluiITENS
                                End If

                                varResultadoIncluiITENS = "<* Protheus retorno: " & varResultadoIncluiITENS & " *>"
                            End If


                            'FIM DE RESOLVE O QUE SERÁ O STRING MONTADO EM CIMA DA COLLECTION .ITENS DO RETORNO

                            Dim varFlgStatusPedido As String = String.Empty
                            varObservacaoPedido = objPedido.pObservacao
                            varObservacaoResumidaPedido = ""

                            If varResultadoInclui.STATUS = "C01" Then
                                'INDICA STATUS DE SUCESSO
                                'varFlgStatusPedido = "F" 'Finalizado
                                varFlgStatusPedido = "E" 'Enviado

                                varObservacaoPedido &= " Aprovado: " & varResultadoInclui.DESCRICAO & " " & varResultadoIncluiITENS
                                varObservacaoResumidaPedido = varResultadoIncluiITENSResumido.Trim
                            Else
                                varFlgStatusPedido = "R" 'Rejeitado
                                varObservacaoPedido &= " Motivo Rejeição: " & varResultadoInclui.DESCRICAO
                                varObservacaoResumidaPedido = ""
                            End If

                            objPedido.pFlgStatus = varFlgStatusPedido
                            objPedido.pObservacao = varObservacaoPedido
                            objPedido.pObservacaoResumida = varObservacaoResumidaPedido
                            objPedido.pWsOrcamento_DESCRICAO = varResultadoInclui.DESCRICAO
                            objPedido.pWsOrcamento_ITENS = varResultadoIncluiITENS
                            objPedido.pWsOrcamento_STATUS = varResultadoInclui.STATUS

                            objPedido.pFlgStatusEnvioCliente = "P" & objPedido.pFlgStatus
                            'pFlgStatusEnvioCliente formato XX 
                            '     Status Envio Cliente      X -> (P)endente envio | (E)nviado com sucesso
                            '     Status Protheus Retorno    X -> (E)nviado Protheus | (R)ejeitado Protheus

                            objPedido.Save()

                            S5T.AppFvendasPedidosMov.UpdatePedWsOrcamentoByNumeroPedido(objPedido.pNumeroPedido, objPedido.pFlgStatus, objPedido.pWsOrcamento_DESCRICAO, objPedido.pWsOrcamento_ITENS, objPedido.pWsOrcamento_STATUS)

                            'Dim o = varResultadoInclui.ITENS
                            'varResultadoInclui.
                            'o(0).

                            'ServiceOrcamentoProtheusClient.Close()
                        End If


                        scope.Complete()


                    Catch ex As Exception
                        'My.Log.WriteException(ex, TraceEventType.Error, varObservacaoPedido)

                        Dim varBaseDir = AppDomain.CurrentDomain.BaseDirectory


                        response = New HttpResponseMessage(HttpStatusCode.ServiceUnavailable)
                        response.Content = new StringContent("Erro Webservice Protheus")

                        statusOperacao = statusSucessoErro.Erro

                        IO.File.AppendAllText(varBaseDir & "LogAspNet5t.txt", String.Format("{0}{1} {2} {3}", Environment.NewLine, Date.Now.ToString, ex.ToString(), varObservacaoPedido))
                    Finally
                        If (Not (scope) Is Nothing) Then
                            scope.Dispose()
                        End If

                    End Try

                    If Not statusOperacao = statusSucessoErro.Erro Then

                        If tipoOperacao = tpInsAlt.Insercao Then
                            response = New HttpResponseMessage(HttpStatusCode.Created)
                            response.Content = New StringContent("Criado pedido número " & numPedido)

                        ElseIf tipoOperacao = tpInsAlt.Alteracao Then
                            response = New HttpResponseMessage(HttpStatusCode.OK)
                            response.Content = New StringContent("Alterado pedido número " & numPedido)
                        End If

                    End If

                End If
            End If

            Return response
        End Function

        ' PUT: api/Pedido/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Pedido/5
        <HttpDelete>
        <Route("{parNumeroPedido}/")>
        Public Function DeleteValuePedido(<FromUri> ByVal parNumeroPedido As String) As IHttpActionResult
            S5T.AppFvendasPedidos.DeleteByNumeroPedido(parNumeroPedido)

            S5T.AppFvendasPedidosMov.DeleteByNumeroPedido(parNumeroPedido)

            Return Ok()
        End Function
        Private Function GetVendedor(ByVal parA3_COD As String) As S5TVendedor
            Dim objVendedor = New S5TVendedor

            Dim varSqlBase = "SELECT A3_COD, A3_NOME,A3_COTA FROM SA3010 SA3 WHERE SA3.D_E_L_E_T_ = ' ' AND A3_STATUS= '1' AND A3_FILIAL = '01'"

            varSqlBase &= " AND A3_COD = '" & parA3_COD & "'"

            Dim conn As OracleConnection = Nothing
            Dim oradbConn As String = String.Empty

            Dim oradb As String = AppUtils.dbConnectionString

            conn = New OracleConnection(oradb)
            conn.Open()

            Dim cmdVendedor As New OracleCommand(varSqlBase, conn) With {.CommandType = CommandType.Text}

            'Dim cmdVendedor As OracleCommand

            Dim drVendedor As OracleDataReader = Nothing
            Try
                drVendedor = cmdVendedor.ExecuteReader()
                If drVendedor.HasRows Then
                    Do While drVendedor.Read
                        objVendedor.A3_COD = AppUtils.Nvl(drVendedor.Item("A3_COD"), "")
                        objVendedor.A3_NOME = AppUtils.Nvl(drVendedor.Item("A3_NOME"), "").ToString.Trim
                        objVendedor.A3_COTA = AppUtils.Nvl(drVendedor.Item("A3_COTA"), "")
                    Loop

                    drVendedor.Close()
                End If
            Catch ex As Exception
                'Return InternalServerError(ex)
            Finally
                conn.Close()
                If (Not (drVendedor) Is Nothing) Then
                    drVendedor.Dispose()
                End If
            End Try

            Return objVendedor
        End Function

        Private Function GetCliente(ByVal parA1_VEND As String, ByVal parA1_COD As String, ByVal parA1_LOJA As String) As S5TCliente
            Dim objCliente = New S5TCliente

            Dim varSqlBase = "SELECT A1_COD, A1_LOJA, A1_CGC, A1_END, A1_DDD, A1_TEL, A1_MUN, A1_EST, A1_NOME, A1_VEND FROM SA1010 SA1 WHERE A1_MSBLQL = '2' AND A1_FILIAL = '01' AND SA1.D_E_L_E_T_ = ' '"

            varSqlBase &= " AND A1_VEND = '" & parA1_VEND & "' AND A1_COD = '" & parA1_COD & "' AND A1_LOJA = '" & parA1_LOJA & "'"

            Dim conn As OracleConnection = Nothing
            Dim oradbConn As String = String.Empty

            Dim oradb As String = AppUtils.dbConnectionString

            conn = New OracleConnection(oradb)
            conn.Open()

            Dim cmdCliente As New OracleCommand(varSqlBase, conn) With {.CommandType = CommandType.Text}

            'Dim cmdCliente As OracleCommand

            Dim drCliente As OracleDataReader = Nothing
            Try
                drCliente = cmdCliente.ExecuteReader()
                If drCliente.HasRows Then
                    Do While drCliente.Read
                        objCliente.A1_COD = AppUtils.Nvl(drCliente.Item("A1_COD"), "").ToString.Trim
                        objCliente.A1_LOJA = AppUtils.Nvl(drCliente.Item("A1_LOJA"), "").ToString.Trim
                        objCliente.A1_CGC = AppUtils.Nvl(drCliente.Item("A1_CGC"), "").ToString.Trim
                        objCliente.A1_END = AppUtils.Nvl(drCliente.Item("A1_END"), "").ToString.Trim
                        objCliente.A1_DDD = AppUtils.Nvl(drCliente.Item("A1_DDD"), "").ToString.Trim
                        objCliente.A1_TEL = AppUtils.Nvl(drCliente.Item("A1_TEL"), "").ToString.Trim
                        objCliente.A1_MUN = AppUtils.Nvl(drCliente.Item("A1_MUN"), "").ToString.Trim
                        objCliente.A1_EST = AppUtils.Nvl(drCliente.Item("A1_EST"), "").ToString.Trim
                        objCliente.A1_NOME = AppUtils.Nvl(drCliente.Item("A1_NOME"), "").ToString.Trim
                        objCliente.A1_VEND = AppUtils.Nvl(drCliente.Item("A1_VEND"), "").ToString.Trim
                    Loop

                    drCliente.Close()
                End If
            Catch ex As Exception
                'Return InternalServerError(ex)
            Finally
                conn.Close()
                If (Not (drCliente) Is Nothing) Then
                    drCliente.Dispose()
                End If
            End Try

            Return objCliente
        End Function

        Private Function GetProdutos(ByVal parA1_COD As String, ByVal parA1_LOJA As String, ByVal parA1_VEND As String, ByVal parPRODUTOS As List(Of String)) As List(Of S5TProduto)
            Dim Produtos = New List(Of S5TProduto)

            '*** IMPORTANTE: String em varSqlBase deve ser mesma de ProdutoController - GetProdutosPlain

            'Comentado em 17/08/2016 - alteração enviada por Everton
            'Dim varSqlBase = "SELECT B1_COD, B1_DESC, DA1_PRCVEN, B1_CONV, B1_TIPCONV, B1_GRUPO, TRUNC(B1_ZZPESOP, 0) B1_ZZPESOP, NVL(ZP_SALDO, 0) ZP_SALDO, NVL(ZP_STATUS, '2') ZP_STATUS, CASE WHEN B1_GRUPO = '3' AND B1_COD NOT IN ('325001', '315500', '310000','322305','314510','312905') THEN DA1_PRCVEN * TRUNC(B1_ZZPESOP, 0) ELSE DA1_PRCVEN * B1_CONV END PRECO_CAIXA FROM SA1010 SA1 INNER JOIN DA1010 DA1 ON DA1_CODTAB = A1_TABELA AND DA1.D_E_L_E_T_ = ' ' INNER JOIN SB1010 SB1 ON B1_COD = DA1_CODPRO AND B1_FILIAL = '01' AND SB1.D_E_L_E_T_ = ' ' LEFT JOIN SZP010 SZP ON ZP_VENDEDO = A1_VEND AND ZP_CODIGO = B1_COD AND SZP.D_E_L_E_T_ = ' ' WHERE A1_MSBLQL = '2' AND DA1_ATIVO = '1' AND B1_MSBLQL = '2' AND A1_FILIAL = '01' AND SA1.D_E_L_E_T_ = ' ' AND B1_GRUPO <> ' '"

            Dim varSqlBase = "SELECT DISTINCT DA1_CODPRO B1_COD, B1_DESC, ZZO_DESCRI, DA1_PRCVEN, B1_CONV, B1_TIPCONV, B1_GRUPO, B1_ZZPESOP, DECODE(NVL(ZP_STATUS, '2'),'2',9999,NVL(ZP_SALDO, 0)) ZP_SALDO, NVL(ZP_STATUS, '2') ZP_STATUS, CASE WHEN B1_GRUPO = '3' AND B1_COD NOT IN ( SELECT ZZO_CHAVE FROM ZZO010 ZZO WHERE ZZO_TABELA = '000033' AND ZZO_FILIAL = '01' AND ZZO.D_E_L_E_T_ = ' ' ) THEN DA1_PRCVEN * TRUNC(B1_ZZPESOP, 0) ELSE DA1_PRCVEN * B1_CONV END PRECO_CAIXA FROM SA1010 SA1 INNER JOIN ( SELECT A1_FILIAL, A1_CGC, DA1_CODPRO, DA1_PRCVEN FROM SA1010 SA1 INNER JOIN DA1010 DA1 ON DA1_CODTAB = A1_TABELA AND DA1.D_E_L_E_T_ = ' ' WHERE SA1.D_E_L_E_T_ = ' ' AND DA1_ATIVO = '1' AND A1_FILIAL || DA1_CODPRO NOT IN ( SELECT ZZO_FILIAL || ZZO_CHAVE FROM ZZO010 ZZO WHERE ZZO_TABELA = '000058' AND ZZO_FILIAL = '01' AND ZZO.D_E_L_E_T_ = ' ' ) ) TAB ON SA1.A1_CGC = TAB.A1_CGC INNER JOIN SB1010 SB1 ON B1_FILIAL = TAB.A1_FILIAL AND B1_COD = DA1_CODPRO AND SB1.D_E_L_E_T_ = ' ' INNER JOIN ZZO010 ZZO ON ZZO_TABELA = '000016' AND ZZO_CHAVE = B1_COD AND ZZO_FILIAL = '01' AND ZZO.D_E_L_E_T_ = ' ' LEFT JOIN SZP010 SZP ON ZP_VENDEDO = A1_VEND AND ZP_CODIGO = DA1_CODPRO AND SZP.D_E_L_E_T_ = ' ' WHERE A1_MSBLQL = '2' AND B1_MSBLQL = '2' AND SA1.A1_FILIAL = '01' AND SA1.D_E_L_E_T_ = ' ' AND B1_GRUPO <> ' '"

            varSqlBase &= " AND A1_COD = '" & parA1_COD & "' AND A1_LOJA = '" & parA1_LOJA & "' AND A1_VEND = '" & parA1_VEND & "'"

            Dim varListaDeCodigos As String

            varListaDeCodigos = String.Format("'{0}'", String.Join("','", parPRODUTOS.ToArray()))

            varSqlBase &= String.Format(" AND B1_COD IN ( {0} )", varListaDeCodigos)

            Dim conn As OracleConnection = Nothing
            Dim oradbConn As String = String.Empty

            Dim oradb As String = AppUtils.dbConnectionString

            conn = New OracleConnection(oradb)
            conn.Open()

            Dim cmdProduto As New OracleCommand(varSqlBase, conn) With {.CommandType = CommandType.Text}

            'Dim cmdProduto As OracleCommand

            Dim drProduto As OracleDataReader = Nothing
            Try
                drProduto = cmdProduto.ExecuteReader()
                If drProduto.HasRows Then
                    Do While drProduto.Read
                        Dim objProduto = New S5TProduto

                        objProduto.B1_COD = AppUtils.Nvl(drProduto.Item("B1_COD"), "").ToString.Trim
                        objProduto.B1_DESC = AppUtils.Nvl(drProduto.Item("B1_DESC"), "").ToString.Trim
                        objProduto.DA1_PRCVEN = AppUtils.Nvl(drProduto.Item("DA1_PRCVEN"), 0)
                        objProduto.B1_CONV = AppUtils.Nvl(drProduto.Item("B1_CONV"), "").ToString.Trim
                        objProduto.B1_TIPCONV = AppUtils.Nvl(drProduto.Item("B1_TIPCONV"), "").ToString.Trim
                        objProduto.B1_GRUPO = AppUtils.Nvl(drProduto.Item("B1_GRUPO"), "").ToString

                        If objProduto.B1_GRUPO.Trim = "1" Then
                            objProduto.B1_GRUPO_DESC = "MANTEIGA"
                        ElseIf objProduto.B1_GRUPO.Trim = "2" Then
                            objProduto.B1_GRUPO_DESC = "DOCE DE LEITE"
                        ElseIf objProduto.B1_GRUPO.Trim = "3" Then
                            objProduto.B1_GRUPO_DESC = "QUEIJO"
                        ElseIf objProduto.B1_GRUPO.Trim = "4" Then
                            objProduto.B1_GRUPO_DESC = "REQUEIJÃO"
                        Else
                            objProduto.B1_GRUPO_DESC = "OUTROS"
                        End If
                        objProduto.B1_ZZPESOP = AppUtils.Nvl(drProduto.Item("B1_ZZPESOP"), 0)
                        objProduto.ZP_SALDO = AppUtils.Nvl(drProduto.Item("ZP_SALDO"), 0)
                        objProduto.ZP_STATUS = AppUtils.Nvl(drProduto.Item("ZP_STATUS"), "").ToString.Trim
                        objProduto.PRECO_CAIXA = AppUtils.Nvl(drProduto.Item("PRECO_CAIXA"), 0)

                        Produtos.Add(objProduto)
                    Loop

                    drProduto.Close()
                End If
            Catch ex As Exception
                'Return InternalServerError(ex)
            Finally
                conn.Close()
                If (Not (drProduto) Is Nothing) Then
                    drProduto.Dispose()
                End If
            End Try

            Return Produtos
        End Function



    End Class
End Namespace