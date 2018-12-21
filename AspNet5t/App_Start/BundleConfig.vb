Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Optimization

Public Class BundleConfig
    ' For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkID=303951
    Public Shared Sub RegisterBundles(ByVal bundles As BundleCollection)
        bundles.Add(New ScriptBundle("~/bundles/WebFormsJs").Include(
                        "~/Scripts/WebForms/WebForms.js",
                        "~/Scripts/WebForms/WebUIValidation.js",
                        "~/Scripts/WebForms/MenuStandards.js",
                        "~/Scripts/WebForms/Focus.js",
                        "~/Scripts/WebForms/GridView.js",
                        "~/Scripts/WebForms/DetailsView.js",
                        "~/Scripts/WebForms/TreeView.js",
                        "~/Scripts/WebForms/WebParts.js"))

        ' Order is very important for these files to work, they have explicit dependencies
        bundles.Add(New ScriptBundle("~/bundles/MsAjaxJs").Include(
                "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
                "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
                "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
                "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"))

        ' Use the Development version of Modernizr to develop with and learn from. Then, when you’re
        ' ready for production, use the build tool at http://modernizr.com to pick only the tests you need
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"))

        'CENÁRIO GERENCIAL Css
        bundles.Add(New StyleBundle("~/Content/dxcss4Tcengerencial").Include(
                        "~/Content/dx.common.css",
                        "~/Content/dx.light.compact.css"))

        bundles.Add(New StyleBundle("~/Content/csspagehistprop").Include(
                        "~/frmUsina/cnGerencial/HistoricoPropriedadeJS/css/pagehistprop.css"))

        bundles.Add(New StyleBundle("~/Content/csspagectrlbroca").Include(
                        "~/frmUsina/cnGerencial/ControleBrocaJS/css/pagectrlbroca.css"))

        'CENÁRIO GERENCIAL Javascript
        bundles.Add(New ScriptBundle("~/bundles/dx4Tcengerencial").Include(
                        "~/Scripts/dx.webappjs.js",
                        "~/Scripts/dx.chartjs.js",
                        "~/Scripts/devextreme-nonNuget/js/vectormap-utils/dx.vectormaputils.js"))

        bundles.Add(New ScriptBundle("~/bundles/app4Thistprop").Include(
                        "~/frmUsina/cnGerencial/HistoricoPropriedadeJS/js/app.module.js",
                        "~/angularAppServices/ApiGetService.js",
                        "~/frmUsina/cnGerencial/HistoricoPropriedadeJS/js/app.histpropController.js"))

        bundles.Add(New ScriptBundle("~/bundles/app4Tctrlpragas").Include(
                        "~/frmUsina/cnGerencial/ControleBrocaJS/js/app.module.js",
                        "~/angularAppServices/ApiGetService.js",
                        "~/angularAppServices/ApiGetServiceMOCK.js",
                        "~/frmUsina/cnGerencial/ControleBrocaJS/js/app.brocaController.js"))

        'CENÁRIO COLHEITA DE CANA Css
        bundles.Add(New StyleBundle("~/Content/dxcss4Tcencolheitacana").Include(
                        "~/Content/dx.common.css",
                        "~/Content/dx.light.css"))

        bundles.Add(New StyleBundle("~/Content/csspagectrlestfrente").Include(
                        "~/frmUsina/cnEntCana/ControleEstoqueFrenteJS/css/pagectrlestfrente.css"))

        'CENÁRIO COLHEITA DE CANA Javascript
        bundles.Add(New ScriptBundle("~/bundles/dx4Tcencolheitacana").Include(
                        "~/Scripts/dx.webappjs.js",
                        "~/Scripts/dx.chartjs.js",
                        "~/Scripts/devextreme-nonNuget/js/vectormap-utils/dx.vectormaputils.js"))

        bundles.Add(New ScriptBundle("~/bundles/app4Tctrlestcolheita").Include(
                        "~/frmUsina/cnEntCana/ControleEstoqueFrenteJS/js/app.module.js",
                        "~/angularAppServices/ApiGetService.js",
                        "~/angularAppServices/ApiPostService.js",
                        "~/frmUsina/cnEntCana/ControleEstoqueFrenteJS/js/app.ctrlestController.js"))

        ScriptManager.ScriptResourceMapping.AddDefinition("respond", New ScriptResourceDefinition() With {
                .Path = "~/Scripts/respond.min.js",
                .DebugPath = "~/Scripts/respond.js"})

    End Sub
End Class
