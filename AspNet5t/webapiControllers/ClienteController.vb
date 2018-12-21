Imports System.Net
Imports System.Net.Http
Imports System.Runtime.Serialization
Imports System.Web.Http
Imports System.Web.Http.Cors
Imports Oracle.DataAccess.Client

Namespace webapiControllers
    <Authorize>
    <RoutePrefix("api/Cliente")>
    <EnableCors("*", "*", "*", SupportsCredentials:=True)>
    Public Class ClienteController
        Inherits ApiController

        <DataContract>
        Private Class S5TCliente
            <DataMember>
            Public Property A1_COD As String
            <DataMember>
            Public Property A1_LOJA As String
            <DataMember>
            Public Property A1_CGC As String
            <DataMember>
            Public Property A1_END As String
            <DataMember>
            Public Property A1_DDD As String
            <DataMember>
            Public Property A1_TEL As String
            <DataMember>
            Public Property A1_MUN As String
            <DataMember>
            Public Property A1_EST As String
            <DataMember>
            Public Property A1_NOME As String
            <DataMember>
            Public Property A1_VEND As String


        End Class

        Private Class S5TClienteGroupByNomeItems
            Implements ICloneable
            <DataMember>
            Public Property A1_COD As String
            <DataMember>
            Public Property A1_LOJA As String
            <DataMember>
            Public Property A1_VEND As String

            Public Function Clone() As Object Implements ICloneable.Clone
                Return Me.MemberwiseClone
            End Function
        End Class

        Private Class S5TClienteGroupByNome
            <DataMember>
            Public Property A1_NOME As String
            <DataMember>
            Public Property items As List(Of S5TClienteGroupByNomeItems)
        End Class

        Public Class S5TNFVenda
            <DataMember>
            Public Property pNUMERO_NF As String
            <DataMember>
            Public Property pDATA_EMISSAO As Date
            <DataMember>
            Public Property pLOJA As String
            <DataMember>
            Public Property pCLIENTE As String
            <DataMember>
            Public Property pNOME_CLIENTE As String
            <DataMember>
            Public Property pPRODUTO As String
            <DataMember>
            Public Property pDESCRICAO As String
            <DataMember>
            Public Property pTOTAL_QTD_UN As Double
            <DataMember>
            Public Property pTOTAL_QTD_CX As Double
            <DataMember>
            Public Property pTOTAL_VL_PRODUTO As Double

        End Class

        <DataContract>
        Private Class S5TNFVendaGroupByNumeroNF
            <DataMember>
            Public Property pNUMERO_NF As String
            <DataMember>
            Public Property pDATA_EMISSAO As Date
            Public Property pLOJA As String
            Public Property pCLIENTE As String
            Public Property pNOME_CLIENTE As String
            <DataMember>
            Public Property pTOTAL_VL_PRODUTO As Double
            <DataMember>
            Public Property items As List(Of S5TNFVendaGroupByNFItems)

        End Class

        <DataContract>
        Private Class S5TNFVendaGroupByNFItems
            Implements ICloneable

            <DataMember>
            Public Property pPRODUTO As String
            <DataMember>
            Public Property pDESCRICAO As String
            <DataMember>
            Public Property pTOTAL_QTD_UN As Double
            <DataMember>
            Public Property pTOTAL_QTD_CX As Double
            <DataMember>
            Public Property pTOTAL_VL_PRODUTO As Double

            Public Function Clone() As Object Implements ICloneable.Clone
                Return Me.MemberwiseClone
            End Function
        End Class



        <DataContract>
        Private Class S5TClienteInfo
            <DataMember>
            Public Property A1_COD As String
            <DataMember>
            Public Property A1_LOJA As String
            <DataMember>
            Public Property A1_NOME As String
            <DataMember>
            Public Property A1_VEND As String
            <DataMember>
            Public Property A1_TABELA As String
            <DataMember>
            Public Property A1_COND As String
            <DataMember>
            Public Property A1_METR As Double
            <DataMember>
            Public Property A1_NROCOM As Integer
            <DataMember>
            Public Property A1_ULTCOM As Date
            <DataMember>
            Public Property A1_SALDUP As Double
            <DataMember>
            Public Property itemsNFsVenda As List(Of S5TNFVendaGroupByNumeroNF)
        End Class
        ' GET: api/Cliente
        <HttpGet>
        <Route("")>
        Public Function GetValuesCliente() As IHttpActionResult
            'Console.WriteLine(Me.Request.GetQueryNameValuePairs().ToList)

            Return Ok(GetClientes(Me.Request.GetQueryNameValuePairs().ToList))
        End Function

        Private Function GetClientes(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As Object
            Dim ClientesPlain = GetClientesPlain(parOptions)

            GetClientes = ClientesPlain

            If parOptions IsNot Nothing Then
                Dim groupOptions As List(Of KeyValuePair(Of String, String)) = parOptions.FindAll(Function(x) x.Key = "group.field")

                If groupOptions.Count > 0 Then
                    If groupOptions(0).Value = "A1_NOME" Then
                        'EXISTE PARÂMETRO group.field = A1_NOME
                        GetClientes = GetClienteGroupByNome(ClientesPlain)
                    End If
                End If
            End If

        End Function

        Private Function GetClienteGroupByNome(ByVal parClientes As List(Of S5TCliente)) As List(Of S5TClienteGroupByNome)
            Dim ListaClientesGroupByNome = parClientes.GroupBy(Function(x) New With {Key .A1_NOME = x.A1_NOME}).Select(Function(x) x.Key).ToList

            Dim ClientesGroupByNome = New List(Of S5TClienteGroupByNome)

            Dim ClienteGroupByNomeItems = New List(Of S5TClienteGroupByNomeItems)
            Dim ClienteGroupByNomeItemsClone = New List(Of S5TClienteGroupByNomeItems)

            'EstoqueColheitaFrenteFazendas = GetFazendas(objEstoqueColheitaFrenteBase.FRENTE_LIB, EstoqueColheitaFrenteFazendasBase)
            'EstoqueColheitaFrenteFazendasClone = EstoqueColheitaFrenteFazendas.Select(Function(x) x.Clone()).Cast(Of S5TEstoqueColheitaFrenteFazenda).ToList

            For Each objClientesGroupByNome In ListaClientesGroupByNome
                ClienteGroupByNomeItems = parClientes.FindAll(Function(x) x.A1_NOME = objClientesGroupByNome.A1_NOME).Select(Function(y) New S5TClienteGroupByNomeItems With {.A1_COD = y.A1_COD, .A1_LOJA = y.A1_LOJA, .A1_VEND = y.A1_VEND}).ToList
                ClienteGroupByNomeItemsClone = ClienteGroupByNomeItems.Select(Function(x) x.Clone()).Cast(Of S5TClienteGroupByNomeItems).ToList

                ClientesGroupByNome.Add(New S5TClienteGroupByNome With {.A1_NOME = objClientesGroupByNome.A1_NOME, .items = ClienteGroupByNomeItemsClone})
            Next

            Return ClientesGroupByNome
        End Function

        Private Function GetClientesPlain(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As List(Of S5TCliente)
            Dim Clientes = New List(Of S5TCliente)

            Dim varSqlBase = "SELECT A1_COD, A1_LOJA, A1_CGC, A1_END, A1_DDD, A1_TEL, A1_MUN, A1_EST, A1_NOME, A1_VEND FROM SA1010 SA1 WHERE A1_MSBLQL = '2' AND A1_FILIAL = '01' AND SA1.D_E_L_E_T_ = ' '"

            varSqlBase &= ClientesWhereClause(parOptions)

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
                        Dim objCliente = New S5TCliente

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

                        Clientes.Add(objCliente)
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

            Return Clientes.OrderBy(Function(x) x.A1_NOME).ToList
        End Function

        Private Function ClientesWhereClause(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As String
            ClientesWhereClause = ""

            Dim varWhereClause As String = String.Empty

            Dim FilterElements = parOptions.FindAll(Function(x) x.Key = "filter")

            If FilterElements IsNot Nothing Then
                varWhereClause = " And"

                For Each filterElement In FilterElements
                    If {"="}.Contains(filterElement.Value) Then
                        varWhereClause &= " ="
                    ElseIf {"A1_VEND"}.Contains(filterElement.Value) Then
                        varWhereClause &= " " & filterElement.Value
                    Else
                        varWhereClause &= " '" & filterElement.Value & "'"
                    End If
                Next
            End If

            ClientesWhereClause = varWhereClause
        End Function

        ' GET: api/Cliente/5
        <HttpGet>
        <Route("{parCodClienteCodLoja}/")>
        Public Function GetValueCliente(<FromUri> ByVal parCodClienteCodLoja As String) As IHttpActionResult
            Dim parCodCliente As String = parCodClienteCodLoja.Substring(0, 6)
            Dim parCodLoja As String = parCodClienteCodLoja.Substring(6, 2)

            Dim objClienteInfo = New S5TClienteInfo

            Dim varSqlBase = "SELECT A1_COD, A1_LOJA, A1_NOME, A1_VEND, A1_TABELA, A1_COND, A1_METR, A1_NROCOM, A1_ULTCOM, A1_SALDUP FROM SA1010 SA1 WHERE A1_FILIAL = '01' AND SA1.D_E_L_E_T_ = ' '"

            Dim varWhereClause = " AND A1_COD = '{0}' AND A1_LOJA = '{1}'"

            varSqlBase &= String.Format(varWhereClause, parCodCliente, parCodLoja)

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
                    drCliente.Read()

                    'A1_COD, --Código do Cliente
                    '  A1_LOJA, --Loja do Cliente
                    '  A1_NOME, --Nome do Cliente
                    '  A1_VEND, --Código do Vendedor
                    'A1_TABELA, --Tabela de Preço
                    '  A1_COND, --Condição de Pagamento
                    '  A1_METR, --Média de Atraso
                    '  A1_NROCOM, --Número de Compras
                    '  A1_ULTCOM, --Data da última compra
                    '  A1_SALDUP  --Saldo dos títulos em aberto

                    objClienteInfo.A1_COD = AppUtils.Nvl(drCliente.Item("A1_COD"), "").ToString.Trim
                    objClienteInfo.A1_LOJA = AppUtils.Nvl(drCliente.Item("A1_LOJA"), "").ToString.Trim
                    objClienteInfo.A1_NOME = AppUtils.Nvl(drCliente.Item("A1_NOME"), "").ToString.Trim
                    objClienteInfo.A1_VEND = AppUtils.Nvl(drCliente.Item("A1_VEND"), "").ToString.Trim
                    objClienteInfo.A1_TABELA = AppUtils.Nvl(drCliente.Item("A1_TABELA"), "").ToString.Trim
                    objClienteInfo.A1_COND = AppUtils.Nvl(drCliente.Item("A1_COND"), "").ToString.Trim
                    objClienteInfo.A1_METR = AppUtils.Nvl(drCliente.Item("A1_METR"), 0)
                    objClienteInfo.A1_NROCOM = AppUtils.Nvl(drCliente.Item("A1_NROCOM"), 0)

                    Dim varDataUltCom As Date

                    If Date.TryParseExact(AppUtils.Nvl(drCliente.Item("A1_ULTCOM"), "").ToString.Trim, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, varDataUltCom) Then
                        objClienteInfo.A1_ULTCOM = varDataUltCom

                    Else
                        objClienteInfo.A1_ULTCOM = DateTime.MinValue
                    End If

                    objClienteInfo.A1_SALDUP = AppUtils.Nvl(drCliente.Item("A1_SALDUP"), 0)


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

            'BUSCA INFORMAÇÕES DE NFs DE VENDA DO CLIENTE
            objClienteInfo.itemsNFsVenda = GetNFsVenda(parCodCliente, parCodLoja)

            Return Ok(objClienteInfo)
        End Function

        Private Function GetNFsVenda(ByVal parCodCliente As String, ByVal parCodLoja As String) As List(Of S5TNFVendaGroupByNumeroNF)
            Dim NFsVendaPlain = GetNFsVendaPlain(parCodCliente, parCodLoja)

            GetNFsVenda = GetNFsVendaGroupByNumeroNF(NFsVendaPlain).OrderByDescending(Function(x) x.pDATA_EMISSAO).ToList
        End Function

        Private Class _NFVendaGroupByNumeroNF
            Public Property pNUMERO_NF As String
            Public Property pDATA_EMISSAO As String
            Public Property pLOJA As String
            Public Property pCLIENTE As String
            Public Property pNOME_CLIENTE As String
            Public Property pTOTAL_VL_PRODUTO As Double
        End Class

        Private Function GetNFsVendaGroupByNumeroNF(ByVal parNFsVenda As List(Of S5TNFVenda)) As List(Of S5TNFVendaGroupByNumeroNF)
            Dim ListaNFsVendaGroupByNumeroNF = parNFsVenda.GroupBy(Function(x) New With {Key .pNUMERO_NF = x.pNUMERO_NF,
                                                                       Key .pDATA_EMISSAO = x.pDATA_EMISSAO,
                                                                       Key .pLOJA = x.pLOJA,
                                                                       Key .pCLIENTE = x.pCLIENTE,
                                                                       Key .pNOME_CLIENTE = x.pNOME_CLIENTE}).Select(Function(y) New _NFVendaGroupByNumeroNF With {.pNUMERO_NF = y.Min(Function(group) group.pNUMERO_NF),
                                                                                                                                                                   .pDATA_EMISSAO = y.Min(Function(group) group.pDATA_EMISSAO),
                                                                                                                                                                   .pLOJA = y.Min(Function(group) group.pLOJA),
                                                                                                                                                                   .pCLIENTE = y.Min(Function(group) group.pCLIENTE),
                                                                                                                                                                   .pNOME_CLIENTE = y.Min(Function(group) group.pNOME_CLIENTE),
                                                                                                                                                                    .pTOTAL_VL_PRODUTO = Math.Round(y.Sum(Function(group) group.pTOTAL_VL_PRODUTO), 2)}).ToList
            Dim NFsVendaGroupByNumeroNF = New List(Of S5TNFVendaGroupByNumeroNF)

            Dim NFsVendaGroupByNFItems = New List(Of S5TNFVendaGroupByNFItems)
            Dim NFsVendaGroupByNFItemsClone = New List(Of S5TNFVendaGroupByNFItems)

            For Each objPedidosGroupByNumeroNF In ListaNFsVendaGroupByNumeroNF
                NFsVendaGroupByNFItems = parNFsVenda.FindAll(Function(x) x.pNUMERO_NF = objPedidosGroupByNumeroNF.pNUMERO_NF).Select(Function(y) New S5TNFVendaGroupByNFItems With {.pPRODUTO = y.pPRODUTO,
                                                                                                                                                                                    .pDESCRICAO = y.pDESCRICAO,
                                                                                                                                                                                    .pTOTAL_QTD_CX = y.pTOTAL_QTD_CX,
                                                                                                                                                                                    .pTOTAL_QTD_UN = y.pTOTAL_QTD_UN,
                                                                                                                                                                                    .pTOTAL_VL_PRODUTO = y.pTOTAL_VL_PRODUTO}).ToList
                NFsVendaGroupByNFItemsClone = NFsVendaGroupByNFItems.Select(Function(x) x.Clone()).Cast(Of S5TNFVendaGroupByNFItems).ToList

                NFsVendaGroupByNumeroNF.Add(New S5TNFVendaGroupByNumeroNF With {.pNUMERO_NF = objPedidosGroupByNumeroNF.pNUMERO_NF,
                                                                                .pDATA_EMISSAO = objPedidosGroupByNumeroNF.pDATA_EMISSAO,
                                                                                .pLOJA = objPedidosGroupByNumeroNF.pLOJA,
                                                                                .pCLIENTE = objPedidosGroupByNumeroNF.pCLIENTE,
                                                                                .pNOME_CLIENTE = objPedidosGroupByNumeroNF.pNOME_CLIENTE,
                                                                                .pTOTAL_VL_PRODUTO = objPedidosGroupByNumeroNF.pTOTAL_VL_PRODUTO,
                                                                                .items = NFsVendaGroupByNFItemsClone})
            Next

            Return NFsVendaGroupByNumeroNF
        End Function


        Private Function GetNFsVendaPlain(ByVal parCodCliente As String, ByVal parCodLoja As String) As List(Of S5TNFVenda)
            Dim NFsVenda = New List(Of S5TNFVenda)

            Dim NFsVendaList = S5T.AviacaoVendas.LoadPedidosNFAppRaw(parCodCliente, parCodLoja, "")

            If NFsVendaList Is Nothing Then Return NFsVenda

            For Each obj In NFsVendaList
                Dim objNFVenda = New S5TNFVenda
                With objNFVenda
                    .pNUMERO_NF = obj.pNUMERO_NF
                    .pDATA_EMISSAO = obj.pDATA_EMISSAO
                    .pPRODUTO = obj.pPRODUTO.ToString.Trim
                    .pDESCRICAO = obj.pDESCRICAO.ToString.Trim
                    .pLOJA = obj.pLOJA.ToString.Trim
                    .pCLIENTE = obj.pCLIENTE
                    .pNOME_CLIENTE = obj.pNOME_CLIENTE
                    .pTOTAL_QTD_CX = obj.pQTD_EM_CAIXA
                    .pTOTAL_QTD_UN = obj.pQUANTIDADE
                    .pTOTAL_VL_PRODUTO = obj.pVLR_TOTAL_NOTA


                    NFsVenda.Add(objNFVenda)
                End With
            Next


            Return NFsVenda.OrderBy(Function(x) x.pNUMERO_NF).ToList
        End Function


        ' POST: api/Cliente
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Cliente/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Cliente/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace