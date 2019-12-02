<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LibraryManagement.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/main.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 102px;
        }

        .auto-style2 {
            width: 376px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="login">
            <table class="auto-style2">
                <tr>
                    <th colspan="2">Login</th>
                </tr>

                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtUsername" runat="server" placeholder="Username"></asp:TextBox></td>
                </tr>

                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="Password: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" placeholder="Password"></asp:TextBox>
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
