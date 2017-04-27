using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using bal = esigelec_bal;

namespace esigelec_work.admin.uc
{
    public partial class uc_Login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            if (Page.IsValid)
            {
                bal.Users obj = new bal.Users();
                obj.email = username;
                obj.password = password;

                obj.checklogin();

                if (obj.userid > 0)
                {
                    Session["users"] = obj;
                    Response.Redirect("~/admin/main.aspx");
                }
                else
                {
                    lblerrormsg.Text = "Username & Password isnot Found !!!";
                }


            }
        }
    }
}