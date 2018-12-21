Imports System.Net.Http
Imports System.Runtime.Serialization
Imports System.Web.Http
Imports System.Web.Http.Cors
Imports Oracle.DataAccess.Client

Namespace webapiControllers
    <Authorize>
    <RoutePrefix("api/Produto")>
    <EnableCors("*", "*", "*", SupportsCredentials:=True)>
    Public Class ProdutoController
        Inherits ApiController

        <DataContract>
        Private Class S5TProduto
            <DataMember>
            Public Property B1_COD As String
            <DataMember>
            Public Property B1_DESC As String
            <DataMember>
            Public Property ZZO_DESCRI As String
            <DataMember>
            Public Property DA1_PRCVEN As Double
            <DataMember>
            Public Property B1_CONV As String '-- Fator de Conversão
            <DataMember>
            Public Property B1_TIPCONV As String '-- Tipo Conversão (D=Divide;M=Multiplica)
            <DataMember>
            Public Property B1_GRUPO As String
            <DataMember>
            Public Property B1_GRUPO_DESC As String
            <DataMember>
            Public Property B1_ZZPESOP As Double
            <DataMember>
            Public Property ZP_SALDO As Double
            <DataMember>
            Public Property ZP_STATUS As String '-- 1=Utiliza Cota; 2=Não Utiliza Cota
            <DataMember>
            Public Property PRECO_CAIXA As Double

        End Class

        Private Class S5TProdutoGroupByGrupoItems
            Implements ICloneable

            <DataMember>
            Public Property B1_COD As String
            <DataMember>
            Public Property B1_DESC As String
            <DataMember>
            Public Property ZZO_DESCRI As String
            <DataMember>
            Public Property DA1_PRCVEN As Double
            <DataMember>
            Public Property B1_CONV As String '-- Fator de Conversão
            <DataMember>
            Public Property B1_TIPCONV As String '-- Tipo Conversão (D=Divide;M=Multiplica)
            <DataMember>
            Public Property B1_ZZPESOP As Double
            <DataMember>
            Public Property ZP_SALDO As Double
            <DataMember>
            Public Property SP_STATUS As String '-- 1=Utiliza Cota; 2=Não Utiliza Cota
            <DataMember>
            Public Property PRECO_CAIXA As Double

            Public Function Clone() As Object Implements ICloneable.Clone
                Return Me.MemberwiseClone
            End Function
        End Class

        Private Class S5TProdutoGroupByGrupo
            <DataMember>
            Public Property B1_GRUPO As String
            <DataMember>
            Public Property B1_GRUPO_DESC As String
            <DataMember>
            Public Property items As List(Of S5TProdutoGroupByGrupoItems)

        End Class

        ' GET: api/Produto
        <HttpGet>
        <Route("")>
        Public Function GetValuesProduto() As IHttpActionResult
            Return Ok(GetProdutos(Me.Request.GetQueryNameValuePairs().ToList))
        End Function

        Private Function GetProdutos(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As Object
            Dim ProdutosPlain = GetProdutosPlain(parOptions)

            GetProdutos = ProdutosPlain

            If parOptions IsNot Nothing Then
                Dim groupOptions As List(Of KeyValuePair(Of String, String)) = parOptions.FindAll(Function(x) x.Key = "group.field")

                If groupOptions.Count > 0 Then
                    If groupOptions(0).Value = "B1_GRUPO" Then
                        'EXISTE PARÂMETRO group.field = B1_GRUPO
                        GetProdutos = GetProdutoGroupByGrupo(ProdutosPlain).OrderBy(Function(x) x.B1_GRUPO).ToList
                    End If
                End If
            End If

        End Function

        Private Function GetProdutoGroupByGrupo(ByVal parProdutos As List(Of S5TProduto)) As List(Of S5TProdutoGroupByGrupo)
            Dim ListaProdutosGroupByGrupo = parProdutos.GroupBy(Function(x) New With {Key .B1_GRUPO = x.B1_GRUPO, Key .B1_GRUPO_DESC = x.B1_GRUPO_DESC}).Select(Function(x) x.Key).ToList

            Dim ProdutosGroupByGrupo = New List(Of S5TProdutoGroupByGrupo)

            Dim ProdutoGroupByGrupoItems = New List(Of S5TProdutoGroupByGrupoItems)
            Dim ProdutoGroupByGrupoItemsClone = New List(Of S5TProdutoGroupByGrupoItems)

            For Each objProdutosGroupByGrupo In ListaProdutosGroupByGrupo
                ProdutoGroupByGrupoItems = parProdutos.FindAll(Function(x) x.B1_GRUPO = objProdutosGroupByGrupo.B1_GRUPO).Select(Function(y) New S5TProdutoGroupByGrupoItems With {.B1_COD = y.B1_COD,
                                                                                                                                                                                    .B1_DESC = y.B1_DESC,
                                                                                                                                                                                    .ZZO_DESCRI = y.ZZO_DESCRI,
                                                                                                                                                                                    .DA1_PRCVEN = y.DA1_PRCVEN,
                                                                                                                                                                                    .B1_CONV = y.B1_CONV,
                                                                                                                                                                                    .B1_TIPCONV = y.B1_TIPCONV,
                                                                                                                                                                                    .B1_ZZPESOP = y.B1_ZZPESOP,
                                                                                                                                                                                    .ZP_SALDO = y.ZP_SALDO,
                                                                                                                                                                                    .SP_STATUS = y.ZP_STATUS,
                                                                                                                                                                                    .PRECO_CAIXA = y.PRECO_CAIXA}).ToList
                ProdutoGroupByGrupoItemsClone = ProdutoGroupByGrupoItems.Select(Function(x) x.Clone()).Cast(Of S5TProdutoGroupByGrupoItems).ToList

                ProdutosGroupByGrupo.Add(New S5TProdutoGroupByGrupo With {.B1_GRUPO = objProdutosGroupByGrupo.B1_GRUPO, .B1_GRUPO_DESC = objProdutosGroupByGrupo.B1_GRUPO_DESC, .items = ProdutoGroupByGrupoItemsClone})
            Next

            Return ProdutosGroupByGrupo
        End Function

        Private Function GetProdutosPlain(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As List(Of S5TProduto)
            Dim Produtos = New List(Of S5TProduto)

            '*** IMPORTANTE: String em varSqlBase deve ser mesma de PedidoController - GetProdutos

            'Comentado em 17/08/2016 - alteração enviada por Everton
            'Dim varSqlBase = "SELECT B1_COD, B1_DESC, ZZO_DESCRI, DA1_PRCVEN, B1_CONV, B1_TIPCONV, B1_GRUPO, B1_ZZPESOP, DECODE(NVL(ZP_STATUS, '2'),'2',9999,NVL(ZP_SALDO, 0)) ZP_SALDO, NVL(ZP_STATUS, '2') ZP_STATUS, CASE WHEN B1_GRUPO = '3' AND B1_COD NOT IN ('325001', '315500', '310000','322305','314510','312905') THEN ROUND(DA1_PRCVEN * B1_ZZPESOP,2) ELSE ROUND(DA1_PRCVEN * B1_CONV,2) END PRECO_CAIXA FROM SA1010 SA1 INNER JOIN DA1010 DA1 ON DA1_CODTAB = A1_TABELA AND DA1.D_E_L_E_T_ = ' ' INNER JOIN SB1010 SB1 ON B1_COD = DA1_CODPRO AND B1_FILIAL = '01' AND SB1.D_E_L_E_T_ = ' ' INNER JOIN ZZO010 ZZO ON ZZO_TABELA = '000016' AND ZZO_CHAVE = B1_COD AND ZZO_FILIAL = '01' AND ZZO.D_E_L_E_T_ = ' ' LEFT JOIN SZP010 SZP ON ZP_VENDEDO = A1_VEND AND ZP_CODIGO = B1_COD AND SZP.D_E_L_E_T_ = ' ' WHERE A1_MSBLQL = '2' AND DA1_ATIVO = '1' AND B1_MSBLQL = '2' AND A1_FILIAL = '01' AND SA1.D_E_L_E_T_ = ' ' AND B1_GRUPO <> ' '"

            Dim varSqlBase = "SELECT DISTINCT DA1_CODPRO B1_COD, B1_DESC, ZZO_DESCRI, DA1_PRCVEN, B1_CONV, B1_TIPCONV, B1_GRUPO, B1_ZZPESOP, DECODE(NVL(ZP_STATUS, '2'),'2',9999,NVL(ZP_SALDO, 0)) ZP_SALDO, NVL(ZP_STATUS, '2') ZP_STATUS, CASE WHEN B1_GRUPO = '3' AND B1_COD NOT IN ( SELECT ZZO_CHAVE FROM ZZO010 ZZO WHERE ZZO_TABELA = '000033' AND ZZO_FILIAL = '01' AND ZZO.D_E_L_E_T_ = ' ' ) THEN DA1_PRCVEN * TRUNC(B1_ZZPESOP, 0) ELSE DA1_PRCVEN * B1_CONV END PRECO_CAIXA FROM SA1010 SA1 INNER JOIN ( SELECT A1_FILIAL, A1_CGC, DA1_CODPRO, DA1_PRCVEN FROM SA1010 SA1 INNER JOIN DA1010 DA1 ON DA1_CODTAB = A1_TABELA AND DA1.D_E_L_E_T_ = ' ' WHERE SA1.D_E_L_E_T_ = ' ' AND DA1_ATIVO = '1' AND A1_FILIAL || DA1_CODPRO NOT IN ( SELECT ZZO_FILIAL || ZZO_CHAVE FROM ZZO010 ZZO WHERE ZZO_TABELA = '000058' AND ZZO_FILIAL = '01' AND ZZO.D_E_L_E_T_ = ' ' ) ) TAB ON SA1.A1_CGC = TAB.A1_CGC INNER JOIN SB1010 SB1 ON B1_FILIAL = TAB.A1_FILIAL AND B1_COD = DA1_CODPRO AND SB1.D_E_L_E_T_ = ' ' INNER JOIN ZZO010 ZZO ON ZZO_TABELA = '000016' AND ZZO_CHAVE = B1_COD AND ZZO_FILIAL = '01' AND ZZO.D_E_L_E_T_ = ' ' LEFT JOIN SZP010 SZP ON ZP_VENDEDO = A1_VEND AND ZP_CODIGO = DA1_CODPRO AND SZP.D_E_L_E_T_ = ' ' WHERE A1_MSBLQL = '2' AND B1_MSBLQL = '2' AND SA1.A1_FILIAL = '01' AND SA1.D_E_L_E_T_ = ' ' AND B1_GRUPO <> ' '"

            'WHERE A1_COD = '000430' AND A1_LOJA = '59' AND A1_VEND = '001'

            varSqlBase &= ProdutosWhereClause(parOptions)

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
                        objProduto.ZZO_DESCRI = AppUtils.Nvl(drProduto.Item("ZZO_DESCRI"), "").ToString.Trim
                        objProduto.DA1_PRCVEN = AppUtils.Nvl(drProduto.Item("DA1_PRCVEN"), 0)
                        objProduto.B1_CONV = AppUtils.Nvl(drProduto.Item("B1_CONV"), "").ToString.Trim
                        objProduto.B1_TIPCONV = AppUtils.Nvl(drProduto.Item("B1_TIPCONV"), "").ToString.Trim
                        objProduto.B1_GRUPO = AppUtils.Nvl(drProduto.Item("B1_GRUPO"), "").ToString.Trim

                        If objProduto.B1_GRUPO.Trim = "1" Then
                            objProduto.B1_GRUPO_DESC = "MANTEIGA"
                        ElseIf objProduto.B1_GRUPO.Trim = "2" Then
                            objProduto.B1_GRUPO_DESC = "DOCE DE LEITE"
                        ElseIf objProduto.B1_GRUPO.Trim = "3" Then
                            objProduto.B1_GRUPO_DESC = "QUEIJO"
                        ElseIf objProduto.B1_GRUPO.Trim = "4" Then
                            objProduto.B1_GRUPO_DESC = "REQUEIJÃO"
                        ElseIf objProduto.B1_GRUPO.Trim = "5" Then
                            objProduto.B1_GRUPO_DESC = "CAFÉ"
                        ElseIf objProduto.B1_GRUPO.Trim = "7" Then
                            objProduto.B1_GRUPO_DESC = "ÁGUA"
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

            Return Produtos.OrderBy(Function(x) x.B1_DESC).ToList
        End Function

        Private Function ProdutosWhereClause(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As String
            ProdutosWhereClause = ""

            Dim varWhereClause As String = String.Empty

            Dim FilterElements = parOptions.FindAll(Function(x) x.Key.StartsWith("filter"))

            If FilterElements IsNot Nothing Then
                varWhereClause = " And"

                For Each filterElement In FilterElements
                    If {"="}.Contains(filterElement.Value) Then
                        varWhereClause &= " ="
                    ElseIf {"And", "and"}.Contains(filterElement.Value) Then
                        varWhereClause &= " And"
                    ElseIf {"A1_COD"}.Contains(filterElement.Value) Then
                        varWhereClause &= " " & filterElement.Value
                    ElseIf {"A1_LOJA"}.Contains(filterElement.Value) Then
                        varWhereClause &= " " & filterElement.Value
                    ElseIf {"A1_VEND"}.Contains(filterElement.Value) Then
                        varWhereClause &= " " & filterElement.Value
                    Else
                        varWhereClause &= " '" & filterElement.Value & "'"
                    End If
                Next
            End If

            ProdutosWhereClause = varWhereClause
        End Function

        Private Function ProdutoParseInfo(ByVal parNomeCampo As string, ByVal parOptions As List(Of KeyValuePair(Of String, String))) As String
            ProdutoParseInfo = String.Empty

            Dim FilterElements1 = parOptions.FindAll(Function(x) x.Value = parNomeCampo)
            Dim FilterElements2 As KeyValuePair(Of String,String)
            
            Dim filterStr = string.Empty

            If FilterElements1.Count > 0 Then
                filterStr = FilterElements1.FirstOrDefault().Key

                FilterElements2 = parOptions.FindAll(Function(x) x.Key = filterStr).LastOrDefault()

                ProdutoParseInfo = FilterElements2.Value
            End If
        End Function


        ' GET: api/Produto/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/Produto
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Produto/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Produto/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace