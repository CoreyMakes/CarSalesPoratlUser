using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserWebsite
{
    public partial class Booked : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                dml ob = new dml();
                string userid = Request.QueryString["userid"];
                DataTable dt = new DataTable();
                dt = ob.get_booked(userid);
                if(dt.Rows.Count>0)
                {
                    Label1.Text = "Booked Cars";
                    DataList1.DataSource = dt;
                    DataList1.DataBind();
                }
                else
                {
                    Label1.Text="Oops!!! Seems Like You Don't Have Bookings";
                }
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string s = bt.CommandName;
            Response.Redirect("Booking_Details.aspx?bookingid=" + s);
        }
    }
}