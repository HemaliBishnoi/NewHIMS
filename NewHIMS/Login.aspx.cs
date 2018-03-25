using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace NewHIMS
{
    public partial class Login : System.Web.UI.Page
    {
        public static string IP = "";
        public static string Role = "";
        public static string Uname = "";
        SqlConnection con = Main.GetDBConnection();
        private void getIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    IP = ip.ToString();
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void button1_Click(object sender, EventArgs e)
        {
            string login = "Login";
            string status = "Active";
            Main code = new Main();
            string sqlRole = "select Role from Register where Uname='" + Convert.ToString(uname.Text) + "' and Password='" + Convert.ToString(pwd.Text) + "'";
            Role = code.Converter_string(sqlRole).ToString();
            if (Role != "")
            {
                string sqlUname = "select Uname from Register where Role='" + Convert.ToString(Role) + "'";
                Uname = code.Converter_string(sqlUname).ToString();
                code.Execute(@"insert into Log values('" + Convert.ToString(uname.Text) + "','" + DateTime.Now + "','" + login + "','" + IP + "','" + status + "','" + Role + "')");
            }
            try
            {
                SqlConnection con = Main.GetDBConnection();
                SqlCommand cmd = new SqlCommand("CheckUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("uname", uname.Text);
                SqlParameter p2 = new SqlParameter("password", pwd.Text);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    Label3.Text = "Login successful.";
                    Response.Redirect("UserProfile.aspx");
                }

                else
                {
                    Label3.Text = "Invalid username or password.";

                }
            }
            catch
            {
                throw;
            }
            Session["uname"] = uname.Text;

        }
    }
}