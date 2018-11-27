using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserWebsite
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        public static string modelid;
        public static string colorid;
        public static string submodelid;
        public static int bal;
        public static string username;
        public static string userid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                submodelid = Request.QueryString["submodelid"];
                string colorname = (string)Session["colorname"];
                colorid = (string)Session["colorid"];
                //username = (string)Session["username3"];
                //userid = (string)Session["userid3"];
                if(submodelid!="")
                {
                    dml ob = new dml();
                    modelid = ob.getmodel_id(submodelid);
                    DataTable dt = new DataTable();
                    dt = ob.getsubmodel_details(submodelid);
                    if (dt.Rows.Count > 0)
                    {
                        Image1.ImageUrl = "http://localhost:49447/Images/" + dt.Rows[0]["PICTURE"].ToString();
                        Label1.Text = dt.Rows[0]["SUBMODEL_NAME"].ToString();
                        Label4.Text = dt.Rows[0]["ADV_AMOUNT"].ToString();
                    }
                    Label6.Text = (string)colorname;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dml ob = new dml();
            if(Session["username"]==null)
            {
                Session["flag"] = "1";
                //Session["temp"] = HttpContext.Current.Request.Url.AbsoluteUri;
                Response.Redirect("WebForm7.aspx");
      
            }
            else
            {
                //ob.booking_details(bookingid,userid ,modelid, colorid, submodelid, System.DateTime.Today, price, "T", bal_a);
                string bookingid = ob.inc1();
                string price = ob.getprice(modelid, submodelid, colorid);
                bal = Int32.Parse(price) - Int32.Parse(Label4.Text);
                string bal_a = Convert.ToString(bal);
                string j = username;
                Session["submodel_id"] = submodelid;
                Session["colorid"] = colorid;
                Session["bookingid"] = bookingid;
                //Session["userid"] = userid;
                Session["modelid"] = modelid;
                Session["balalance"] = bal_a;
                Session["Adv"] = Int32.Parse(Label4.Text);
                Response.Redirect("Payment.aspx");
                
            }
        }
    }
}