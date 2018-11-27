using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserWebsite
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        public static string name;
        protected void Page_Load(object sender, EventArgs e)
        {
            string flag;

            flag = (string)Session["flag"];
            if(flag=="1")
            {
                // href="#signup" 
                login1.Attributes["class"] = "tab active";
                login.Attributes.Remove("style");
                login.Attributes.Add("style", "display: block;");

                signup.Attributes.Remove("style");
                signup.Attributes.Add("style", "display: none;");



                //LinkButton1.PostBackUrl = "#login";
            }
            else
            {
                sign.Attributes["class"] = "tab active";
                signup.Attributes.Remove("style");
                signup.Attributes.Add("style", "display: block;");

                login.Attributes.Remove("style");
                login.Attributes.Add("style", "display: none;");
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dml ob = new dml();
            DataTable dt = new DataTable();
            dt=ob.check(TextBox2.Text, TextBox1.Text); 
            if(dt.Rows.Count>0)
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                Session["username"] = dt.Rows[0]["FIRST_NAME"].ToString();
                Session["userid"] = dt.Rows[0]["USER_ID"].ToString();
                if(Session["url"]!=null)
                {
                    string url = (string)Session["url"];
                    
                    if(url=="http://localhost:52193/WebForm7.aspx")
                    {
                        Response.Redirect("WebForm2.aspx");
                    }
                    else if (Session["adpost"] != null)
                    {
                        Response.Redirect("AdPosting.aspx");
                    }
                    else
                    {
                        Response.Redirect(url);
                    }
                }
            }
            else
            {
                
            }
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            dml ob = new dml();
            DataTable dt = new DataTable();
            dt = ob.check1(TextBox4.Text);
            if(dt.Rows.Count>0)
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('UserName Alredy Exist!');", true);
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
            }
            else
            {
                string userid = ob.inc2();
                ob.user_details(userid, TextBox6.Text, TextBox5.Text, TextBox4.Text, TextBox3.Text);
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
            }
            

        }
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Forgot_Password.aspx");
        }
    }
}