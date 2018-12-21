﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="pivotVendasComDevolucao.aspx.vb" Inherits="AspNet5t.pivotVendasComDevolucao" %>

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
            <dx:PivotGridField ID="fieldpULTIMACOMPRA" AreaIndex="0" Caption="Última Compra" FieldName="pULTIMA_COMPRA" Area="DataArea" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpCIDADECLIENTEIBGE" Caption="Cidade Cliente Ibge" FieldName="pCIDADE_CLIENTE_IBGE" Visible="False" Area="DataArea" AreaIndex="0">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpNUMERONF" Caption="Número NF" FieldName="pNUMERO_NF" Area="DataArea" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpSERIE" Area="DataArea" Caption="Série NF" FieldName="pSERIE" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpCLIENTE" Caption="Cód.Cliente" FieldName="pCLIENTE" Visible="False" Area="DataArea">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpFILIAL" Area="DataArea" Caption="Filial" FieldName="pFILIAL" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpLOJA" Caption="Loja" FieldName="pLOJA" Visible="False" Area="DataArea">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpNOMECLIENTE" Caption="Cliente" FieldName="pNOME_CLIENTE" AreaIndex="1">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpCIDADECLIENTE" AreaIndex="2" Caption="Cidade Cliente" FieldName="pCIDADE_CLIENTE" Visible="False" >
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpESTADO" AreaIndex="3" Caption="UF Cliente" FieldName="pESTADO" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField FieldName="pREGIAO" ID="fieldpREGIAO" Caption="Região" AreaIndex="0" Visible="false">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpPERCENTDESCONTO1" Caption="Perc.Desconto" CellFormat-FormatString="{0:#,#0.0}" CellFormat-FormatType="Numeric" FieldName="pPERCENT_DESCONTO" Area="DataArea" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpPORCENTCOMISSAO1" Area="DataArea" Caption="Porcent.Comissão" CellFormat-FormatString="{0:#,#0.0}" CellFormat-FormatType="Numeric" FieldName="pPORCENT_COMISSAO" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpCODIGOVENDEDOR1" Area="DataArea" Caption="Cód.Vendedor" FieldName="pCODIGO_VENDEDOR" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpNOMEVENDEDOR1" AreaIndex="8" Caption="Nome Vendedor" FieldName="pNOME_VENDEDOR" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpCIDADEVENDEDOR1" Area="DataArea" Caption="Cidade Vendedor" FieldName="pCIDADE_VENDEDOR" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpVALORCOMISSAO1" Area="DataArea" Caption="Valor Comissão" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pVALOR_COMISSAO" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDATAEMISSAO1" AreaIndex="4" Caption="Data Emissão" FieldName="pDATA_EMISSAO" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDIAEMISSAO1" AreaIndex="5" Caption="Dia Emissão" FieldName="pDIA_EMISSAO" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpMESEMISSAO1" AreaIndex="2" Caption="Mês Emissão" FieldName="pMES_EMISSAO">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpMESEXTENSO1" AreaIndex="7" Caption="Mês Extenso" FieldName="pMES_EXTENSO" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpANOEMISSAO1" AreaIndex="3" Caption="Ano Emissão" FieldName="pANO_EMISSAO">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpTRIMESTRE1" Area="DataArea" Caption="Trimestre" FieldName="pTRIMESTRE" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpCODIGOTRANSP1" Area="DataArea" Caption="Cód.Transportador" FieldName="pCODIGO_TRANSP" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpNOMETRANSP1" Area="DataArea" Caption="Nome Transportador" FieldName="pNOME_TRANSP" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpREDESPACHO1" Area="DataArea" Caption="Redespacho" FieldName="pREDESPACHO" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpNOMEREDESPACHO1" Area="DataArea" Caption="Nome Redespacho" FieldName="pNOME_REDESPACHO" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpPRODUTO1" Area="DataArea" Caption="Cód.Produto" FieldName="pPRODUTO" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGRUPOPRODUTO1" AreaIndex="4" Caption="Grupo Produto" FieldName="pGRUPO_PRODUTO">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpPESOPRODUTO1" Area="DataArea" Caption="Peso Produto" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pPESO_PRODUTO" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpQTDPCAIXA1" Area="DataArea" Caption="Qtd.Por Caixa" FieldName="pQTD_P_CAIXA" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpQTDEMCAIXA1" Area="DataArea" Caption="Qtd.Em Caixa" CellFormat-FormatString="{0:#,#0.0}" CellFormat-FormatType="Numeric" FieldName="pQTD_EM_CAIXA" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpPESOTOTAL1" Caption="Peso Total" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pPESO_TOTAL" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpPESOBRUTO1" Area="DataArea" Caption="Peso Bruto" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pPESO_BRUTO" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDESCRICAO1" AreaIndex="5" Caption="Produto" FieldName="pDESCRICAO">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpQUANTIDADE1" Area="DataArea" Caption="Quantidade" CellFormat-FormatString="{0:#,#0.0}" CellFormat-FormatType="Numeric" FieldName="pQUANTIDADE" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpPRECOTABELA1" Area="DataArea" Caption="Preço Tabela" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pPRECO_TABELA" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpVLRTOTALPRODUTO1" Area="DataArea" Caption="Valor Total Produto" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pVLR_TOTAL_PRODUTO" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpPRECODEVENDA1" Area="DataArea" Caption="Preço de Venda" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pPRECO_DE_VENDA" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpVLRDESCONTO1" Area="DataArea" Caption="Valor Desconto" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pVLR_DESCONTO" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpVLRBASEICM1" Area="DataArea" Caption="Valor Base Icm" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pVLR_BASE_ICM" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpVLRTOTALNOTA1" AreaIndex="7" Caption="Valor Liquido (vendas - devol)" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pVLR_TOTAL_NOTA">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpVLRSEMICMSST1" Area="DataArea" Caption="Valor Sem Icms ST" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pVLR_SEM_ICMSST" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpVLRICM1" Area="DataArea" Caption="Valor Icm" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pVLR_ICM" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpVLRCOFINS1" Area="DataArea" Caption="Valor Cofins" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pVLR_COFINS" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpVLRPIS1" Area="DataArea" Caption="Valor Pis" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pVLR_PIS" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpPRECOFORAIMPOSTO1" Area="DataArea" Caption="Preço Fora Imposto" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pPRECO_FORA_IMPOSTO" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpPRECOFORAIMPOSTOUNIT1" Area="DataArea" Caption="Preço Fora Imposto Unit." CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pPRECO_FORA_IMPOSTO_UNIT" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpIMPOSTOTOTALNOTA1" Area="DataArea" Caption="Imposto Total Nota" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pIMPOSTO_TOTAL_NOTA" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpPLACA1" Area="DataArea" Caption="Placa" FieldName="pPLACA" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpCFOP1" Area="DataArea" Caption="CFOP" FieldName="pCFOP" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpMARCA1" Area="DataArea" Caption="Marca" FieldName="pMARCA" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpGRUPOCLIENTE1" AreaIndex="12" Caption="Grupo Cliente" FieldName="pGRUPO_CLIENTE" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDTENTRADA1" Area="DataArea" Caption="Data Entrada" FieldName="pDT_ENTRADA" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDIAENTRADA1" Area="DataArea" Caption="Dia Entrada" FieldName="pDIA_ENTRADA" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpMESENTRADA1" Area="DataArea" Caption="Mês Entrada" FieldName="pMES_ENTRADA" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpANOENTRADA1" Area="DataArea" Caption="Ano Entrada" FieldName="pANO_ENTRADA" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDESCONFINAN1" Area="DataArea" Caption="Desc.Financ. %" FieldName="pDESCON_FINAN" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpVALORDESCFINAN1" Area="DataArea" Caption="Desc.Financ. Valor" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric"  FieldName="pVALOR_DESC_FINAN" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpCUSTOPRODUTO1" Area="DataArea" Caption="Custo Produto" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pCUSTO_PRODUTO" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpCUSTOPRODQTD1" Area="DataArea" Caption="Custo Produto Qtd." CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pCUSTO_PROD_QTD" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpNROPEDIDOCLIENTE1" Area="DataArea" Caption="Número Pedido Cliente" FieldName="pNRO_PEDIDO_CLIENTE" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpPEDIDO1" Area="DataArea" Caption="Pedido" FieldName="pPEDIDO" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpENDERECOCLI1" Area="DataArea" Caption="Endereço Cliente" FieldName="pENDERECO_CLI" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpBAIRROCLIE1" Area="DataArea" Caption="Bairro Cliente" FieldName="pBAIRRO_CLIE" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpULTIMACOMPRA1" Area="DataArea" Caption="Última Compra" FieldName="pULTIMA_COMPRA" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpCIDADECLIENTEIBGE1" Area="DataArea" Caption="Cidade Cliente Ibge" FieldName="pCIDADE_CLIENTE_IBGE" Visible="False">
            </dx:PivotGridField>
            <dx:PivotGridField ID="calcPRECOMEDIOVENDA" Area="DataArea" Caption="Valor Preço Médio Venda" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" SummaryType="Custom"  visible="False" FieldName="teste">
            </dx:PivotGridField>
            <dx:PivotGridField ID="calcCUSTOPRODQTD" Area="DataArea" Caption="Custo Médio" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" SummaryType="Custom"  visible="False" FieldName="teste">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpTIPOMOV" Caption="Tipo Mov" FieldName="pTIPOMOV" Visible="true" AreaIndex="1">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDEVOL_NF_ORIGEM" Area="DataArea" Caption="NF Origem" FieldName="pDEVOL_NF_ORIGEM" Visible="false">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDEVOL_SERIE_ORIGEM" Area="DataArea" Caption="Serie NF Origem" FieldName="pDEVOL_SERIE_ORIGEM" Visible="false">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDEVOL_DESPESAS" Area="DataArea" Caption="DEVOL - Valor Despesas" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pDEVOL_DESPESAS" Visible="false">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDEVOL_TIPO_DOCTO" Area="DataArea" Caption="DEVOL - Tipo Doc" FieldName="pDEVOL_TIPO_DOCTO" Visible="false">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDEVOL_TIPO_DEVOLUCAO" Caption="DEVOL - Tipo Devolucao" FieldName="pDEVOL_TIPO_DEVOLUCAO" Visible="true" AreaIndex="1">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDEVOL_TP" Area="DataArea" Caption="DEVOL - TP" FieldName="pDEVOL_TP" Visible="false">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDEVOL_TES" Area="DataArea" Caption="DEVOL - TES" FieldName="pDEVOL_TES" Visible="false">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpDEVOL_MOTIVO_DEVOL" Area="DataArea" Caption="DEVOL - Mot. Devolução" FieldName="pDEVOL_MOTIVO_DEVOL" Visible="false">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpQUANTIDADE_VENDA" Area="DataArea" Caption="Quant. Venda" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pQUANTIDADE_VENDA" Visible="false">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpQUANTIDADE_DEVOL" Area="DataArea" Caption="Quant. Devolução" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pQUANTIDADE_DEVOL" Visible="false">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpVLR_TOTAL_PRODUTO_VENDA" Area="DataArea" Caption="Vl Total Produto Venda" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pVLR_TOTAL_PRODUTO_VENDA" Visible="false">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpVLR_TOTAL_PRODUTO_DEVOL" Area="DataArea" Caption="Vl Total Produto Devol" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pVLR_TOTAL_PRODUTO_DEVOL" Visible="false">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpVLR_TOTAL_NOTA_VENDA" AreaIndex="30" Caption="Vl Total Nota Venda" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pVLR_TOTAL_NOTA_VENDA" Visible="true">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpVLR_TOTAL_NOTA_DEVOL" AreaIndex="35" Caption="Vl Total Nota Devol" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pVLR_TOTAL_NOTA_DEVOL" Visible="true" >
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldpVALOR_FRETE_ITEM_SEQ_TOTAL" AreaIndex="40" Caption="Vl Frete" CellFormat-FormatString="{0:#,#0.00}" CellFormat-FormatType="Numeric" FieldName="pVALOR_FRETE_ITEM_SEQ_TOTAL" Visible="true" >
            </dx:PivotGridField>

        </Fields>
        <OptionsPager RowsPerPage="0">
        </OptionsPager>
    </dx:ASPxPivotGrid>
    <dx:LinqServerModeDataSource runat="server" ID="LinqServerModeDataSource1" ContextTypeName="AspNet5t.AviacaoVendasComDevolucaoBasedataclassDataContext" TableName="AviacaoVendasComDevolucaos"></dx:LinqServerModeDataSource>
    <asp:SqlDataSource ID="SqlDataSourceGridPivotAnalise" runat="server" ConnectionString="<%$ ConnectionStrings:s5taviacaoConnectionString %>" ProviderName="<%$ ConnectionStrings:s5taviacaoConnectionString.ProviderName %>" ></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:s5taviacaoConnectionString %>' />
    <dx:ASPxPivotGridExporter ID="ASPxPivotGridExporter1" runat="server" ASPxPivotGridID="ASPxPivotGrid1" Visible="False" />
</asp:Content>