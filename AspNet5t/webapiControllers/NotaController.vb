Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports System.Web.Http.Cors
Imports Oracle.DataAccess.Client

Namespace webapiControllers
    <Authorize>
    <RoutePrefix("api/Nota")>
    <EnableCors("*", "*", "*", SupportsCredentials:=True)>
    Public Class NotaController
        Inherits ApiController

        Private Class S5TNota
            Public Property pNUMERO_NF As String
            'Public Property pCLIENTE As String
            'Public Property pLOJA As String
            Public Property pDATA_EMISSAO As Date
            Public Property pPRODUTO As String
            Public Property pDESCRICAO As String
            Public Property pQUANTIDADE As Double
            Public Property pQTD_EM_CAIXA As Double
            Public Property pVLR_TOTAL_PRODUTO As Double
            Public Property pVLR_TOTAL_NOTA As Double
            Public Property VLR_ST As Double
        End Class
        Private Class S5TNotaGroupByNotasItems
            Implements ICloneable
            'Public Property pNUMERO_NF As String
            'Public Property pCLIENTE As String
            'Public Property pLOJA As String
            Public Property pDATA_EMISSAO As Date
            Public Property pPRODUTO As String
            Public Property pDESCRICAO As String
            Public Property pQUANTIDADE As Double
            Public Property pQTD_EM_CAIXA As Double
            Public Property pVLR_TOTAL_PRODUTO As Double
            Public Property pVLR_TOTAL_NOTA As Double
            Public Property VLR_ST As Double

            Public Function Clone() As Object Implements ICloneable.Clone
                Return Me.MemberwiseClone
            End Function
        End Class

        Private Class S5TNotaGroupByNota
            Public Property pNUMERO_NF As String
            'Public Property pCLIENTE As String
            'Public Property pLOJA As String
            Public Property itemsNota As List(Of S5TNotaGroupByNotasItems)
        End Class

        Private Function GetNotasPlain(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As List(Of S5TNota)
            Dim Notas = New List(Of S5TNota)
            Dim varCodCliente As String = "011981"
            Dim varDataEmissao As Date
            'varDataEmissao = DateAdd("d", -60, CDate(Now).ToString("MM-dd-yyyy"))
            varDataEmissao = Date.Now.AddDays(-60) 'DateAdd("d", -60, Now.Date)
            'varDataEmissao = CDate(varDataEmissao).ToString("MM-dd-yyyy")

            Dim varNotas = S5T.AviacaoVendasCollection.LoadNotasPorCliente(varCodCliente, varDataEmissao)

            Notas = varNotas.Select(Function(x) New S5TNota With {.pNUMERO_NF = x.pNUMERO_NF,
                                                                    .pDATA_EMISSAO = x.pDATA_EMISSAO,
                                                                    .pPRODUTO = x.pPRODUTO.Trim,
                                                                    .pDESCRICAO = x.pDESCRICAO.Trim,
                                                                    .pQUANTIDADE = x.pQUANTIDADE,
                                                                    .pQTD_EM_CAIXA = x.pQTD_EM_CAIXA,
                                                                    .pVLR_TOTAL_PRODUTO = x.pVLR_TOTAL_PRODUTO,
                                                                    .pVLR_TOTAL_NOTA = x.pVLR_TOTAL_NOTA,
                                                                    .VLR_ST = x.pVLR_TOTAL_NOTA - x.pVLR_TOTAL_PRODUTO}).ToList
            Return Notas



            'Dim varSqlBase = "select pcliente,pNUMERO_NF,pDATA_EMISSAO,pPRODUTO,pDESCRICAO,pQUANTIDADE,pQTD_EM_CAIXA,pVLR_TOTAL_PRODUTO,pVLR_TOTAL_nota,ROUND(pvlr_total_nota - pVLR_TOTAL_PRODUTO,2) VLR_ST from AviacaoVendas where pcliente = '011981' AND pDATA_EMISSAO >= DATEADD(dd, -60, getdate())"

            'varSqlBase &= NotasWhereClause(parOptions)
            'Dim conn As OracleConnection = Nothing
            'Dim oradbConn As String = String.Empty

            'Dim oradb As String = AppUtils.dbConnectionString

            'conn = New OracleConnection(oradb)
            'conn.Open()

            'Dim cmdNota As New OracleCommand(varSqlBase, conn) With {.CommandType = CommandType.Text}
            'Dim drNota As OracleDataReader = Nothing

            'Try
            '    drNota = cmdNota.ExecuteReader()
            '    If drNota.HasRows Then
            '        Do While drNota.Read
            '            Dim objNota = New S5TNota
            '            objNota.pNUMERO_NF = AppUtils.Nvl(drNota.Item("pNUMERO"), "").ToString.Trim
            '            objNota.pDATA_EMISSAO = AppUtils.Nvl(drNota.Item("pDATA_EMISSAO"), "").ToString.Trim
            '            objNota.pPRODUTO = AppUtils.Nvl(drNota.Item("pPRODUTO"), "").ToString.Trim
            '            objNota.pDESCRICAO = AppUtils.Nvl(drNota.Item("pDESCRICAO"), "").ToString.Trim
            '            objNota.pQUANTIDADE = AppUtils.Nvl(drNota.Item("pQUANTIDADE"), 0).ToString.Trim
            '            objNota.pQTD_EM_CAIXA = AppUtils.Nvl(drNota.Item("pQTD_EM_CAIXA"), 0).ToString.Trim
            '            objNota.pVLR_TOTAL_PRODUTO = AppUtils.Nvl(drNota.Item("pVLR_TOTAL_PRODUTO"), 0).ToString.Trim
            '            objNota.pVLR_TOTAL_NOTA = AppUtils.Nvl(drNota.Item("pVLR_TOTAL_NOTA"), 0).ToString.Trim


            '            Notas.Add(objNota)
            '        Loop

            '        drNota.Close()
            '    End If
            'Catch ex As Exception
            '    'Return InternalServerError(ex)
            'Finally
            '    conn.Close()
            '    If (Not (drNota) Is Nothing) Then
            '        drNota.Dispose()
            '    End If
            'End Try

            'Return Notas.OrderByDescending(Function(x) x.pDATA_EMISSAO).ToList



        End Function

        Private Function NotasWhereClause(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As String
            NotasWhereClause = ""

            Dim varWhereClause As String = String.Empty

            Dim FilterElements = parOptions.FindAll(Function(x) x.Key.StartsWith("filter"))

            If FilterElements IsNot Nothing Then
                varWhereClause = " And"
                'verificar com rx se coloca a loja como parametro, porque o cliente está tudo por loja
                For Each filterElement In FilterElements
                    If {"="}.Contains(filterElement.Value) Then
                        varWhereClause &= " ="
                    ElseIf {"And", "and"}.Contains(filterElement.Value) Then
                        varWhereClause &= " And"
                    ElseIf {"pcliente "}.Contains(filterElement.Value) Then
                        varWhereClause &= " " & filterElement.Value
                    Else
                        varWhereClause &= " '" & filterElement.Value & "'"
                    End If
                Next
            End If

            NotasWhereClause = varWhereClause
        End Function

        Private Function GetNotas(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As Object
            Dim NotasPlain = GetNotasPlain(parOptions)

            GetNotas = NotasPlain

            If parOptions IsNot Nothing Then
                Dim groupOptions As List(Of KeyValuePair(Of String, String)) = parOptions.FindAll(Function(x) x.Key = "group.field")

                If groupOptions.Count > 0 Then
                    If groupOptions(0).Value = "pNUMERO_NF" Then
                        'EXISTE PARÂMETRO group.field = pNUMERO_NF
                        GetNotas = GetNotasGroupByNota(NotasPlain).OrderBy(Function(x) x.pNUMERO_NF).ToList
                    End If
                End If
            End If

        End Function
        Private Function GetNotasGroupByNota(ByVal parNotas As List(Of S5TNota)) As List(Of S5TNotaGroupByNota)
            Dim ListaNotasGroupByNota = parNotas.GroupBy(Function(x) New With {Key .pNUMERO_NF = x.pNUMERO_NF}).Select(Function(x) x.Key).ToList

            Dim NotasGroupByNota = New List(Of S5TNotaGroupByNota)

            Dim NotaGroupByGrupoItems = New List(Of S5TNotaGroupByNotasItems)
            Dim NotaGroupByGrupoItemsClone = New List(Of S5TNotaGroupByNotasItems)

            For Each objNotasGroupByGrupo In ListaNotasGroupByNota
                NotaGroupByGrupoItems = parNotas.FindAll(Function(x) x.pNUMERO_NF = objNotasGroupByGrupo.pNUMERO_NF).Select(Function(y) New S5TNotaGroupByNotasItems With {.pDATA_EMISSAO = y.pDATA_EMISSAO,
                                                                                                                                                                                    .pPRODUTO = y.pPRODUTO,
                                                                                                                                                                                    .pDESCRICAO = y.pDESCRICAO,
                                                                                                                                                                                    .pQUANTIDADE = y.pQUANTIDADE,
                                                                                                                                                                                    .pQTD_EM_CAIXA = y.pQTD_EM_CAIXA,
                                                                                                                                                                                    .pVLR_TOTAL_PRODUTO = y.pVLR_TOTAL_PRODUTO,
                                                                                                                                                                                    .pVLR_TOTAL_NOTA = y.pVLR_TOTAL_NOTA,
                                                                                                                                                                                    .VLR_ST = y.VLR_ST}).ToList
                NotaGroupByGrupoItemsClone = NotaGroupByGrupoItems.Select(Function(x) x.Clone()).Cast(Of S5TNotaGroupByNotasItems).ToList

                NotasGroupByNota.Add(New S5TNotaGroupByNota With {.pNUMERO_NF = objNotasGroupByGrupo.pNUMERO_NF, .itemsNota = NotaGroupByGrupoItemsClone})
            Next

            Return NotasGroupByNota
        End Function


        ' GET: api/Nota
        <HttpGet>
        <Route("")>
        Public Function GetValuesNota() As IHttpActionResult
            Return Ok(GetNotas(Me.Request.GetQueryNameValuePairs().ToList))
        End Function

        ' GET: api/Nota/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/Nota
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Nota/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Nota/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace