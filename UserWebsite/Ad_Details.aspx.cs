using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserWebsite
{
    public partial class Ad_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string adid = Request.QueryString["adid"];
                dml ob = new dml();
                DataTable dt = new DataTable();
                dt = ob.get_addetails(adid);
                if (dt.Rows.Count > 0)
                {
                    Label1.Text = dt.Rows[0]["NAME"].ToString();
                    Label2.Text = dt.Rows[0]["CONTACT_NO"].ToString();
                    Label3.Text = dt.Rows[0]["COMPANY"].ToString();
                    Label4.Text = dt.Rows[0]["MODEL"].ToString();
                    Label5.Text = dt.Rows[0]["SUB_MODEL"].ToString();
                    Label6.Text = dt.Rows[0]["FUEL_TYPE"].ToString();
                    Label7.Text = dt.Rows[0]["YEAR"].ToString();
                    Label8.Text = dt.Rows[0]["KILOMETER"].ToString();
                    Label9.Text = dt.Rows[0]["EXPECTED_PRICE"].ToString();
                    Image1.ImageUrl = "~/IMG/" + dt.Rows[0]["PICTURE"].ToString();
                    Image2.ImageUrl = "~/IMG/" + dt.Rows[0]["PICTURE1"].ToString();
                }
            }
        }
    }
}