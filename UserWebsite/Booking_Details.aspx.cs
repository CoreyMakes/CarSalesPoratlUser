using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserWebsite
{
    public partial class Booking_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Button1.Enabled = false;
                string bookingid = Request.QueryString["bookingid"];
                dml ob = new dml();
                DataTable dt = new DataTable();
                dt = ob.get_booking_etails(bookingid);
                if(dt.Rows.Count>0)
                {
                    Image1.ImageUrl = "http://localhost:49447/Images/" + dt.Rows[0]["PICTURE"].ToString();
                    Image2.ImageUrl = "http://localhost:49447/Images/" + dt.Rows[0]["MODEL_PICTURE"].ToString();
                    Label1.Text = dt.Rows[0]["MODEL_NAME"].ToString();
                    Label2.Text = dt.Rows[0]["SUBMODEL_NAME"].ToString();
                    Label3.Text = dt.Rows[0]["TYPE_NAME"].ToString();
                    Label4.Text = dt.Rows[0]["AMOUNT"].ToString();
                    int paid = Int32.Parse(dt.Rows[0]["AMOUNT"].ToString()) - Int32.Parse(dt.Rows[0]["BALANCE_AMOUNT"].ToString());
                    Label5.Text = paid.ToString(); 
                    Label6.Text = dt.Rows[0]["BALANCE_AMOUNT"].ToString();
                    DateTime bookingdate = Convert.ToDateTime(dt.Rows[0]["BOOKING_DATE"].ToString());
                    Label7.Text = bookingdate.ToString("dd-MM-yyyy");
                    double day = Double.Parse(dt.Rows[0]["EXPECTED_DAYS"].ToString());
                    DateTime expdate = bookingdate.AddDays(day);
                    if(dt.Rows[0]["STATUS"].ToString()=="B")
                    {
                        Label10.Text = "Not Issued";
                        Label8.Text = expdate.ToString("dd-MM-yyyy");
                        Button1.Enabled = true;
                    }
                    if (dt.Rows[0]["STATUS"].ToString() == "I")
                    {
                        DateTime issuedate = Convert.ToDateTime(dt.Rows[0]["ISSUE_DATE"].ToString());
                        Label8.Text = issuedate.ToString("dd-MM-yyyy");
                        Label10.Text = "Issued";
                        Button1.Enabled = false;
                    }
                    if(dt.Rows[0]["STATUS"].ToString() == "C")
                    {
                        Label10.Text = "Cancelled";
                        Label8.Text = "--";
                        Button1.Enabled = false;
                    }
                }

            }
        }
    }
}