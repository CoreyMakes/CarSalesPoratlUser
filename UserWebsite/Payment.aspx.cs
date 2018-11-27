using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using ASPSnippets.SmsAPI;
namespace UserWebsite
{
    public partial class Payment : System.Web.UI.Page
    {
        public static string submodelid;
        public static string colorid;
        public static string userid;
        public static string bookingid;
        public static string modelid;
        public static string balance;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                for (int i = 2017; i < 2050; i++)
                {
                    DropDownList2.Items.Add(i.ToString());
                }
                submodelid = (string)Session["submodel_id"];
                colorid = (string)Session["colorid"];
                dml ob = new dml();
                DataTable dt = new DataTable();
                dt = ob.get_detials(submodelid, colorid);
                if (dt.Rows.Count > 0)
                {
                    Label2.Text = dt.Rows[0]["MODEL_NAME"].ToString();
                    Label3.Text = dt.Rows[0]["SUBMODEL_NAME"].ToString();
                    Label4.Text = dt.Rows[0]["TYPE_NAME"].ToString();
                    Label5.Text = dt.Rows[0]["COLOR_NAME"].ToString();
                    Label6.Text = dt.Rows[0]["PRICE"].ToString();
                    double d = Double.Parse(dt.Rows[0]["EXPECTED_DAYS"].ToString());
                    Label7.Text = Convert.ToString(Session["Adv"]);
                    DateTime expdate = System.DateTime.Today.AddDays(d);
                    Label1.Text = expdate.ToString("dd/MM/yyyy");
                }
                RadioButtonList1.DataSource = ob.getPaymentDetails();
                RadioButtonList1.DataTextField = "METHOD_NAME";
                RadioButtonList1.DataValueField = "METHOD_ID";
                RadioButtonList1.DataBind();
            }

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(RadioButtonList1.SelectedIndex==0)
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
            }
            if(RadioButtonList1.SelectedIndex==1)
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Session["flag"] = "1";
                Response.Redirect("WebForm7.aspx");
            }
            else
            {
                dml ob = new dml();
                /*SMS Sending
                SMS.APIType = SMSGateway.Site2SMS;
                SMS.MashapeKey = "7DFfOImpRmmshfYB7oUmXMcnoFmMp1PSxMyjsnbzIaH9U6gpYb";
                SMS.Username = "9633514465";
                SMS.Password = "0987noeltoy";
                SMS.SendSms("9495528982", "This Is Testing Jesus");
                end*/
                userid = (string)Session["userid"];
                bookingid = (string)Session["bookingid"];
                modelid = (string)Session["modelid"];
                balance = (string)Session["balalance"];
                ob.booking_details(bookingid, userid, modelid, colorid, submodelid, System.DateTime.Today, Label6.Text, "B", balance,TextBox4.Text,TextBox5.Text,TextBox6.Text);
                if(RadioButtonList1.SelectedIndex==0)
                {
                    ob.payment_method(RadioButtonList1.SelectedValue.ToString(), userid, bookingid, TextBox2.Text);
                }
                if (RadioButtonList1.SelectedIndex == 1)
                {
                    ob.payment_method(RadioButtonList1.SelectedValue.ToString(), userid, bookingid, RadioButtonList2.SelectedItem.ToString());
                }
                Response.Redirect("WebForm2.aspx");
            }
        }
    }
}