<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="pink">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Text="Login Form"></asp:Label>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lbllogin" runat="server" Text="Login Name"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="lblerr" runat="server" Text=""></asp:Label></td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblpass" runat="server" Text="Password"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="lblerrpass" runat="server" Text=""></asp:Label></td>

                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnlogin" runat="server" Text="Submit" OnClick="btnlogin_Click" /></td>
                    <td colspan="2">
                        <asp:Label ID="lblerr2" runat="server" Text=""></asp:Label>
                    </td>

                </tr>
            </table>
        </div>
    </form>
</body>
</html>
