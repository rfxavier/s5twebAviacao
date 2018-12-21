<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="cnVendasComparativoClientes.aspx.vb" Inherits="AspNet5t.cnVendasComparativoClientes" %>

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
            dv.SetHeight(height - 80 * 1.5 - 100);
        }
        function OnInit2(s, e) {
            AdjustSize2();
            ASPxClientUtils.AttachEventToElement(window, "resize", function (evt) {
                AdjustSize2();
            });
        }
        function AdjustSize2() {
            dv2.SetHeight(250);
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
            pc.SetActiveTabIndex(1);
        }
        function OnMasterFilterSet(s, e) {
            var strProduto = e.Values[0][0];
            var strProdutoTrat;

            init = strProduto.indexOf('{');
            fin = strProduto.indexOf('}');
            strProdutoTrat = strProduto.substr(init + 1, fin - init - 1);
              
            //alert(hf.Get('produtoCod'));
            //alert(strProdutoTrat);

            
           if (strProdutoTrat != '' || hf.Get('produtoCod') != '') {
            //if (!strProdutoTrat || !hf.Get('produtoCod')) {
               
                var strRegiao = e.Values[0][0];
                var strRegiaoTrat;

                init2 = strRegiao.indexOf('[');
                fin2 = strRegiao.indexOf(']');
                strRegiaoTrat = strRegiao.substr(init2 + 1, fin2 - init2 - 1);
                
                var parameters = dv2.GetParameters();
                var parameter0 = parameters.GetParameterByIndex(0);                
                var parameter1 = parameters.GetParameterByIndex(1);
                var parameter2 = parameters.GetParameterByIndex(2);
                var parameter3 = parameters.GetParameterByIndex(3);
                //parametros de Marca 
                var parameter4 = parameters.GetParameterByIndex(4);
                //parametros de Regiao 
                var parameter5 = parameters.GetParameterByIndex(5);
               
                dv2.BeginUpdateParameters();
                parameter0.SetValue(CmbCliente.GetValue().toString());
                
               //teste pra saber se a loja foi escolhida
                if ((CmbLoja.GetValue()) != '') {
                    if ((CmbLoja.GetValue()) != undefined) {
                        parameter1.SetValue(CmbLoja.GetValue().toString());
                        parameter2.SetValue(CmbLoja.GetValue().toString());
                    } else {
                        parameter1.SetValue('00');
                        parameter2.SetValue('ZZ');
                    }
                }
                else {
                    parameter1.SetValue('00');
                    parameter2.SetValue('ZZ');
                }
                
                if (hf.Get('produtoCod') != undefined) {
                    parameter3.SetValue(hf.Get('produtoCod'));
                } else {
                    
                    parameter3.SetValue(strProdutoTrat);
                }
                          
                //hf.Clear();
                hf.Set("produtoCod", strProdutoTrat);
                
                //teste pra saber se a marca foi escolhida
                if ((CmbMarca.GetValue()) != undefined) {
                    parameter4.SetValue(CmbMarca.GetValue().toString());
                }
                else {                    
                    parameter4.SetValue('%');
                }

                //teste pra saber se a regiao foi escolhida
                if (strRegiaoTrat != '') {
                   
                    parameter5.SetValue(strRegiaoTrat);
                 
                } else {
                    
                    parameter5.SetValue('%');
                }
                             

                dv2.EndUpdateParameters();
            }                      
            
            
        }


    </script>
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContentPlaceHolderMain" runat="server">
    <center>
    <dx:ASPxPageControl ID="pc" runat="server" ActiveTabIndex="0" Height="300px" ClientInstanceName="pc"
        Width="95%">        
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
            <dx:TabPage Text="Dashboard">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxCallbackPanel ID="ASPxCallbackPanel1" Width="100%" runat="server" ClientInstanceName="cbPanel" >
                            <PanelCollection>
                                <dx:PanelContent runat="server" >
                                    <dx:ASPxLabel ID="ASPxLabelNomeCliente" runat="server" Text="" Theme="Moderno"></dx:ASPxLabel>
                                    <dx:ASPxDashboardViewer ID="ASPxDashboardViewer1" runat="server"  Width="98%" Height="370px" UseDataAccessApi="True" ClientInstanceName="dv">
                                        <%--<ClientSideEvents Init="OnInit" MasterFilterSet="OnMasterFilterSet" />--%>
                                        <ClientSideEvents Init="OnInit" />
                                    </dx:ASPxDashboardViewer>
                                    <dx:ASPxDashboardViewer ID="ASPxDashboardViewer2" runat="server"  Width="98%" Height="250px" UseDataAccessApi="True" ClientInstanceName="dv2" Visible="False">
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

