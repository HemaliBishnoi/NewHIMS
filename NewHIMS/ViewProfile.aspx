<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="NewHIMS.ViewProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Profile</h1>
        <table border="1" style="border-collapse: collapse"  cellspacing="1">
            <tr>
              <td width="77" height="16" align="left" ><b><font size="2" color="red">First Name:</font></b></td>
              <td width="77" height="16" align="left" ><b><font size="2">&nbsp;<asp:Label 
                     ID="lbl_UserName" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>
            </tr>
            <tr>
              <td width="77" height="16" align="left" ><b><font size="2" color="red">Last Name:</font></b></td>
              <td width="77" height="16" align="left" ><b><font size="2">&nbsp;<asp:Label 
                     ID="Label1" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>
            </tr>
            <tr>
              <td width="77" height="16" align="left" ><b><font size="2" color="red">UserName:</font></b></td>
              <td width="77" height="16" align="left" ><b><font size="2">&nbsp;<asp:Label 
                     ID="Label2" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>
            </tr>
            <tr>
              <td width="77" height="16" align="left" ><b><font size="2" color="red">Email Id:</font></b></td>
              <td width="77" height="16" align="left" ><b><font size="2">&nbsp;<asp:Label 
                     ID="Label3" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>
            </tr>
            <tr>
              <td width="77" height="16" align="left" ><b><font size="2" color="red">First Name:</font></b></td>
              <td width="77" height="16" align="left" ><b><font size="2">&nbsp;<asp:Label 
                     ID="Label4" runat="server" Font-Bold="True"></asp:Label><br /></font></b></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
