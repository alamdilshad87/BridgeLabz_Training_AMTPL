<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="SeedBooks.aspx.cs"
    Inherits="BookStoreEF.SeedBooks" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Seed Books</title>
</head>
<body>
<form runat="server">
    <asp:Button ID="btnSeed"
        runat="server"
        Text="Add Sample Books"
        OnClick="btnSeed_Click" />
    <br /><br />
    <asp:Label ID="lblMsg" runat="server" />
</form>
</body>
</html>
