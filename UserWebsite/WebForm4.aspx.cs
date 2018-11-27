using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserWebsite
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        public static string username;
        public static string userid;
        public static string submodelid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //username = (string)Session["username2"];
                //userid = (string)Session["userid2"];
                submodelid = Request.QueryString["submodelid"];
                if(submodelid==null)
                {
                    submodelid = (string)Session["submodel_id"];
                }
                Button1.CommandName = submodelid;
                if(submodelid!="")
                {
                    dml ob = new dml();
                    DataTable dt = new DataTable();
                    DataTable dt1 = new DataTable();
                    DropDownList1.DataSource = ob.getsubmodeldetails_drop(submodelid);
                    DropDownList1.DataTextField = "COLOR_NAME";
                    DropDownList1.DataValueField = "Expr1";
                    DropDownList1.DataBind();
                    dt = ob.getsubmodeldetails_1(submodelid);
                    if (dt.Rows.Count > 0)
                    {
                        Image1.ImageUrl = "http://localhost:49447/Images/" + dt.Rows[0]["PICTURE"].ToString();
                        Label1.Text = dt.Rows[0]["SUBMODEL_NAME"].ToString();
                    }
                    dt1 = ob.getfeatures(submodelid);
                    Label6.Text = "<ul type='square'>";
                    if(dt1.Rows.Count>0)
                    {
                        for(int i=0;i<dt1.Rows.Count;i++)
                        {
                            Label6.Text = Label6.Text+"<li>"  + dt1.Rows[i]["FEATURE_NAME"].ToString() +"</li>"  ;
                        }
                    }
                    Label6.Text = Label6.Text + "</ul>";
                }
            }
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedValue=="0")
            {
                Label2.Text = "XXX";
            }
            Button1.CommandArgument = DropDownList1.SelectedItem.ToString();
            dml ob = new dml();
            DataTable dt = new DataTable();
            dt = ob.getsubmodeldetails_label(DropDownList1.SelectedValue.ToString(),submodelid);
            if(dt.Rows.Count>0)
            {
                Label2.Text=dt.Rows[0]["PRICE"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string s = bt.CommandName;
            Session["colorname"] = bt.CommandArgument;
            Session["colorid"] = DropDownList1.SelectedValue.ToString();
            //Session["username3"] = username;
            //Session["userid3"] = userid;
            DropDownList1.SelectedIndex = 0;
            Label2.Text = "XXX";
            Response.Redirect("WebForm5.aspx?submodelid=" + s);
        }
    }
}