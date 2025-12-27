<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Cart.aspx.cs"
    Inherits="BookStoreEF.CartPage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Cart</title>
</head>
<body>
<form id="form1" runat="server">

    <h2>My Cart</h2>

    <asp:GridView ID="gvCart" runat="server"
        AutoGenerateColumns="False"
        DataKeyNames="CartId"
        BorderWidth="1"
        CellPadding="8">

        <Columns>
            <asp:BoundField DataField="Title" HeaderText="Book" />
            <asp:BoundField DataField="Price" HeaderText="Price" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
            <asp:BoundField DataField="Total" HeaderText="Total" />
        </Columns>

    </asp:GridView>

    <br />

    <asp:Label ID="lblTotal" runat="server"
        Font-Bold="true"
        Font-Size="Large" />

    <br /><br />

    <asp:Button ID="btnPlaceOrder"
        runat="server"
        Text="Place Order"
        OnClick="PlaceOrder_Click" />

    &nbsp;&nbsp;

    <asp:Button ID="btnBack"
        runat="server"
        Text="Back to Books"
        OnClick="Back_Click" />

</form>
</body>
</html>
