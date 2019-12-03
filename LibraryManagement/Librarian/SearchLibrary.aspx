<%@ Page Title="" Language="C#" MasterPageFile="~/Librarian/LibrarianMaster.master" AutoEventWireup="true" CodeBehind="SearchLibrary.aspx.cs" Inherits="LibraryManagement.Librarian.SearchLibrary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        SEARCH LIBRARY</p>
    <p>
        &nbsp;</p>
    <p>
        Search for:
        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
&nbsp;in
        <asp:DropDownList ID="ddlSearch" runat="server">
            <asp:ListItem>Title</asp:ListItem>
            <asp:ListItem>Author</asp:ListItem>
            <asp:ListItem>Publisher</asp:ListItem>
            <asp:ListItem>Genre</asp:ListItem>
        </asp:DropDownList>
        .&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSearch" runat="server" Text="Search" />
    </p>
    <p>
        // in title, author, publisher, genre, status, Rented</p>
</asp:Content>
