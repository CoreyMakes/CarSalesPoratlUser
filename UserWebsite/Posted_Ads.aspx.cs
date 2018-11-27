using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserWebsite
{
    public partial class Posted_Ads : System.Web.UI.Page
    {
        public static string userid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                dml ob = new dml();
                DataTable dt = new DataTable();
                userid = Request.QueryString["userid"];
                dt = ob.get_posted_ads(userid);
                if(dt.Rows.Count>0)
                {
                    Label1.Text = "Your Ads";
                    DataList1.DataSource = dt;
                    DataList1.DataBind();
                }
                else
                {
                    Label1.Text = "Oops!!! Seems like you haven't posted any ads";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                Button bt = (Button)sender;
                string s = bt.CommandName;
                dml ob = new dml();
                ob.ad_delete(s);
                Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);
                //DataTable dt = new DataTable();
                //dt = ob.get_posted_ads(userid);
                //if (dt.Rows.Count > 0)
                //{
                //    Label1.Text = "Your Ads";
                //    DataList1.DataSource = dt;
                //    DataList1.DataBind();
                //}
                //else
                //{
                //    Label1.Text = "Oops!!! Seems like you haven't posted any ads";
                //}
            }
            else
            {
                Session["flag"] = "1";
                Response.Redirect("WebForm7.aspx");
            }
            

        }
    }
}