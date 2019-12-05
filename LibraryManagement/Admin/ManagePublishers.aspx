<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="ManagePublishers.aspx.cs" Inherits="LibraryManagement.Admin.ManagePublishers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Select Publisher From List:
        <asp:ListBox ID="lstPublishers" runat="server"></asp:ListBox>
    </p>
    <p>
        New Name: <asp:TextBox ID="txtNew" runat="server"></asp:TextBox>
        <br />
    </p>
    <p>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnChange" runat="server" Text="Change Publisher" Width="182px" Height="30px" OnClick="btnChange_Click"/>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnDelete" runat="server" Text="Delete Publisher" Width="182px" Height="30px" OnClick="btnDelete_Click" />
    </p>
    <p>
        Note: This will modify all books with this Publisher</p>
    <p>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
    </p>
</asp:Content>
