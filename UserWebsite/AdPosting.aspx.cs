using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserWebsite
{
    public partial class AdPosting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Session["username"]==null)
            {
                Session["flag"] = "1";
                Response.Redirect("WebForm7.aspx");
            }
            else
            {
                dml ob = new dml();
                string adid = ob.inc3();
                string userid = (string)Session["userid"];
                string extension = "";
                string extension1 = "";
            string id = Guid.NewGuid().ToString();
            if (FileUpload1.HasFile)
            {
                if (FileUpload1.PostedFile.ContentLength <= 2048000000)
                {

                    extension = id + Path.GetExtension(FileUpload1.FileName);

                    if (FileUpload1.PostedFile.ContentType == "image/jpeg")
                    {
                        //fileName = Path.GetFileName(FileUpload2.PostedFile.FileName);
                        FileUpload1.PostedFile.SaveAs(Server.MapPath("~/IMG/") + extension);
                    }
                }
            }
            string id1 = Guid.NewGuid().ToString();
            if (FileUpload2.HasFile)
            {
                if (FileUpload2.PostedFile.ContentLength <= 2048000000)
                {

                    extension1 = id1 + Path.GetExtension(FileUpload2.FileName);

                    if (FileUpload2.PostedFile.ContentType == "image/jpeg")
                    {
                        //fileName = Path.GetFileName(FileUpload2.PostedFile.FileName);
                        FileUpload2.PostedFile.SaveAs(Server.MapPath("~/IMG/") + extension1);
                    }
                }
            }
            ob.adpost_details(adid, userid, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, extension,extension1);
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            Response.Redirect("AdPosting.aspx");
            }
        }
    }
}