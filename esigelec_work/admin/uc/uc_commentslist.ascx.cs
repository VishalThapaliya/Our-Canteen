using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using bal = esigelec_bal;

namespace esigelec_work.admin.uc
{
    public partial class uc_commentslist : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bal.Comments obj = new bal.Comments();

                if (Request.QueryString["commentid"] == null)
                {

                    GridView1.DataSource = obj.list();
                    GridView1.DataBind();
                }
                else
                {
                    obj.commentid = Int32.Parse(Request.QueryString["commentid"].ToString());

                    if (obj.remove() > 0)
                    {
                        Response.Redirect("~/admin/commentslist.aspx");
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