<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebFormVB_Adfs._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        <asp:Label ID="signedIn" runat="server" /></h1>
    <asp:Panel runat="server" ID="p"></asp:Panel>
    <table runat="server" id="sometabkle"></table>

    <%--<a href="https://adfs.clarionad.clariontech.com/adfs/ls/?wa=wsignout1.0&wreply=https://localhost:44303/FederationMetadata/test.aspx">Logout</a>--%>
</asp:Content>
