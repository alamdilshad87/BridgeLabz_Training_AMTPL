<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BookStoreEF.Register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Registration</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label><br />
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label><br />
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br /><br />

            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="Register_Click" />

            <br /><br />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>

        </div>
    </form>
</body>
</html>
