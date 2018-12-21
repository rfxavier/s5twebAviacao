Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.Web
Imports Microsoft.AspNet.Identity
Imports Oracle.DataAccess.Client
Public Class cnVendasComparativoClientesV2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Page.IsCallback) And (Not Page.IsPostBack) Then
            'ASPxDashboardViewer1.DashboardSource = AppUtils.GetDashboardInstance(dashboardsList.dashCnVendasComparativoClientes)
            ''ASPxDashboardViewer1.DataBind()

            'ASPxDashboardViewer2.DashboardSource = AppUtils.GetDashboardInstance(dashboardsList.dashCnVendasComparativoClientesProduto)
            ''ASPxDashboardViewer2.DataBind()

            LogUserAccess(User.Identity.GetUserName, Me.Page.AppRelativeVirtualPath)

            'preenchendo o combo cliente
            Dim conn As OracleConnection = Nothing
            Dim oradbConn As String = AppUtils.dbConnectionString

            Dim oradb As String = String.Format(oradbConn)

            'carrega combo Cliente
            Try
                conn = New OracleConnection(oradb)
                conn.Open()

                Dim cmdListaClientes As New OracleCommand("SELECT A1_COD, MAX(A1_NOME) a1_nome FROM SA1010 A WHERE A.A1_GRPVEN IN ('000009','000010','000011','000145','000004','000005','000001','000023') AND A.D_E_L_E_T_ = ' ' GROUP BY A1_COD ORDER BY A1_NOME", conn) With {.CommandType = CommandType.Text}

                drListaClientes = cmdListaClientes.ExecuteReader()
                If drListaClientes.HasRows Then
                    Do While drListaClientes.Read
                        CmbCliente.Items.Add(drListaClientes.Item("a1_nome"), drListaClientes.Item("A1_COD"))
                        'ListaClientes.Add(drListaClientes.Item("DATA_FECHAMENTO"))
                    Loop

                    drListaClientes.Close()
                End If
            Finally
                If (Not (drListaClientes) Is Nothing) Then
                    drListaClientes.Dispose()
                End If
            End Try

        Else
            ASPxDashboardViewer1.DashboardSource = AppUtils.GetDashboardInstance(dashboardsList.dashCnVendasComparativoClientesV2)
            'ASPxDashboardViewer1.DataBind()

            ASPxDashboardViewer2.DashboardSource = AppUtils.GetDashboardInstance(dashboardsList.dashCnVendasComparativoClientesComProdutoV2)
            'ASPxDashboardViewer1.DataBind()

        End If
    End Sub
    Protected Sub CmbLoja_Callback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
        Dim conn As OracleConnection = Nothing
        Dim oradbConn As String = AppUtils.dbConnectionString

        Dim oradb As String = String.Format(oradbConn)

        Try
            conn = New OracleConnection(oradb)
            conn.Open()

            Dim cmdListaLoja As New OracleCommand(String.Format("SELECT A.A1_LOJA  FROM SA1010 A WHERE A1_COD = '{0}'  AND A.D_E_L_E_T_ = ' ' GROUP BY A.A1_LOJA ORDER BY A.A1_LOJA", CmbCliente.Value), conn) With {.CommandType = CommandType.Text}

            drListaLoja = cmdListaLoja.ExecuteReader()
            If drListaLoja.HasRows Then
                Do While drListaLoja.Read
                    CmbLoja.Items.Add(drListaLoja.Item("A1_LOJA"), drListaLoja.Item("A1_LOJA"))
                    'ListaLoja.Add(drListaLoja.Item("DATA_FECHAMENTO"))
                Loop

                drListaLoja.Close()
            End If
        Finally
            If (Not (drListaLoja) Is Nothing) Then
                drListaLoja.Dispose()
            End If
        End Try


    End Sub
    Protected Sub CmbMarca_Callback(ByVal source As Object, ByVal e As CallbackEventArgsBase)

        ''CARREGA COMBO MARCA
        Dim objMarcas = S5T.AviacaoVendasAnoMenos1Collection.LoadAllViewMarca
        If objMarcas IsNot Nothing Then
            For Each obj In objMarcas.GroupBy(Function(X) X.pMARCA).Select(Function(y) New With {.pMARCA = y.Key, .pCLIENTE = y.Min(Function(z) z.pCLIENTE)}).ToList.FindAll(Function(x) x.pCLIENTE = CmbCliente.Value)
                CmbMarca.Items.Add(Trim(obj.pMARCA), Trim(obj.pMARCA))
            Next
        End If


    End Sub

    Protected Sub ASPxDashboardViewer1_ConfigureDataConnection(sender As Object, e As DevExpress.DashboardWeb.ConfigureDataConnectionWebEventArgs) Handles ASPxDashboardViewer1.ConfigureDataConnection
        e.ConnectionParameters = AppUtils.dashConnectionParameters
    End Sub
    Private Sub ASPxDashboardViewer1_CustomParameters(sender As Object, e As DevExpress.DashboardWeb.CustomParametersWebEventArgs) Handles ASPxDashboardViewer1.CustomParameters
        e.Parameters(0).Value = CmbCliente.Value
        e.Parameters(1).Value = IIf(CmbLoja.Value Is Nothing, "00", CmbLoja.Value)
        e.Parameters(2).Value = IIf(CmbLoja.Value Is Nothing, "ZZ", CmbLoja.Value)
        e.Parameters(3).Value = IIf(CmbMarca.Value Is Nothing, "%", CmbMarca.Value)
    End Sub

    Private Sub ASPxDashboardViewer2_ConfigureDataConnection(sender As Object, e As DevExpress.DashboardWeb.ConfigureDataConnectionWebEventArgs) Handles ASPxDashboardViewer2.ConfigureDataConnection
        e.ConnectionParameters = AppUtils.dashConnectionParameters
    End Sub

    Private Sub ASPxDashboardViewer2_CustomParameters(sender As Object, e As DevExpress.DashboardWeb.CustomParametersWebEventArgs) Handles ASPxDashboardViewer2.CustomParameters
        e.Parameters(0).Value = CmbCliente.Value
        e.Parameters(1).Value = IIf(CmbLoja.Value Is Nothing, "00", CmbLoja.Value)
        e.Parameters(2).Value = IIf(CmbLoja.Value Is Nothing, "ZZ", CmbLoja.Value)
        e.Parameters(3).Value = IIf(CmbMarca.Value Is Nothing, "%", CmbMarca.Value)
    End Sub


    Private Sub ASPxCallbackPanel1_Callback(sender As Object, e As CallbackEventArgsBase) Handles ASPxCallbackPanel1.Callback
        ASPxLabelNomeCliente.Text = CmbCliente.Text
        If CmbLoja.Text <> "" Then
            ASPxLabelNomeCliente.Text &= " - Loja " & CmbLoja.Text
        End If
        If CmbMarca.Text <> "" Then
            ASPxLabelNomeCliente.Text &= " - Marca " & CmbMarca.Text
        End If

        ASPxDashboardViewer1.DataBind()
    End Sub

    Private Sub ASPxCallbackPanel2_Callback(sender As Object, e As CallbackEventArgsBase) Handles ASPxCallbackPanel2.Callback
        ASPxLabelNomeCliente2.Text = CmbCliente.Text
        If CmbLoja.Text <> "" Then
            ASPxLabelNomeCliente2.Text &= " - Loja " & CmbLoja.Text
        End If
        If CmbMarca.Text <> "" Then
            ASPxLabelNomeCliente2.Text &= " - Marca " & CmbMarca.Text
        End If
        ASPxDashboardViewer2.DataBind()
    End Sub

End Class