using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserWebsite
{
    public partial class Contacts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                dml ob = new dml();
                Label2.Font.Italic = true;
                Label3.Font.Italic = true;
                Label4.Font.Italic = true;
                Label5.Font.Italic = true;
                Label6.Font.Italic = true;
                Label7.Font.Italic = true;

                Label2.Font.Bold = true;
                Label3.Font.Bold = true;
                Label4.Font.Bold = true;
                Label5.Font.Bold = true;
                Label6.Font.Bold = true;
                Label7.Font.Bold = true;
                
                DataTable dt = new DataTable();
                dt = ob.getCompanyDetails();
                if(dt.Rows.Count>0)
                {
                    Label2.Text = dt.Rows[0]["COMPANY_NAME"].ToString();
                    Label3.Text = dt.Rows[0]["ADDRESS"].ToString();
                    Label4.Text = dt.Rows[0]["MOBILE_CONTACT_NO"].ToString();
                    Label5.Text = dt.Rows[0]["LAND_CONTACT_NO"].ToString();
                    Label6.Text = dt.Rows[0]["E_MAIL"].ToString();
                    Label7.Text = dt.Rows[0]["WEB_ADDRESS"].ToString();
                }
            }
        }
    }
}