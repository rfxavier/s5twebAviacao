<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="RelatoriosMobileAdmin.aspx.vb" Inherits="AspNet5t.RelatoriosMobileAdmin" %>
<%@ Register assembly="DevExpress.Web.v17.2, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolderMain" runat="server">
    <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="dsAppRelatorio" KeyFieldName="pId">
    <Columns>
        <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowNewButtonInHeader="True" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn FieldName="pId" ReadOnly="True" VisibleIndex="3" Visible="False">
            <EditFormSettings Visible="False" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="pNomeRelatorio" VisibleIndex="4" Caption="Nome Relat&#243;rio">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="pTituloRelatorio" VisibleIndex="5" Caption="T&#237;tulo Relat&#243;rio">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="pSequencia" VisibleIndex="6" Caption="Sequ&#234;ncia">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="pNomeFormArgumento" VisibleIndex="7" Caption="viewName Mobile App">
        </dx:GridViewDataTextColumn>
    </Columns>
        <SettingsPager PageSize="20">
        </SettingsPager>
</dx:ASPxGridView>
<asp:ObjectDataSource ID="dsAppRelatorio" runat="server" DataObjectTypeName="S5T.AppRelatorio" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="LoadAll" TypeName="S5T.AppRelatorioCollection" UpdateMethod="Save"></asp:ObjectDataSource>
</asp:Content>
