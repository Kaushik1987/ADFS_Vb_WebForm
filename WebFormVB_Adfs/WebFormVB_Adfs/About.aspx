<%@ Page Title="About" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.vb" Inherits="WebFormVB_Adfs.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <p>Your app description page.</p>
    <p>Use this area to provide additional information.</p>
     <asp:Label runat="server" ID="lbl"></asp:Label>
    <br />
    <br />
    <asp:TextBox runat="server" CssClass="form-control" ID="claimkey"></asp:TextBox>
    <asp:TextBox runat="server" CssClass="form-control" ID="txtclaimvalue"></asp:TextBox>
    <br />
    <asp:Button runat="server" OnClick="CheckClaim" Text="validate" />
</asp:Content>
