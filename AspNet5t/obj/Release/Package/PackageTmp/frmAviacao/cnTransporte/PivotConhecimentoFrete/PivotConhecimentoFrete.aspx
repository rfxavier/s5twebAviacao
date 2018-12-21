<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="PivotConhecimentoFrete.aspx.vb" Inherits="AspNet5t.PivotConhecimentoFrete" %>

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
                <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Nome:" Theme="Moderno">
                </dx:ASPxLabel>
                <asp:TextBox ID="txtNomeAnalise" runat="server" Width="402px"></asp:TextBox>
                <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Pasta:">
                </dx:ASPxLabel>
                <dx:ASPxComboBox ID="ASPxComboBoxPasta" runat="server"   Width="400px" DropDownStyle="DropDown" Theme="Moderno" >
                </dx:ASPxComboBox>
                <dx:ASPxCheckBox ID="ASPxCheckBoxCompartilhada" runat="server" AutoPostBack="true" Text="Análise Compartilhada" Visible="True" />
                <dx:ASPxButton ID="ASPxButtonSalvar" runat="server" OnClick="ASPxButtonNova_Click" Text="Salvar Análise" >
                </dx:ASPxButton>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
    <dx:ASPxPopupControl ID="ASPxPopupControl2" runat="server" ClientInstanceName="pcRestaurar" PopupElementID="ASPxButtonPopUpRestaurar" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="Below" CssClass="popupresultado" HeaderText="Restauração do Modelo de Análise" Width="750px">
        <HeaderStyle Font-Size="Larger" Font-Bold="True" />
        <ContentCollection>
            <dx:PopupControlContentControl runat="server">
                <dx:ASPxGridView ID="ASPxGridView2" SettingsPager-Mode="ShowAllRecords" runat="server" DataSourceID="SqlDataSourceGridPivotAnalise" AutoGenerateColumns="False" Theme="Office2010Silver" KeyFieldName="ROWPK" ClientInstanceName="gridPivotAnalise" Width="100%">
                    <Styles>
                        <Header Wrap="True">
                        </Header>
                        <GroupRow Font-Bold="True">
                        </GroupRow>
                        <RowHotTrack BackColor="WhiteSmoke" Cursor="hand">
                        </RowHotTrack>
                        <Cell>
                            <Paddings PaddingTop="0px" PaddingBottom="0px">
                            </Paddings>
                        </Cell>
                        <GroupFooter Font-Bold="True">
                        </GroupFooter>
                        <TitlePanel Font-Size="Medium">
                        </TitlePanel>
                    </Styles>
                    <SettingsBehavior EnableRowHotTrack="true" AllowFixedGroups="True" />
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="pPastaNome" Caption="Pasta" VisibleIndex="0" Visible="true" Width="460px">
                            <Settings AllowHeaderFilter="true" AllowAutoFilter="true" AllowGroup="True" />
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
                        <dx:GridViewCommandColumn ButtonType="Button" VisibleIndex="4">
                            <CustomButtons>
                                <dx:GridViewCommandColumnCustomButton ID="BtnExcluir" Text="Excluir">
                                </dx:GridViewCommandColumnCustomButton>
                            </CustomButtons>
                        </dx:GridViewCommandColumn>
                    </Columns>
                    <ClientSideEvents RowClick="OnRowDbClick" CustomButtonClick="gridAnalise_OnCustomButtonClick" />
                    <SettingsBehavior AllowDragDrop="False" AllowSelectByRowClick="False" AllowSelectSingleRowOnly="False" AllowFixedGroups="False" AllowSort="False" />
                    <SettingsPager Mode="ShowAllRecords">
                    </SettingsPager>
                    <Settings HorizontalScrollBarMode="Visible" ShowVerticalScrollBar="false" VerticalScrollableHeight="35" UseFixedTableLayout="True" ShowTitlePanel="true" ShowFilterRow="False" ShowGroupedColumns="False" ShowFooter="True" ShowStatusBar="Hidden" />
                    <SettingsText Title="Análises Salvas - Pivot" />
                    <SettingsCommandButton>
                        <ShowAdaptiveDetailButton ButtonType="Image">
                        </ShowAdaptiveDetailButton>
                        <HideAdaptiveDetailButton ButtonType="Image">
                        </HideAdaptiveDetailButton>
                    </SettingsCommandButton>
                    <SettingsDataSecurity AllowEdit="False" AllowInsert="False" AllowDelete="False">
                    </SettingsDataSecurity>
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
                <dx:ASPxHiddenField ID="ASPxHiddenField1" runat="server" ClientInstanceName="hf">
                </dx:ASPxHiddenField>
                <dx:ASPxButton ID="ASPxButton3" runat="server" OnClick="ASPxButton3_Click" Text="Abrir Análise" AutoPostBack="false" ClientInstanceName="botaoRestaurar" ClientVisible="false">
                </dx:ASPxButton>
                <dx:ASPxButton ID="ASPxButtonExcluir" runat="server" OnClick="ASPxButtonExcluir_Click" Text="Excluir Análise" AutoPostBack="false" ClientInstanceName="botaoExcluir" ClientVisible="false">
                </dx:ASPxButton>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
    <dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server"  ClientIDMode="AutoID" Theme="Moderno" EnableTheming="True" Width="100%" ClientInstanceName="pivotVendas"  oncustomcellvalue="ASPxPivotGrid1_CustomCellValue" OnCustomFieldValueCells="pivotGrid_CustomFieldValueCells" >
        <Fields>
            <dx:PivotGridField ID="fieldpGW1_FILIAL" Caption="Filial" FieldName="pGW1_FILIAL" Visible="false" AreaIndex="1">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW1_NRDC" Caption="NF" FieldName="pGW1_NRDC" Visible="false" AreaIndex="5">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGU3_NMEMIT" Caption="Cliente" FieldName="pGU3_NMEMIT" Visible="true" AreaIndex="0">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW8_DSITEM" Caption="Produto" FieldName="pGW8_DSITEM" Visible="true" AreaIndex="1">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW3_DTEMIS" Caption="Data Emissão" FieldName="pGW1_DTEMIS" Visible="false" AreaIndex="16">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW3_DTEMIS_DIA" Caption="Dia Emissão" FieldName="pGW1_DTEMIS_DIA" Visible="false" AreaIndex="17">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW3_DTEMIS_MES" Caption="Mês Emissão" FieldName="pGW1_DTEMIS_MES" Visible="false" AreaIndex="18">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW3_DTEMIS_ANO" Caption="Ano Emissão" FieldName="pGW1_DTEMIS_ANO" Visible="false" AreaIndex="19">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGU3_NMEMIT_TRETRAN" Caption="Transportador" FieldName="pGU3_NMEMIT_TRETRAN" Visible="true" AreaIndex="2">
            </dx:PivotGridField>
            <%--<dx:PivotGridField ID="fieldpGU3_NMEMIT_CALCDES" Caption="Cliente" FieldName="pGU3_NMEMIT_CALCDES" Visible="false" AreaIndex="25">
            </dx:PivotGridField>--%>
            <dx:PivotGridField ID="fieldpGWM_VLFRET_RTDCCAR" Caption="Valor Frete" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pGWM_VLFRET_RTDCCAR" Visible="true" AreaIndex="3">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW8_VALOR" Caption="Valor Produto" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pGW8_VALOR" Visible="true" AreaIndex="4" AllowedAreas="RowArea, FilterArea">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW8_QTDE" Caption="Quant. Produto" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pGW8_QTDE" Visible="false" AreaIndex="40" AllowedAreas="RowArea, FilterArea">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW8_VOLUME" Caption="Volume Produto" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pGW8_VOLUME" Visible="false" AreaIndex="45" AllowedAreas="RowArea, FilterArea">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW8_PESOR" Caption="Peso Produto" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pGW8_PESOR" Visible="true" AreaIndex="5" AllowedAreas="RowArea, FilterArea">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpF2_PBRUTO" Caption="Peso Bruto Total NF" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pF2_PBRUTO" Visible="true" AreaIndex="5" AllowedAreas="RowArea, FilterArea">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpF2_PLIQUI" Caption="Peso Líquido Total NF" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pF2_PLIQUI" Visible="true" AreaIndex="5" AllowedAreas="RowArea, FilterArea">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGU7_NMCID_CALCCDDES" Caption="Cidade Destino Frete" FieldName="pGU7_NMCID_CALCCDDES" Visible="false" AreaIndex="60">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGU7_CDUF_CALCCDDES" Caption="UF Destino Frete" FieldName="pGU7_CDUF_CALCCDDES" Visible="false" AreaIndex="65">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGU7_NMCID_CALCCDORI" Caption="Cidade Origem Frete" FieldName="pGU7_NMCID_CALCCDORI" Visible="false" AreaIndex="70">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGU7_CDUF_CALCCDORI" Caption="UF Origem Frete" FieldName="pGU7_CDUF_CALCCDORI" Visible="false" AreaIndex="75">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW8_CFOP" Caption="CFOP" FieldName="pGW8_CFOP" Visible="true" AreaIndex="6">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpREGIAO_ORIGEM" Caption="Região Origem Frete" FieldName="pREGIAO_ORIGEM" Visible="False" AreaIndex="85">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpREGIAO_DESTINO" Caption="Região Destino Frete" FieldName="pREGIAO_DESTINO" Visible="False" AreaIndex="90">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW8_VALOR_TOTAL_NOTA" Caption="Valor Total Nota" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pGW8_VALOR_TOTAL_NOTA" Visible="true" AreaIndex="7" AllowedAreas="RowArea, FilterArea">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW8_VALOR_BRUTO_TOTAL_NOTA" Caption="Valor Total Bruto Nota" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pGW8_VALOR_BRUTO_TOTAL_NOTA" Visible="true" AreaIndex="8" AllowedAreas="RowArea, FilterArea">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW3_VLCARG" Caption="Valor Total NF Frete Agrupado" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pGW3_VLCARG" Visible="true" AreaIndex="8" AllowedAreas="RowArea, FilterArea">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGWU_DTENT" Caption="Data Entrega" FieldName="pGWU_DTENT" Visible="false" AreaIndex="16">
            </dx:PivotGridField>
        </Fields>
        <OptionsPager RowsPerPage="8" AlwaysShowPager="True">
        </OptionsPager>
    </dx:ASPxPivotGrid>
    <dx:LinqServerModeDataSource runat="server" ID="LinqServerModeDataSource1" ContextTypeName="AspNet5t.AviacaoConhecimentoFreteBasedataclassDataContext" TableName="AviacaoConhecimentoFretes"></dx:LinqServerModeDataSource>
    <asp:SqlDataSource ID="SqlDataSourceGridPivotAnalise" runat="server" ConnectionString="<%$ ConnectionStrings:s5taviacaoConnectionString %>" ProviderName="<%$ ConnectionStrings:s5taviacaoConnectionString.ProviderName %>" ></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:s5taviacaoConnectionString %>' />
    <dx:ASPxPivotGridExporter ID="ASPxPivotGridExporter1" runat="server" ASPxPivotGridID="ASPxPivotGrid1" Visible="False" />
</asp:Content>
