<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forgetpwd.aspx.cs" Inherits="NewHIMS.Forgetpwd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center">
        <tr><td>Email:</td><td>
        <asp:TextBox ID="txtemail" runat="server" Width="150px"></asp:TextBox>

            <asp:RequiredFieldValidator ID="rfvemail" runat="server"

                ErrorMessage="Please Enter Email" ControlToValidate="txtemail"

                ForeColor="Red"></asp:RequiredFieldValidator>

            </td></tr>

        <tr><td>&nbsp;</td><td>

            <asp:Button ID="btnsend" runat="server" Text="Send" onclick="btnsend_Click" /></td></tr>

        <tr><td colspan="2">
            <asp:Label ID="lbresult" runat="server"></asp:Label>
            </td></tr>

        </table>
    </div>
    </form>
</body>
</html>
