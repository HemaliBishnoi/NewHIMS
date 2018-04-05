<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Changepwd.aspx.cs" Inherits="NewHIMS.Changepwd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Current password" Width="120px" 
            Font-Bold="True" ForeColor="#996633"></asp:Label>
        <asp:TextBox ID="txt_cpassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txt_cpassword" 
            ErrorMessage="Please enter Current password"></asp:RequiredFieldValidator>
        <br />
        
         <asp:Label ID="Label2" runat="server" Text="New password"  Width="120px" 
            Font-Bold="True" ForeColor="#996633"></asp:Label>
        <asp:TextBox ID="txt_npassword" runat="server" TextMode="Password" onkeyup="CheckPasswordStrength(this.value)"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txt_npassword" ErrorMessage="Please enter New password"></asp:RequiredFieldValidator>
        <span id="password_strength"></span>
<script type="text/javascript">
    function CheckPasswordStrength(password) {
        var password_strength = document.getElementById("password_strength");

        //TextBox left blank.
        if (password.length == 0) {
            password_strength.innerHTML = "";
            return;
        }

        //Regular Expressions.
        var regex = new Array();
        regex.push("[A-Z]"); //Uppercase Alphabet.
        regex.push("[a-z]"); //Lowercase Alphabet.
        regex.push("[0-9]"); //Digit.
        regex.push("[$@$!%*#?&]"); //Special Character.

        var passed = 0;

        //Validate for each Regular Expression.
        for (var i = 0; i < regex.length; i++) {
            if (new RegExp(regex[i]).test(password)) {
                passed++;
            }
        }

        //Validate for length of Password.
        if (passed > 2 && password.length > 8) {
            passed++;
        }

        //Display status.
        var color = "";
        var strength = "";
        switch (passed) {
            case 0:
            case 1:
                strength = "Weak";
                color = "red";
                break;
            case 2:
                strength = "Good";
                color = "darkorange";
                break;
            case 3:
            case 4:
                strength = "Strong";
                color = "green";
                break;
            case 5:
                strength = "Very Strong";
                color = "darkgreen";
                break;
        }
        password_strength.innerHTML = strength;
        password_strength.style.color = color;
    }
</script>
        <br />
        
         <asp:Label ID="Label3" runat="server" Text="Confirm password" Width="120px" 
            Font-Bold="True" ForeColor="#996633"></asp:Label>
        <asp:TextBox ID="txt_ccpassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lbl_msg" runat="server"></asp:Label>
    
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="txt_ccpassword" 
            ErrorMessage="Please enter Confirm  password"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="txt_npassword" ControlToValidate="txt_ccpassword" 
            ErrorMessage="Password Mismatch"></asp:CompareValidator>

    </div>
        <asp:Button ID="btn_update" runat="server" Font-Bold="True" 
            BackColor="#CCFF99" onclick="btn_update_Click" 
        Text="Update" />
    <asp:Label ID="Label4" Font-Bold="True" BackColor="#FFFF66" ForeColor="#FF3300" runat="server" Text=""></asp:Label><br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">Login</asp:HyperLink>
    </form>
</body>
</html>
