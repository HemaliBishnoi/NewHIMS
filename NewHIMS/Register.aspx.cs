using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewHIMS
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void button1_Click(object sender, EventArgs e)
        {
            if (this.fileupload1.HasFile)
            {
                fileupload1.SaveAs(Server.MapPath("~/Image/" + this.fileupload1.FileName));
                string fileName = Path.GetFileName(this.fileupload1.PostedFile.FileName);
                Session["ImagePath"] = "Image/" + fileName;
            }
            Main code = new Main();
            code.Execute(@"insert into Register values('" + fname.Text + "','" + lname.Text + "','" + uname.Text + "','" + pwd.Text + "','" + phone.Text + "','" + email.Text + "','" + DropDownList1.SelectedValue + "','" + fileupload1.FileName + "','"+0+"')");
            code.Execute(@"insert into Login values('" + uname.Text + "','" + pwd.Text + "')");
            Response.Redirect("Login.aspx");
        }
    }
}