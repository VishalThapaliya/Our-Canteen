using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using bal = esigelec_bal;

namespace esigelec_work.admin.uc
{
    public partial class uc_categorylist : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bal.Category obj = new bal.Category();

                if (Request.QueryString["catid"] == null)
                {

                    GridView1.DataSource = obj.list();
                    GridView1.DataBind();
                }
                else
                {
                    obj.catid = Int32.Parse(Request.QueryString["catid"].ToString());

                    if (obj.remove() > 0)
                    {
                        Response.Redirect("~/admin/categorylist.aspx");
                    }
                    else
                    {
                        Response.Write("Data couldnot Removed !!");
                    }
                }
            }
        }
    }
}