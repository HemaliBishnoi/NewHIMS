using System;
using System.Collections.Generic;
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