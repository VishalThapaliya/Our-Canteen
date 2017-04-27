using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using bal = esigelec_bal;

namespace esigelec_work.admin
{
    public partial class adminMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["users"] != null)
                {
                    bal.Users obj = new bal.Users();
                    obj = (bal.Users)Session["users"];
                    lblUsers.Text = "Welcome  <b>" + obj.fullname + "</b>" ;
                }
                else
                {
                    Response.Redirect("~/admin/default.aspx");
                }
            }
        }

        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/admin/default.aspx");
        }
    }
}