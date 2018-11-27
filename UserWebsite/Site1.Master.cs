using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserWebsite
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public static string url;
        protected void Page_Load(object sender, EventArgs e)
        {
            url = HttpContext.Current.Request.Url.AbsoluteUri;
            Session["url"] = url;
            if (!IsPostBack)
            {
                dml ob = new dml();
                DropDownList1.DataSource = ob.getcolordetails();
                DropDownList2.DataSource = ob.getmodeldetails();
                DropDownList3.DataSource = ob.getpricedetails();
                DropDownList1.DataTextField = "COLOR_NAME";
                DropDownList2.DataTextField = "MODEL_NAME";
                DropDownList3.DataTextField = "PRICE";
                DropDownList1.DataValueField = "COLOR_NAME";
                DropDownList2.DataValueField = "MODEL_NAME";
                DropDownList3.DataValueField = "PRICE";
                DropDownList1.DataBind();
                DropDownList2.DataBind();
                DropDownList3.DataBind();
            }
            if (Session["username"]!=null)
            {
                //Response.ClearHeaders();
                //Response.AddHeader("Cache-Control", "no-cache, no-store, max-age=0, must-revalidate");
                //Response.AddHeader("Pragma", "no-cache");
                LinkButton12.Visible = true;
                LinkButton4.Visible = false;
                LinkButton5.Visible = false;
                LinkButton10.Visible = true;
                LinkButton8.Visible = true;
                Label1.Text = "Welcome" + " " + Session["username"].ToString();
            }
            else
            {
                LinkButton12.Visible = false;
                LinkButton10.Visible = false;
                LinkButton4.Visible = true;
                LinkButton5.Visible = true;
                LinkButton8.Visible = false;
                Label1.Text = "";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm8.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session["flag"] = "0";
            Response.Redirect("WebForm7.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Session["flag"] = "1";
            Response.Redirect("WebForm7.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {

            Session.RemoveAll();
            Session.Abandon();
            Session.Clear();
            Response.Redirect("WebForm2.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            string userid = (string)Session["userid"];
            if (Session["username"] != null)
            {
                Response.Redirect("Posted_Ads.aspx?userid=" + userid);
            }
            else
            {
                Response.Redirect("WebForm7.aspx");
            }
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdView.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            string userid = (string)Session["userid"];
            if(userid!=null)
            {
                Response.Redirect("Booked.aspx?userid=" + userid);
            }
            else
            {
                Response.Redirect("WebForm7.aspx");
            }
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                Response.Redirect("AdPosting.aspx");
            }
            else
            {
                Session["flag"] = "1";
                Session["adpost"] = "1";
                Response.Redirect("WebForm7.aspx");
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("New_Cars.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("New_Cars.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contacts.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["search1"] = DropDownList1.SelectedValue.ToString();
            
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["search2"] = DropDownList2.SelectedValue.ToString();
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["search3"] = DropDownList3.SelectedValue.ToString();
        }
    }
}