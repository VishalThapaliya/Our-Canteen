using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using bal = esigelec_bal;

namespace esigelec_work.admin.uc
{
    public partial class uc_useradd : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["userid"] != null)
                {
                    bal.Users obj = new bal.Users();
                    obj.userid = Int32.Parse(Request.QueryString["userid"].ToString());
                    List<bal.Users> list = obj.get();

                    txt_email.Text = list[0].email.ToString();
                    txt_fullname.Text = list[0].fullname.ToString();
                 //   txt_passwords.Text = list[0].password.ToString();
                  //  txt_conformedpasssword.Text = txt_passwords.Text;

                }
                else
                {
                    clearFields();
                }
            }
        }
        void clearFields()
        {
            txt_email.Text = string.Empty;
            txt_fullname.Text = string.Empty;
            txt_passwords.Text = string.Empty;
            txt_conformedpasssword.Text = string.Empty;
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {

            bal.Users obj = new bal.Users();

            obj.userid = Request.QueryString["userid"] == null ? 0 : Int32.Parse(Request.QueryString["userid"].ToString());

            obj.email = txt_email.Text; 
            obj.fullname = txt_fullname.Text;
            obj.password = txt_passwords.Text;

            if (obj.save() > 0)
            {
                Response.Redirect("~/admin/userlist.aspx");
            }
            else
            {
                Response.Write("Could not Saved !!!");
            }
        }
    }
}