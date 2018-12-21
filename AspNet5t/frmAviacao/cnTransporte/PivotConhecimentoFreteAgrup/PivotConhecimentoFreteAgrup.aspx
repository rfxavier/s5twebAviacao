<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="PivotConhecimentoFreteAgrup.aspx.vb" Inherits="AspNet5t.PivotConhecimentoFreteAgrup" %>

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
            <dx:PivotGridField ID="fieldpGW1_EMISDC" Caption="pGW1_EMISDC" FieldName="pGW1_EMISDC" Visible="false" AreaIndex="5">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW1_CDTPDC" Caption="Tp. Documento" FieldName="pGW1_CDTPDC" Visible="false" AreaIndex="10">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGV5_DSTPDC" Caption="pGV5_DSTPDC" FieldName="pGV5_DSTPDC" Visible="false" AreaIndex="15">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW1_DTEMIS" Caption="Data Emissão" FieldName="pGW1_DTEMIS" Visible="false" AreaIndex="20">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW1_DTEMIS_DIA" Caption="Dia Emissão" FieldName="pGW1_DTEMIS_DIA" Visible="false" AreaIndex="25">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW1_DTEMIS_MES" Caption="Mês Emissão" FieldName="pGW1_DTEMIS_MES" Visible="false" AreaIndex="30">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW1_DTEMIS_ANO" Caption="Ano Emissão" FieldName="pGW1_DTEMIS_ANO" Visible="false" AreaIndex="35">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW1_SERDC" Caption="Série Documento" FieldName="pGW1_SERDC" Visible="false" AreaIndex="40">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW1_NRDC" Caption="Número Documento" FieldName="pGW1_NRDC" Visible="false" AreaIndex="45">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW1_CDREM" Caption="Cód. Remetente" FieldName="pGW1_CDREM" Visible="false" AreaIndex="50">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGU3_NMEMIT_REM" Caption="Desc. Remetente" FieldName="pGU3_NMEMIT_REM" Visible="false" AreaIndex="55">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGU3_CDERP_REM" Caption="pGU3_CDERP_REM" FieldName="pGU3_CDERP_REM" Visible="false" AreaIndex="60">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGU3_CDCERP_REM" Caption="Loja Remetente" FieldName="pGU3_CDCERP_REM" Visible="false" AreaIndex="65">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW1_CDDEST" Caption="pGW1_CDDEST" FieldName="pGW1_CDDEST" Visible="false" AreaIndex="70">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGU3_NMEMIT" Caption="Cliente" FieldName="pGU3_NMEMIT" Visible="false" AreaIndex="75">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGU3_CDERP" Caption="Cód. Cliente" FieldName="pGU3_CDERP" Visible="false" AreaIndex="80">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGU3_CDCERP" Caption="Loja Cliente" FieldName="pGU3_CDCERP" Visible="false" AreaIndex="85">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW1_NRROM" Caption="Num. Romaneio" FieldName="pGW1_NRROM" Visible="false" AreaIndex="90">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW1_TPFRET" Caption="Tipo Frete" FieldName="pGW1_TPFRET" Visible="false" AreaIndex="95">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW1_DTSAI" Caption="Data Saída" FieldName="pGW1_DTSAI" Visible="false" AreaIndex="100">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW1_DTSAI_DIA" Caption="Dia Saída" FieldName="pGW1_DTSAI_DIA" Visible="false" AreaIndex="105">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW1_DTSAI_MES" Caption="Mês Saída" FieldName="pGW1_DTEMIS_MES" Visible="false" AreaIndex="110">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW1_DTSAI_ANO" Caption="Ano Saída" FieldName="pGW1_DTSAI_ANO" Visible="false" AreaIndex="115">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW1_DSESP" Caption="Embalagem" FieldName="pGW1_DSESP" Visible="false" AreaIndex="120">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW3_NRDF" Caption="Número CTe" FieldName="pGW3_NRDF" Visible="false" AreaIndex="125">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW1_QTVOL" Caption="Volume Produto" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pGW1_QTVOL" Visible="false" AreaIndex="130">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW8_VALOR_TOTAL_NOTA" Caption="Valor Total Nota" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pGW8_VALOR_TOTAL_NOTA" Visible="true" AreaIndex="135">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGW8_VALOR_BRUTO_TOTAL_NOTA" Caption="Valor Total Bruto Nota" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pGW8_VALOR_BRUTO_TOTAL_NOTA" Visible="true" AreaIndex="140">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpVALOR_TOTAL_NF_FRETE_AGRUPADO" Caption="Valor Total De Notas (Frete Agrupado)" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pVALOR_TOTAL_NF_FRETE_AGRUPADO" Visible="true" AreaIndex="145">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpVALOR_FRETE_TOTAL" Caption="Valor Total Frete" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pVALOR_FRETE_TOTAL" Visible="true" AreaIndex="150">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpPERC_NF_FRETE_AGRUPADO" Caption="% Frete Agrupado" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pPERC_NF_FRETE_AGRUPADO" Visible="false" AreaIndex="155">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGWM_VLFRET_CFRT_CCAR_NOVOFRETE" Caption="Total de frete por % do GFE" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pGWM_VLFRET_CFRT_CCAR_NOVOFRETE" Visible="false" AreaIndex="160">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGWM_VLFRET_RTDCCAR_TOTALNRDC" Caption="Total de frete por rateio contábil" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pGWM_VLFRET_RTDCCAR_TOTALNRDC" Visible="true" AreaIndex="165">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpSTATUS_GFE" Caption="Status" FieldName="pSTATUS_GFE" Visible="false" AreaIndex="170">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpF2_PBRUTO_TOTALNRDC" Caption="Peso Bruto" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pF2_PBRUTO_TOTALNRDC" Visible="true" AreaIndex="175">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpF2_PLIQUI_TOTALNRDC" Caption="Peso Líquido" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pF2_PLIQUI_TOTALNRDC" Visible="true" AreaIndex="180">
            </dx:PivotGridField>
        </Fields>
        <OptionsPager RowsPerPage="8" AlwaysShowPager="True">
        </OptionsPager>
    </dx:ASPxPivotGrid>
    <dx:LinqServerModeDataSource runat="server" ID="LinqServerModeDataSource1" ContextTypeName="AspNet5t.AviacaoConhecimentoFreteAgrupBasedataclassDataContext" TableName="AviacaoConhecimentoFreteAgrups"></dx:LinqServerModeDataSource>
    <asp:SqlDataSource ID="SqlDataSourceGridPivotAnalise" runat="server" ConnectionString="<%$ ConnectionStrings:s5taviacaoConnectionString %>" ProviderName="<%$ ConnectionStrings:s5taviacaoConnectionString.ProviderName %>" ></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:s5taviacaoConnectionString %>' />
    <dx:ASPxPivotGridExporter ID="ASPxPivotGridExporter1" runat="server" ASPxPivotGridID="ASPxPivotGrid1" Visible="False" />
</asp:Content>
