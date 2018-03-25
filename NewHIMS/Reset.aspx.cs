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
    public partial class Reset : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Session["email"].ToString();
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string email = Session["email"].ToString();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Update Register set Password = '" + txtpwd.Text + "'where email= '" + email + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert ('your password has been successfully updated')</script>");
            txtpwd.Text = "";
            txtcofrmpwd.Text = "";

        }
    }
}