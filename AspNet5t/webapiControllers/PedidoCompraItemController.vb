Imports System.Net
Imports System.Net.Http
Imports System.Runtime.Serialization
Imports System.Web.Http
Imports System.Web.Http.Cors
Imports Oracle.DataAccess.Client

Namespace webapiControllers
    '<Authorize>
    <RoutePrefix("api/PedidoCompraItem")>
    <EnableCors("*", "*", "*", SupportsCredentials:=True)>
    Public Class PedidoCompraItemController
        Inherits ApiController

        <DataContract>
        Private Class S5TPedidoCompraItem
            Public Property C7_FILIAL As String
            Public Property C7_NUM As String
            <DataMember>
            Public Property C7_ITEM As String
            <DataMember>
            Public Property C7_PRODUTO As String
            <DataMember>
            Public Property B1_DESC As String
            <DataMember>
            Public Property C7_UM As String
            <DataMember>
            Public Property C7_QUANT As Double
            <DataMember>
            Public Property C7_PRECO As Double
            <DataMember>
            Public Property C7_TOTAL As Double
            <DataMember>
            Public Property C7_OBS As String
        End Class

        ' GET: api/PedidoCompraItem
        <HttpGet>
        <Route("")>
        Public Function GetValues() As IHttpActionResult
            Return Ok(GetPedidoCompraItens(Me.Request.GetQueryNameValuePairs().ToList))
        End Function

        Private Function GetPedidoCompraItens(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As Object
            Dim PedidoCompraItensPlain = GetPedidoCompraItensPlain(parOptions)

            GetPedidoCompraItens = PedidoCompraItensPlain
        End Function

        Private Function GetPedidoCompraItensPlain(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As List(Of S5TPedidoCompraItem)
            Dim PedidoCompraItens = New List(Of S5TPedidoCompraItem)

            'Dim varSqlBase = "SELECT C7_FILIAL, C7_ITEM, C7_PRODUTO, B1_DESC, C7_UM, C7_QUANT, C7_PRECO, C7_TOTAL, C7_OBS FROM SC7010 SC7 INNER JOIN SB1010 SB1 ON B1_COD = C7_PRODUTO AND B1_FILIAL = C7_FILIAL AND SB1.D_E_L_E_T_ = ' ' WHERE SC7.D_E_L_E_T_ = ' '"
            '' AND C7_FILIAL = '02' AND C7_NUM = '021739'

            'varSqlBase &= PedidoCompraItensWhereClause(parOptions)

            Dim varSqlBase As String = String.Empty

            strAppendWhereClause = PedidoCompraItensWhereClause(parOptions)

            Dim strEmpresa = PedidoCompraItensEmpresaFromWhereClause(strAppendWhereClause)

            strAppendWhereClause = PedidoCompraItensWhereClauseSemEmpresa(strAppendWhereClause)

            Dim varSqlBaseEmpresa01 = "SELECT C7_FILIAL, C7_ITEM, C7_PRODUTO, B1_DESC, C7_UM, C7_QUANT, C7_PRECO, C7_TOTAL, C7_OBS FROM SC7010 SC7 INNER JOIN SB1010 SB1 ON B1_COD = C7_PRODUTO AND B1_FILIAL = C7_FILIAL AND SB1.D_E_L_E_T_ = ' ' WHERE SC7.D_E_L_E_T_ = ' '"

            Dim varSqlBaseEmpresa02 = "SELECT C7_FILIAL, C7_ITEM, C7_PRODUTO, B1_DESC, C7_UM, C7_QUANT, C7_PRECO, C7_TOTAL, C7_OBS FROM SC7020 SC7 INNER JOIN SB1020 SB1 ON B1_COD = C7_PRODUTO AND B1_FILIAL = C7_FILIAL AND SB1.D_E_L_E_T_ = ' ' WHERE SC7.D_E_L_E_T_ = ' '"

            If strEmpresa = "01" Then
                varSqlBase = varSqlBaseEmpresa01
            ElseIf strEmpresa = "02" Then
                varSqlBase = varSqlBaseEmpresa02
            End If

            varSqlBase &= strAppendWhereClause

            Dim conn As OracleConnection = Nothing
            Dim oradbConn As String = String.Empty

            Dim oradb As String = AppUtils.dbConnectionString

            conn = New OracleConnection(oradb)
            conn.Open()

            Dim cmdPedidoCompraItem As New OracleCommand(varSqlBase, conn) With {.CommandType = CommandType.Text}

            'Dim cmdPedidoCompraItem As OracleCommand

            Dim drPedidoCompraItem As OracleDataReader = Nothing
            Try
                drPedidoCompraItem = cmdPedidoCompraItem.ExecuteReader()
                If drPedidoCompraItem.HasRows Then
                    Do While drPedidoCompraItem.Read
                        Dim objPedidoCompraItem = New S5TPedidoCompraItem

                        objPedidoCompraItem.C7_FILIAL = AppUtils.Nvl(drPedidoCompraItem.Item("C7_FILIAL"), "").ToString.Trim
                        objPedidoCompraItem.C7_ITEM = AppUtils.Nvl(drPedidoCompraItem.Item("C7_ITEM"), "").ToString.Trim
                        objPedidoCompraItem.C7_PRODUTO = AppUtils.Nvl(drPedidoCompraItem.Item("C7_PRODUTO"), "").ToString.Trim
                        objPedidoCompraItem.B1_DESC = AppUtils.Nvl(drPedidoCompraItem.Item("B1_DESC"), "").ToString.Trim
                        objPedidoCompraItem.C7_UM = AppUtils.Nvl(drPedidoCompraItem.Item("C7_UM"), "").ToString.Trim
                        objPedidoCompraItem.C7_QUANT = AppUtils.Nvl(drPedidoCompraItem.Item("C7_QUANT"), 0)
                        objPedidoCompraItem.C7_PRECO = Math.Round(AppUtils.Nvl(drPedidoCompraItem.Item("C7_PRECO"), 0), 2)
                        objPedidoCompraItem.C7_TOTAL = Math.Round(AppUtils.Nvl(drPedidoCompraItem.Item("C7_TOTAL"), 0), 2)
                        objPedidoCompraItem.C7_OBS = AppUtils.Nvl(drPedidoCompraItem.Item("C7_OBS"), "").ToString.Trim

                        PedidoCompraItens.Add(objPedidoCompraItem)
                    Loop

                    drPedidoCompraItem.Close()
                End If
            Catch ex As Exception
                'Return InternalServerError(ex)
            Finally
                conn.Close()
                If (Not (drPedidoCompraItem) Is Nothing) Then
                    drPedidoCompraItem.Dispose()
                End If
            End Try

            Return PedidoCompraItens.OrderBy(Function(x) x.C7_PRODUTO).ToList
        End Function

        Private Function PedidoCompraItensWhereClause(ByVal parOptions As List(Of KeyValuePair(Of String, String))) As String
            PedidoCompraItensWhereClause = ""

            Dim varWhereClause As String = String.Empty

            Dim FilterElements = parOptions.FindAll(Function(x) x.Key.StartsWith("filter"))

            If FilterElements IsNot Nothing Then
                varWhereClause = " And"

                For Each filterElement In FilterElements
                    If {"="}.Contains(filterElement.Value) Then
                        varWhereClause &= " ="
                    ElseIf {"And", "and"}.Contains(filterElement.Value) Then
                        varWhereClause &= " And"
                    ElseIf {"EMPRESA"}.Contains(filterElement.Value) Then
                        varWhereClause &= " " & filterElement.Value
                    ElseIf {"C7_FILIAL"}.Contains(filterElement.Value) Then
                        varWhereClause &= " " & filterElement.Value
                    ElseIf {"C7_NUM"}.Contains(filterElement.Value) Then
                        varWhereClause &= " " & filterElement.Value
                    Else
                        varWhereClause &= " '" & filterElement.Value & "'"
                    End If
                Next
            End If

            PedidoCompraItensWhereClause = varWhereClause
        End Function

        Private Function PedidoCompraItensWhereClauseSemEmpresa(ByVal parWhereClause As String) As String

            Dim strWhereClauseSemEmpresa01 = parWhereClause.ToUpper.Replace(" AND EMPRESA = '01'", "")
            Dim strWhereClauseSemEmpresa01e02 = strWhereClauseSemEmpresa01.ToUpper.Replace(" AND EMPRESA = '02'", "")

            PedidoCompraItensWhereClauseSemEmpresa = strWhereClauseSemEmpresa01e02
        End Function

        Private Function PedidoCompraItensEmpresaFromWhereClause(ByVal parWhereClause As String) As String
            Dim strEmpresa = ""

            Dim strEmpresaTag = " AND EMPRESA = '"
            Dim intEmpresaPos = parWhereClause.ToUpper.IndexOf(strEmpresaTag)

            If intEmpresaPos >= 0 Then
                strEmpresa = parWhereClause.Substring(intEmpresaPos + strEmpresaTag.Length, 2)
            End If

            PedidoCompraItensEmpresaFromWhereClause = strEmpresa
        End Function

        ' GET: api/PedidoCompraItem/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/PedidoCompraItem
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/PedidoCompraItem/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/PedidoCompraItem/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace