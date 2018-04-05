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
    public partial class Changepwd : System.Web.UI.Page
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
        protected void btn_update_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_npassword.Text != "")
                {

                    cmd = new SqlCommand("update Register set Password='" + txt_npassword.Text + "' where Uname='" + Session["uname"] + "'", con);

                    con.Open();
                    cmd.Parameters.AddWithValue("@password", txt_npassword.Text);
                    cmd.ExecuteNonQuery();
                    lbl_msg.Text = "Password Updated";
                    con.Close();
                }
                else
                {
                    lbl_msg.Text = "Please enter correct Current password";
                }
            }
            catch(Exception ex)
            {

                throw ex;
            }
        }
    }
}
/* 
        string str = null;
        SqlCommand com;
        byte up;
        
       
            
            con.Open();
            str = "select * from Login ";
            com = new SqlCommand(str, con);
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                if (txt_cpassword.Text == reader["Password"].ToString())
                {
                    up = 1;
                }
            }
            reader.Close();
            con.Close();
            if (up == 1)
            {
                //Main code = new Main();
                //  code.Execute(@"update Login set Password='"+Convert.ToString(txt_npassword.Text)+"' where Uname='" + Session["uname"] + "'");

                con.Open();
                str = "update Register set Password=@password where Uname='" + Session["uname"].ToString() + "'";
                com = new SqlCommand(str, con);
                com.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar, 20));
                com.Parameters["@password"].Value = txt_npassword.Text;
                com.ExecuteNonQuery();
                con.Close();
                lbl_msg.Text = "Password changed Successfully";
               // Response.Redirect("Login.aspx");
            }
            else
            {
                lbl_msg.Text = "Please enter correct Current password";
            }
            
        }*/