using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using bal = esigelec_bal;

namespace esigelec_work
{
    public partial class _default : System.Web.UI.Page
    {

        List<bal.Recipes> list = new List<bal.Recipes>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (list.Count <= 0)
                {
                    bal.Recipes obj = new bal.Recipes();
                    list = obj.list();
                }
                //BannerImage.ImageUrl = "~/images/" + list[0].image;
                Literal1.Text = "<div style='background-image : url(/images/" + list[0].image + ");height:300px;width:1000px'>" + 
                               " </div>";


                bal.Category cobj = new bal.Category();
                List<bal.Category> cList = new List<bal.Category>();
                cList = cobj.list();

                String CategoryList = String.Empty;
                for (int i = 0; i < cList.Count; i++)
                {
                    CategoryList += "<div id='downContent'>" + 
                                    "<div id='downMenu'>" +
                                     "<a href='menuitemlist.aspx?catid=" + cList[i].catid + "'>" + cList[i].categoryname + " </a> " + 
                                     "</div>" +

                                 " <div id='downImage'> <img src='images/" + cList[i].image + "' alt=' " + cList[i].categoryname + "'/>  </div>" + 
         
                                "</div>" ;
                              
                }

                Literal2.Text = CategoryList;
                    
                  
            }
            
        }

        protected void Timer_Tick(object sender, EventArgs e)
        {
            if (list.Count <= 0)
            {
                bal.Recipes obj = new bal.Recipes();
                list = obj.list();
            }
            Random rand = new Random();
            int i = rand.Next(0, list.Count);
            Literal1.Text = "<div style='background-image : url(/images/" + list[i].image + ");height:300px;width:1000px'>" +
                                 "</div>";
        }

    }
}