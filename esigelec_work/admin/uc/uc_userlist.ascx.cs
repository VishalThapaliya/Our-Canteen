using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using bal = esigelec_bal;

namespace esigelec_work.admin.uc
{
    public partial class uc_userlist : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bal.Users obj = new bal.Users();

                if (Request.QueryString["userid"] == null)
                {
                    
                    GridView1.DataSource = obj.list();
                    GridView1.DataBind();
                }
                else
                {
                    obj.userid = Int32.Parse(Request.QueryString["userid"].ToString());

                    if (obj.remove() > 0)
                    {
                        Response.Redirect("~/admin/userlist.aspx");
                    }
                    else
                    {
                        Response.Write("Data couldnot Removed !!");
                    }
                }
            }
        }

        protected void txt_Search_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_Search.Text;
            Response.Write(searchText);

        }
    }
}