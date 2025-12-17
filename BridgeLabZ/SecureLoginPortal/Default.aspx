<%@ Page Title="Login"
    Language="C#"
    MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="SecureLoginPortal.Default" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2>Login</h2>

    <asp:TextBox ID="txtUsername" runat="server" />
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />

    <asp:Label ID="lblMsg" runat="server" />
</asp:Content>
