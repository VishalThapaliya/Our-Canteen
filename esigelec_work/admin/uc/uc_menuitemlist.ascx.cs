using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using bal = esigelec_bal;

namespace esigelec_work.admin.uc
{
    public partial class uc_menuitemlist : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bal.Recipes obj = new bal.Recipes();

                if (Request.QueryString["recipeid"] == null)
                {

                    GridView1.DataSource = obj.list();
                    GridView1.DataBind();
                }
                else
                {
                    obj.recipeid = Int32.Parse(Request.QueryString["recipeid"].ToString());

                    if (obj.remove() > 0)
                    {
                        Response.Redirect("~/admin/menuitemlist.aspx");
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