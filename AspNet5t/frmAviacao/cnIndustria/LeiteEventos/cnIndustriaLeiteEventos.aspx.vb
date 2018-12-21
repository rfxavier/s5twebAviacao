﻿Imports DevExpress.DashboardWeb
Imports Microsoft.AspNet.Identity

Public Class cnIndustriaLeiteEventos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Page.IsCallback) And (Not Page.IsPostBack) Then
            ASPxDashboardViewer1.DashboardSource = AppUtils.GetDashboardInstance(dashboardsList.dashCnIndustriaLeiteEventos)
            ASPxDashboardViewer1.DataBind()

            LogUserAccess(User.Identity.GetUserName, Me.Page.AppRelativeVirtualPath)
        End If
    End Sub

    Private Sub ASPxDashboardViewer1_ConfigureDataConnection(sender As Object, e As ConfigureDataConnectionWebEventArgs) Handles ASPxDashboardViewer1.ConfigureDataConnection
        e.ConnectionParameters = AppUtils.dashConnectionParameters
    End Sub
End Class