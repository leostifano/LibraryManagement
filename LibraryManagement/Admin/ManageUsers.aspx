<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ManageUsers.aspx.cs" Inherits="LibraryManagement.Admin.ModifyUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderAside" runat="server">
    <p>
    <asp:Button ID="btnManageBooks" runat="server" Text="Manage Books" Width="182px" Height="30px" />
    </p>
    <p>
    <asp:Button ID="btnAddBook" runat="server" Text="Add User" Width="182px" Height="30px" />
    </p>
    <p>
    <asp:Button ID="btnUpdateSelected" runat="server" Text="Update User" Width="182px" Height="30px" />
    </p>
    <p>
    <asp:Button ID="btnDeleteSelected" runat="server" Text="Delete User" Width="182px" Height="30px" />
        <br />
    </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
</asp:Content>
