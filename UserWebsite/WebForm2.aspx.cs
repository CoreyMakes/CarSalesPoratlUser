using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserWebsite
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public static string username;
        public static string userid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //username = (string)Session["username"];
                //userid = (string)Session["userid"];
                dml ob=new dml();
                DataTable dt = new DataTable();
                dt= ob.sliderimages();
                if(dt.Rows.Count>0)
                {

                    img1.Src = "http://localhost:49447/Images/" + dt.Rows[0]["PICTURE1"].ToString();
                    img2.Src = "http://localhost:49447/Images/" + dt.Rows[0]["PICTURE2"].ToString();
                    img3.Src = "http://localhost:49447/Images/" + dt.Rows[0]["PICTURE3"].ToString();
                    img4.Src = "http://localhost:49447/Images/" + dt.Rows[0]["PICTURE4"].ToString();
                }
                DataList1.DataSource = ob.getmodeldetails();
                DataList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string s = ((Button)(sender)).CommandArgument.ToString();
            Button bt = (Button)sender;
            string s = bt.CommandName;
            //Session["username1"] = username;
            //Session["userid1"] = userid;
            Response.Redirect("WebForm3.aspx?modelid=" + s);
        }
    }
}