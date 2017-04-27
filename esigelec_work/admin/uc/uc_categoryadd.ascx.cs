using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

using bal = esigelec_bal;

namespace esigelec_work.admin.uc
{
    public partial class uc_categoryadd : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["catid"] != null)
                {
                    bal.Category obj = new bal.Category();
                    obj.catid = Int32.Parse(Request.QueryString["catid"].ToString());
                    List<bal.Category> list = obj.get();
                    txt_categoryname.Text = list[0].categoryname;
                }
                else
                {
                    clearFields();
                }
            }
        }

        void clearFields()
        {
            txt_categoryname.Text = string.Empty;
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            

            bal.Category obj = new bal.Category();

            obj.catid = Request.QueryString["catid"] == null ? 0 : Int32.Parse(Request.QueryString["catid"].ToString());

            obj.categoryname = txt_categoryname.Text;

            if (fu_picture.HasFile)
            {
                string ext = Path.GetExtension(fu_picture.PostedFile.FileName);
                if (ext == ".jpg" || ext == ".png" || ext == ".gif")
                {
                    fu_picture.SaveAs(MapPath("~/images/" + fu_picture.PostedFile.FileName));

                    System.Drawing.Image objImage = System.Drawing.Image.FromFile(MapPath("~/images/" + fu_picture.PostedFile.FileName));
                    int width = objImage.Width;
                    int height = objImage.Height;

                    if (width != 320 && height != 200)
                    {
                        Response.Write("width and height must be 320 and 200 pixel !!!");
                        return;
                    }

                }
                else
                {
                    Response.Write("Only .JPG or .PNG formate is accepted !!!");
                    return;
                }

            }
            obj.image = fu_picture.PostedFile.FileName;
            if (obj.save() > 0)
            {
                Response.Redirect("~/admin/categorylist.aspx");
            }
            else
            {
                Response.Write("Could not Saved !!!");
            }
        }
    }
}