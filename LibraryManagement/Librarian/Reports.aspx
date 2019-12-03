<%@ Page Title="" Language="C#" MasterPageFile="~/Librarian/LibrarianMaster.master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="LibraryManagement.Librarian.Reports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        REPORTS</p>
    <p>
        All Books:
        <asp:Button ID="btnAllBooks" runat="server" Text="Show All Books" />
    </p>
    <p>
        All Books Taken Out:
        <asp:Button ID="btnShowAllIssued" runat="server" Text="Show All Issued Books" />
    </p>
    <p>
        Overdue Books:
        <asp:Button ID="btnOverdue" runat="server" Text="Show" />
    </p>
    <p>
        Show All [Categories]: <asp:DropDownList ID="ddlCategories" runat="server">
            <asp:ListItem>Author</asp:ListItem>
            <asp:ListItem>Publisher</asp:ListItem>
            <asp:ListItem>Genre</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:Button ID="Button1" runat="server" Text="Show" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="380px" Width="1042px">
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
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
