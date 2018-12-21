Imports DevExpress.DataAccess.ConnectionParameters
Imports Microsoft.AspNet.Identity

Public Class cnVendasIndicadoresParaVendedorDual
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Page.IsCallback) And (Not Page.IsPostBack) Then
            ASPxDashboardViewer1.DashboardSource = AppUtils.GetDashboardInstance(dashboardsList.dashCnProducaoProducaoIndicadoresParaVendedor3Meses)
            ASPxDashboardViewer1.DataBind()

            ASPxDashboardViewer2.DashboardSource = AppUtils.GetDashboardInstance(dashboardsList.dashCnFinanceiroTitulosAbertoVendedor)
            ASPxDashboardViewer2.DataBind()


            LogUserAccess(User.Identity.GetUserName, Me.Page.AppRelativeVirtualPath)
        End If
    End Sub

    Protected Sub ASPxDashboardViewer1_ConfigureDataConnection(sender As Object, e As DevExpress.DashboardWeb.ConfigureDataConnectionWebEventArgs) Handles ASPxDashboardViewer1.ConfigureDataConnection
        e.ConnectionParameters = AppUtils.dashConnectionParameters
    End Sub

    Private Sub ASPxDashboardViewer2_ConfigureDataConnection(sender As Object, e As DevExpress.DashboardWeb.ConfigureDataConnectionWebEventArgs) Handles ASPxDashboardViewer2.ConfigureDataConnection
        e.ConnectionParameters = AppUtils.dashConnectionParametersOracle
    End Sub

    Private Sub ASPxDashboardViewer1_CustomParameters(sender As Object, e As DevExpress.DashboardWeb.CustomParametersWebEventArgs) Handles ASPxDashboardViewer1.CustomParameters
        Dim objUsuario = S5T.Usuario.LoadBypLogin(User.Identity.GetUserName)

        If objUsuario IsNot Nothing Then
            If objUsuario.pCodigoVendedor = "" Then
                e.Parameters(0).Value = "0"
                e.Parameters(1).Value = "999999"
            Else
                e.Parameters(0).Value = objUsuario.pCodigoVendedor
                e.Parameters(1).Value = objUsuario.pCodigoVendedor

            End If
        Else
            e.Parameters(0).Value = "0"
            e.Parameters(1).Value = "999999"
        End If
    End Sub

    Private Sub ASPxDashboardViewer2_CustomParameters(sender As Object, e As DevExpress.DashboardWeb.CustomParametersWebEventArgs) Handles ASPxDashboardViewer2.CustomParameters
        Dim objUsuario = S5T.Usuario.LoadBypLogin(User.Identity.GetUserName)

        If objUsuario IsNot Nothing Then
            If objUsuario.pCodigoVendedor <> "" Then
                e.Parameters(0).Value = objUsuario.pCodigoVendedor
                e.Parameters(1).Value = objUsuario.pCodigoVendedor
            End If
            'Else
            '    e.Parameters(0).Value = "000"
            '    e.Parameters(1).Value = "999"
        End If
    End Sub
End Class