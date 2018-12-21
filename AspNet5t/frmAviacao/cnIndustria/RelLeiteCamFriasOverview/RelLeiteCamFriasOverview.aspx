<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="RelLeiteCamFriasOverview.aspx.vb" Inherits="AspNet5t.RelLeiteCamFriasOverview" %>

<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register TagPrefix="dx" Namespace="DevExpress.XtraReports.Web" Assembly="DevExpress.XtraReports.v17.2.Web, Version=17.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" %>
<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContentPlaceHolderMain" runat="server">
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContentPlaceHolderMain" runat="server">
    <div style="float: left; margin-top:4px;">
        <span>Data Referência:</span>
    </div>
    <div style="float: left; margin-top:4px; margin-left:10px;">
        <dx:ASPxDateEdit ID="dataReferencia" runat="server" AllowNull="False" Width="120px" AllowUserInput="False"></dx:ASPxDateEdit>   
    </div>
    <div style="float: left; margin-left:10px;">
        <dx:ASPxButton ID="buttonPesquisar" runat="server" Text="Pesquisar"></dx:ASPxButton>             
    </div>
    <div>
        <dx:ASPxWebDocumentViewer runat="server" ID="ASPxWebDocumentViewer"></dx:ASPxWebDocumentViewer>

    </div>
</asp:Content>
