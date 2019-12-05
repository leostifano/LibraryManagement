<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="ManageBooks.aspx.cs" Inherits="LibraryManagement.Admin.ManageBooks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="margin-left: 40px">
        BookID:
        <asp:TextBox ID="txtBookID" runat="server"></asp:TextBox>
&nbsp;</p>
    <p style="margin-left: 40px">
        Title:
        <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 40px">
        Author:
        <asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 40px">
        Genre:
        <asp:TextBox ID="txtGenre" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 40px">
        Publisher:
        <asp:TextBox ID="txtPublisher" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 40px">
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </p>
    <p>
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAddBook" runat="server" Text="Add Book" Width="182px" Height="30px" OnClick="btnAddBook_Click"/>
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" Text="Delete Book" Width="182px" Height="30px" OnClick="btnDelete_Click"/>
        &nbsp;&nbsp;
        <asp:Button ID="btnUpdateSelected" runat="server" Text="Modify Book" Width="182px" Height="30px" OnClick="btnUpdateSelected_Click"/>
    &nbsp;&nbsp;
    </p>
    <p>
        <asp:GridView ID="grdBooks" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
</asp:Content>
