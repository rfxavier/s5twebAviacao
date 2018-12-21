Imports System.Web.Mvc
Imports AspNet5t.ReportingBackend.Services
Imports DevExpress.Web.Mvc.Controllers

Namespace reportClasses.Controllers
    '<RoutePrefix("WebDocumentViewer")>
    Public Class WebDocumentViewerController
        Inherits WebDocumentViewerApiController

#Region "WebDocumentViewer Overrides"
        ' This action processes each request from the Web Document Viewer.
        '<Route("Invoke")>
        Public Overrides Function Invoke() As ActionResult
            Response.AddHeader("Access-Control-Allow-Origin", "*") ' Allow cross-domain requests.
            Return MyBase.Invoke()
        End Function
#End Region

        ' Create an action to provide the Web Document Viewer with available reports.
        Public Function GetReportList() As ActionResult
            Dim reports = (New CustomReportResolver()).GetAvailableReports().ToArray()
            Response.AddHeader("Access-Control-Allow-Origin", "*") ' Allow cross-domain requests.
            Return New JsonResult() With {.ContentType = "application/json", .Data = reports}
        End Function
    End Class
End Namespace