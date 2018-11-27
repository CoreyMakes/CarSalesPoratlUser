using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserWebsite
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string search1 = (string)Session["search1"];
                string search2 = (string)Session["search2"];
                string search3 = (string)Session["search3"];
                dml ob = new dml();
                DataList1.DataSource = ob.get_datalist_searchColor(search1,search2,search3);
                DataList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string submodel_id = b.CommandArgument;
            Session["submodel_id"] = submodel_id;
            Response.Redirect("WebForm4.aspx");
        
        }
    }
}