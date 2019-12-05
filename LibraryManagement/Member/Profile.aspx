<%@ Page Title="" Language="C#" MasterPageFile="~/Member/MemberMaster.master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="LibraryManagement.Member.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Profile Picture:
        <asp:FileUpload ID="FileUpload1" runat="server" />
    </p>
    <p>
        Username:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Password:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </p>
</asp:Content>
