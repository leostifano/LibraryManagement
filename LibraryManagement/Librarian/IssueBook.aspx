<%@ Page Title="" Language="C#" MasterPageFile="~/Librarian/LibrarianMaster.master" AutoEventWireup="true" CodeBehind="IssueBook.aspx.cs" Inherits="LibraryManagement.Librarian.IssueBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        ISSUE BOOK</p>
    <p>
        <asp:Button ID="btnRefresh" runat="server" Text="Refresh" />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        // on page load, show all books that are available</p>
    <p>
        &nbsp;</p>
    <p>
        Username:
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Choose a book:
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnIssue" runat="server" Text="Issue" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <br />
    <br />
</asp:Content>
