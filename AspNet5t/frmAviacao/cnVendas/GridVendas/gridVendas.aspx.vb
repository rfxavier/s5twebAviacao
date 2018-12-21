Imports DevExpress.Utils
Imports DevExpress.Web.ASPxPivotGrid
Imports DevExpress.XtraPrinting
Imports DevExpress.Export
Imports Microsoft.AspNet.Identity

Public Class gridVendas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LogUserAccess(User.Identity.GetUserName, Me.Page.AppRelativeVirtualPath)

        ASPxGridView1.DataBind()

    End Sub

    Private Sub ASPxPivotGrid1_DataBinding(sender As Object, e As EventArgs) Handles ASPxGridView1.DataBinding
        ASPxGridView1.DataSource = LinqServerModeDataSource1

    End Sub

    Protected Sub buttonSaveAs_Click(sender As Object, e As EventArgs) Handles buttonSaveAs.Click
        Export(True)
    End Sub

    Private Sub Export(ByVal saveAs As Boolean)
        gridExport.WriteXlsxToResponse("gridVendas", New XlsxExportOptionsEx With {.ExportType = ExportType.WYSIWYG})
    End Sub

End Class