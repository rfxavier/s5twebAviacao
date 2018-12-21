Imports DevExpress.DashboardCommon

Public Class FrmExemplo
    Private Sub FrmExemplo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'DashboardViewer1.DashboardSource = AppUtils.GetDashboardInstance(dashboardsList.dashCnVendasMapaVendas)
        Dim dash As New S5TWinFormAviacao.Win_Dashboards.dashCnProducaoEstoqueMaturacao

        DashboardViewer1.Dashboard = dash
    End Sub


    Private Sub DashboardViewer1_ConfigureDataConnection(sender As Object, e As DashboardConfigureDataConnectionEventArgs) Handles DashboardViewer1.ConfigureDataConnection
        e.ConnectionParameters = AppUtils.dashConnectionParameters
    End Sub
End Class