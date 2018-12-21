Public Class RelEnvaseOverview
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not IsPostBack) And (Not IsCallback) 
            dataReferencia.Date = Now.AddDays(-1)
        End If

        dim report = new repCnIndEnvaseOverview

        report.Parameters(0).Value = CDate(dataReferencia.Value).ToString("yyyyMMdd") & "_AUTOGEN"

        ASPxWebDocumentViewer.OpenReport(report)

        'ASPxWebDocumentViewer.ReportTypeName = AppUtils.GetReportTypeName(reportsList.repCnIndEnvaseOverview)
        'ASPxWebDocumentViewer.Report = AppUtils.GetReportInstance(reportsList.repCnIndEnvaseOverview)

        'ASPxWebDocumentViewer.Report.Parameters(0).Value = CDate(dataReferencia.Value).ToString("yyyyMMdd") & "_AUTOGEN"

        'ASPxWebDocumentViewer.Report.CreateDocument()

    End Sub

End Class