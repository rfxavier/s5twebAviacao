Public Class RelLeiteCamFriasOverview
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not IsPostBack) And (Not IsCallback) 
            dataReferencia.Date = Now.AddDays(-1)
        End If

        dim report = new repCnIndLeiteCamarasFriasOverview

        report.Parameters(0).Value = CDate(dataReferencia.Value).ToString("yyyyMMdd") & "_AUTOGEN"

        ASPxWebDocumentViewer.OpenReport(report)
    End Sub

End Class