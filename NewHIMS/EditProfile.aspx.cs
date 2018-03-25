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

namespace NewHIMS
{
    public partial class EditProfile : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uname"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            if (phone.Text != "" && email.Text != "")
            {
                cmd = new SqlCommand("update Register set Phone='"+phone.Text+"',Email='"+email .Text+"' where Uname='" + Session["uname"] + "'", con);
                con.Open();               
                cmd.Parameters.AddWithValue("@phone", phone.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.ExecuteNonQuery();
                
                lbl_msg.Text = "Profile updated";
                con.Close();
             
            }
            else
            {
                lbl_msg.Text = "Please enter correct Details";
            }
        }
    }
}