<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="cnCadastroVisitantes.aspx.vb" Inherits="AspNet5t.cnCadastroVisitantes" EnableEventValidation="false"%>

<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Data.Linq" TagPrefix="dx" %>

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
           .uppercase .dxeEditAreaSys
        {
            text-transform: uppercase;
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


       <%-- var pageUrl = '<%=ResolveUrl("~/frmAviacao/cnVisitas/CadastroVisitantes/cnCadastroVisitantes.aspx") %>';
         
        $(function () {
            jQuery("#webcam").webcam({
                width: 320,
                height: 240,
                mode: "save",
                swffile: '<%=ResolveUrl("~/Webcam_Plugin/jscam.swf") %>',
                debug: function (type, status) {
                    $('#camStatus').append(type + ": " + status + '<br /><br />');
                },
                onSave: function (data) {
                    $.ajax({
                        type: "POST",
                        url: pageUrl + "/GetCapturedImage",
                        data: '',
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (r) {
                            $("[id*=imgCapture]").css("visibility", "visible");
                            $("[id*=imgCapture]").attr("src", r.d);
                        },
                        failure: function (response) {
                            alert(response.d);
                        }
                    });
                },
                onCapture: function () {
                    webcam.save(pageUrl);
                }
            });
        });
        function Capture() {
            webcam.capture();
            return false;
        }--%>





     </script>    

</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolderMain" runat="server">
  

  


    <div style="width:100%; border: solid 1px groove; text-align: center; ">
        <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="CADASTRO DE VISITANTES" FONT-SIZE="X-Large" Font-Bold="true" BackColor="GradientActiveCaption" width="100%" ></dx:ASPxLabel>
    </div>
    <div>


        <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" Width="100%" ClientInstanceName="PageControl">
            <TabPages>

                <dx:TabPage Name="TabPesquisa" Text="PESQUISA">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            <div class="AlinhadoDireita">
                                <dx:ASPxButton runat="server" Text="FILTRAR" ID="btnPesquisar" ImagePosition="Top" Theme="Default"  BackColor="White" AutoPostBack="false" Visible="false">
                                    <Image IconID="filter_multiplemasterfilter_32x32">
                                    </Image>
                                    <Border BorderStyle="None" />
                                </dx:ASPxButton>
                            </div>
                                 <div>
        <dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server"  ClientInstanceName="pp" Width="100%" PopupElementID="btnPesquisar" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="Below" CssClass="popupresultado32" HeaderText="Filtro de Análise">
            <HeaderStyle Font-Size="Larger" Font-Bold="True" />
           <%-- <ClientSideEvents Init="AdjustSizePopUp" />--%>
            <ContentCollection>
                <dx:PopupControlContentControl runat="server"  >
                    <dx:ASPxFormLayout ID="ASPxFormLayoutPesq" runat="server" ColCount="4" Width="100%">
                        <Items>
                            <dx:TabbedLayoutGroup ColSpan="4" RowSpan="5" ClientInstanceName="tabbedGroupPageControlPesq" Width="100%" ShowGroupDecoration="False" HorizontalAlign="Center">
                                <ParentContainerStyle CssClass="tabbedGroupPageControlCell" />
                                <%--<ClientSideEvents Init="OnTabbedGroupPageControlInit" />--%>
                                <Items>
                                    <dx:LayoutGroup ColCount="3" Caption="" GroupBoxDecoration="None" Name="layoutPesq" VerticalAlign="Top" Width="100%" HorizontalAlign="Left" RowSpan="3">
                                        <Items>
                                            <dx:LayoutItem Caption="Data Saída - Período " ColSpan="1" VerticalAlign="Top" Width="34%">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxDateEdit runat="server" EditFormat="Date" Width="100%" Theme="Moderno" ID="mskDatSaidaIniPesq">
                                                        </dx:ASPxDateEdit>
                                                        <dx:ASPxDateEdit runat="server" EditFormat="Date" Width="100%" Theme="Moderno" ID="mskDatSaidaFinPesq">
                                                        </dx:ASPxDateEdit>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                                <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle">
                                                </CaptionSettings>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Data Prev. Ret. - Período" ColSpan="1" Width="33%">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxDateEdit runat="server" Width="100%" Theme="Moderno" ID="mskDatPrevIniPesq">
                                                        </dx:ASPxDateEdit>
                                                        <dx:ASPxDateEdit runat="server" Width="100%" Theme="Moderno" ID="mskDatPrevFinPesq">
                                                        </dx:ASPxDateEdit>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                                <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle">
                                                </CaptionSettings>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Data Retorno - Período" ColSpan="1" Width="33%">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxDateEdit runat="server" EditFormat="Date" Width="100%" Theme="Moderno" ID="mskDatRetornoIniPesq">
                                                        </dx:ASPxDateEdit>
                                                        <dx:ASPxDateEdit runat="server" EditFormat="Date" Width="100%" Theme="Moderno" ID="mskDatRetornoFinPesq">
                                                        </dx:ASPxDateEdit>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                                <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle">
                                                </CaptionSettings>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Motorista" Width="34%">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxComboBox runat="server" DropDownStyle="DropDown" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" Width="100%" ClientInstanceName="CmbMotoristaPesq" Theme="Moderno" ID="CmbMotoristaPesq">
                                                        </dx:ASPxComboBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                                <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle">
                                                </CaptionSettings>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Caminhão" Width="33%">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxComboBox runat="server" DropDownStyle="DropDown" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" Width="100%" ClientInstanceName="CmbCaminhaoPesq" Theme="Moderno" ID="CmbCaminhaoPesq">
                                                        </dx:ASPxComboBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                                <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle">
                                                </CaptionSettings>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Local/Linha" Width="33%">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxComboBox runat="server" DropDownStyle="DropDown" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" Width="100%" ClientInstanceName="CmbLocalLinhaPesq" Theme="Moderno" ID="CmbLocalLinhaPesq">
                                                        </dx:ASPxComboBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                                <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle">
                                                </CaptionSettings>
                                            </dx:LayoutItem>
                                           
                                             <dx:LayoutItem Caption="Dia Saída" Width="33%">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxComboBox runat="server" DropDownStyle="DropDown" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" Width="100%" ClientInstanceName="CmbDiaSaidaPesq" Theme="Moderno" ID="CmbDiaSaidaPesq">
                                                        </dx:ASPxComboBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                                <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle">
                                                </CaptionSettings>
                                            </dx:LayoutItem>
                                             <dx:LayoutItem Caption="Veículo" Width="33%">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxComboBox runat="server" DropDownStyle="DropDown" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" Width="100%" ClientInstanceName="CmbVeiculoPesq" Theme="Moderno" ID="CmbVeiculoPesq">
                                                        </dx:ASPxComboBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                                <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle">
                                                </CaptionSettings>
                                            </dx:LayoutItem>
                                             <dx:LayoutItem Caption="Somente Viagens em Aberto/Disponível" Width="67%" ColSpan="1">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxCheckBox ID="cbCaminhaoDisponivel" runat="server" AutoPostBack="false" Text="" Visible="True" />
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                                <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle">
                                                </CaptionSettings>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="" Width="100%" ColSpan="3">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxButton ID="buttonAplicarFiltro" ClientInstanceName="buttonAplicarFiltro" runat="server" ToolTip="PESQUISAR" OnClick="btnPesquisar_Click" Text="PESQUISAR" Theme="Moderno" Width="100%" Image-IconID="find_find_32x32"/>
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



                                <dx:ASPxGridView ID="gridPesquisa"  runat="server" AutoGenerateColumns="False" KeyFieldName="pId" Width="100%" EnableCallBacks="False" Theme="Office2010Silver" SettingsPager-Mode="ShowAllRecords">
                                        <Columns>
                                            <dx:GridViewDataHyperLinkColumn FieldName="pId" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
                                            </dx:GridViewDataHyperLinkColumn>                                                
                                            <dx:GridViewDataTextColumn Caption="Nome" FieldName="pNome" ShowInCustomizationForm="True" VisibleIndex="6" Width="395px">
                                            </dx:GridViewDataTextColumn>     
                                            <dx:GridViewDataTextColumn Caption="CPF" FieldName="pCpfCnpj" ShowInCustomizationForm="True" VisibleIndex="6" Width="95px">
                                            </dx:GridViewDataTextColumn>                                    
                                            <dx:GridViewDataTextColumn Caption="RG" FieldName="pRg" ShowInCustomizationForm="True" VisibleIndex="6" Width="95px">
                                            </dx:GridViewDataTextColumn>                                            
                                            <dx:GridViewDataTextColumn Caption="Cidade" FieldName="pCidadeNome" ShowInCustomizationForm="True" VisibleIndex="6" Width="295px">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="UF" FieldName="pCidadeUF" ShowInCustomizationForm="True" VisibleIndex="6" Width="95px">
                                            </dx:GridViewDataTextColumn>                                      
                                                                           
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

                <dx:TabPage Name="tabDados1" Text="DADOS DO VISITANTE">
                    <ContentCollection>
                        <dx:ContentControl runat="server">

                       


                            <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" ColCount="3" Width="100%" Height="143px">
                                <Items>

                                    <dx:TabbedLayoutGroup ColSpan="1" RowSpan="2" ClientInstanceName="tabbedGroupPageControl" Width="100%" ShowGroupDecoration="False">
                                        <ParentContainerStyle CssClass="tabbedGroupPageControlCell" />
                                        <%--<ClientSideEvents Init="OnTabbedGroupPageControlInit" />--%>
                                        <Items>
                                            <dx:LayoutGroup ColCount="3" Caption="" GroupBoxDecoration="None" Name="lgPF" VerticalAlign="Top" Width="100%" HorizontalAlign="Left" RowSpan="2" ColSpan="2">
                                                <Items>
                                                    <dx:LayoutItem Caption="NOME COMPLETO" Width="70%" Name="label1" ColSpan="2">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxTextBox ID="TxtNome" runat="server" Width="100%" Theme="Moderno" NullText="DIGITE O NOME COMPLETO DO VISITANTE" CssClass="uppercase"></dx:ASPxTextBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>
                                                                        
                                                    <dx:LayoutItem Caption="FOTO" Width="40%" Name="label1" ColSpan="1" RowSpan="7" VerticalAlign="Top">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                 <asp:Image ID="ImgFoto" runat="server"  />                                                                
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>
                                                    
                                                                                                                                       
                                                    <dx:LayoutItem Caption="SEXO" Width="40%" Name="label2" ColSpan="1">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxComboBox ID="cmbSexo" runat="server" Width="50%" Theme="Moderno" NullText="SELECIONE O SEXO"></dx:ASPxComboBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <CaptionSettings HorizontalAlign="Left" VerticalAlign="Middle"></CaptionSettings>
                                                    </dx:LayoutItem>

                                                    <dx:LayoutItem Caption="Nº HABILITAÇÃO" Name="label312" Width="30%" ColSpan="1">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxTextBox ID="TxtHABILITACAO" runat="server" Theme="Moderno" NullText="DIGITE O Nº HABILITAÇÃO" Width="100%">
                                                                </dx:ASPxTextBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>

                                                    <dx:LayoutItem Caption="CPF" Name="label4" Width="40%"  ColSpan="1">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxTextBox ID="TxtCPF" runat="server" Theme="Moderno" NullText="DIGITE O CPF" Width="50%">
                                                                </dx:ASPxTextBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>


                                                    <dx:LayoutItem Caption="RG" Name="label5" Width="30%"  ColSpan="1">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxTextBox ID="TxtRG" runat="server" Theme="Moderno" NullText="DIGITE O RG" Width="50%">
                                                                </dx:ASPxTextBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>
                                                    

                                                    <dx:LayoutItem Caption="TELEFONE FIXO" Name="label" Width="40%"  ColSpan="1">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxTextBox ID="TxtTELEFONE" runat="server" Theme="Moderno" NullText="DIGITE O TELEFONE" Width="50%">
                                                                </dx:ASPxTextBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>

                                                    <dx:LayoutItem Caption="TELEFONE CELULAR" Name="label6" Width="30%"  ColSpan="1">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxTextBox ID="TxtTELEFONECEL" runat="server" Theme="Moderno" NullText="DIGITE O TELEFONE" Width="50%">
                                                                </dx:ASPxTextBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>


                                                    <dx:LayoutItem Caption="ENDEREÇO" Name="label7" Width="40%"  ColSpan="1">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxTextBox ID="TxtENDERECO" runat="server" Theme="Moderno" CssClass="uppercase" NullText="DIGITE O ENDEREÇO" Width="100%">
                                                                </dx:ASPxTextBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>

                                                    <dx:LayoutItem Caption="NÚMERO" Name="label8" Width="30%"  ColSpan="1">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxTextBox ID="TxtNUMERO" runat="server" Theme="Moderno" NullText="DIGITE O NÚMERO" Width="60%">
                                                                </dx:ASPxTextBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>



                                                    <dx:LayoutItem Caption="COMPLEMENTO" Name="label9" Width="40%"  ColSpan="1">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxTextBox ID="TxtCOMPLEMENTO" runat="server" Theme="Moderno" CssClass="uppercase" NullText="COMPLEMENTO" Width="60%">
                                                                </dx:ASPxTextBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>

                                                    <dx:LayoutItem Caption="BAIRRO" Name="label10" Width="30%"  ColSpan="1">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxTextBox ID="TxtBAIRRO" runat="server" Theme="Moderno" CssClass="uppercase" NullText="DIGITE O BAIRRO" Width="60%">
                                                                </dx:ASPxTextBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>

                                                     <dx:LayoutItem Caption="CEP" Name="label12" Width="40%" ColSpan ="2" >
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxTextBox ID="TxtCEP" runat="server" Theme="Moderno" NullText="DIGITE O CEP" Width="50%">
                                                                </dx:ASPxTextBox>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>

                                                    <dx:LayoutItem Caption="CIDADE" Name="lablel11" Width="70%"  ColSpan="2">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                     <%--           <dx:ASPxComboBox ID="cmbCidade" runat="server" Theme="Moderno" NullText="DIGITE A CIDADE" Width="70%" FilterMinLength="3" IncrementalFilteringMode="StartsWith">
                                                                </dx:ASPxComboBox>--%>

                                                             
                                                               <dx:ASPxComboBox ID="cmbCidade"  NullText="DIGITE A CIDADE" runat="server" EnableCallbackMode="true" CallbackPageSize="10" ValueField="pId" TextField="pNome" 
                                                                    OnItemsRequestedByFilterCondition="ASPxComboBox_OnItemsRequestedByFilterCondition_SQL"
                                                                    OnItemRequestedByValue="ASPxComboBox_OnItemRequestedByValue_SQL" TextFormatString="{0} ({1})"
                                                                    Width="70%" DropDownStyle="DropDown" Theme="Moderno" ClientInstanceName="btnCidade">
                                                                    <Columns>
                                                                        <dx:ListBoxColumn FieldName="pNOME" Caption="Nome" Width="100%" />
                                                                        <dx:ListBoxColumn FieldName="pId" Caption="Id" Width="90px" />
                                                                    </Columns>
                                                                </dx:ASPxComboBox>


                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>

                                                   

                                                    <dx:LayoutItem Width="100%" Caption="" ColSpan="3">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer runat="server">
                                                                <dx:ASPxButton ID="btnSalvar" runat="server" Width="40%" Theme="Moderno" Text="SALVAR" AutoPostBack="False" AllowFocus="False">
                                                                </dx:ASPxButton>  
                                                                 <%--<dx:ASPxButton ID="btnTirarFoto" runat="server" Width="20%" Theme="moderno" Text="TIRAR FOTO" AutoPostBack="false" AllowFocus="False">
                                                                </dx:ASPxButton>--%>  
                                                                <dx:ASPxButton ID="btnExcluir" runat="server" Width="20%" Theme="moderno" Text="EXCLUIR" AutoPostBack="False" AllowFocus="False">
                                                                </dx:ASPxButton>
                                                                <dx:ASPxButton ID="btnLimpar" runat="server" Width="20%" Theme="moderno" Text="LIMPAR" AutoPostBack="False" AllowFocus="False">
                                                                </dx:ASPxButton>                                                            
                           
                                                                                                                           
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                        <BorderBottom BorderColor="Lime" />
                                                        <HelpTextStyle Font-Bold="True">
                                                        </HelpTextStyle>
                                                        <CaptionStyle Font-Bold="True">
                                                        </CaptionStyle>
                                                    </dx:LayoutItem>
                                                    

                                                </Items>
                                                <SettingsItemCaptions Location="Top" VerticalAlign="Top"></SettingsItemCaptions>
                                            </dx:LayoutGroup>
                                            <dx:LayoutGroup ColCount="2">
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
     <dx:LinqServerModeDataSource runat="server" ID="LinqServerModeDataSource1" ContextTypeName="AspNet5t.AviacaoCidadebasedataclassDataContext" TableName="Cidade"></dx:LinqServerModeDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:s5taviacaoConnectionString %>' />
</asp:Content>
