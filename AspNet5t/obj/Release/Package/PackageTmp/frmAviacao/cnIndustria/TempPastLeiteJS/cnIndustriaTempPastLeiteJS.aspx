<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="cnIndustriaTempPastLeiteJS.aspx.vb" Inherits="AspNet5t.cnIndustriaTempPastLeiteJS" %>
<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContentPlaceHolderMain" runat="server">
    <link rel="stylesheet" href="<%= Page.ResolveUrl("~/Content/dx.common.css")%>" />
    <link rel="stylesheet" href="<%= Page.ResolveUrl("~/Content/dx.light.compact.css")%>" />
    <link rel="stylesheet" href="<%= Page.ResolveUrl("css/pageTempPastLeite.css")%>" />

    <script src="<%= Page.ResolveUrl("~/Scripts/jquery-2.2.3.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/Scripts/knockout-3.4.2.js")%>"></script>

    <script src="<%= Page.ResolveUrl("~/Scripts/cldr.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/Scripts/cldr/event.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/Scripts/cldr/supplemental.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/Scripts/globalize.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/Scripts/globalize/number.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/Scripts/globalize/date.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/Scripts/globalize/message.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/Scripts/globalize/currency.js")%>"></script>

    <script src="<%= Page.ResolveUrl("~/Scripts/dx.all.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/Scripts/vectormap-utils/dx.vectormaputils.js")%>"></script>

    <script type="text/javascript">
        window.App4t = $.extend(true, window.App4t, {
            version: '1.0'
        });
    </script>

    <script src="<%= Page.ResolveUrl("~/Scripts/utils4t/app4t.zabbixapi.client.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/Scripts/utils4t/appUtils4t.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/Scripts/utils4t/zabbixConfig.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/Scripts/utils4t/db.js")%>"></script>


</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContentPlaceHolderMain" runat="server">
    <div id="app4t">
        <div class="row">
            <div class="col-xs-8">
                <div style="height: 550px;" data-bind="dxChart: chartOptions"></div>
            </div>
            <div class="col-xs-4 text-center">
                <div class="row">
                    <div class="col-xs-12 text-center">
                        <h4 style="float: left;">HORAS PARA HISTÓRICO:&nbsp;</h4>
                        <div class="dx-field-value" style="float: left; font-size: medium;" data-bind="dxNumberBox: numberboxOptions"></div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-12">
                        <div data-bind="dxCircularGauge: gaugeOptions"></div>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <script src="<%= Page.ResolveUrl("~/frmAviacao/cnIndustria/TempPastLeiteJS/js/tempPastLeite.js")%>"></script>
</asp:Content>
