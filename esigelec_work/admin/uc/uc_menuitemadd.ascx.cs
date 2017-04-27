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
    public partial class uc_menuitemadd : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bal.Category objcat = new bal.Category();
                dd_menucateogry.DataSource = objcat.list();
                dd_menucateogry.DataTextField = "categoryname";
                dd_menucateogry.DataValueField = "catid";
                dd_menucateogry.DataBind();

                if (Request.QueryString["recipeid"] != null)
                {
                    bal.Recipes obj = new bal.Recipes();
                    obj.recipeid = Int32.Parse(Request.QueryString["recipeid"].ToString());
                    List<bal.Recipes> list = obj.get();

                   txt_menuitem.Text = list[0].recipename ;
                   txt_menuitemdescription.Text = list[0].recipedesc;
                   txt_price.Text = list[0].price.ToString();
                   dd_menucateogry.SelectedValue= list[0].category.catid.ToString();

                }

            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
         
            if (Page.IsValid)
            {

                if (fu_picture.HasFile)
                {
                    string ext = Path.GetExtension(fu_picture.PostedFile.FileName);
                    if (ext == ".jpg" || ext == ".png" || ext == ".gif")
                    {
                        fu_picture.SaveAs(MapPath("~/images/" + fu_picture.PostedFile.FileName));

                        System.Drawing.Image objImage = System.Drawing.Image.FromFile(MapPath("~/images/" + fu_picture.PostedFile.FileName));
                        int width = objImage.Width;
                        int height = objImage.Height;

                        if (width != 1000 && height != 300)
                        {
                            Response.Write("width and height must be 1000 and 300 pixel !!!");
                            return;
                        }

                    }
                    else
                    {
                        Response.Write("Only .JPG or .PNG formate is accepted !!!");
                        return;
                    }
                    
                }
                bal.Recipes obj = new bal.Recipes();
                obj.recipeid = Request.QueryString["recipeid"] == null ? 0 : Int32.Parse(Request.QueryString["recipeid"].ToString());
                obj.recipename = txt_menuitem.Text;
                obj.recipedesc = txt_menuitemdescription.Text;
                obj.price = Int32.Parse(txt_price.Text);
                obj.image = fu_picture.PostedFile.FileName;
                bal.Category o = new bal.Category();
                o.categoryname = dd_menucateogry.SelectedItem.Text;
                o.catid = Int32.Parse(dd_menucateogry.SelectedItem.Value);
                obj.category = o ;// = Int32.Parse(dd_menucateogry.SelectedItem.Value.ToString());
 
                if (obj.save() > 0)
                {
                    Response.Redirect("~/admin/menuitemlist.aspx");
                }
                else
                {
                }
            }
        }
    }
}