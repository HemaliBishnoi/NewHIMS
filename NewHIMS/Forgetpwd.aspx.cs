using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace NewHIMS
{
    public partial class Forgetpwd : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnsend_Click(object sender, EventArgs e)
        {
            try
            {

                Session["email"] = txtemail.Text;

                SqlDataAdapter adp = new SqlDataAdapter("select * from Register where Email=@email", con);
                con.Open();

                adp.SelectCommand.Parameters.AddWithValue("@email", txtemail.Text);

                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    SqlCommand cmd = new SqlCommand("Update Register set password_change_status=1 where Email='" + txtemail.Text + "'", con);

                    cmd.ExecuteNonQuery();


                    SendEmail();

                    lbresult.Text = "successfully sent reset link on  your mail ,please check once! Thank you.";
                    con.Close();

                    cmd.Dispose();

                    txtemail.Text = "";

                }
                else
                {

                    lbresult.Text = "Please enter vaild email ,please check once! Thank you.";

                }

            }

            catch (Exception ex)
            {

            }
        }
 private void SendEmail()
    {

        try
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("Hi,<br/> Click on below given link to Reset Your Password<br/>");
            sb.Append("<a href=http://localhost:9209/Reset.aspx?username=" + GetUserEmail(txtemail.Text));
            sb.Append("&email=" + txtemail.Text + ">Click here to change your password</a><br/>");
            MailMessage message = new System.Net.Mail.MailMessage("bishnoihemali@gmail.com", txtemail.Text.Trim(), "Reset Your Password", sb.ToString());

            SmtpClient smtp = new SmtpClient();

            smtp.Host = "smtp.gmail.com";

            smtp.Port = 587;

            smtp.Credentials = new System.Net.NetworkCredential("bishnoihemali@gmail.com", "hemali29");

            smtp.EnableSsl = true;

            message.IsBodyHtml = true;

            smtp.Send(message);

        }

        catch (Exception ex)
        {

        }
    }

    private string GetUserEmail(string Email)
    {
        SqlCommand cmd = new SqlCommand("select Email from Register WHERE Email=@email", con);
        cmd.Parameters.AddWithValue("@email", txtemail.Text);
        string username = cmd.ExecuteScalar().ToString();
        return username;
    }
}

}
    