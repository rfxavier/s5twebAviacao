<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="cnTransporteControleViagemAg.aspx.vb" Inherits="AspNet5t.cnTransporteControleViagemAg" EnableEventValidation="false"%>

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
    </script>    

</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolderMain" runat="server">
    <div class="buttonsToolbar">
        <dx:ASPxButton ID="btnExcluir" runat="server" Text="Excluir" ImagePosition="Top" BackColor="White"  >
            <Image IconID="edit_delete_32x32">
            </Image>
            <Border BorderStyle="None" />
        </dx:ASPxButton>
        <dx:ASPxButton ID="btnSalvar" runat="server" Text="Salvar" ImagePosition="Top" BackColor="White" UseSubmitBehavior="False" >
            <%--<ClientSideEvents Click="OnSumbitButtonClick" />--%>
            <Image IconID="save_saveto_32x32">
            </Image>
            <Border BorderStyle="None" />
        </dx:ASPxButton>
        <dx:ASPxButton ID="btnDesistir" runat="server" Text="Desistir" ImagePosition="Top" BackColor="White">
            <Image IconID="actions_cancel_32x32">
            </Image>
            <Border BorderStyle="None" />
        </dx:ASPxButton>
        <dx:ASPxButton ID="btnSair" runat="server" Text="Sair" ImagePosition="Top" Theme="Default" BackColor="White">
            <Image IconID="navigation_backward_32x32">
            </Image>
            <Border BorderStyle="None" />
        </dx:ASPxButton>
         <dx:ASPxButton runat="server" Text="Pesquisar" ID="btnPesquisar" ImagePosition="Top" Theme="Default"  BackColor="White" AutoPostBack="false">
              <Image IconID="find_findcustomers_32x32"> 
              </Image>
               <Border BorderStyle="None" />
         </dx:ASPxButton>
      
    </div>
    <div>
      <dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server"  ClientInstanceName="pp" Width="100%" PopupElementID="btnPesquisar" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="Below" CssClass="popupresultado32" HeaderText="Filtro de Análise">
        <HeaderStyle Font-Size="Larger" Font-Bold="True" />
           <ClientSideEvents Init="AdjustSizePopUp" />
        <ContentCollection>
            <dx:PopupControlContentControl runat="server"  >
                <dx:ASPxFormLayout ID="ASPxFormLayoutPesq" runat="server" ColCount="3" Width="100%">
                                <Items>
                                                                                                        
                                    <dx:TabbedLayoutGroup ColSpan="1" RowSpan="2" ClientInstanceName="tabbedGroupPageControlPesq" Width="100%" ShowGroupDecoration="False">
                                        <ParentContainerStyle CssClass="tabbedGroupPageControlCell" />
                                        <ClientSideEvents Init="OnTabbedGroupPageControlInit" />
                                        <Items>
                                            <dx:LayoutGroup ColCount="8" Caption="" GroupBoxDecoration="None" Name="layoutPesq" VerticalAlign="Top" Width="100%" HorizontalAlign="Left" RowSpan="2">
                                                <Items>

                                                    <dx:LayoutItem Caption="Data Saída - Período " ColSpan="1" VerticalAlign="Top" Width="18%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxDateEdit runat="server" EditFormat="Date" Width="100%" Theme="Moderno" ID="mskDatSaidaIniPesq">
                                                                    
                                                                </dx:ASPxDateEdit>
 <dx:ASPxDateEdit runat="server" EditFormat="Date" Width="100%" Theme="Moderno" ID="mskDatSaidaFinPesq">
                                                                   
                                                                </dx:ASPxDateEdit>



                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>

                                                    <dx:LayoutItem Caption="Data Prev. Ret. - Período" ColSpan="1" Width="15%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxDateEdit runat="server" Width="100%" Theme="Moderno" ID="mskDatPrevIniPesq">
                                                                   
                                                                </dx:ASPxDateEdit>
 <dx:ASPxDateEdit runat="server" Width="100%" Theme="Moderno" ID="mskDatPrevFinPesq">
                                                                  
                                                                </dx:ASPxDateEdit>

                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>

                                                    <dx:LayoutItem Caption="Data Retorno - Período" ColSpan="1" Width="15%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxDateEdit runat="server" EditFormat="Date" Width="100%" Theme="Moderno" ID="mskDatRetornoIniPesq"></dx:ASPxDateEdit>
    <dx:ASPxDateEdit runat="server" EditFormat="Date" Width="100%" Theme="Moderno" ID="mskDatRetornoFinPesq"></dx:ASPxDateEdit>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>


                                                    <dx:LayoutItem Caption="Motorista" Width="25%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxComboBox runat="server" DropDownStyle="DropDown" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" Width="100%" ClientInstanceName="CmbMotoristaPesq" Theme="Moderno" ID="CmbMotoristaPesq"></dx:ASPxComboBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>

                                                    <dx:LayoutItem Caption="Caminhão" Width="12%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxComboBox runat="server" DropDownStyle="DropDown" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" Width="100%" ClientInstanceName="CmbCaminhaoPesq" Theme="Moderno" ID="CmbCaminhaoPesq"></dx:ASPxComboBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>

                                                    <dx:LayoutItem Caption="Local/Linha" Width="15%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxComboBox runat="server" DropDownStyle="DropDown" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" Width="100%" ClientInstanceName="CmbLocalLinhaPesq" Theme="Moderno" ID="CmbLocalLinhaPesq"></dx:ASPxComboBox>
                                                                </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>
                                                    
                                                    <dx:LayoutItem Caption="Somente Viagens em Aberto/Disponível" Width="15%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                 <dx:ASPxCheckBox ID="cbCaminhaoDisponivel" runat="server" AutoPostBack="false" Text="" Visible="True" />
                                                            </dx:LayoutItemNestedControlContainer>
                                                         </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>

                                                     <dx:LayoutItem Caption="" Width="15%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                  <dx:ASPxButton ID="buttonAplicarFiltro" ClientInstanceName="buttonAplicarFiltro" runat="server" ToolTip="Aplicar Filtro" OnClick="btnPesquisar_Click" Text="Aplicar Filtro" />
                                                             </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>


                                                </Items>
                                                <SettingsItemCaptions Location="Top" VerticalAlign="Top"></SettingsItemCaptions>
                                            </dx:LayoutGroup>
                                          
                                        </Items>
                                    </dx:TabbedLayoutGroup>
                                    
                                    
                                </Items>
                                <SettingsItems Width="100%"></SettingsItems>
                            </dx:ASPxFormLayout>

                <%--<dx:ASPxButton ID="ASPxButtonSalvar" runat="server" OnClick="ASPxButtonNova_Click" Text="Salvar Análise" >  </dx:ASPxButton>--%>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
    </div>
    <div>
        <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="1" Width="100%" ClientInstanceName="PageControl">
            <TabPages>
                
                <dx:TabPage Name="tabDados1" Text="Dados">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" ColCount="3" Width="100%">
                                <Items>
                                                                                                        
                                    <dx:TabbedLayoutGroup ColSpan="1" RowSpan="2" ClientInstanceName="tabbedGroupPageControl" Width="100%" ShowGroupDecoration="False">
                                        <ParentContainerStyle CssClass="tabbedGroupPageControlCell" />
                                        <ClientSideEvents Init="OnTabbedGroupPageControlInit" />
                                        <Items>
                                            <dx:LayoutGroup ColCount="8" Caption="" GroupBoxDecoration="None" Name="lgPF" VerticalAlign="Top" Width="100%" HorizontalAlign="Left" RowSpan="2">
                                                <Items>
                                               
                                                    <dx:LayoutItem Caption="Data Saída" ColSpan="1" VerticalAlign="Top" Width="18%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxDateEdit runat="server" EditFormat="DateTime" Width="100%" Theme="Moderno" ID="mskDatSaida">
                                                                    <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ErrorText="" SetFocusOnError="True" ValidationGroup="DadosForm">
                                                                        <RequiredField IsRequired="True" ErrorText="Data Sa&#237;da obrigat&#243;ria"></RequiredField>
                                                                    </ValidationSettings>
                                                                </dx:ASPxDateEdit>
                                                                

                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>

                                                    <dx:LayoutItem Caption="Data Prev. Ret." ColSpan="1" Width="15%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxDateEdit runat="server" Width="100%" Theme="Moderno" ID="mskDatPrev">
                                                                    <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ErrorText="" SetFocusOnError="True" ValidationGroup="DadosForm">
                                                                        <RequiredField IsRequired="True" ErrorText="Data Sa&#237;da obrigat&#243;ria"></RequiredField>
                                                                    </ValidationSettings>
                                                                </dx:ASPxDateEdit>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>

                                                    <dx:LayoutItem Caption="Data Retorno" ColSpan="1" Width="14%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxDateEdit runat="server" EditFormat="DateTime" Width="100%" Theme="Moderno" ID="mskDatRetorno"></dx:ASPxDateEdit>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>


                                                    <dx:LayoutItem Caption="Motorista" Width="18%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxComboBox runat="server" DropDownStyle="DropDown" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" Width="100%" ClientInstanceName="CmbMotorista" Theme="Moderno" ID="CmbMotorista"></dx:ASPxComboBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>
                                                   
                                                    <dx:LayoutItem Caption="Caminhão" Width="12%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxComboBox runat="server" DropDownStyle="DropDown" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" Width="100%" ClientInstanceName="CmbCaminhao" Theme="Moderno" ID="CmbCaminhao"></dx:ASPxComboBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>

                                                   

                                                     <dx:LayoutItem Caption="Local/Linha Ret." Width="12%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxComboBox runat="server" DropDownStyle="DropDown" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" Width="100%" ClientInstanceName="
                                                                    Retorno" Theme="Moderno" ID="CmbLocalLinhaRetorno"></dx:ASPxComboBox>
                                                                </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>
                                                                                                   
                                                   <dx:LayoutItem Caption="Em Manutenção" Width="5%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                 <dx:ASPxCheckBox ID="cbEmManutencao" runat="server" AutoPostBack="false" Text="" Visible="True" />
                                                            </dx:LayoutItemNestedControlContainer>
                                                         </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>

                                                </Items>
                                                <SettingsItemCaptions Location="Top" VerticalAlign="Top"></SettingsItemCaptions>
                                            </dx:LayoutGroup>
                                            <dx:LayoutGroup>
                                                <Items>
                                                    <dx:LayoutItem>
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxLabel runat="server" Text="teste" ID="ASPxFormLayout1_E1"></dx:ASPxLabel>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>
                                                </Items>
                                            </dx:LayoutGroup>
                                        </Items>
                                    </dx:TabbedLayoutGroup>
                                    
                                    
                                </Items>
                                <SettingsItems Width="100%"></SettingsItems>
                            </dx:ASPxFormLayout>

                               <dx:ASPxFormLayout ID="ASPxFormLayout2" runat="server" ColCount="3" Width="100%">
                                <Items>
                                      <dx:TabbedLayoutGroup ColSpan="1" RowSpan="2" ClientInstanceName="tabbedGroupPageControl" Width="100%" ShowGroupDecoration="False">
                                        <ParentContainerStyle CssClass="tabbedGroupPageControlCell" />
                                        <ClientSideEvents Init="OnTabbedGroupPageControlInit" />
                                        <Items>
                                            <dx:LayoutGroup Width="100%">
                                                <Items>
                                                    <dx:LayoutItem Caption="">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <%--GRID DE PESQUISA--%>
                                                                <dx:ASPxGridView ID="gridPesquisa" runat="server" AutoGenerateColumns="False" KeyFieldName="pId" Width="100%" EnableCallBacks="False" Theme="Office2010Silver" SettingsPager-Mode="ShowAllRecords">
                                                                        <Columns>
                                                                            <dx:GridViewDataHyperLinkColumn FieldName="pId" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
                                                                            </dx:GridViewDataHyperLinkColumn>
                                                                           <%-- <dx:GridViewDataTextColumn Caption="Produto" FieldName="pProdutoDescricao" ShowInCustomizationForm="True" VisibleIndex="6" Width="95px">
                                                                            </dx:GridViewDataTextColumn>
                                                                            <dx:GridViewDataTextColumn Caption="Lote" FieldName="pLote" ShowInCustomizationForm="True" VisibleIndex="6" Width="35px">
                                                                            </dx:GridViewDataTextColumn>
                                                                            <dx:GridViewDataTextColumn Caption="Formas" FieldName="pFormas" ShowInCustomizationForm="True" VisibleIndex="6" Width="25px">
                                                                            </dx:GridViewDataTextColumn>
                                                                            <dx:GridViewDataTextColumn Caption="Data Fabricação" FieldName="pDataFabricacao" ShowInCustomizationForm="True" VisibleIndex="6" Width="25px">
                                                                            </dx:GridViewDataTextColumn>
                                                                            <dx:GridViewDataTextColumn Caption="Data Maturação" FieldName="pDataMaturacao" ShowInCustomizationForm="True" VisibleIndex="6" Width="25px" >
                                                                            </dx:GridViewDataTextColumn>                                                                            
                                                                            <dx:GridViewDataTextColumn Caption="Finalizado" FieldName="pFinalizado"  ShowInCustomizationForm="True" VisibleIndex="6" Width="25px">
                                                                            </dx:GridViewDataTextColumn>--%>
                                                                            <%--<dx:GridViewCommandColumn ShowClearFilterButton="true" ShowApplyFilterButton="true" VisibleIndex="8" />--%>
                                                                        </Columns>
                                                                        <SettingsBehavior AllowSelectByRowClick="True" AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" FilterRowMode="OnClick" />
                                                                        <SettingsPager EnableAdaptivity="True">
                                                                        </SettingsPager>
                                                                        <Settings ShowFilterBar="Auto" ShowFilterRow="True" />

                                                                        <SettingsCommandButton>
                                                                        <ShowAdaptiveDetailButton ButtonType="Image"></ShowAdaptiveDetailButton>

                                                                        <HideAdaptiveDetailButton ButtonType="Image"></HideAdaptiveDetailButton>
                                                                        </SettingsCommandButton>

                                                                     <SettingsDataSecurity AllowEdit="False" AllowInsert="False" AllowDelete="False" />
                                                                     <SettingsSearchPanel ShowApplyButton="True" AllowTextInputTimer="False" ShowClearButton="True" />
                                                                                                                                      
                                                                </dx:ASPxGridView>


                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>
                                                </Items>
                                            </dx:LayoutGroup>
                                        </Items>
                                    </dx:TabbedLayoutGroup>
                                       </Items>
                                <SettingsItems Width="100%"></SettingsItems>
                            </dx:ASPxFormLayout>
                                                        
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>


               
                <dx:TabPage Name="tabDados2" Text="Movimentação">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            <dx:ASPxFormLayout ID="ASPxFormLayout3" runat="server" ColCount="3" Width="100%">
                                <Items>
                                                                                                        
                                    <dx:TabbedLayoutGroup ColSpan="1" RowSpan="2" ClientInstanceName="tabbedGroupPageControl" Width="100%" ShowGroupDecoration="False">
                                        <ParentContainerStyle CssClass="tabbedGroupPageControlCell" />
                                        <ClientSideEvents Init="OnTabbedGroupPageControlInit" />
                                        <Items>
                                            <dx:LayoutGroup ColCount="8" Caption="" GroupBoxDecoration="None" Name="lgPF" VerticalAlign="Top" Width="100%" HorizontalAlign="Left" RowSpan="2">
                                                <Items>
                                               
                                                    <dx:LayoutItem Caption="Data Saída" ColSpan="1" VerticalAlign="Top" Width="18%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxDateEdit runat="server" EditFormat="DateTime" Width="100%" Theme="Moderno" ID="ASPxDateEdit1">
                                                                    <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ErrorText="" SetFocusOnError="True" ValidationGroup="DadosForm">
                                                                        <RequiredField IsRequired="True" ErrorText="Data Sa&#237;da obrigat&#243;ria"></RequiredField>
                                                                    </ValidationSettings>
                                                                </dx:ASPxDateEdit>
                                                                

                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>

                                                    <dx:LayoutItem Caption="Data Prev. Ret." ColSpan="1" Width="15%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxDateEdit runat="server" Width="100%" Theme="Moderno" ID="ASPxDateEdit2">
                                                                    <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ErrorText="" SetFocusOnError="True" ValidationGroup="DadosForm">
                                                                        <RequiredField IsRequired="True" ErrorText="Data Sa&#237;da obrigat&#243;ria"></RequiredField>
                                                                    </ValidationSettings>
                                                                </dx:ASPxDateEdit>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>

                                                    <dx:LayoutItem Caption="Data Retorno" ColSpan="1" Width="14%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxDateEdit runat="server" EditFormat="DateTime" Width="100%" Theme="Moderno" ID="ASPxDateEdit3"></dx:ASPxDateEdit>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>


                                                    <dx:LayoutItem Caption="Motorista" Width="18%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxComboBox runat="server" DropDownStyle="DropDown" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" Width="100%" ClientInstanceName="CmbMotorista" Theme="Moderno" ID="ASPxComboBox1"></dx:ASPxComboBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>
                                                   
                                                    <dx:LayoutItem Caption="Caminhão" Width="12%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxComboBox runat="server" DropDownStyle="DropDown" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" Width="100%" ClientInstanceName="CmbCaminhao" Theme="Moderno" ID="ASPxComboBox2"></dx:ASPxComboBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>

                                                  

                                                     <dx:LayoutItem Caption="Local/Linha Ret." Width="12%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxComboBox runat="server" DropDownStyle="DropDown" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" Width="100%" ClientInstanceName="
                                                                    Retorno" Theme="Moderno" ID="ASPxComboBox3"></dx:ASPxComboBox>
                                                                </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>
                                                                                                   
                                                   <dx:LayoutItem Caption="Em Manutenção" Width="5%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                 <dx:ASPxCheckBox ID="ASPxCheckBox1" runat="server" AutoPostBack="false" Text="" Visible="True" />
                                                            </dx:LayoutItemNestedControlContainer>
                                                         </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>

                                                </Items>
                                                <SettingsItemCaptions Location="Top" VerticalAlign="Top"></SettingsItemCaptions>
                                            </dx:LayoutGroup>
                                            <dx:LayoutGroup>
                                                <Items>
                                                    <dx:LayoutItem>
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxLabel runat="server" Text="teste" ID="ASPxLabel1"></dx:ASPxLabel>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>
                                                </Items>
                                            </dx:LayoutGroup>
                                        </Items>
                                    </dx:TabbedLayoutGroup>
                                    
                                    
                                </Items>
                                <SettingsItems Width="100%"></SettingsItems>
                            </dx:ASPxFormLayout>

                            
                                                        
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>



            </TabPages>
        </dx:ASPxPageControl>
    </div>
    <div class="mensagensValSummary">
        <dx:ASPxValidationSummary ID="ASPxValidationSummary1" runat="server" RenderMode="BulletedList" ValidationGroup="DadosForm" HeaderText="Mensagens" ShowErrorsInEditors="True"></dx:ASPxValidationSummary>
    </div>
    <div class="mensagensGenericas" style="font-size:medium; color:red; font-weight:600">
        <asp:Literal ID="litMsgGenerica" runat="server"></asp:Literal>
    </div>

</asp:Content>
