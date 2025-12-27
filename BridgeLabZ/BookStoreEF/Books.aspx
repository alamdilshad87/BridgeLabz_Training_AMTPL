<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Books.aspx.cs"
    Inherits="BookStoreEF.Books" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Books</title>
</head>
<body>
<form runat="server">

    <h2>Available Books</h2>

    <asp:GridView ID="gvBooks" runat="server"
        AutoGenerateColumns="False"
        DataKeyNames="BookId"
        OnRowCommand="gvBooks_RowCommand">

        <Columns>
            <asp:BoundField DataField="Title" HeaderText="Title" />
            <asp:BoundField DataField="Author" HeaderText="Author" />
            <asp:BoundField DataField="Price" HeaderText="Price" />

            <asp:ButtonField
                Text="Add to Cart"
                CommandName="AddToCart" />

            <asp:ButtonField
                Text="Wishlist ❤️"
                CommandName="AddToWishlist" />
        </Columns>
    </asp:GridView>

    <br />

    <asp:Button Text="View Cart"
        runat="server"
        OnClick="ViewCart_Click" />

    &nbsp;&nbsp;

    <asp:Button Text="View Wishlist"
        runat="server"
        OnClick="ViewWishlist_Click" />

    &nbsp;&nbsp;

    <asp:Button Text="Logout"
        runat="server"
        OnClick="Logout_Click" />

</form>
</body>
</html>
