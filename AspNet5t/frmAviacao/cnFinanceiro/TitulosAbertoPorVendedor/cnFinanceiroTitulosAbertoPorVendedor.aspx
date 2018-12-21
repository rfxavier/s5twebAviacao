<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="cnFinanceiroTitulosAbertoPorVendedor.aspx.vb" Inherits="AspNet5t.cnFinanceiroTitulosAbertoPorVendedor" %>

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
        function btnPesquisar_Click(s, e) {
            console.log(btnCliente.GetText());
            if (dv.CanSetMasterFilter('comboBoxDashboardItem2')) {
                dv.SetMasterFilter('comboBoxDashboardItem2', [[btnCliente.GetText()]]);
                //dv.SetMasterFilter('gridDashboardItem2', [['A DAHER E CIA LTDA  ']]);
            }
        }
        function btnLimpar_Click(s, e) {
            //dv.ClearMasterFilter('comboBoxDashboardItem2');
            var allSelection2 = dv.GetAvailableFilterValues("comboBoxDashboardItem2");
            dv.SetMasterFilter("comboBoxDashboardItem2", allSelection2);
            btnCliente.SetSelectedIndex(-1);
        }
        function OnMasterFilterSet(s, e) {
            console.log(e.ItemName);
            console.log(e.Values[0][0] + '*');
        }
        function OnMasterFilterCleared(s, e) {
            console.log(e.ItemName);
            if (e.ItemName == 'gridDashboardItem2') {
                btnCliente.SetSelectedIndex(-1);
            };
        }

    </script>
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContentPlaceHolderMain" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Cliente:" Theme="Moderno"></dx:ASPxLabel>
                </td>
                <td>
                    <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" EnableCallbackMode="true" CallbackPageSize="10" ValueField="pNOME"
                        OnItemsRequestedByFilterCondition="ASPxComboBox_OnItemsRequestedByFilterCondition_SQL"
                        OnItemRequestedByValue="ASPxComboBox_OnItemRequestedByValue_SQL" TextFormatString="{0} ({1})"
                        Width="900px" DropDownStyle="DropDown" Theme="Moderno" ClientInstanceName="btnCliente">
                        <Columns>
                            <dx:ListBoxColumn FieldName="pNOME" Caption="Nome" Width="100%" />
                            <dx:ListBoxColumn FieldName="pCODIGO" Caption="C&#243;digo" Width="90px" />
                        </Columns>
                    </dx:ASPxComboBox>
                </td>
                <td>
                    <dx:ASPxButton ID="ASPxButtonPesquisar" runat="server" Text="Filtrar" Theme="Moderno" AutoPostBack="False">
                        <ClientSideEvents Click="btnPesquisar_Click" />
                    </dx:ASPxButton>
                </td>
                <td>
                    <dx:ASPxButton ID="ASPxButtonLimpar" runat="server" Text="Todos" Theme="Moderno" AutoPostBack="False">
                        <ClientSideEvents Click="btnLimpar_Click" />
                    </dx:ASPxButton>

                </td>
            </tr>
        </table>
        <dx:ASPxDashboardViewer ID="ASPxDashboardViewer1" runat="server" DashboardSource="AspNet5t.Win_Dashboards.dashCnFinanceiroTitulosAbertoVendedorSeparado" Width="98%" Height="370px" UseDataAccessApi="True" ClientInstanceName="dv">
            <ClientSideEvents Init="OnInit" MasterFilterSet="OnMasterFilterSet" MasterFilterCleared="OnMasterFilterCleared"/>
        </dx:ASPxDashboardViewer>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:s5taviacaoConnectionString %>' />
</asp:Content>
