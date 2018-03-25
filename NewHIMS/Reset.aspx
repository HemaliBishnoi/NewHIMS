<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reset.aspx.cs" Inherits="NewHIMS.Reset" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="style1" align="center">
            <tr>
                <td class="style2">
                    New Password
                </td>
                <td>
                    <asp:TextBox ID="txtpwd" runat="server" Width="158px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Confirm Password
                </td>
                <td>
                    <asp:TextBox ID="txtcofrmpwd" runat="server" Width="158px" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidatorPassword" runat="server" ControlToCompare="txtpwd"
                        ControlToValidate="txtcofrmpwd" ErrorMessage="Password does not match" Font-Names="Rockwell"
                        ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;
                </td>
                <td>
                    <asp:Button ID="btnsubmit" runat="server" Text="Submit" Width="156px" OnClick="btnsubmit_Click" />
                </td>
            </tr>
        </table>
    </div>
        
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">Login</asp:HyperLink>

    </form>
</body>
</html>
