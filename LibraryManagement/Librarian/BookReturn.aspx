<%@ Page Title="" Language="C#" MasterPageFile="~/Librarian/LibrarianMaster.master" AutoEventWireup="true" CodeBehind="BookReturn.aspx.cs" Inherits="LibraryManagement.Librarian.BookReturn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        BOOK RETURN</p>
    <p>
        Id:
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnLoad" runat="server" Text="load" OnClick="btnLoad_Click" />
&nbsp;&nbsp;&nbsp; // enter username, load taken out books to grd, populate ddl with book names, return updates Rented column</p>
    <p>
        &nbsp;</p>
    <asp:GridView ID="gridBooks" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
    <br />
    <br />
    <asp:Button ID="btnReturn" runat="server" Text="Return" OnClick="btnReturn_Click" />
    <br />
    <br />
    <asp:Label runat="server" ID="lblMessage"></asp:Label>
</asp:Content>
