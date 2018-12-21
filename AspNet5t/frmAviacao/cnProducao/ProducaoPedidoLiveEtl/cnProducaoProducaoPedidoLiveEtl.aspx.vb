Imports DevExpress.DataAccess.ConnectionParameters
Imports Microsoft.AspNet.Identity

Public Class cnProducaoProducaoPedidoLiveEtl
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Page.IsCallback) And (Not Page.IsPostBack) Then
            ASPxDashboardViewer1.DashboardSource = AppUtils.GetDashboardInstance(dashboardsList.dashCnProducaoProducaoPedidoObjDs)
            ASPxDashboardViewer1.DataBind()

            LogUserAccess(User.Identity.GetUserName, Me.Page.AppRelativeVirtualPath)
        End If
    End Sub

    Private Sub ASPxDashboardViewer1_DataLoading(sender As Object, e As DevExpress.DashboardWeb.DataLoadingWebEventArgs) Handles ASPxDashboardViewer1.DataLoading
        If e.DataSourceName = "Object Data Source 1" Then
            e.Data = dsProducaoPedido.GetProducaoPedido(True)
        End If
    End Sub

End Class