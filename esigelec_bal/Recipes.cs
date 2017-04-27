using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using dal = esigelect_dal;

namespace esigelec_bal
{
    public class Recipes
    {
        public int recipeid { get; set; }
        public string recipename { get; set; }
        public string recipedesc { get; set; }
        public int price { get; set; }
        public string image { get; set; }
        public List<Comments> commentList { get; set; }

        public Category category { get; set; }

        public int save()
        {
            dal.Recipesdb obj = new dal.Recipesdb();
            return obj.save(this);

        }
        public int remove()
        {
            dal.Recipesdb obj = new dal.Recipesdb();
            return obj.remove(this);

        }

       

        public List<Recipes> list()
        {
            dal.Recipesdb obj = new dal.Recipesdb();
            return obj.list();
        }


        public List<Recipes> get()
        {
            dal.Recipesdb obj = new dal.Recipesdb();
            return obj.get(this);
        }

        public List<Recipes> getbycategory(int catid)
        {
            dal.Recipesdb obj = new dal.Recipesdb();
            return obj.getbyCategory(catid);
        }
    }
}
