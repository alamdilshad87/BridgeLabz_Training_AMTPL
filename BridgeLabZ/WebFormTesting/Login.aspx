<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebFormTesting.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login Form</h1>
            <p>This is a Simple Login Page.</p>

        </div>
        <asp:Label ID="username" runat="server" Text="username"></asp:Label>
        <asp:TextBox ID="UserTxt" runat="server"></asp:TextBox>
        </br>
        <asp:Label ID="Password" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="PasswordTxt" runat="server"></asp:TextBox>
        </br>
        <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click" />
        </br>
        <asp:Label ID="lblmsg" runat="server" ForeColor="Red" />
        

    </form>
</body>
</html>
