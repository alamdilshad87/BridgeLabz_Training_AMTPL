<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Wishlist.aspx.cs"
    Inherits="BookStoreEF.WishlistPage" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Wishlist</title>
</head>
<body>
<form runat="server">

    <h2>My Wishlist ❤️</h2>

    <asp:GridView ID="gvWishlist" runat="server"
        AutoGenerateColumns="False"
        DataKeyNames="WishlistId"
        OnRowCommand="gvWishlist_RowCommand">

        <Columns>
            <asp:BoundField DataField="Title" HeaderText="Book" />
            <asp:BoundField DataField="Author" HeaderText="Author" />
            <asp:BoundField DataField="Price" HeaderText="Price" />

            <asp:ButtonField Text="Remove"
                CommandName="Remove" />
        </Columns>
    </asp:GridView>

    <br />

    <asp:Button Text="Back to Books"
        runat="server"
        OnClick="Back_Click" />

</form>
</body>
</html>
