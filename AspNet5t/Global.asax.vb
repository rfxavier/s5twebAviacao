Imports System.Web.Optimization
Imports System.Web.Http
Imports DevExpress.XtraReports.Web.WebDocumentViewer
Imports AspNet5t.ReportingBackend.Services
Imports System.Web.Mvc

Public Class Global_asax
    Inherits HttpApplication

    Sub Application_Start(sender As Object, e As EventArgs)
        ' Fires when the application is started
        AreaRegistration.RegisterAllAreas()
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
        DefaultWebDocumentViewerContainer.Register(Of IWebDocumentViewerReportResolver, CustomReportResolver)()
    End Sub
End Class