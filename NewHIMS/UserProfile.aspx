<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="NewHIMS.UserProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
   <table>
       <tr>
           <td>
               <asp:Image ID="img" runat="server" Width="100px" Height="100px" />
           </td>
       </tr>
       <tr>
           <td>
               <asp:Button ID="button1" runat="server" Text="Logout" OnClick="button1_Click" />
           </td>
       </tr>
       <tr>
           <td>
               <asp:Button ID="button2" runat="server" Text="Change Password" OnClick="changepwd_Click" />
           </td>
       </tr>
       <tr>
           <td>
               <asp:Button ID="button3" runat="server" Text="Edit Profile" OnClick="button3_Click" />
           </td>
       </tr>
   </table>
    </div>
    </form>
</body>
</html>
