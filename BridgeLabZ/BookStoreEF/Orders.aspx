<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Orders.aspx.cs"
    Inherits="BookStoreEF.Orders" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Orders</title>
</head>
<body>
<form id="form1" runat="server">

    <h2>My Orders</h2>

    <asp:GridView ID="gvOrders" runat="server"
        AutoGenerateColumns="False"
        BorderWidth="1"
        CellPadding="8">

        <Columns>
            <asp:BoundField DataField="OrderId" HeaderText="Order ID" />
            <asp:BoundField DataField="OrderDate" HeaderText="Order Date"
                DataFormatString="{0:dd-MMM-yyyy}" />
            <asp:BoundField DataField="TotalAmount" HeaderText="Total Amount" />
        </Columns>

    </asp:GridView>

    <br />

    <asp:Button ID="btnBack"
        runat="server"
        Text="Back to Books"
        OnClick="Back_Click" />

    &nbsp;&nbsp;

    <asp:Button ID="btnLogout"
        runat="server"
        Text="Logout"
        OnClick="Logout_Click" />

</form>
</body>
</html>
