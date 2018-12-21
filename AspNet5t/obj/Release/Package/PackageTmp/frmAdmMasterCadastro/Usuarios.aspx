<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="Usuarios.aspx.vb" Inherits="AspNet5t.Usuarios" %>

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
    </script>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolderMain" runat="server">
    <dx:ASPxSiteMapDataSource ID="ASPxSiteMapDataSource1" runat="server" SiteMapFileName="~/web.sitemap" EnableRoles="True" />
    <div class="buttonsToolbar">
        <dx:ASPxButton ID="btnExcluir" runat="server" Text="Excluir" ImagePosition="Top" BackColor="White">
            <Image IconID="edit_delete_32x32">
            </Image>
            <Border BorderStyle="None" />
        </dx:ASPxButton>
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
    </div>

    <div>
        <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="1" Width="100%" ClientInstanceName="PageControl">
            <TabPages>
                <dx:TabPage Name="tabPesquisa" Text="Pesquisa">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            <dx:ASPxFormLayout ID="ASPxFormLayout0" runat="server" ColCount="3" Width="100%">
                                <Items>
                                    <dx:EmptyLayoutItem Width="160px"></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem Width="100%"></dx:EmptyLayoutItem>
                                    <dx:LayoutItem Caption="" Width="150px" HorizontalAlign="Right" RowSpan="2" ShowCaption="False">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <div style="text-align: right;">
                                                <dx:ASPxButton runat="server" ImagePosition="Top" Text="Pesquisar" BackColor="White" ID="btnPesquisar">
                                                    <Image IconID="find_findcustomers_32x32"></Image>

                                                    <Border BorderStyle="None"></Border>
                                                </dx:ASPxButton>
                                                </div>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:EmptyLayoutItem Width="160px"></dx:EmptyLayoutItem>
                                    <dx:EmptyLayoutItem Width="100%"></dx:EmptyLayoutItem>

                                    <dx:LayoutItem ColSpan="3" Caption="" ShowCaption="False">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxGridView ID="gridUsuarios" runat="server" AutoGenerateColumns="False" KeyFieldName="pId" Width="100%" EnableCallBacks="False">
                                                    <Columns>
                                                        <dx:GridViewDataTextColumn FieldName="pId" ShowInCustomizationForm="True" VisibleIndex="3" ReadOnly="True" Visible="False">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn FieldName="pCodigo" ShowInCustomizationForm="True" VisibleIndex="4" Visible="False">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="Login" FieldName="pLogin" ShowInCustomizationForm="True" VisibleIndex="5" SortIndex="0" SortOrder="Ascending">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn FieldName="oIdUserId" ShowInCustomizationForm="True" VisibleIndex="11" ReadOnly="True" Visible="False">
                                                        </dx:GridViewDataTextColumn>
                                                    </Columns>
                                                    <SettingsBehavior AllowSelectByRowClick="True" AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" FilterRowMode="OnClick" />
                                                    <SettingsPager EnableAdaptivity="True">
                                                    </SettingsPager>
                                                    <Settings ShowFilterBar="Auto" ShowFilterRow="True" />
                                                    <SettingsDataSecurity AllowEdit="False" AllowInsert="False" />
                                                    <SettingsSearchPanel ShowApplyButton="True" Visible="True" AllowTextInputTimer="False" ShowClearButton="True" />
                                                </dx:ASPxGridView>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>

                                </Items>

                                <SettingsItemCaptions HorizontalAlign="Right" VerticalAlign="Middle"></SettingsItemCaptions>
                            </dx:ASPxFormLayout>

                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Name="tabUsuario" Text="Usu&#225;rio">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            <dx:ASPxFormLayout ID="ASPxFormLayout3" runat="server" ColCount="2">
                                <Items>
                                    <dx:LayoutItem Caption="Login" ColSpan="2">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxTextBox ID="txtLoginUsuario" runat="server" Width="170px">
                                                    <ValidationSettings ValidationGroup="DadosForm">
                                                    </ValidationSettings>
                                                </dx:ASPxTextBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                        <CaptionSettings VerticalAlign="Middle" />
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="Senha">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxTextBox runat="server" Width="170px" Password="True" ClientInstanceName="txtSenhaUsuario" ID="txtSenhaUsuario">
                                                    <ValidationSettings ValidationGroup="DadosForm"></ValidationSettings>
                                                </dx:ASPxTextBox>


                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                        <CaptionSettings VerticalAlign="Middle"></CaptionSettings>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="Confirmar Senha">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxTextBox ID="txtSenhaConfirmarUsuario" runat="server" Width="170px" ClientInstanceName="txtSenhaConfirmarUsuario" Password="True">
                                                    <ClientSideEvents Validation="function(s, e) {e.isValid = (s.GetText() == txtSenhaUsuario.GetText());}"></ClientSideEvents>

                                                    <ValidationSettings ValidationGroup="DadosForm" ErrorDisplayMode="ImageWithTooltip" ErrorText="A senha n&#227;o confere">
                                                    </ValidationSettings>
                                                </dx:ASPxTextBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                        <CaptionSettings VerticalAlign="Middle" />
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="C&#243;digo Vendedor">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxTextBox ID="txtCodigoVendedor" runat="server">
                                                    <ValidationSettings ValidationGroup="DadosForm">
                                                    </ValidationSettings>
                                                </dx:ASPxTextBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                        <CaptionSettings VerticalAlign="Middle" />
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="C&#243;digo Aprovador">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxTextBox runat="server" ID="txtCodigoAprovador">
                                                    <ValidationSettings ValidationGroup="DadosForm"></ValidationSettings>
                                                </dx:ASPxTextBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                        <CaptionSettings VerticalAlign="Middle" />
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="C&#243;digo Sub-Vendedor">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxTextBox runat="server" ID="txtCodigoSubVendedor">
                                                    <ValidationSettings ValidationGroup="DadosForm"></ValidationSettings>
                                                </dx:ASPxTextBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                        <CaptionSettings VerticalAlign="Middle"></CaptionSettings>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="C&#243;digo Vendedor Vinculado">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxTextBox runat="server" ID="txtCodigoVendedorVinculado">
                                                    <ValidationSettings ValidationGroup="DadosForm"></ValidationSettings>
                                                </dx:ASPxTextBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                        <CaptionSettings VerticalAlign="Middle"></CaptionSettings>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="Habilitado">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxCheckBox runat="server" CheckState="Unchecked" ID="chkHabilitadoUsuario">
                                                    <ValidationSettings ValidationGroup="DadosForm"></ValidationSettings>
                                                </dx:ASPxCheckBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                        <CaptionSettings VerticalAlign="Middle"></CaptionSettings>
                                    </dx:LayoutItem>
                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                    <dx:LayoutItem ShowCaption="False" VerticalAlign="Top">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxGridView runat="server" AutoGenerateColumns="False" EnableCallBacks="False" KeyFieldName="Id" ID="gridRolesUsuario">
                                                    <SettingsPager PageSize="2000"></SettingsPager>
                                                    <Columns>
                                                        <dx:GridViewCommandColumn ShowSelectCheckbox="True" ShowInCustomizationForm="True" VisibleIndex="0"></dx:GridViewCommandColumn>
                                                        <dx:GridViewDataTextColumn FieldName="Id" ReadOnly="True" ShowInCustomizationForm="True" Name="colId" Caption="Id" Visible="False" VisibleIndex="2"></dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn FieldName="Name" ReadOnly="True" ShowInCustomizationForm="True" Name="colName" Caption="Permiss&#227;o" VisibleIndex="4"></dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataCheckColumn FieldName="IdComp" UnboundType="Boolean" ShowInCustomizationForm="True" Name="colIdComp" Visible="False" VisibleIndex="5"></dx:GridViewDataCheckColumn>
                                                    </Columns>
                                                </dx:ASPxGridView>

                                                <asp:ObjectDataSource runat="server" DataObjectTypeName="S5T.IdRole" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="LoadAll" TypeName="S5T.IdRoleCollection" UpdateMethod="Save" ID="dsRoles"></asp:ObjectDataSource>

                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem ShowCaption="False" VerticalAlign="Top">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                <dx:ASPxGridView runat="server" AutoGenerateColumns="False" EnableCallBacks="False" KeyFieldName="pId" ID="gridRelatoriosMobileUsuario">
                                                    <SettingsPager PageSize="2000"></SettingsPager>
                                                    <Columns>
                                                        <dx:GridViewCommandColumn ShowSelectCheckbox="True" ShowInCustomizationForm="True" VisibleIndex="0"></dx:GridViewCommandColumn>
                                                        <dx:GridViewDataTextColumn FieldName="pId" ReadOnly="True" ShowInCustomizationForm="True" Name="colId" Caption="pId" Visible="False" VisibleIndex="2"></dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn FieldName="pTituloRelatorio" ReadOnly="True" ShowInCustomizationForm="True" Name="colName" Caption="Relat&#243;rio Mobile" VisibleIndex="4"></dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataCheckColumn FieldName="pIdComp" UnboundType="Boolean" ShowInCustomizationForm="True" Name="colIdComp" Visible="False" VisibleIndex="5"></dx:GridViewDataCheckColumn>
                                                    </Columns>
                                                </dx:ASPxGridView>


                                                <asp:ObjectDataSource runat="server" DataObjectTypeName="S5T.AppRelatorio" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="LoadAll" TypeName="S5T.AppRelatorioCollection" UpdateMethod="Save" ID="dsRelatorios"></asp:ObjectDataSource>


                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                </Items>
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
    <div class="mensagensGenericas">
        <asp:Literal ID="litMsgGenerica" runat="server"></asp:Literal>
    </div>

</asp:Content>
