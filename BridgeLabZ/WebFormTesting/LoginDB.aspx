<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginDB.aspx.cs" Inherits="WebFormTesting.LoginDB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login Using DB</h1>
            <p> This login is through Database.</p>

        </div>
        <asp:Label ID="UserName" runat="server" Text="UserName"></asp:Label>
        <asp:TextBox ID="UserNameTxt" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Password" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="PasswordTxt" runat="server"></asp:TextBox>
        <br />
        
        <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" />
        <br />
        <asp:label ID="lblmsg" runat="server" ForeColor="red" />
    </form>
</body>
</html>
