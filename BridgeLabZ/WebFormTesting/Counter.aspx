<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Counter.aspx.cs" Inherits="WebFormTesting.Counter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Counter App</h1>
            <p>This is a Simple Counter Form.</p>

        </div>
        <asp:Label ID="Count" runat="server" Text="0"></asp:Label>
        <p>
            <asp:Button ID="Add" runat="server" Text="Add" OnClick="Add_Click" />
        </p>
    </form>
</body>
</html>
