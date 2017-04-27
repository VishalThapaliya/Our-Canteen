using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace esigelec_work
{
    public partial class aja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ////
            
            // if (PreviousPage != null && PreviousPage.IsCrossPagePostBack) {
            //   TextBox t = PrevousPage.FindControl("TextBox") as TextBox;
            //   if (t != null) {
            //     label1.Text = t.Text;
            //   }
            // }
             
            if (!IsPostBack) { }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                String fileName = FileUpload1.PostedFile.FileName;

                String ext = Path.GetExtension(FileUpload1.PostedFile.FileName);
                int filelen = FileUpload1.PostedFile.ContentLength / 1000;

                if (filelen > 2)
                {
                    Response.Write("File is more than 2 MB.");
                }

                if (ext == ".jpg" || ext == ".png")
                {

                    FileUpload1.SaveAs(MapPath("~/images/" + fileName));
                }
                else
                {
                    Response.Write("File invalid");
                }

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Response.Redirect("~/wb1.aspx?value=" + TextBox1.Text);
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Server.Transfer("~/wb1.aspx");
        }
    }
}