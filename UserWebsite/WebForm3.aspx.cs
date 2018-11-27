using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserWebsite
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        public static string username;
        public static string userid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //username = (string)Session["username1"];
                //userid = (string)Session["userid1"];
                string modelid = Request.QueryString["modelid"];
                if(modelid!="")
                {
                    dml ob=new dml();
                    DataTable dt = new DataTable();
                    DataTable dt1 = new DataTable();
                    dt = ob.getModelPhotos(modelid);
                    dt1 = ob.getModelVideo(modelid);
                    if (dt1.Rows.Count > 0)
                    {
                        videoplayer.Src = dt1.Rows[0]["VIDEO_LINK"].ToString();
                    }
                    if (dt.Rows.Count > 0)
                    {
                        img1.Src = "http://localhost:49447/Images/" + dt.Rows[0]["MODEL_PHOTO1"].ToString();
                        img2.Src = "http://localhost:49447/Images/" + dt.Rows[0]["MODEL_PHOTO2"].ToString();
                        img3.Src = "http://localhost:49447/Images/" + dt.Rows[0]["MODEL_PHOTO3"].ToString();
                        img4.Src = "http://localhost:49447/Images/" + dt.Rows[0]["MODEL_PHOTO4"].ToString();
                      
                    }
                    DataList1.DataSource = ob.getsubmodeldetails(modelid);
                    DataList1.DataBind();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string s = bt.CommandName;
            //Session["username2"] = username;
            //Session["userid2"] = userid;
            Response.Redirect("WebForm4.aspx?submodelid=" + s);
        }
    }
}