<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="cnVendasComparativoClientesV2.aspx.vb" Inherits="AspNet5t.cnVendasComparativoClientesV2" %>

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
            dv.SetHeight(height - 80 * 1.5);
        }
        function OnInit2(s, e) {
            AdjustSize2();
            ASPxClientUtils.AttachEventToElement(window, "resize", function (evt) {
                AdjustSize2();
            });
        }
        function AdjustSize2() {
            var height = document.documentElement.clientHeight;
            dv2.SetHeight(height - 60 * 1.5);
        }
        function OnInitTabPanel(s, e) {
            AdjustSizePanel();

            ASPxClientUtils.AttachEventToElement(window, "resize", function (evt) {
                AdjustSizePanel();
            });
        }
        function AdjustSizePanel() {
            var height = document.documentElement.clientHeight;
            pc.SetHeight(height);
        }
        var lastCliente = null;
        function OnClienteChanged(cmbCliente) {
            if (CmbLoja.InCallback())
                lastCliente = cmbCliente.GetValue().toString();
            else
                CmbLoja.PerformCallback(cmbCliente.GetValue().toString());
                CmbMarca.PerformCallback(cmbCliente.GetValue().toString());
        }
        function OnEndCallback(s, e) {
            if (lastCliente) {
                CmbLoja.PerformCallback(lastCliente);
                lastCliente = null;
            }
        }
        function OnEndCallbackMarca(s, e) {
            if (lastCliente) {
                CmbMarca.PerformCallback(lastCliente);
                lastCliente = null;
            }
        }
        function onClickFiltro(s, e) {
            cbPanel.PerformCallback();
            cbPanel2.PerformCallback();
            pc.SetActiveTabIndex(1);
        }
    </script>
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContentPlaceHolderMain" runat="server">
    <center>
    <dx:ASPxPageControl ID="pc" runat="server" ActiveTabIndex="0" Height="300px" ClientInstanceName="pc" Width="95%">        
        <Paddings Padding="0px" />
       
        <TabPages>
             
            <dx:TabPage Text="Dados de Filtro">
              
                <ContentCollection>
                    <dx:ContentControl runat="server" >
                        <dx:ASPxComboBox runat="server" ValueType="System.String" ID="CmbCliente" ClientInstanceName="CmbCliente" Width="450px" Theme="Moderno" Caption="Cliente:">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { OnClienteChanged(s); }" />
                        </dx:ASPxComboBox>
                        <br />
                                                
                        <dx:ASPxComboBox runat="server" ID="CmbMarca" ClientInstanceName="CmbMarca" OnCallback="CmbMarca_Callback" DropDownStyle="DropDown" TextField=""
                            ValueField="" IncrementalFilteringMode="StartsWith" EnableSynchronization="False" Caption="Marca:" Width="350px" Theme="Moderno" >
                            <ClientSideEvents EndCallback=" OnEndCallbackMarca" />
                        </dx:ASPxComboBox>
                        <br />

                        <dx:ASPxComboBox runat="server" ID="CmbLoja" ClientInstanceName="CmbLoja" OnCallback="CmbLoja_Callback" DropDownStyle="DropDown" TextField=""
                            ValueField="" IncrementalFilteringMode="StartsWith" EnableSynchronization="False" Caption="Loja:" Width="150px" Theme="Moderno" >
                            <ClientSideEvents EndCallback=" OnEndCallback" />
                        </dx:ASPxComboBox>

                        <dx:ASPxHiddenField ID="ASPxHiddenField1" runat="server" ClientInstanceName="hf"></dx:ASPxHiddenField>
                        <br />
                        <dx:ASPxButton ID="ASPxButtonFiltrar" runat="server"  AutoPostBack="false"
                               Text="Filtrar"  ClientVisible ="true" Theme="Moderno">
                            <ClientSideEvents Click="onClickFiltro" />
                        </dx:ASPxButton>
                    </dx:ContentControl>
                </ContentCollection>
                     
            </dx:TabPage>
            <dx:TabPage Text="Geral">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxCallbackPanel ID="ASPxCallbackPanel1" Width="100%" runat="server" ClientInstanceName="cbPanel" >
                            <PanelCollection>
                                <dx:PanelContent runat="server" >
                                    <dx:ASPxLabel ID="ASPxLabelNomeCliente" runat="server" Text="" Theme="Moderno"></dx:ASPxLabel>
                                    <dx:ASPxDashboardViewer ID="ASPxDashboardViewer1" runat="server"  Width="98%" Height="370px" UseDataAccessApi="True" ClientInstanceName="dv">
                                        <ClientSideEvents Init="OnInit" />
                                    </dx:ASPxDashboardViewer>
                             </dx:PanelContent>
                            </PanelCollection>
                        </dx:ASPxCallbackPanel>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
         
            <dx:TabPage Text="Por Grupo Produto">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                            <dx:ASPxCallbackPanel ID="ASPxCallbackPanel2" Width="100%" runat="server" ClientInstanceName="cbPanel2" >
                                <PanelCollection>
                                    <dx:PanelContent runat="server" >
                                        <dx:ASPxLabel ID="ASPxLabelNomeCliente2" runat="server" Text="" Theme="Moderno"></dx:ASPxLabel>
                                        <dx:ASPxDashboardViewer ID="ASPxDashboardViewer2" runat="server" Width="98%" Height="370px" UseDataAccessApi="True" ClientInstanceName="dv2">
                                            <ClientSideEvents Init="OnInit2" />
                                        </dx:ASPxDashboardViewer>
                                 </dx:PanelContent>
                                </PanelCollection>
                            </dx:ASPxCallbackPanel>

                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
        </TabPages>
        <ClientSideEvents Init="OnInitTabPanel" />
    </dx:ASPxPageControl>
    </center>
</asp:Content>

