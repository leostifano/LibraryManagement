﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Member/MemberMaster.master" AutoEventWireup="true" CodeBehind="Fees.aspx.cs" Inherits="LibraryManagement.Member.Fees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Overdue fees:
        <asp:Label ID="lblOverdueFees" runat="server"></asp:Label>
&nbsp;
        <asp:Button ID="btnPayNow" runat="server" OnClick="btnPayNow_Click" Text="Pay Now" />
        </p>
    <p>
        Fee History:</p>
    <p>
        <asp:GridView ID="grdFeeHistory" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
    </p>
    <p>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </p>
</asp:Content>
