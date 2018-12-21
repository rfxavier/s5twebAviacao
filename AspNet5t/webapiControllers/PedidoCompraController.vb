Imports System.Net
Imports System.Net.Http
Imports System.Runtime.Serialization
Imports System.Web.Http
Imports System.Web.Http.Cors
Imports Oracle.DataAccess.Client

Namespace webapiControllers
    '<Authorize>
    <RoutePrefix("api/PedidoCompra")>
    <EnableCors("*", "*", "*", SupportsCredentials:=True)>
    Public Class PedidoCompraController
        Inherits ApiController

        <DataContract>
        Private Class S5TPedidoCompra
            <DataMember>
            Public Property EMPRESA As String
            Public Property EMPRESA_NOME As String
            <DataMember>
            Public Property CR_FILIAL As String
            <DataMember>
            Public Property C7_NUM As String
            <DataMember>
            Public Property C7_FORNECE As String
            <DataMember>
            Public Property C7_LOJA As String
            <DataMember>
            Public Property A2_NOME As String
            <DataMember>
            Public Property CR_EMISSAO As Date
            <DataMember>
            Public Property CR_TOTAL As Double
            <DataMember>
            Public Property C7_ZZINCNO As String
            <DataMember>
            Public Property OBS As String
        End Class

        Public Class S5TPedidoCompraGroupByEmpresaItems
            Implements ICloneable

            Public Property CR_FILIAL As String
            <DataMember>
            Public Property C7_NUM As String
            <DataMember>
            Public Property C7_FORNECE As String
            <DataMember>
            Public Property C7_LOJA As String
            <DataMember>
            Public Property A2_NOME As String
            <DataMember>
            Public Property CR_EMISSAO As Date
            <DataMember>
            Public Property CR_TOTAL As Double
            <DataMember>
            Public Property C7_ZZINCNO As String
            <DataMember>
            Public Property OBS As String

            Public Function Clone() As Object Implements ICloneable.Clone
                Return Me.MemberwiseClone
            End Function
        End Class

        Public Class S5TPedidoCompraGroupByEmpresa
            <DataMember>
            Public Property EMPRESA As String
            <DataMember>
            Public Property EMPRESA_NOME As String
            <DataMember>
            Public Property items As List(Of S5TPedidoCompraGroupByEmpresaItems)
        End Class

        Public Class S5TPedidoCompraSubmetidoDetalhamentoPedidos
            <DataMember>
            Public Property empresa As String
            <DataMember>
            Public Property codFilial As String
            <DataMember>
            Public Property numPedido As String
        End Class

        Public Class S5TPedidoCompraSubmetido
            <DataMember>
            Public Property codAprovador As String
            <DataMember>
            Public Property flgOperacao As String 'L = Liberar, B = Bloquear
            <DataMember>
            Public Property pedidos As List(Of S5TPedidoCompraSubmetidoDetalhamentoPedidos)
        End Class

        ' GET: api/PedidoCompra
        <HttpGet>
        <Route("")>
        Public Function GetValues() As IHttpActionResult
            Return Ok(GetPedidosCompra(Me.Request.GetQueryNameValuePairs().ToList))
        End Function

        Private Function GetPedidosCompra(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As Object
            Dim PedidosCompraPlain = GetPedidosCompraPlain(parOptions)

            GetPedidosCompra = PedidosCompraPlain

            If parOptions IsNot Nothing Then
                Dim groupOptions As List(Of KeyValuePair(Of String, String)) = parOptions.FindAll(Function(x) x.Key = "group.field")

                If groupOptions.Count > 0 Then
                    If groupOptions(0).Value = "EMPRESA" Then
                        'EXISTE PARÂMETRO group.field = EMPRESA
                        GetPedidosCompra = GetPedidosCompraGroupByEmpresa(PedidosCompraPlain)
                    End If
                End If
            End If

        End Function

        Private Function GetPedidosCompraGroupByEmpresa(ByVal parPedidosCompra As List(Of S5TPedidoCompra)) As List(Of S5TPedidoCompraGroupByEmpresa)
            Dim ListaPedidosCompraGroupByNome = parPedidosCompra.GroupBy(Function(x) New With {Key .EMPRESA = x.EMPRESA, Key .EMPRESA_NOME = x.EMPRESA_NOME}).Select(Function(x) x.Key).OrderBy((Function(x) x.EMPRESA)).ToList

            Dim PedidosCompraGroupByEmpresa = New List(Of S5TPedidoCompraGroupByEmpresa)

            Dim PedidoCompraGroupByEmpresaItems = New List(Of S5TPedidoCompraGroupByEmpresaItems)
            Dim PedidoCompraGroupByEmpresaItemsClone = New List(Of S5TPedidoCompraGroupByEmpresaItems)

            For Each objPedidoCompraGroupByEmpresa In ListaPedidosCompraGroupByNome
                PedidoCompraGroupByEmpresaItems = parPedidosCompra.FindAll(Function(x) x.EMPRESA = objPedidoCompraGroupByEmpresa.EMPRESA).Select(Function(y) New S5TPedidoCompraGroupByEmpresaItems With {.CR_FILIAL = y.CR_FILIAL,
                                                                                                                                                                                                             .C7_NUM = y.C7_NUM,
                                                                                                                                                                                                             .C7_FORNECE = y.C7_FORNECE,
                                                                                                                                                                                                             .C7_LOJA = y.C7_LOJA,
                                                                                                                                                                                                             .A2_NOME = y.A2_NOME,
                                                                                                                                                                                                             .CR_EMISSAO = y.CR_EMISSAO,
                                                                                                                                                                                                             .CR_TOTAL = y.CR_TOTAL,
                                                                                                                                                                                                             .C7_ZZINCNO = y.C7_ZZINCNO,
                                                                                                                                                                                                             .OBS = y.OBS}).ToList
                PedidoCompraGroupByEmpresaItemsClone = PedidoCompraGroupByEmpresaItems.Select(Function(x) x.Clone()).Cast(Of S5TPedidoCompraGroupByEmpresaItems).ToList

                PedidosCompraGroupByEmpresa.Add(New S5TPedidoCompraGroupByEmpresa With {.EMPRESA = objPedidoCompraGroupByEmpresa.EMPRESA, .EMPRESA_NOME = objPedidoCompraGroupByEmpresa.EMPRESA_NOME, .items = PedidoCompraGroupByEmpresaItemsClone})
            Next

            Return PedidosCompraGroupByEmpresa
        End Function

        Private Function GetPedidosCompraPlain(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As List(Of S5TPedidoCompra)
            Dim PedidosCompra = New List(Of S5TPedidoCompra)

            'Dim varSqlBase = "SELECT DISTINCT CR_FILIAL, SC7.C7_NUM, SC7.C7_FORNECE, SC7.C7_LOJA, A2_NOME, CR_EMISSAO, CR_TOTAL, OBS FROM SCR010 SCR INNER JOIN SC7010 SC7 ON C7_NUM = CR_NUM AND C7_FILIAL = CR_FILIAL AND SC7.D_E_L_E_T_ = ' ' INNER JOIN SA2010 SA2 ON A2_COD = C7_FORNECE AND A2_LOJA = C7_LOJA AND A2_FILIAL = C7_FILIAL AND SA2.D_E_L_E_T_ = ' ' LEFT JOIN ( SELECT C7_FILIAL, C7_NUM, LISTAGG(RTRIM(C7_OBS), ' ') WITHIN GROUP ( ORDER BY C7_FILIAL, C7_NUM) OBS FROM SC7010 SC7 WHERE SC7.D_E_L_E_T_ = ' ' GROUP BY C7_FILIAL, C7_NUM ) OBS ON SC7.C7_FILIAL = OBS.C7_FILIAL AND SC7.C7_NUM = OBS.C7_NUM WHERE CR_STATUS = '02' AND SCR.D_E_L_E_T_ = ' '"
            ' AND CR_USER = '000029'

            'varSqlBase &= PedidosCompraWhereClause(parOptions)

            Dim strAppendWhereClause = PedidosCompraWhereClause(parOptions)


            'Dim varSqlBase = "SELECT DISTINCT '01' EMPRESA, 'AVIAÇÃO' EMPRESA_NOME, CR_FILIAL, SC7.C7_NUM, SC7.C7_FORNECE, SC7.C7_LOJA, A2_NOME, CR_EMISSAO, CR_TOTAL, OBS FROM SCR010 SCR INNER JOIN SC7010 SC7 ON C7_NUM = CR_NUM AND C7_FILIAL = CR_FILIAL AND SC7.D_E_L_E_T_ = ' ' INNER JOIN SA2010 SA2 ON A2_COD = C7_FORNECE AND A2_LOJA = C7_LOJA AND A2_FILIAL = C7_FILIAL AND SA2.D_E_L_E_T_ = ' ' LEFT JOIN ( SELECT C7_FILIAL, C7_NUM, LISTAGG(RTRIM(C7_OBS), ' ') WITHIN GROUP ( ORDER BY C7_FILIAL, C7_NUM) OBS FROM SC7010 SC7 WHERE SC7.D_E_L_E_T_ = ' ' GROUP BY C7_FILIAL, C7_NUM ) OBS ON SC7.C7_FILIAL = OBS.C7_FILIAL AND SC7.C7_NUM = OBS.C7_NUM WHERE CR_STATUS = '02' AND SCR.D_E_L_E_T_ = ' ' {0} UNION SELECT DISTINCT '02' EMPRESA, 'A.G.' EMPRESA_NOME, CR_FILIAL, SC7.C7_NUM, SC7.C7_FORNECE, SC7.C7_LOJA, A2_NOME, CR_EMISSAO, CR_TOTAL, OBS FROM SCR020 SCR INNER JOIN SC7020 SC7 ON C7_NUM = CR_NUM AND C7_FILIAL = CR_FILIAL AND SC7.D_E_L_E_T_ = ' ' INNER JOIN SA2020 SA2 ON A2_COD = C7_FORNECE AND A2_LOJA = C7_LOJA AND A2_FILIAL = C7_FILIAL AND SA2.D_E_L_E_T_ = ' ' LEFT JOIN ( SELECT C7_FILIAL, C7_NUM, LISTAGG(RTRIM(C7_OBS), ' ') WITHIN GROUP ( ORDER BY C7_FILIAL, C7_NUM) OBS FROM SC7020 SC7 WHERE SC7.D_E_L_E_T_ = ' ' GROUP BY C7_FILIAL, C7_NUM ) OBS ON SC7.C7_FILIAL = OBS.C7_FILIAL AND SC7.C7_NUM = OBS.C7_NUM WHERE CR_STATUS = '02' AND SCR.D_E_L_E_T_ = ' ' {0} ORDER BY EMPRESA, CR_FILIAL, C7_NUM"
            'Dim varSqlBase = "SELECT DISTINCT '01' EMPRESA, 'AVIAÇÃO' EMPRESA_NOME, CR_FILIAL, SC7.C7_NUM, SC7.C7_FORNECE, SC7.C7_LOJA, A2_NOME, CR_EMISSAO, CR_TOTAL, C7_ZZINCNO, OBS FROM SCR010 SCR INNER JOIN SC7010 SC7 ON C7_NUM = CR_NUM AND C7_FILIAL = CR_FILIAL AND SC7.D_E_L_E_T_ = ' ' INNER JOIN SA2010 SA2 ON A2_COD = C7_FORNECE AND A2_LOJA = C7_LOJA AND A2_FILIAL = C7_FILIAL AND SA2.D_E_L_E_T_ = ' ' LEFT JOIN (SELECT C7_FILIAL, C7_NUM, LISTAGG(RTRIM(C7_OBS), ' ') WITHIN GROUP ( ORDER BY C7_FILIAL, C7_NUM) OBS FROM SC7010 SC7 WHERE SC7.D_E_L_E_T_ = ' ' GROUP BY C7_FILIAL, C7_NUM ) OBS ON SC7.C7_FILIAL = OBS.C7_FILIAL AND SC7.C7_NUM = OBS.C7_NUM WHERE CR_STATUS = '02' AND SCR.D_E_L_E_T_ = ' ' {0} UNION SELECT DISTINCT '02' EMPRESA, 'A.G.' EMPRESA_NOME, CR_FILIAL, SC7.C7_NUM, SC7.C7_FORNECE, SC7.C7_LOJA, A2_NOME, CR_EMISSAO, CR_TOTAL, C7_ZZINCNO, OBS FROM SCR020 SCR INNER JOIN SC7020 SC7 ON C7_NUM = CR_NUM AND C7_FILIAL = CR_FILIAL AND SC7.D_E_L_E_T_ = ' ' INNER JOIN SA2020 SA2 ON A2_COD = C7_FORNECE AND A2_LOJA = C7_LOJA AND A2_FILIAL = C7_FILIAL AND SA2.D_E_L_E_T_ = ' ' LEFT JOIN (SELECT C7_FILIAL, C7_NUM, LISTAGG(RTRIM(C7_OBS), ' ') WITHIN GROUP ( ORDER BY C7_FILIAL, C7_NUM) OBS FROM SC7020 SC7 WHERE SC7.D_E_L_E_T_ = ' ' GROUP BY C7_FILIAL, C7_NUM ) OBS ON SC7.C7_FILIAL = OBS.C7_FILIAL AND SC7.C7_NUM = OBS.C7_NUM WHERE CR_STATUS = '02' AND SCR.D_E_L_E_T_ = ' ' {0} ORDER BY EMPRESA, CR_FILIAL, C7_NUM"
            Dim varSqlBase = "SELECT DISTINCT '01' EMPRESA, 'AVIAÇÃO' EMPRESA_NOME, CR_FILIAL, SC7.C7_NUM, SC7.C7_FORNECE, SC7.C7_LOJA, A2_NOME, CR_EMISSAO, CR_TOTAL, C7_ZZINCNO, OBS FROM SCR010 SCR INNER JOIN SC7010 SC7 ON C7_NUM = CR_NUM AND C7_FILIAL = CR_FILIAL AND SC7.D_E_L_E_T_ = ' ' AND SC7.C7_ZZINCNO <> ' ' INNER JOIN SA2010 SA2 ON A2_COD = C7_FORNECE AND A2_LOJA = C7_LOJA AND A2_FILIAL = C7_FILIAL AND SA2.D_E_L_E_T_ = ' ' LEFT JOIN (SELECT C7_FILIAL, C7_NUM, LISTAGG(RTRIM(C7_OBS), ' ') WITHIN GROUP ( ORDER BY C7_FILIAL, C7_NUM) OBS FROM SC7010 SC7 WHERE SC7.D_E_L_E_T_ = ' ' GROUP BY C7_FILIAL, C7_NUM ) OBS ON SC7.C7_FILIAL = OBS.C7_FILIAL AND SC7.C7_NUM = OBS.C7_NUM WHERE CR_STATUS = '02' AND SCR.D_E_L_E_T_ = ' ' {0} UNION SELECT DISTINCT '02' EMPRESA, 'A.G.' EMPRESA_NOME, CR_FILIAL, SC7.C7_NUM, SC7.C7_FORNECE, SC7.C7_LOJA, A2_NOME, CR_EMISSAO, CR_TOTAL, C7_ZZINCNO, OBS FROM SCR020 SCR INNER JOIN SC7020 SC7 ON C7_NUM = CR_NUM AND C7_FILIAL = CR_FILIAL AND SC7.D_E_L_E_T_ = ' ' INNER JOIN SA2020 SA2 ON A2_COD = C7_FORNECE AND A2_LOJA = C7_LOJA AND A2_FILIAL = C7_FILIAL AND SA2.D_E_L_E_T_ = ' ' LEFT JOIN (SELECT C7_FILIAL, C7_NUM, LISTAGG(RTRIM(C7_OBS), ' ') WITHIN GROUP ( ORDER BY C7_FILIAL, C7_NUM) OBS FROM SC7020 SC7 WHERE SC7.D_E_L_E_T_ = ' ' GROUP BY C7_FILIAL, C7_NUM ) OBS ON SC7.C7_FILIAL = OBS.C7_FILIAL AND SC7.C7_NUM = OBS.C7_NUM WHERE CR_STATUS = '02' AND SCR.D_E_L_E_T_ = ' ' {0} ORDER BY EMPRESA, CR_FILIAL, C7_NUM "

            varSqlBase = String.Format(varSqlBase, strAppendWhereClause)

            Dim conn As OracleConnection = Nothing
            Dim oradbConn As String = String.Empty

            Dim oradb As String = AppUtils.dbConnectionString

            conn = New OracleConnection(oradb)
            conn.Open()

            Dim cmdPedidoCompra As New OracleCommand(varSqlBase, conn) With {.CommandType = CommandType.Text}

            'Dim cmdPedidoCompra As OracleCommand

            Dim drPedidoCompra As OracleDataReader = Nothing
            Try
                drPedidoCompra = cmdPedidoCompra.ExecuteReader()
                If drPedidoCompra.HasRows Then
                    Do While drPedidoCompra.Read
                        Dim objPedidoCompra = New S5TPedidoCompra

                        objPedidoCompra.EMPRESA = AppUtils.Nvl(drPedidoCompra.Item("EMPRESA"), "").ToString.Trim
                        objPedidoCompra.EMPRESA_NOME = AppUtils.Nvl(drPedidoCompra.Item("EMPRESA_NOME"), "").ToString.Trim
                        objPedidoCompra.CR_FILIAL = AppUtils.Nvl(drPedidoCompra.Item("CR_FILIAL"), "").ToString.Trim
                        objPedidoCompra.C7_NUM = AppUtils.Nvl(drPedidoCompra.Item("C7_NUM"), "").ToString.Trim
                        objPedidoCompra.C7_FORNECE = AppUtils.Nvl(drPedidoCompra.Item("C7_FORNECE"), "").ToString.Trim
                        objPedidoCompra.C7_LOJA = AppUtils.Nvl(drPedidoCompra.Item("C7_LOJA"), "").ToString.Trim
                        objPedidoCompra.A2_NOME = AppUtils.Nvl(drPedidoCompra.Item("A2_NOME"), "").ToString.Trim
                        objPedidoCompra.CR_EMISSAO = DateTime.ParseExact(drPedidoCompra.Item("CR_EMISSAO"), "yyyyMMdd", Nothing)
                        objPedidoCompra.CR_TOTAL = AppUtils.Nvl(drPedidoCompra.Item("CR_TOTAL"), "").ToString.Trim
                        objPedidoCompra.C7_ZZINCNO = AppUtils.Nvl(drPedidoCompra.Item("C7_ZZINCNO"), "").ToString.Trim
                        objPedidoCompra.OBS = AppUtils.Nvl(drPedidoCompra.Item("OBS"), "").ToString.Trim

                        PedidosCompra.Add(objPedidoCompra)
                    Loop

                    drPedidoCompra.Close()
                End If
            Catch ex As Exception
                'Return InternalServerError(ex)
            Finally
                conn.Close()
                If (Not (drPedidoCompra) Is Nothing) Then
                    drPedidoCompra.Dispose()
                End If
            End Try

            Return PedidosCompra.OrderBy(Function(x) x.C7_NUM).ToList
        End Function

        Private Function PedidosCompraWhereClause(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As String
            PedidosCompraWhereClause = ""

            Dim varWhereClause As String = String.Empty

            Dim FilterElements = parOptions.FindAll(Function(x) x.Key = "filter")

            If FilterElements IsNot Nothing Then
                varWhereClause = " And"

                For Each filterElement In FilterElements
                    If {"="}.Contains(filterElement.Value) Then
                        varWhereClause &= " ="
                    ElseIf {"CR_USER"}.Contains(filterElement.Value) Then
                        varWhereClause &= " " & filterElement.Value
                    Else
                        varWhereClause &= " '" & filterElement.Value & "'"
                    End If
                Next
            End If

            PedidosCompraWhereClause = varWhereClause
        End Function


        ' GET: api/PedidoCompra/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/PedidoCompra
        <HttpPost>
        <Route("")>
        Public Function PostValue(<FromBody()> ByVal oPedidoCompraSubmetido As S5TPedidoCompraSubmetido) As HttpResponseMessage
            Dim response As HttpResponseMessage

            response = New HttpResponseMessage(HttpStatusCode.BadRequest)
            response.Content = New StringContent("Conteúdo de Pedido está incompleto")

            If oPedidoCompraSubmetido IsNot Nothing Then
                If oPedidoCompraSubmetido.pedidos IsNot Nothing Then
                    If oPedidoCompraSubmetido.pedidos.Count > 0 Then

                        Dim ServicePedCompraProtheusClient As New ServicePedCompraProtheusReference.GSLIBPEDCOMSOAPClient

                        Dim ServicePedCompraProtheusPedLib As New ServicePedCompraProtheusReference.GSPEDLIB
                        Dim ServicePedCompraProtheusPedCompraItens = New ServicePedCompraProtheusReference.ARRAYOFGSPEDCOM

                        ServicePedCompraProtheusPedLib.APROVADOR = oPedidoCompraSubmetido.codAprovador


                        Dim ServicePedCompraProtheusClientEmpresa02 As New ServicePedCompraEmpresa02ProtheusReference.GSLIBPEDCOMSOAPClient

                        Dim ServicePedCompraProtheusPedLibEmpresa02 As New ServicePedCompraEmpresa02ProtheusReference.GSPEDLIB
                        Dim ServicePedCompraProtheusPedCompraItensEmpresa02 = New ServicePedCompraEmpresa02ProtheusReference.ARRAYOFGSPEDCOM

                        ServicePedCompraProtheusPedLibEmpresa02.APROVADOR = oPedidoCompraSubmetido.codAprovador


                        For Each objItem In oPedidoCompraSubmetido.pedidos
                            If objItem.empresa = "01" Then
                                ServicePedCompraProtheusPedCompraItens.Add(New ServicePedCompraProtheusReference.GSPEDCOM With {.FILPED = objItem.codFilial, .PEDIDO = objItem.numPedido})
                            ElseIf objItem.empresa = "02" Then
                                ServicePedCompraProtheusPedCompraItensEmpresa02.Add(New ServicePedCompraEmpresa02ProtheusReference.GSPEDCOM With {.FILPED = objItem.codFilial, .PEDIDO = objItem.numPedido})
                            End If
                        Next

                        ServicePedCompraProtheusPedLib.PEDIDOS = ServicePedCompraProtheusPedCompraItens

                        ServicePedCompraProtheusPedLibEmpresa02.PEDIDOS = ServicePedCompraProtheusPedCompraItensEmpresa02

                        If oPedidoCompraSubmetido.flgOperacao = "L" Then
                            If ServicePedCompraProtheusPedLib.PEDIDOS.Count > 0 Then
                                Dim varResultado = ServicePedCompraProtheusClient.LIBERAR(ServicePedCompraProtheusPedLib)

                                Dim varResultadoStr As String = String.Empty

                                'If varResultado.Count > 0 Then
                                '    For Each objResultadoItem In varResultado
                                '        varResultadoStr &= "Pedido:" & objResultadoItem.PEDIDO & " Status:" & objResultadoItem.STATUS & " Descrição:" & objResultadoItem.DESCRICAO
                                '    Next
                                'End If
                            End If

                            If ServicePedCompraProtheusPedLibEmpresa02.PEDIDOS.Count > 0 Then
                                Dim varResultado = ServicePedCompraProtheusClientEmpresa02.LIBERAR(ServicePedCompraProtheusPedLibEmpresa02)

                                Dim varResultadoStr As String = String.Empty

                                'If varResultado.Count > 0 Then
                                '    For Each objResultadoItem In varResultado
                                '        varResultadoStr &= "Pedido:" & objResultadoItem.PEDIDO & " Status:" & objResultadoItem.STATUS & " Descrição:" & objResultadoItem.DESCRICAO
                                '    Next
                                'End If
                            End If


                        ElseIf oPedidoCompraSubmetido.flgOperacao = "B" Then
                            If ServicePedCompraProtheusPedLib.PEDIDOS.Count > 0 Then
                                Dim varResultado = ServicePedCompraProtheusClient.BLOQUEAR(ServicePedCompraProtheusPedLib)

                                Dim varResultadoStr As String = String.Empty

                                'If varResultado.Count > 0 Then
                                '    For Each objResultadoItem In varResultado
                                '        varResultadoStr &= "Pedido:" & objResultadoItem.PEDIDO & " Status:" & objResultadoItem.STATUS & " Descrição:" & objResultadoItem.DESCRICAO
                                '    Next
                                'End If
                            End If

                            If ServicePedCompraProtheusPedLibEmpresa02.PEDIDOS.Count > 0 Then
                                Dim varResultado = ServicePedCompraProtheusClientEmpresa02.BLOQUEAR(ServicePedCompraProtheusPedLibEmpresa02)

                                Dim varResultadoStr As String = String.Empty

                                'If varResultado.Count > 0 Then
                                '    For Each objResultadoItem In varResultado
                                '        varResultadoStr &= "Pedido:" & objResultadoItem.PEDIDO & " Status:" & objResultadoItem.STATUS & " Descrição:" & objResultadoItem.DESCRICAO
                                '    Next
                                'End If
                            End If
                        End If
                    End If
                End If
            End If

            response = New HttpResponseMessage(HttpStatusCode.Created)
            response.Content = New StringContent("")

            Return response
        End Function

        ' PUT: api/PedidoCompra/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/PedidoCompra/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace