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

        .auto-style4 {
            height: 26px;
        }

        .auto-style5 {
            width: 102px;
            height: 29px;
        }

        .auto-style6 {
            height: 29px;
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
                    <td class="auto-style5">
                        <asp:Label ID="Label3" runat="server" Text="Password: "></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtPassword" runat="server" placeholder="Password"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td colspan="2" class="center">
                        <asp:Button ID="btnLogin" runat="server" BorderStyle="Ridge" Height="30px" OnClick="btnLogin_Click" Text="Login" Width="71px" />
                    </td>
                </tr>

                <tr>
                    <td class="auto-style4 center" colspan="2">
                        Dont have an account?
                        <asp:HyperLink ID="hlRegister" runat="server">Register</asp:HyperLink>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style4 center" colspan="2">
                        <asp:Label ID="lblMsg" runat="server" ForeColor="Red" Text="Username or Password is incorrect" Visible="False"></asp:Label>
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
