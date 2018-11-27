using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserWebsite
{
    public partial class New_Cars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                dml ob = new dml();
                DataList1.DataSource = ob.get_new_modeldetails();
                DataList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string s = bt.CommandName;
            Response.Redirect("WebForm3.aspx?modelid=" + s);
        }
    }
}