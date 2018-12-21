<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="cnVendasIndicadoresParaVendedor.aspx.vb" Inherits="AspNet5t.cnVendasIndicadoresParaVendedor" %>

<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Dashboard.v17.2.Web, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContentPlaceHolderMain" runat="server">
    <script>
        function OnInit(s, e) {
            AdjustSize();
            ASPxClientUtils.AttachEventToElement(window, "resize", function (evt) {
                AdjustSize();
            });
        }
        function AdjustSize() {
            var height = document.documentElement.clientHeight;
            dv.SetHeight(height + 140 * 1.5);
        }
        function OnInit2(s, e) {
            AdjustSize2();
            ASPxClientUtils.AttachEventToElement(window, "resize", function (evt) {
                AdjustSize2();
            });
        }
        function AdjustSize2() {
            dv2.SetHeight(550);
        }
    </script>
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContentPlaceHolderMain" runat="server">
    <div>
        <dx:ASPxDashboardViewer ID="ASPxDashboardViewer1" runat="server" DashboardSource="AspNet5t.Win_Dashboards.dashCnProducaoProducaoIndicadoresParaVendedor3Meses" Width="98%" Height="370px" UseDataAccessApi="True" ClientInstanceName="dv">
            <ClientSideEvents Init="OnInit" />
        </dx:ASPxDashboardViewer>
        <dx:ASPxDashboardViewer ID="ASPxDashboardViewer2" runat="server" DashboardSource="AspNet5t.Win_Dashboards.dashCnFinanceiroTitulosAbertoVendedor" Width="98%" Height="370px" UseDataAccessApi="True" ClientInstanceName="dv2">
            <ClientSideEvents Init="OnInit2" />
        </dx:ASPxDashboardViewer>
    </div>
</asp:Content>
