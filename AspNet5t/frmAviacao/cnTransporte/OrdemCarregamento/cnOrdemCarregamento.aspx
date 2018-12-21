<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="cnOrdemCarregamento.aspx.vb" Inherits="AspNet5t.cnOrdemCarregamento" EnableEventValidation="false"%>

<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Data.Linq" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.XtraReports.v17.2.Web, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Dashboard.v17.2.Web, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ContentPlaceHolderID="HeadContentPlaceHolderMain" runat="server">
    <style type="text/css">
        .container {
            width: 400px;
        }
        .parentContainer {
            width: 100%;
        }
        .tabbedGroupPageControlCell {
            padding-left: 0px;
            padding-right: 0px;
            padding-bottom: 0px!important;
        }
        .tabbedGroupPageControlCell .dxflPCSys {
            padding-bottom: 0px;
        }
        .radioButtonList .dxe {
            padding:0px!important; 
        }

         /*hide the ASPxComboBox column's headers:*/
          .dxeHLC, .dxeHC, .dxeHFC
        {
            display: none;
        }

          .AlinhadoDireita {
              text-align: right;
          }
          .dxbButton
          {
              background-image: none!important;
          }

          .dxflGroupBox
          {
              padding: 0px 0px 0px;
              margin: 0px 0px;
          }

          .dxtcLite > .dxtc-content
          {
              padding: 0px;
          }

          .dxeRadioButtonList td.dxe, .dxeCheckBoxList td.dxe
          {
              padding: 0px 0px 1px 5px;
          }
          .tabbedGroupPageControlCell 
          {
              vertical-align: top;
          }
          .dxflGroupBox > .dxflGroup tr:first-child > .dxflGroupCell > .dxflItem 
          {
              padding-top: 0px;
          }
    </style>
     <script type="text/javascript">
        var textSeparator = "/";
        function OnListBoxSelectionChanged(listBox, args) {
            //if(args.index == 0)
            //    args.isSelected ? listBox.SelectAll() : listBox.UnselectAll();
            //UpdateSelectAllItemState();
            UpdateText();
        }
        function UpdateSelectAllItemState() {
            //IsAllSelected() ? checkListBox.SelectIndices([0]) : checkListBox.UnselectIndices([0]);
        }
        function IsAllSelected() {
            //var selectedDataItemCount = checkListBox.GetItemCount() - (checkListBox.GetItem(0).selected ? 0 : 1);
            //return checkListBox.GetSelectedItems().length == selectedDataItemCount;
        }
        function UpdateText() {
            var selectedItems = checkListBox.GetSelectedItems();
            checkComboBox.SetText(GetSelectedItemsText(selectedItems));
            checkComboBox.SetValue(GetSelectedItemsText(selectedItems)); //
        }
        function SynchronizeListBoxValues(dropDown, args) {
            checkListBox.UnselectAll();
            var texts = dropDown.GetText().split(textSeparator);
            var values = GetValuesByTexts(texts);
            checkListBox.SelectValues(values);
            UpdateSelectAllItemState();
            UpdateText(); // for remove non-existing texts
        }
        function GetSelectedItemsText(items) {
            var texts = [];
            for(var i = 0; i < items.length; i++)
                //if(items[i].index != 0)
                    texts.push(items[i].text);
                    //texts.push(items[i].value);
            return texts.join(textSeparator);

        }
        function GetValuesByTexts(texts) {
            var actualValues = [];
            var item;
            for(var i = 0; i < texts.length; i++) {
                item = checkListBox.FindItemByText(texts[i]);
                if(item != null)
                    actualValues.push(item.value);
            }
            return actualValues;
        }

        function OnListBoxRetSelectionChanged(listBox, args) {
            UpdateTextRet();
        }

        function UpdateSelectAllItemStateRet() {
            //IsAllSelected() ? checkListBox.SelectIndices([0]) : checkListBox.UnselectIndices([0]);
        }
        function IsAllSelectedRet() {
            //var selectedDataItemCount = checkListBox.GetItemCount() - (checkListBox.GetItem(0).selected ? 0 : 1);
            //return checkListBox.GetSelectedItems().length == selectedDataItemCount;
        }
        function UpdateTextRet() {
            var selectedItems = checkListBoxRet.GetSelectedItems();
            checkComboBoxRet.SetText(GetSelectedItemsTextRet(selectedItems));
            checkComboBoxRet.SetValue(GetSelectedItemsTextRet(selectedItems)); //
        }
        function SynchronizeListBoxValuesRet(dropDown, args) {
            checkListBoxRet.UnselectAll();
            var texts = dropDown.GetText().split(textSeparator);
            var values = GetValuesByTextsRet(texts);
            checkListBoxRet.SelectValues(values);
            UpdateSelectAllItemStateRet();
            UpdateTextRet(); // for remove non-existing texts
        }
        function GetSelectedItemsTextRet(items) {
            var texts = [];
            for (var i = 0; i < items.length; i++)
                //if(items[i].index != 0)
                texts.push(items[i].text);
            //texts.push(items[i].value);
            return texts.join(textSeparator);

        }
        function GetValuesByTextsRet(texts) {
            var actualValues = [];
            var item;
            for (var i = 0; i < texts.length; i++) {
                item = checkListBoxRet.FindItemByText(texts[i]);
                if (item != null)
                    actualValues.push(item.value);
            }
            return actualValues;
        }

        function FocoQuantidade() {
            var textbox = document.getElementById("txtQTD_LOTE");
            textbox.focus();
            textbox.scrollIntoView();
        }

    </script>    

</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolderMain" runat="server">
  

    <div style="width:100%; border: solid 1px groove; text-align: center; ">
        <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="ORDEM DE CARREGAMENTO - LOTE: 71006SC0 até 71006SC0 - DT SAÍDA: 09/10/2017" FONT-SIZE="X-Large" Font-Bold="true" BackColor="GradientActiveCaption" width="100%" ></dx:ASPxLabel>
    </div>
    <div>

         <div>
                                                                 
   </div>

        <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" Width="100%" ClientInstanceName="PageControl">
           
             <TabPages>

                <dx:TabPage Name="TabPesquisa" Text="PESQUISA">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            <div class="AlinhadoDireita">
                                <%--<dx:ASPxButton runat="server" Text="FILTRAR" ID="btnPesquisar" ImagePosition="Top" Theme="Default"  BackColor="White" AutoPostBack="false" Visible="false">
                                    <Image IconID="filter_multiplemasterfilter_32x32">
                                    </Image>
                                    <Border BorderStyle="None" />
                                </dx:ASPxButton>--%>
                            </div>
                            <div>
                                  <dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server"  ClientInstanceName="pp2" Width="700px" PopupElementID="btnSalvar" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="Below" CssClass="popupresultado32" HeaderText="Apontamento de Lote/Quantidade">
                                            <HeaderStyle Font-Size="Larger" Font-Bold="True" />
                                            <%--<ClientSideEvents Init="AdjustSizePopUp" />--%>
                                            <ContentCollection>
                                                <dx:PopupControlContentControl runat="server"  >
                                                    <dx:ASPxFormLayout ID="ASPxFormLayoutPesq" runat="server" ColCount="2" Width="100%">
                                                        <Items>
                                                             <dx:TabbedLayoutGroup ColSpan="1" RowSpan="2" ClientInstanceName="tabbedGroupPageControl" Width="100%" ShowGroupDecoration="False">
                                                                    <ParentContainerStyle CssClass="tabbedGroupPageControlCell" />
                                                                    <%--<ClientSideEvents Init="OnTabbedGroupPageControlInit" />--%>
                                                                    <Items>
                                                                        <dx:LayoutGroup ColCount="2" Caption="" GroupBoxDecoration="None" Name="lgPF" VerticalAlign="Top" Width="100%" HorizontalAlign="Left" RowSpan="2" ColSpan="2">
                                                                            <Items>

                                                                             <dx:LayoutItem Caption="Produto" ColSpan="1" RowSpan="1" Width="75%">
                                                                                <LayoutItemNestedControlCollection>
                                                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                                                        <dx:ASPxLabel ID="lblDescProduto" runat="server" Text="" Font-Size="Medium" Font-Bold="True"></dx:ASPxLabel>
                                                                                    </dx:LayoutItemNestedControlContainer>
                                                                                </LayoutItemNestedControlCollection>
                                                                                <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle">
                                                                                </CaptionSettings>
                                                                            </dx:LayoutItem>

                                                                            <dx:LayoutItem Caption="Qtd" ColSpan="1" RowSpan="1" Width="25%">
                                                                                <LayoutItemNestedControlCollection>
                                                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                                                        <dx:ASPxLabel ID="lblQtdProdACarregar" runat="server" Text="" Font-Size="Medium" Font-Bold="True"></dx:ASPxLabel>
                                                                                    </dx:LayoutItemNestedControlContainer>
                                                                                </LayoutItemNestedControlCollection>
                                                                                <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle">
                                                                                </CaptionSettings>
                                                                            </dx:LayoutItem>




                                                                            <dx:LayoutItem Caption="Produtos Liberados " ColSpan="1" rowspan="200"  VerticalAlign="Top" Width="70%">
                                                                                <LayoutItemNestedControlCollection>
                                                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                                
                                                                                        <dx:ASPxGridView ID="GridLOTES"  Font-Size="Medium"  runat="server" AutoGenerateColumns="False" KeyFieldName="pId" Width="100%" EnableCallBacks="False" Theme="Office2010Silver" SettingsPager-Mode="ShowAllRecords" Settings-VerticalScrollBarMode="Auto">
                                                                                                
                                                                                            <Columns>
                                                                                                    <dx:GridViewDataHyperLinkColumn FieldName="pId" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
                                                                                                    </dx:GridViewDataHyperLinkColumn>                                                  
                                                                                                    <dx:GridViewDataTextColumn Caption="Lote" FieldName="pLote" ShowInCustomizationForm="True" VisibleIndex="6" Width="45%">
                                                                                                    </dx:GridViewDataTextColumn>     

                                                                                                    <dx:GridViewDataTextColumn Caption="Data Val." FieldName="pDataValidade" ShowInCustomizationForm="True" VisibleIndex="6" Width="30%" >
                                                                                                                      <propertiestextedit displayformatstring="d" />
                                                                                                        </dx:GridViewDataTextColumn>
                                                                                                    <dx:GridViewDataTextColumn Caption="Quantidade"  FieldName="pQuantidade" ShowInCustomizationForm="True" VisibleIndex="6" Width="25%">
                                                                                                    </dx:GridViewDataTextColumn>                                    
                                                                           
                                                                                                </Columns>
                                                                                                <%--<SettingsBehavior AllowSelectByRowClick="True" AllowSelectSingleRowOnly="True"  />--%>
                                                                                                <SettingsBehavior AllowSelectByRowClick="True"  AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" FilterRowMode="OnClick"  />
                                                                                                <SettingsPager EnableAdaptivity="True">
                                                                                                </SettingsPager>
                                                                                                <Settings ShowFilterBar="auto" ShowFilterRow="true" ShowGroupedColumns="True" ShowGroupPanel="false" />

                                                                                                <SettingsCommandButton>
                                                                                                <ShowAdaptiveDetailButton ButtonType="Image"></ShowAdaptiveDetailButton>

                                                                                                <HideAdaptiveDetailButton ButtonType="Image"></HideAdaptiveDetailButton>
                                                                                                </SettingsCommandButton>

                                                                                                <SettingsDataSecurity AllowEdit="False" AllowInsert="False" AllowDelete="False" />
                                                                                                <SettingsSearchPanel ShowApplyButton="True" AllowTextInputTimer="False" ShowClearButton="True" />
                                                                                                                                      
                                                                                        </dx:ASPxGridView>   
                                                                              
                                                                                    </dx:LayoutItemNestedControlContainer>
                                                                                </LayoutItemNestedControlCollection>
                                                                                <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle">
                                                                                </CaptionSettings>
                                                                            </dx:LayoutItem>
                                                                            <dx:LayoutItem Caption="Lote" ColSpan="1" RowSpan="1" Width="30%">
                                                                                <LayoutItemNestedControlCollection>
                                                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                                                         <dx:ASPxTextBox ID="txtLOTE" runat="server" Theme="Moderno" NullText="Digite o Lote" Width="100%">  </dx:ASPxTextBox>
                                                                                    </dx:LayoutItemNestedControlContainer>
                                                                                </LayoutItemNestedControlCollection>
                                                                                <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle">
                                                                                </CaptionSettings>
                                                                            </dx:LayoutItem>
                                                                            <dx:LayoutItem Caption="Quantidade" ColSpan="1" RowSpan="1" Width="30%">
                                                                                <LayoutItemNestedControlCollection>
                                                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                                                         <dx:ASPxTextBox ID="txtQTD_LOTE"  ClientInstanceName="CiQtd_lote" runat="server" Theme="Moderno" NullText="" Width="100%">  </dx:ASPxTextBox>

                                                                                    </dx:LayoutItemNestedControlContainer>
                                                                                </LayoutItemNestedControlCollection>
                                                                                <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle">
                                                                                </CaptionSettings>
                                                                            </dx:LayoutItem>
                                                                
                                                                            <dx:LayoutItem Caption="" Width="30%" ColSpan="1" RowSpan="1">
                                                                                <LayoutItemNestedControlCollection>
                                                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                                                        <dx:ASPxButton ID="btnAdicionar" ClientInstanceName="btnAdicionarCI" runat="server" ToolTip="ADICIONAR"  Text="ADICIONAR" Theme="Moderno" Width="100%" Image-IconID="save_save_32x32"/>
                                                                                    </dx:LayoutItemNestedControlContainer>
                                                                                </LayoutItemNestedControlCollection>
                                                                                <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle">
                                                                                </CaptionSettings>
                                                                            </dx:LayoutItem>
                                                                        </Items>
                                                                        <SettingsItemCaptions Location="Top" VerticalAlign="Top">
                                                                        </SettingsItemCaptions>
                                                                    </dx:LayoutGroup>
                                                                </Items>
                                                            </dx:TabbedLayoutGroup>
                                                        </Items>
                                                        <SettingsItems Width="100%">
                                                        </SettingsItems>
                                                    </dx:ASPxFormLayout>
                                                    <%--<dx:ASPxButton ID="ASPxButtonSalvar" runat="server" OnClick="ASPxButtonNova_Click" Text="Salvar Análise" >  </dx:ASPxButton>--%>
                                                </dx:PopupControlContentControl>
                                            </ContentCollection>
                                        </dx:ASPxPopupControl>    
                            </div>



                        <dx:ASPxGridView ID="gridPesquisa"  runat="server" AutoGenerateColumns="False" KeyFieldName="pId" Width="100%" EnableCallBacks="False" Theme="Office2010Silver" SettingsPager-Mode="ShowAllRecords" Font-Size="Medium" Settings-VerticalScrollBarMode="Hidden" Settings-VerticalScrollBarStyle="Standard">
                                <Columns>
                                    <dx:GridViewDataHyperLinkColumn FieldName="pId" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
                                    </dx:GridViewDataHyperLinkColumn>                                                  
                                    <dx:GridViewDataTextColumn Caption="Cliente" FieldName="pClienteDescricao" ShowInCustomizationForm="True" VisibleIndex="6" Width="30%">
                                    </dx:GridViewDataTextColumn>     

                                    <dx:GridViewDataTextColumn Caption="Cód. Produto" FieldName="pProdutoCodigo" ShowInCustomizationForm="True" VisibleIndex="6" Width="5%" >
                                                <%--      <PropertiesTextEdit DisplayFormatString="D" />--%>
                                        </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Produto" FieldName="pProdutoDescricao" ShowInCustomizationForm="True" VisibleIndex="6" Width="30%" >
                                    </dx:GridViewDataTextColumn>     
                                    <dx:GridViewDataTextColumn Caption="Quantidade" FieldName="pQuantidade" ShowInCustomizationForm="True" VisibleIndex="6" Width="5%">
                                    </dx:GridViewDataTextColumn>          
                                    <dx:GridViewDataTextColumn Caption="Quant.Carregada" FieldName="pQuantidadeCarregada" ShowInCustomizationForm="True" VisibleIndex="6" Width="5%">
                                    </dx:GridViewDataTextColumn>                                 
                                    <dx:GridViewDataTextColumn Caption="Cubagem" FieldName="pM3" ShowInCustomizationForm="True" VisibleIndex="6" Width="5%">
                                    </dx:GridViewDataTextColumn>                                            
                                    <dx:GridViewDataTextColumn Caption="Peso" FieldName="pPeso" ShowInCustomizationForm="True" VisibleIndex="6" Width="5%">
                                    </dx:GridViewDataTextColumn>                                      
                                    <dx:GridViewDataTextColumn Caption="Formas" FieldName="pFormas" ShowInCustomizationForm="True" VisibleIndex="6" Width="5%">
                                    </dx:GridViewDataTextColumn>        

                             <%--       
                                    
                                    
                                    <dx:GridViewDataHyperLinkColumn FieldName="pId" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
                                    </dx:GridViewDataHyperLinkColumn>                                                  
                                    <dx:GridViewDataTextColumn Caption="Data Visita" FieldName="pDataVisita" ShowInCustomizationForm="True" VisibleIndex="6" Width="25px">
                                        </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Visitante" FieldName="pVisitanteNome" ShowInCustomizationForm="True" VisibleIndex="6" Width="95px">
                                    </dx:GridViewDataTextColumn>     
                                    <dx:GridViewDataTextColumn Caption="Empresa" FieldName="pEmpresaNome" ShowInCustomizationForm="True" VisibleIndex="6" Width="95px">
                                    </dx:GridViewDataTextColumn>                                    
                                    <dx:GridViewDataTextColumn Caption="Funcionário" FieldName="pFuncionarioNome" ShowInCustomizationForm="True" VisibleIndex="6" Width="95px">
                                    </dx:GridViewDataTextColumn>                                            
                                    <dx:GridViewDataTextColumn Caption="Setor" FieldName="pSetorNome" ShowInCustomizationForm="True" VisibleIndex="6" Width="95px">
                                    </dx:GridViewDataTextColumn>                    --%>                  
                                                                           
                                </Columns>
                                <SettingsBehavior AllowSelectByRowClick="True" AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" FilterRowMode="OnClick" />
                                <SettingsPager EnableAdaptivity="True">
                                </SettingsPager>
                                <Settings ShowFilterBar="Auto" ShowFilterRow="true" ShowGroupedColumns="True" ShowGroupPanel="false" />

                                <SettingsCommandButton>
                                <ShowAdaptiveDetailButton ButtonType="Image"></ShowAdaptiveDetailButton>

                                <HideAdaptiveDetailButton ButtonType="Image"></HideAdaptiveDetailButton>
                                </SettingsCommandButton>

                                <SettingsDataSecurity AllowEdit="False" AllowInsert="False" AllowDelete="False" />
                                <SettingsSearchPanel ShowApplyButton="True" AllowTextInputTimer="False" ShowClearButton="True" />
                                                                                                                                      
                        </dx:ASPxGridView>

                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                     
                                

                
            </TabPages>
        </dx:ASPxPageControl>
    </div>
  
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:s5taviacaoConnectionString %>' />

     <div class="mensagensValSummary">
        <dx:ASPxValidationSummary ID="ASPxValidationSummary1" runat="server" RenderMode="BulletedList" ValidationGroup="DadosForm" HeaderText="Mensagens" ShowErrorsInEditors="True"></dx:ASPxValidationSummary>
    </div>
    <div class="mensagensGenericas" style="font-size:medium; color:red; font-weight:600">
        <asp:Literal ID="litMsgGenerica" runat="server"></asp:Literal>
    </div>

</asp:Content>
