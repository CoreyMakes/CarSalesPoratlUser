using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserWebsite
{
    public partial class AdView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dml ob = new dml();
                DataList1.DataSource = ob.get_datalist_adview();
                DataList1.DataBind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            dml ob = new dml();
            DataList1.DataSource = ob.get_datalist_search_oldcar(TextBox1.Text);
            DataList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string s = bt.CommandName;
            Response.Redirect("Ad_Details.aspx?adid=" + s);
        }
    }
}