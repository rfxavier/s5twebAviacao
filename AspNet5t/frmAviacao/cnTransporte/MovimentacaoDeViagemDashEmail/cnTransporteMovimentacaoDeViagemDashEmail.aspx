<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="cnTransporteMovimentacaoDeViagemDashEmail.aspx.vb" Inherits="AspNet5t.cnTransporteMovimentacaoDeViagemDashEmail" %>

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
            dv.SetHeight(height - 48 * 1.5);
        }
        function showPopupExport(s, e) {
            //pcProp.PerformCallback();
            //pcProp.Show();
        }
    </script>
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContentPlaceHolderMain" runat="server">
    <div>
     <dx:ASPxCallbackPanel ID="ASPxCallbackPanel1" runat="server" Width="100%" ClientInstanceName="cbPanel">
            <PanelCollection>
                <dx:PanelContent runat="server">
                   
                    <dx:ASPxDashboardViewer ID="ASPxDashboardViewer1" runat="server" DashboardSource="AspNet5t.Win_Dashboards.dashCnTransporteMovimentacaoDeViagemDashEmail" Width="98%" Height="370px" UseDataAccessApi="True" ClientInstanceName="dv" AllowExportDashboardItems="True">
                        <ClientSideEvents Init="OnInit" />
                    </dx:ASPxDashboardViewer>
        </dx:PanelContent>
            </PanelCollection>
        </dx:ASPxCallbackPanel>

    </div>

    <dx:ASPxTimer ID="ASPxTimer1" runat="server"  Interval="60000">
        <ClientSideEvents Tick="function(s, e) { dv.ReloadData(); }" />
    </dx:ASPxTimer>

</asp:Content>
