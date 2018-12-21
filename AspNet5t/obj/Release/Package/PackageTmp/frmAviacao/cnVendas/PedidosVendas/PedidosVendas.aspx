<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="PedidosVendas.aspx.vb" Inherits="AspNet5t.PedidosVendas" %>

<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolderMain" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolderMain" runat="server">
        <div class="buttonsToolbar">
            <dx:ASPxButton ID="btnExcluir" runat="server" Text="Excluir" ImagePosition="Top" BackColor="White" theme="PlasticBlue">
            <Image IconID="edit_delete_32x32">
            </Image>
            <Border BorderStyle="None" />
        </dx:ASPxButton>
        <dx:ASPxButton ID="btnSalvar" runat="server" Text="Salvar" ImagePosition="Top" BackColor="White" UseSubmitBehavior="False" theme="PlasticBlue">
            <ClientSideEvents Click="OnSumbitButtonClick" />
            <Image IconID="save_saveto_32x32">
            </Image>
            <Border BorderStyle="None" />
        </dx:ASPxButton>
        <dx:ASPxButton ID="btnDesistir" runat="server" Text="Desistir" ImagePosition="Top" BackColor="White" theme="PlasticBlue">
            <Image IconID="actions_cancel_32x32">
            </Image>
            <Border BorderStyle="None" />
        </dx:ASPxButton>
        <dx:ASPxButton ID="btnSair" runat="server" Text="Sair" ImagePosition="Top" BackColor="White" theme="PlasticBlue">
            <Image IconID="navigation_backward_32x32">
            </Image>
            <Border BorderStyle="None" />
        </dx:ASPxButton>
         <dx:ASPxButton runat="server" Text="Pesquisar" ID="btnPesquisar" ImagePosition="Top" theme="plasticblue"  BackColor="White" AutoPostBack="false">
              <Image IconID="find_findcustomers_32x32"> 
              </Image>
               <Border BorderStyle="None" />
         </dx:ASPxButton>
    </div>
   <div>
        <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="2" Width="100%" ClientInstanceName="PageControl" Theme="moderno">
            <TabPages>
                
                <dx:TabPage Name="tabDados1" Text="DADOS DO PEDIDO DO CLIENTE">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
    <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" ColCount="6" Width="100%">
        <Items>
            <dx:LayoutItem Caption="CLIENTE" RowSpan="1" ColSpan="4" Width="70%">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxComboBox runat="server" ID="ASPxFormLayout1_E1" Theme="Moderno" Width="100%"></dx:ASPxComboBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
                <HelpTextSettings Position="top"></HelpTextSettings>
                <CaptionSettings Location="Top"></CaptionSettings>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="LOJA" RowSpan="1" ColSpan="1" Width="10%">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxTextBox runat="server" ID="ASPxFormLayout1_E6" Theme="Moderno" Width="100%"></dx:ASPxTextBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
                <HelpTextSettings Position="top"></HelpTextSettings>
                <CaptionSettings Location="Top"></CaptionSettings>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="DATA EMISS&#195;O" VerticalAlign="Top" Width="20%">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxDateEdit runat="server" Width="100%" Theme="Moderno" ID="ASPxFormLayout1_E2"></dx:ASPxDateEdit>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
                <HelpTextSettings Position="top"></HelpTextSettings>
                <CaptionSettings Location="Top"></CaptionSettings>
                <CaptionCellStyle>
                    <BackgroundImage VerticalPosition="top"></BackgroundImage>
                </CaptionCellStyle>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="VENDEDOR" VerticalAlign="Top" ColSpan="5" Width="80%">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxComboBox runat="server" Width="100%" Theme="Moderno" ID="ASPxFormLayout1_E3"></dx:ASPxComboBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
                <HelpTextSettings Position="Top"></HelpTextSettings>
                <CaptionSettings Location="Top"></CaptionSettings>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="COMISSAO" VerticalAlign="Top" Width="20%">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxTextBox runat="server" Width="100%" Theme="Moderno" ID="ASPxFormLayout1_E5"></dx:ASPxTextBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
                <HelpTextSettings Position="top"></HelpTextSettings>
                <CaptionSettings Location="Top"></CaptionSettings>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="PRODUTO" VerticalAlign="Top" ColSpan="3" Width="60%">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxComboBox runat="server" ID="ASPxFormLayout1_E4" Theme="Moderno" Width="100%"></dx:ASPxComboBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
                <HelpTextSettings Position="Top"></HelpTextSettings>
                <CaptionSettings Location="Top"></CaptionSettings>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="QUANTIDADE" VerticalAlign="Top" ColSpan="1" Width="10%">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxTextBox runat="server" ID="ASPxFormLayout1_E7"  Theme="Moderno" Width="100%"></dx:ASPxTextBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
                <HelpTextSettings Position="Top"></HelpTextSettings>
                <CaptionSettings Location="Top"></CaptionSettings>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="VALOR UNITÁRIO" VerticalAlign="Top" ColSpan="1" Width="10%">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxTextBox runat="server" ID="ASPxTextBox1"  Theme="Moderno" Width="100%"></dx:ASPxTextBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
                <HelpTextSettings Position="Top"></HelpTextSettings>
                <CaptionSettings Location="Top"></CaptionSettings>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="VALOR TOTAL" VerticalAlign="Top" ColSpan="1" Width="10%">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxTextBox runat="server" ID="ASPxTextBox2"  Theme="Moderno" Width="100%"></dx:ASPxTextBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
                <HelpTextSettings Position="Top"></HelpTextSettings>
                <CaptionSettings Location="Top"></CaptionSettings>
            </dx:LayoutItem>
            <dx:LayoutItem ShowCaption="False" ColSpan="6" HorizontalAlign="Center" Width="100%">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxButton runat="server" text="CLIQUE AQUI PARA INSERIR O PRODUTO NO GRID" ID="ASPxFormLayout1_E9" Theme="Moderno" Width="100%"></dx:ASPxButton>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
                <HelpTextSettings Position="Top" HorizontalAlign="Right"></HelpTextSettings>
                <Paddings PaddingTop="10px"></Paddings>
            </dx:LayoutItem>
            <dx:LayoutItem ColSpan="6" ShowCaption="False" Width="100%">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxGridView ID="ASPxGridView1" runat="server" Theme="Moderno" Width="100%"></dx:ASPxGridView>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>

        </Items>
    </dx:ASPxFormLayout>
                                                    </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>

                 <dx:TabPage Name="tabDash" Text="ANÁLISE DAS ÚLTIMAS VENDAS DO CLIENTE">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                         </dx:ContentControl>
        </ContentCollection>
                </dx:TabPage>

            </TabPages>
        </dx:ASPxPageControl>
    </div>
</asp:Content>
