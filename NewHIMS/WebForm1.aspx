<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="NewHIMS.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
Time Zone offset: <span id="offset"></span>
</p>
 
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.min.js"></script>
 
<script type="text/javascript">
    function get_time_zone_offset() {
        var current_date = new Date();
        var gmt_offset = current_date.getTimezoneOffset() / 60;
        return gmt_offset;
    }

    $('#offset').html(get_time_zone_offset());
</script>
        <table>
            
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="IP Address:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Country:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>  
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="TimeZone"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>   
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Time:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
                </td>
            </tr>    
            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="TimeZone:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
                </td>
            </tr>         
            <tr>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="Current Time to UTC:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label12" runat="server" Text=""></asp:Label>
                </td>
            </tr>         
            <tr>
                <td>
                    <asp:Label ID="Label13" runat="server" Text="UTC to Current Time:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label14" runat="server" Text=""></asp:Label>
                </td>
            </tr>              
        </table>
        
        
    </div>
    </form>
</body>
</html>
