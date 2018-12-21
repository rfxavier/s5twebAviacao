Imports System.Data
Imports System.Net
Imports CodeFluent.Runtime
Imports DevExpress.XtraGrid
Imports DevExpress.Utils.Menu
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Public Class FormDashExemplo

    Private Sub Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sair.Click
        If MsgBox("Deseja sair da tela " & Me.Text & " ?", vbYesNo, "Mensagem do Sistema") = vbYes Then
            Me.Close()
            'MDIPrincipal.Text = S5TEmpresa.pNome + " - " + Modulo.nomeDoSistema
        End If
    End Sub

    Private Sub FormDashExemplo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        DashboardViewer1.DashboardSource = AppUtils.GetDashboardInstance(dashboardsList.dashCnVendasMapaVendas)

    End Sub



    Private Sub DashboardViewer1_ConfigureDataConnection(sender As Object, e As ConfigureDataConnectionEventArgs) Handles DashboardViewer1.ConfigureDataConnection
        e.ConnectionParameters = AppUtils.dashConnectionParameters
    End Sub

End Class