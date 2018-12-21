<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="cnTransporteMovimentacaoDeViagemPortaria.aspx.vb" Inherits="AspNet5t.cnTransporteMovimentacaoDeViagemPortaria" %>

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
        var lastValidationResult = false;
        function OnTipoPFPJChanged(s, e) {
            var selectedIndex = s.GetSelectedIndex();
            tabbedGroupPageControl.SetActiveTabIndex(selectedIndex);
        }
     
        function OnEmailValidation(s, e) {
            var valid = mail.GetText() == retypeEmail.GetText();
            if (s === retypeEmail && mail.GetIsValid())
                e.isValid = valid;
        }
        function OnSubmitButtonClick() {
            if (lastValidationResult)
                alert('Thank you!');
        }
        function OnValidationComplete(s, e) {
            lastValidationResult = e.isValid;
        }
        function SetActiveTab(tabIndexIncrement) {
            var activeTabIndex = PageControl.GetActiveTab().index;
            activeTabIndex += tabIndexIncrement;
            PageControl.SetActiveTab(PageControl.GetTab(activeTabIndex));
        }
        // Submit Button
        function OnSumbitButtonClick(s, e) {
            var tabPageCount = PageControl.GetTabCount();
            for (var i = 1; i < tabPageCount; i++) {
                PageControl.SetActiveTab(PageControl.GetTab(i));
                var editorsContainerId = "ASPxFormLayout" + i;
                //ASPxClientEdit.ClearEditorsInContainerById(editorsContainerId);
                if (!ASPxClientEdit.ValidateEditorsInContainerById(editorsContainerId)) {
                    e.processOnServer = false;
                    break;
                }
            }
        }

        function AdjustSizePopUp() {
            var width = document.documentElement.clientWidth;
            pp.SetWidth(width - 48 * 1.5);
        }
       
       
    </script>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolderMain" runat="server">
    <div class="buttonsToolbar">       
        <dx:ASPxButton ID="btnSalvar" runat="server" Text="Salvar" ImagePosition="Top" BackColor="White" UseSubmitBehavior="False">
            <ClientSideEvents Click="OnSumbitButtonClick" />
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
                                        <%--<ClientSideEvents Init="OnTabbedGroupPageControlInit" />--%>
                                        <Items>
                                            <dx:LayoutGroup ColCount="7" Caption="" GroupBoxDecoration="None" Name="lgPF" VerticalAlign="Top" Width="100%" HorizontalAlign="Left" RowSpan="2">
                                                <Items>
                                               
                                                    <dx:LayoutItem Caption="Data Saída" ColSpan="1" VerticalAlign="Top" Width="18%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxDateEdit runat="server" EditFormat="DateTime" Width="100%" Theme="Moderno" ID="mskDatSaida" ReadOnly="true">
                                                                    <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ErrorText="" SetFocusOnError="True" ValidationGroup="DadosForm">
                                                                        <RequiredField IsRequired="True" ErrorText="Data Sa&#237;da obrigat&#243;ria"></RequiredField>
                                                                    </ValidationSettings>
                                                                </dx:ASPxDateEdit>
                                                                

                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>

                                                    <dx:LayoutItem Caption="Data Prev. Ret." ColSpan="1" Width="15%" >
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxDateEdit runat="server" Width="100%" Theme="Moderno" ID="mskDatPrev" ReadOnly="true">
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
                                                                <dx:ASPxDateEdit runat="server" EditFormat="DateTime" Width="100%" Theme="Moderno" ID="mskDatRetorno" ReadOnly="true"></dx:ASPxDateEdit>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>


                                                    <dx:LayoutItem Caption="Motorista" Width="18%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxComboBox runat="server" DropDownStyle="DropDown" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" Width="100%" ClientInstanceName="CmbMotorista" Theme="Moderno" ID="CmbMotorista" ReadOnly="true"></dx:ASPxComboBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>

                                                    <dx:LayoutItem Caption="Caminhão" Width="12%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxComboBox runat="server" DropDownStyle="DropDown" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" Width="100%" ClientInstanceName="CmbCaminhao" Theme="Moderno" ID="CmbCaminhao" ReadOnly="true"></dx:ASPxComboBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>

                                                    <dx:LayoutItem Caption="Local/Linha" Width="13%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxComboBox runat="server" DropDownStyle="DropDown" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" Width="100%" ClientInstanceName="CmbLocalLinha" Theme="Moderno" ID="CmbLocalLinha" ReadOnly="true"></dx:ASPxComboBox>
                                                                </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>

                                                     <dx:LayoutItem Caption="Local/Linha Ret." Width="13%">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxComboBox runat="server" DropDownStyle="DropDown" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" Width="100%" ClientInstanceName="CmbLocalLinhaRetorno" Theme="Moderno" ID="CmbLocalLinhaRetorno" ReadOnly="true"></dx:ASPxComboBox>
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
                                        <%--<ClientSideEvents Init="OnTabbedGroupPageControlInit" />--%>
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
                                                                            <dx:GridViewDataTextColumn Caption="Caminhão" FieldName="pCAMINHAO_PLACA" ShowInCustomizationForm="True" VisibleIndex="6" Width="25px">
                                                                            </dx:GridViewDataTextColumn>
                                                                            <dx:GridViewDataTextColumn Caption="Motorista" FieldName="pMOTORISTA_NOME" ShowInCustomizationForm="True" VisibleIndex="6" Width="25px">
                                                                            </dx:GridViewDataTextColumn>
                                                                            <dx:GridViewDataTextColumn Caption="Tipo" FieldName="pCAMINHAO_TIPO" ShowInCustomizationForm="True" VisibleIndex="6" Width="25px">
                                                                            </dx:GridViewDataTextColumn>
                                    
                                                                            <dx:GridViewDataTextColumn Caption="Data Saída" FieldName="pDATA_SAIDA" ShowInCustomizationForm="True" VisibleIndex="6" Width="25px">
                                                                            </dx:GridViewDataTextColumn>
                                                                             <dx:GridViewDataTextColumn Caption="Local Linha" FieldName="pLOCAL_LINHA_DESCRICAO" ShowInCustomizationForm="True" VisibleIndex="6" Width="25px">
                                                                            </dx:GridViewDataTextColumn>
                                                                            <dx:GridViewDataTextColumn Caption="Local Linha Ret" FieldName="pLOCAL_LINHA_RETORNO_DESCRICAO" ShowInCustomizationForm="True" VisibleIndex="6" Width="25px">
                                                                            </dx:GridViewDataTextColumn>
                                                                            <dx:GridViewDataTextColumn Caption="Data Prev. Retorno" FieldName="pDATA_PREV_RETORNO" ShowInCustomizationForm="True" VisibleIndex="6" Width="25px">
                                                                            </dx:GridViewDataTextColumn>
                                                                            <dx:GridViewDataTextColumn Caption="Data Retorno" FieldName="pDATA_RETORNO" ShowInCustomizationForm="True" VisibleIndex="6" Width="25px">
                                                                            </dx:GridViewDataTextColumn>
                                                                            <dx:GridViewDataTextColumn Caption="Disponibilidade" FieldName="pSTATUS"  ShowInCustomizationForm="True" VisibleIndex="6" Width="25px">
                                                                            </dx:GridViewDataTextColumn>
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

                            
                            <asp:ObjectDataSource ID="dsCadastro" runat="server" DataObjectTypeName="S5T.Cadastro" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="LoadByNomeFlgCadastroViewGeral" TypeName="S5T.CadastroCollection" UpdateMethod="Save">
                                <SelectParameters>
                                    <asp:Parameter DefaultValue="%" Name="parNome" Type="String" />
                                    <asp:Parameter Name="parFlgCadastro" Type="String" />
                                </SelectParameters>
                            </asp:ObjectDataSource>


                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
            </TabPages>
        </dx:ASPxPageControl>
    </div>
    <div class="mensagensValSummary">
        <dx:ASPxValidationSummary ID="ASPxValidationSummary1" runat="server" RenderMode="BulletedList" ValidationGroup="DadosForm" HeaderText="Mensagens" ShowErrorsInEditors="True"></dx:ASPxValidationSummary>
    </div>
    <div class="mensagensGenericas">
        <asp:Literal ID="litMsgGenerica" runat="server"></asp:Literal>
    </div>

</asp:Content>
