<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="ManageUsers.aspx.cs" Inherits="LibraryManagement.Admin.ManageUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="margin-left: 40px">
    UserID:
    <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
<p style="margin-left: 40px">
    Username:
    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
</p>
<p style="margin-left: 40px">
    Password:
    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
</p>
<p style="margin-left: 40px">
    Role:
    <asp:DropDownList ID="ddlRole" runat="server">
        <asp:ListItem>Admin</asp:ListItem>
        <asp:ListItem>Librarian</asp:ListItem>
        <asp:ListItem>Member</asp:ListItem>
    </asp:DropDownList>
</p>
    <p style="margin-left: 40px">
        Max Books Issued:
        <asp:TextBox ID="txtMaxBooksIssued" runat="server"></asp:TextBox>
</p>
<p style="margin-left: 40px">
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
</p>
<p>
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnAddUser" runat="server" Text="Add User" Width="182px" Height="30px" OnClick="btnAddUser_Click" />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnDelete" runat="server" Text="Delete By UserID" Width="182px" Height="30px" OnClick="btnDeleteSelected0_Click" />
        &nbsp;&nbsp;
    <asp:Button ID="btnUpdateSelected" runat="server" Text="Modify User" Width="182px" Height="30px" OnClick="btnUpdateSelected_Click" />
    &nbsp;&nbsp;
</p>
<p>
    <asp:GridView ID="grdUsers" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</p>
<p>
    &nbsp;</p>
<br />
</asp:Content>
