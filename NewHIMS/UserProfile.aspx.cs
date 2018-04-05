using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewHIMS
{
    public partial class UserProfile : System.Web.UI.Page 
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uname"] == null)
            {
                string activity = "Session Timeout";
                string status = "Deactive";
                Main code = new Main();
                code.Execute(@"insert into Log values('" + Login.Uname + "','" + DateTime.Now + "','" + activity + "','" + Login.IP + "','" + status + "','" + Login.Role + "')");
                Response.Redirect("Login.aspx");
            }
            string text = Session["uname"].ToString();
            Response.Write("Welcome..!!" + text);
            if (!this.IsPostBack)
            {
                if (Session["ImagePath"] != null)
                {
                    this.img.ImageUrl = Session["ImagePath"].ToString();
                    
                }
            }
           
            /*SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Register where Uname='" + Session["uname"] + "'",con);
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            lbl_fname.Text = reader["Fname"].ToString();
            //cmd.Parameters.AddWithValue("@uname",uname);
           sqlDa.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                 //Where ColumnName is the Field from the DB that you want to display
                lbl_lname.Text = dt.Rows[0]["Lname"].ToString();
                lbl_uname.Text = dt.Rows[0]["Uname"].ToString();
                lbl_phone.Text = dt.Rows[0]["Phone"].ToString();
                lbl_email.Text = dt.Rows[0]["Email"].ToString();
            }
            reader.Close();
            con.Close();
               */
            

            
        }
        protected void button1_Click(object sender, EventArgs e)
        {
            string activity = "Logout";
            string status = "Deactive";
            Main code = new Main();
            code.Execute(@"insert into Log values('" + Login.Uname + "','" + DateTime.Now + "','" + activity + "','" + Login.IP + "','" + status + "','" + Login.Role + "')");
            Response.Redirect("Login.aspx");
        }

        protected void changepwd_Click(object sender, EventArgs e)
        {
            Response.Redirect("changepwd.aspx");
        }

        protected void button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditProfile.aspx");
        }

        
    }
}