<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="PivotPedidosXFaturamento.aspx.vb" Inherits="AspNet5t.PivotPedidosXFaturamento" %>

<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v17.2, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>
<%@ Register TagPrefix="dx" Namespace="DevExpress.Data.Linq" Assembly="DevExpress.Web.v17.2, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" %>
<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContentPlaceHolderMain" runat="server">
    <script type="text/javascript"> 
        function showSalvar(s, e) {
            pcSalvar.PerformCallback();
            pcSalvar.Show();
        }
        function showRestaurar(s, e) {
            pcRestaurar.PerformCallback();
            pcRestaurar.Show();
        }
        function GetCheckBoxValue(s, e) {
            var value = s.GetChecked();
            var id = s.Value;
            alert(value);
            alert(id);
        }
       
        function OnRowDbClick(s, e) {
            gridPivotAnalise.GetRowValues(e.visibleIndex, "pId;pDescricao", onGetValues);
        }
        function gridAnalise_OnCustomButtonClick(s, e) {            
            gridPivotAnalise.GetRowValues(e.visibleIndex, "pId;pDescricao", onGetValuesExcluir);
        }
        
        function OnClick(s, e, index) {
            var gridSelectRowIndex = index;
            var row = grdMaster.GetRow(gridSelectRowIndex);
            var cellValue = row.cells[0].innerHTML;

        }


        function onGetValues(data) {
              
            if (data[0] != null) {
                hf.Clear();
                hf.Set("pId", data[0]);
                botaoRestaurar.DoClick();
            };
        }
        function onGetValuesExcluir(data) {
           
            if (data[0] != null) {
                hf.Clear();
                hf.Set("pId", data[0]);
                botaoExcluir.DoClick();
            };
        }
        function refreshGridAnalises() {
            gridPivotAnalise.Refresh();
        }
        function refreshPivot() {
            pivotVendas.Refresh();
        }
        function refreshPagina() {
            location.reload();
        }

           </script>
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContentPlaceHolderMain" runat="server">

    <div>
         <table cellspacing="0">
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxButton ID="buttonSaveAs" ClientInstanceName="buttonSaveAs" runat="server" ToolTip="Exportar Excel Modo Normal" OnClick="buttonSaveAs_Click" >
                        <Image IconID="export_exporttoxlsx_16x16">
                        </Image>
                    </dx:ASPxButton>
                </td>
                 <td>
                    <dx:ASPxButton ID="buttonSaveAsRaw" ClientInstanceName="buttonSaveAsRaw" runat="server" ToolTip="Exportar Excel Modo Básico" OnClick="buttonSaveAsRaw_Click" >
                        <Image IconID="export_exporttoxls_16x16">
                        </Image>
                    </dx:ASPxButton>
                </td>             

                <td>
                      <dx:ASPxButton ID="ASPxButtonNova" runat="server"  AutoPostBack="false" ClientVisible ="true" ToolTip="Salvar Análise" >
                        <Image IconID="save_save_16x16">
                        </Image>
                    </dx:ASPxButton>                    
                </td>

              <%--  <td>                        
                   <dx:ASPxButton ID="ASPxButtonRestaurar" runat="server" OnClick="ASPxButtonRestaurar_Click" ClientVisible ="true" ToolTip="Salvar Análise Como" >
                        <Image IconID="save_saveTO_16x16">
                        </Image>
                    </dx:ASPxButton>
                </td>--%>
                <td>
                    <dx:ASPxButton ID="ASPxButtonPopUpRestaurar" runat="server"  AutoPostBack="false" ClientSideEvents-Click="refreshGridAnalises" ToolTip="Abrir Análise">
<ClientSideEvents Click="refreshGridAnalises"></ClientSideEvents>
                        <Image IconID="actions_open_16x16">
                        </Image>
                    </dx:ASPxButton>
                </td>
                <td>
                    <dx:ASPxButton ID="ASPxButtonPreFiltro" runat="server" ToolTip="Pré-Filtro" UseSubmitBehavior="False" AutoPostBack="False">
                        <ClientSideEvents Click="function(s, e) {pivotVendas.ShowPrefilter();}" />
                        <Image IconID="filter_filter_16x16">
                        </Image>
                    </dx:ASPxButton>
                </td>
                <td>
                    <dx:ASPxButton ID="ASPxButton1" runat="server" AutoPostBack="False" ToolTip="Mostrar Lista de Campos">
                        <ClientSideEvents Click="function(s, e) {pivotVendas.SetCustomizationFieldsVisibility( true );}" />
                        <Image IconID="actions_insert_16x16">
                        </Image>
                    </dx:ASPxButton>
                </td>
                <td>
                    <dx:ASPxButton ID="ASPxButtonLimparAnalise" runat="server" AutoPostBack="False" ToolTip="Limpar Análise">
                        <ClientSideEvents Click="function(s, e) {window.location.reload(false);}" />
                        <Image IconID="actions_clearformatting_16x16">
                        </Image>
                    </dx:ASPxButton>
                </td>
                <td style="width:50px"></td>
                <td>
                    <dx:ASPxCheckBox ID="cbDataHeader" runat="server" AutoPostBack="true" Text="Valores em Linhas" Visible="True" />
                </td>
                 <td style="width:50px"></td>
                <td>
                    <dx:ASPxCheckBox ID="cbOcultarCampos" runat="server" AutoPostBack="true" Text="Ocultar Campos de Cálculo" Visible="True" />
                </td>
                <td style="width:50px"></td>
                <td>
                    <dx:ASPxLabel ID="ASPxLabelNomeAnalise" runat="server" Text="" Font-Bold="true"></dx:ASPxLabel>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                    <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Cliente:" Theme="Moderno">
                    </dx:ASPxLabel>
                </td>
                <td>
                    <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" EnableCallbackMode="true" CallbackPageSize="10" ValueField="pNOME_CLIENTE"
                        OnItemsRequestedByFilterCondition="ASPxComboBox_OnItemsRequestedByFilterCondition_SQL"
                        OnItemRequestedByValue="ASPxComboBox_OnItemRequestedByValue_SQL" TextFormatString="{0} ({1})"
                        Width="900px" DropDownStyle="DropDown" Theme="Moderno" ClientInstanceName="btnCliente">
                        <Columns>
                            <dx:ListBoxColumn FieldName="pNOME_CLIENTE" Caption="Nome" Width="100%" />
                            <dx:ListBoxColumn FieldName="pCLIENTE" Caption="C&#243;digo" Width="90px" />
                        </Columns>
                    </dx:ASPxComboBox>
                </td>
                <td>
                    <dx:ASPxButton ID="ASPxButtonPesquisar" runat="server" Text="Aplicar Pré-Filtro" Theme="Moderno" AutoPostBack="True">
                    </dx:ASPxButton>
                </td>
            </tr>
        </table>
    </div>
   
      <dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server"  ClientInstanceName="pcSalvar" PopupElementID="ASPxButtonNova" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="Below" CssClass="popupresultado" HeaderText="Gravação do Modelo de Análise">
        <HeaderStyle Font-Size="Larger" Font-Bold="True" />
        <ContentCollection>
            <dx:PopupControlContentControl runat="server"  >
                <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Nome:" Theme="Moderno">    </dx:ASPxLabel>
                <asp:TextBox ID="txtNomeAnalise" runat="server" Width="402px"></asp:TextBox>
                <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Pasta:">    </dx:ASPxLabel>
               
                 <dx:ASPxComboBox ID="ASPxComboBoxPasta" runat="server"   Width="400px" DropDownStyle="DropDown" Theme="Moderno" >
                    </dx:ASPxComboBox>
                <dx:ASPxCheckBox ID="ASPxCheckBoxCompartilhada" runat="server" AutoPostBack="true" Text="Análise Compartilhada" Visible="True" />

                <dx:ASPxButton ID="ASPxButtonSalvar" runat="server" OnClick="ASPxButtonNova_Click" Text="Salvar Análise" >  </dx:ASPxButton>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>

<dx:ASPxPopupControl ID="ASPxPopupControl2" runat="server"  ClientInstanceName="pcRestaurar" PopupElementID="ASPxButtonPopUpRestaurar" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="Below" CssClass="popupresultado" HeaderText="Restauração do Modelo de Análise" Width="750px">
        <HeaderStyle Font-Size="Larger" Font-Bold="True" />
        <ContentCollection>
            <dx:PopupControlContentControl runat="server"  >                    
                   <dx:ASPxGridView ID="ASPxGridView2" SettingsPager-Mode="ShowAllRecords" runat="server" DataSourceID="SqlDataSourceGridPivotAnalise" AutoGenerateColumns="False" Theme="Office2010Silver" KeyFieldName="ROWPK" ClientInstanceName="gridPivotAnalise" Width="100%">
                       <Styles>
                            <Header Wrap="True"></Header>

<GroupRow Font-Bold="True"></GroupRow>

                               <RowHotTrack BackColor="WhiteSmoke" Cursor="hand"></RowHotTrack>

                            <Cell>
                                <Paddings PaddingTop="0px" PaddingBottom="0px"></Paddings>
                            </Cell>

                            <GroupFooter Font-Bold="True"></GroupFooter>

                            <TitlePanel Font-Size="Medium"></TitlePanel>
                       </Styles>
                       <SettingsBehavior EnableRowHotTrack="true" AllowFixedGroups="True" />
                       <Columns>
                           <dx:GridViewDataTextColumn FieldName="pPastaNome" Caption="Pasta" VisibleIndex="0" Visible="true" Width="460px">
                                <Settings AllowHeaderFilter="true" AllowAutoFilter="true"  AllowGroup="True"/>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="pId" VisibleIndex="1" Caption="Id" Visible="false">
                                <Settings AllowHeaderFilter="False" AllowAutoFilter="False" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="pDescricao" Caption="Nome da Análise" VisibleIndex="2" Visible="true" Width="430px">
                                <Settings AllowHeaderFilter="true" AllowAutoFilter="true" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="pLayoutVersion" Caption="Versão" VisibleIndex="3" Visible="true" Width="70px">
                                <Settings AllowHeaderFilter="true" AllowAutoFilter="true" />
                            </dx:GridViewDataTextColumn>
                           <dx:GridViewDataTextColumn FieldName="pFlgCompartilhada" Caption="Compartilhada" VisibleIndex="4" Visible="true" Width="90px">
                                <Settings AllowHeaderFilter="true" AllowAutoFilter="true" />
                            </dx:GridViewDataTextColumn>
                            <%--<dx:GridViewDataTextColumn FieldName="" Caption="" VisibleIndex="4" Visible="true" Width="90px">
                                <Settings AllowHeaderFilter="true" AllowAutoFilter="true" />
                                <DataItemTemplate>
                                
                                    <dx:ASPxButton ID="ASPxButtonExcluir" runat="server" OnClick="ASPxButtonExcluir_Click" Text="Excluir"  ClientInstanceName="botaoExcluir" ClientVisible="true"  ToolTip=<%# Eval("pid") %>>
                                    </dx:ASPxButton>
                                </DataItemTemplate>
                            </dx:GridViewDataTextColumn>--%>
                             <dx:GridViewCommandColumn ButtonType="Button" VisibleIndex="4" >
                                <CustomButtons>
                                    <dx:GridViewCommandColumnCustomButton ID="BtnExcluir" Text="Excluir">
                                    </dx:GridViewCommandColumnCustomButton>
                                </CustomButtons>
                            </dx:GridViewCommandColumn>

                           
                        </Columns>

                       <ClientSideEvents RowClick="OnRowDbClick" CustomButtonClick="gridAnalise_OnCustomButtonClick"/>

                        <SettingsBehavior AllowDragDrop="False" AllowSelectByRowClick="False" AllowSelectSingleRowOnly="False" AllowFixedGroups="False" AllowSort="False"/>

<SettingsPager Mode="ShowAllRecords"></SettingsPager>

                        <Settings HorizontalScrollBarMode="Visible" ShowVerticalScrollBar="false" VerticalScrollableHeight="35" UseFixedTableLayout="True" ShowTitlePanel="true" ShowFilterRow="False" ShowGroupedColumns="False" ShowFooter="True" ShowStatusBar="Hidden" />
                        <SettingsText Title="Análises Salvas - Pivot" />

<SettingsCommandButton>
<ShowAdaptiveDetailButton ButtonType="Image"></ShowAdaptiveDetailButton>

<HideAdaptiveDetailButton ButtonType="Image"></HideAdaptiveDetailButton>
</SettingsCommandButton>

                        <SettingsDataSecurity AllowEdit="False" AllowInsert="False" AllowDelete="False"></SettingsDataSecurity>
                        <Styles>
                            <Header Wrap="True">
                            </Header>
                            <GroupFooter Font-Bold="True">
                            </GroupFooter>
                            <TitlePanel Font-Size="Medium">
                            </TitlePanel>
                            <Cell>
                                <Paddings PaddingBottom="0px" PaddingTop="0px" />
                            </Cell>
                            <GroupRow Font-Bold="True">
                            </GroupRow>
                        </Styles>
                        <Templates>
                            <FooterRow>
                                <div style="height: 140px;">
                                    <span style="font-weight: bold; text-decoration: underline;"></span>
                                </div>
                            </FooterRow>
                        </Templates>
                    </dx:ASPxGridView>
                       
                        <dx:ASPxHiddenField ID="ASPxHiddenField1" runat="server" ClientInstanceName="hf"></dx:ASPxHiddenField>
                        <dx:ASPxButton ID="ASPxButton3" runat="server" OnClick="ASPxButton3_Click" Text="Abrir Análise" AutoPostBack="false" ClientInstanceName="botaoRestaurar" ClientVisible="false">
                            </dx:ASPxButton>
                        <dx:ASPxButton ID="ASPxButtonExcluir" runat="server" OnClick="ASPxButtonExcluir_Click" Text="Excluir Análise" AutoPostBack="false" ClientInstanceName="botaoExcluir" ClientVisible="false">
                            </dx:ASPxButton>

            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>

    <dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server"  ClientIDMode="AutoID" Theme="Moderno" EnableTheming="True" Width="100%" ClientInstanceName="pivotVendas"  oncustomcellvalue="ASPxPivotGrid1_CustomCellValue" OnCustomFieldValueCells="pivotGrid_CustomFieldValueCells" >
        <Fields>

            <dx:PivotGridField ID="fieldpTIPO_OP" Caption="Tipo Operação" FieldName="pTIPO_OP" Visible="true" AreaIndex="1">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpFILIAL" Caption="Filial" FieldName="pFILIAL" Visible="true" AreaIndex="5">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpPEDIDO" Caption="Num. Pedido" FieldName="pPEDIDO" Visible="true" AreaIndex="10">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpNOTA_FISCAL" Caption="Nota Fiscal" FieldName="pNOTA_FISCAL" Visible="true" AreaIndex="15">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpSERIE_NF" Caption="Série Nota Fiscal" FieldName="pSERIE_NF" Visible="false" AreaIndex="20">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpCOD_CLIENTE" Caption="Cód. Cliente" FieldName="pCOD_CLIENTE" Visible="false" AreaIndex="25">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpLOJA" Caption="Cód. Loja" FieldName="pLOJA" Visible="false" AreaIndex="30">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDESC_CLIENTE" Caption="Nome Cliente" FieldName="pDESC_CLIENTE" Visible="false" AreaIndex="35">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpCOD_VENDEDOR" Caption="Cód. Vendedor" FieldName="pCOD_VENDEDOR" Visible="false" AreaIndex="40">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpNOME_VENDEDOR" Caption="Nome Vendedor" FieldName="pNOME_VENDEDOR" Visible="false" AreaIndex="45">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDT_EMISSAO" Caption="Dt. Emissão Pedido" FieldName="pDT_EMISSAO" Visible="false" AreaIndex="55">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpCODIGO_PRODUTO" Caption="Cód. Produto" FieldName="pCODIGO_PRODUTO" Visible="true" AreaIndex="60">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDESC_PRODUTO" Caption="Desc. Produto" FieldName="pDESC_PRODUTO" Visible="true" AreaIndex="65">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpQUANT_UNIDADE" Caption="Quantidade" CellFormat-FormatString="{0:#,#0.0}" CellFormat-FormatType="Numeric" FieldName="pQUANT_UNIDADE" Visible="true" AreaIndex="70">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpPRECO_VENDA" Caption="Preço Venda" CellFormat-FormatString="{0:#,#0.0}" CellFormat-FormatType="Numeric" FieldName="pPRECO_VENDA" Visible="true" AreaIndex="75">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpSTATUS" Caption="Status do Pedido" FieldName="pSTATUS" Visible="true" AreaIndex="80">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpQUANT_CAIXA" Caption="Quantidade em Caixa" CellFormat-FormatString="{0:#,#0.0}" CellFormat-FormatType="Numeric" FieldName="pQUANT_CAIXA" Visible="true" AreaIndex="85">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpUF_CLIENTE" Caption="Uf Cliente"  FieldName="pUF_CLIENTE" Visible="false" AreaIndex="90">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpREGIAO" Caption="Região"  FieldName="pREGIAO" Visible="false" AreaIndex="95">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpNUMERO_ORCAMENTO" Caption="Num. Orçamento"  FieldName="pNUMERO_ORCAMENTO" Visible="false" AreaIndex="100">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpCOD_GRUPO_CLIENTE" Caption="Cód. Grupo Cliente"  FieldName="pCOD_GRUPO_CLIENTE" Visible="false" AreaIndex="105">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDESC_GRUPO_CLIENTE" Caption="Desc. Grupo Cliente"  FieldName="pDESC_GRUPO_CLIENTE" Visible="false" AreaIndex="110">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDTDIA_EMISSAO_PED" Caption="Dia Emissão Pedido"  FieldName="pDTDIA_EMISSAO_PED" Visible="false" AreaIndex="115">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDTMES_EMISSAO_PED" Caption="Mes Emissão Pedido"  FieldName="pDTMES_EMISSAO_PED" Visible="false" AreaIndex="120">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDTANO_EMISSAO_PED" Caption="Ano Emissão Pedido"  FieldName="pDTANO_EMISSAO_PED" Visible="false" AreaIndex="120">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDTDIA_EMISSAO_FAT" Caption="Dia Emissão Nota Fiscal"  FieldName="pDTDIA_EMISSAO_FAT" Visible="false" AreaIndex="125">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDTMES_EMISSAO_FAT" Caption="Mes Emissão Nota Fiscal"  FieldName="pDTMES_EMISSAO_FAT" Visible="false" AreaIndex="130">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDTANO_EMISSAO_FAT" Caption="Ano Emissão Nota Fiscal"  FieldName="pDTANO_EMISSAO_FAT" Visible="false" AreaIndex="135">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpBM_DESC" Caption="Grupo de Produto"  FieldName="pBM_DESC" Visible="false" AreaIndex="140">
            </dx:PivotGridField>



        </Fields>
        <OptionsPager RowsPerPage="0">
        </OptionsPager>
    </dx:ASPxPivotGrid>
    <dx:LinqServerModeDataSource runat="server" ID="LinqServerModeDataSource1" ContextTypeName="AspNet5t.AviacaoPedidosFaturamentoBasedataclassDataContext" TableName="AviacaoPedidosFaturamentos"></dx:LinqServerModeDataSource>
    <asp:SqlDataSource ID="SqlDataSourceGridPivotAnalise" runat="server" ConnectionString="<%$ ConnectionStrings:s5taviacaoConnectionString %>" ProviderName="<%$ ConnectionStrings:s5taviacaoConnectionString.ProviderName %>" ></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:s5taviacaoConnectionString %>' />
    <dx:ASPxPivotGridExporter ID="ASPxPivotGridExporter1" runat="server" ASPxPivotGridID="ASPxPivotGrid1" Visible="False" />
</asp:Content>
