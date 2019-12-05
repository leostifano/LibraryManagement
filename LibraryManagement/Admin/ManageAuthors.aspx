<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="ManageAuthors.aspx.cs" Inherits="LibraryManagement.Admin.ManageAuthors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Select Author From List:
        <asp:ListBox ID="lstAuthors" runat="server"></asp:ListBox>
    </p>
    <p>
        New Name: <asp:TextBox ID="txtNew" runat="server"></asp:TextBox>
        <br />
    </p>
    <p>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnChange" runat="server" Text="Change Author" Width="182px" Height="30px" OnClick="btnChange_Click"/>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnDelete" runat="server" Text="Delete Author" Width="182px" Height="30px" OnClick="btnDelete_Click" />
    </p>
    <p>
        Note: This will modify all books with this author</p>
<p>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
</p>
    <p>
        &nbsp;</p>
    <p>
    </p>
</asp:Content>
