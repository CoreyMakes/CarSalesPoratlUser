using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
namespace UserWebsite
{
    public partial class Forgot_Password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dml ob=new dml();
            string email = TextBox1.Text;
            DataTable dt = new DataTable();
            dt = ob.check1(TextBox1.Text);
            if(dt.Rows.Count>0)
            {
                //send Mail
                using (MailMessage mm = new MailMessage("noeltoy@gmail.com", dt.Rows[0]["USER_NAME"].ToString()))
                {
                    mm.Subject = "Your CarSales Portal Password";
                    mm.Body = "Your password is: " + dt.Rows[0]["PASSWORD"].ToString();
                    mm.IsBodyHtml = false;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCred = new NetworkCredential("noeltoy@gmail.com","indiaismycountry");
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587;
                    smtp.Send(mm);
                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Email Sent.Please Check your Email');", true);
                    TextBox1.Text = "";
                }

            }
            else
            {
                Response.Write("<script>alert('Wrong Email Address');</script>");
            }
        }
    }
}