<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LibraryManagement.Admin.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderAside" runat="server">
    <p>
    <asp:Button ID="btnManageUsers" runat="server" Text="Manage Users" Width="182px" Height="30px" />
    <br />
</p>
    <p>
    <asp:Button ID="btnAddBook" runat="server" Text="Add Book" Width="182px" Height="30px" />
</p>
    <p>
    <asp:Button ID="btnUpdateSelected" runat="server" Text="Update Selected Book" Width="182px" Height="30px" />
</p>
    <p>
    <asp:Button ID="btnDeleteSelected" runat="server" Text="Delete Selected Book" Width="182px" Height="30px" />
</p>
    <p>
        &nbsp;</p>
<p>
</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
</asp:Content>
