<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NewHIMS.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>Login Page</h2>
        <table>
            <tr>
                <td>
                    <asp:Label ID="label1" runat="server" Text="Username"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="uname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="label2" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="pwd" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Forgetpwd.aspx">Forget Password</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="button1" runat="server" Text="Login" OnClick="button1_Click" />
                </td>
                <td>
                    <asp:Button ID="button2" runat="server" Text="Cancel" />
                </td>
                <td>
                     <asp:Label ID="Label3" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                </td>
               
            </tr>
        </table>
        Click
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx">Here</asp:HyperLink>
        to register
        <br />
        <asp:HyperLink ID="href1" runat="server" NavigateUrl="~/Forgetpwd.aspx" >Click to recieve reset link</asp:HyperLink>
    </div>
    </form>
</body>
</html>
