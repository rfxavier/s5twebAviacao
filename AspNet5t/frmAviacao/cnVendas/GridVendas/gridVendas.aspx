<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="gridVendas.aspx.vb" Inherits="AspNet5t.gridVendas" %>

<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v17.2, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>
<%@ Register TagPrefix="dx" Namespace="DevExpress.Data.Linq" Assembly="DevExpress.Web.v17.2, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" %>
<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContentPlaceHolderMain" runat="server">
    <script type="text/javascript">
        function button1_Click(s, e) {
            if(grid.IsCustomizationWindowVisible())
                grid.HideCustomizationWindow();
            else
                grid.ShowCustomizationWindow();
            UpdateButtonText();
        }
        function grid_CustomizationWindowCloseUp(s, e) {
            UpdateButtonText();
        }
        function UpdateButtonText() {
            var text = grid.IsCustomizationWindowVisible() ? "Esconder" : "Mostrar";
            text += " Lista de Campos";
            button1.SetText(text);
        }
    </script>
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContentPlaceHolderMain" runat="server">
    <dx:ASPxButton runat="server" ID="button1" ClientInstanceName="button1" Text="Mostrar Lista de Campos"
        UseSubmitBehavior="false" AutoPostBack="false">
        <ClientSideEvents Click="button1_Click" />
    </dx:ASPxButton>
    <dx:ASPxButton ID="buttonSaveAs" ClientInstanceName="buttonSaveAs" runat="server" ToolTip="Exportar Excel" OnClick="buttonSaveAs_Click" Text="Exportar para Excel" />

    <dx:ASPxGridView ID="ASPxGridView1" runat="server" ClientInstanceName="grid" AutoGenerateColumns="False" EnableTheming="True" Theme="DevEx">
         <Settings ShowFilterBar="Visible" />
        <Settings ShowGroupPanel="True" />
        <ClientSideEvents CustomizationWindowCloseUp="grid_CustomizationWindowCloseUp" />
        <SettingsPager PageSize="12">
        </SettingsPager>
        <Settings ShowFilterRow="True" ShowFooter="True" ShowGroupFooter="VisibleIfExpanded" />
        <SettingsBehavior EnableCustomizationWindow="true" />
        <Columns>
            <dx:GridViewDataTextColumn FieldName="pNUMERO_NF" VisibleIndex="1" Caption="N&#250;mero NF"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pSERIE" VisibleIndex="2" Caption="S&#233;rie NF"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pCLIENTE" VisibleIndex="3" Visible="False" Caption="C&#243;d.Cliente"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pFILIAL" VisibleIndex="4" Visible="False" Caption="Filial"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pLOJA" VisibleIndex="5" Visible="False" Caption="Loja"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pNOME_CLIENTE" VisibleIndex="6" Caption="Nome Cliente"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pCIDADE_CLIENTE" VisibleIndex="7" Caption="Cidade Cliente"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pESTADO" VisibleIndex="8" Caption="UF Cliente"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pREGIAO" VisibleIndex="9" Caption="Regi&#227;o"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pPERCENT_DESCONTO" VisibleIndex="10" Visible="False" Caption="Percent.Desconto"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pPORCENT_COMISSAO" VisibleIndex="11" Visible="False" Caption="Porcent.Comiss&#227;o"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pCODIGO_VENDEDOR" VisibleIndex="12" Visible="False" Caption="C&#243;d.Vendedor"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pNOME_VENDEDOR" VisibleIndex="13" Visible="False" Caption="Nome Vendedor"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pCIDADE_VENDEDOR" VisibleIndex="14" Visible="False" Caption="Cidade Vendedor"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pVALOR_COMISSAO" VisibleIndex="15" Visible="False" Caption="Valor Comiss&#227;o"></dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn FieldName="pDATA_EMISSAO" VisibleIndex="16" Caption="Data Emiss&#227;o"></dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn FieldName="pDIA_EMISSAO" VisibleIndex="18" Visible="False" Caption="Dia Emiss&#227;o"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pMES_EMISSAO" VisibleIndex="19" Visible="False" Caption="M&#234;s Emiss&#227;o"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pMES_EXTENSO" VisibleIndex="20" Visible="False" Caption="M&#234;s Extenso"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pANO_EMISSAO" VisibleIndex="21" Visible="False" Caption="Ano Emiss&#227;o"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pTRIMESTRE" VisibleIndex="22" Visible="False" Caption="Trimestre"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pCODIGO_TRANSP" VisibleIndex="23" Visible="False" Caption="C&#243;digo Transp."></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pNOME_TRANSP" VisibleIndex="24" Visible="False" Caption="Nome Transp."></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pREDESPACHO" VisibleIndex="25" Visible="False" Caption="Redespacho"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pNOME_REDESPACHO" VisibleIndex="26" Visible="False" Caption="Nome Redespacho"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pPRODUTO" VisibleIndex="27" Visible="False" Caption="C&#243;d.Produto"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pGRUPO_PRODUTO" VisibleIndex="29" Visible="False" Caption="Grupo Produto"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pPESO_PRODUTO" VisibleIndex="30" Visible="False" Caption="Peso Produto"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pQTD_P_CAIXA" VisibleIndex="31" Visible="False" Caption="Qtde.P.Caixa"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pQTD_EM_CAIXA" VisibleIndex="32" Visible="False" Caption="Qtde.Em Caixa"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pPESO_TOTAL" VisibleIndex="33" Visible="False" Caption="Peso Total"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pPESO_BRUTO" VisibleIndex="34" Visible="False" Caption="Peso Bruto"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pDESCRICAO" VisibleIndex="35" Visible="False" Caption="Produto"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pQUANTIDADE" VisibleIndex="35" Visible="False" Caption="Quantidade">
                <PropertiesTextEdit DisplayFormatString="{0:#,#0.00}">
                </PropertiesTextEdit>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pDT_ENTRADA" VisibleIndex="54" Visible="False" Caption="Data Entrada"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pDIA_ENTRADA" VisibleIndex="55" Visible="False" Caption="Dia Entrada"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pMES_ENTRADA" VisibleIndex="56" Visible="False" Caption="M&#234;s Entrada"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pANO_ENTRADA" VisibleIndex="57" Visible="False" Caption="Ano Entrada"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pDESCON_FINAN" VisibleIndex="58" Visible="False" Caption="Descon. Finan."></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pCUSTO_PRODUTO" VisibleIndex="59" Visible="False" Caption="Custo Produto"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pCUSTO_PROD_QTD" VisibleIndex="60" Visible="False" Caption="Custo Produto Qtde."></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pNRO_PEDIDO_CLIENTE" VisibleIndex="61" Visible="False" Caption="N&#250;mero Pedido Cliente"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pPEDIDO" VisibleIndex="62" Visible="False" Caption="Pedido"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pENDERECO_CLI" VisibleIndex="63" Visible="False" Caption="Endere&#231;o Cliente"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pBAIRRO_CLIE" VisibleIndex="64" Visible="False" Caption="Bairro Cliente"></dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn FieldName="pULTIMA_COMPRA" VisibleIndex="65" Visible="False" Caption="&#218;ltima Compra"></dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn FieldName="pVLR_TOTAL_PRODUTO" VisibleIndex="36" Visible="False" Caption="Valor Total Produto"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pPRECO_DE_VENDA" VisibleIndex="37" Visible="False" Caption="Pre&#231;o de Venda"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pVLR_DESCONTO" VisibleIndex="38" Visible="False" Caption="Valor Desconto"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pVLR_BASE_ICM" VisibleIndex="39" Visible="False" Caption="Valor Base Icm"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pVLR_TOTAL_NOTA" VisibleIndex="40" Caption="Valor Total Nota">
                <PropertiesTextEdit DisplayFormatString="{0:#,#0.00}">
                </PropertiesTextEdit>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pVLR_SEM_ICMSST" VisibleIndex="41" Visible="False" Caption="Valor Sem Icms St"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pVLR_ICM" VisibleIndex="42" Visible="False" Caption="Valor Icms"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pVLR_COFINS" VisibleIndex="43" Visible="False" Caption="Valor Cofins"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pVLR_PIS" VisibleIndex="44" Visible="False" Caption="Valor Pis"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pPRECO_FORA_IMPOSTO" VisibleIndex="45" Visible="False" Caption="Pre&#231;o Fora Imposto"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pPRECO_FORA_IMPOSTO_UNIT" VisibleIndex="46" Visible="False" Caption="Pre&#231;o Fora Imposto Unit."></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pIMPOSTO_TOTAL_NOTA" VisibleIndex="47" Visible="False" Caption="Imposto Total Nota"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pCFOP" VisibleIndex="51" Visible="False" Caption="CFOP"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pMARCA" VisibleIndex="52" Visible="False" Caption="Marca"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pGRUPO_CLIENTE" VisibleIndex="53" Visible="False" Caption="Grupo Cliente"></dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="pCIDADE_CLIENTE_IBGE" VisibleIndex="71" Visible="False" Caption="Cidade Cliente Ibge"></dx:GridViewDataTextColumn>
        </Columns>
         <TotalSummary>
             <dx:ASPxSummaryItem FieldName="pVLR_TOTAL_NOTA" ShowInColumn="Valor Total Nota" SummaryType="Sum" DisplayFormat="{0:#,#0.00}" ValueDisplayFormat="{0:#,#0.00}" />
        </TotalSummary>
        <GroupSummary>
            <dx:ASPxSummaryItem FieldName="pVLR_TOTAL_NOTA" ShowInColumn="Valor Total Nota" ShowInGroupFooterColumn="Valor Total Nota" SummaryType="Sum" DisplayFormat="{0:#,#0.00}" ValueDisplayFormat="{0:#,#0.00}" />
        </GroupSummary>
        <Styles AdaptiveDetailButtonWidth="22"></Styles>
    </dx:ASPxGridView>
    <dx:LinqServerModeDataSource runat="server" ID="LinqServerModeDataSource1" ContextTypeName="AspNet5t.AviacaoVendasBasedataclassDataContext" TableName="AviacaoVendas"></dx:LinqServerModeDataSource>
    <dx:ASPxGridViewExporter ID="gridExport" runat="server" GridViewID="ASPxGridView1"></dx:ASPxGridViewExporter>
</asp:Content>
