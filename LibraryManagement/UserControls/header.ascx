<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="header.ascx.cs" Inherits="LibraryManagement.UserControls.header" %>

<link href="../styles/main.css" rel="stylesheet" />
<div id="header">
    Search For Books<br />
    <asp:Button ID="btnHome" runat="server" Text="Home" style="margin-right: 199px" CssClass="btnhome" />
    <asp:DropDownList ID="ddlSearchBy" runat="server" style="margin-left: 0px">
        <asp:ListItem>Title </asp:ListItem>
        <asp:ListItem>Author</asp:ListItem>
        <asp:ListItem>Publisher</asp:ListItem>
        <asp:ListItem>Genre</asp:ListItem>
    </asp:DropDownList>
    <asp:TextBox  ID="txtSearchBar" runat="server" Width="148px"></asp:TextBox>
    <asp:ImageButton ID="btnSearch" runat="server" BorderColor="#003300"
        BorderStyle="Solid" BorderWidth="1px"
        ImageUrl="~/Resources/search.png" Width="25px" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnLogout" runat="server" style="margin-left: 194px" Text="Logout" />
</div>
