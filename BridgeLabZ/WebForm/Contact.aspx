<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebForm.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>BridgeLabz</h3>
        <address>
            Tech Park 2<br />
            SRM Institute of Science and Technology<br />
            Kattankulathur, Chennai, Tamil Nadu<br />
            <abbr title="Phone">P:</abbr>
            +91 90067 19001
        </address>

        <address>
            <strong>Support:</strong>   <a href="mailto:ma8680@srmist.edu.in">ma8680@srmist.edu.in</a><br />
        </address>
    </main>
</asp:Content>
