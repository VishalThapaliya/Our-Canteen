using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using dal = esigelect_dal;


namespace esigelec_bal
{
    public class Category
    {
        public string categoryname { get; set; }
        public  int catid { get; set; }
        public string image { get; set; }

        public int save()
        {
            dal.Categorydb obj = new dal.Categorydb();
            return obj.save(this);

        }
        public int remove()
        {
            dal.Categorydb obj = new dal.Categorydb();
            return obj.remove(this);

        }



        public List<Category> list()
        {
            dal.Categorydb obj = new dal.Categorydb();
            return obj.list();
        }


        public List<Category> get()
        {
            dal.Categorydb obj = new dal.Categorydb();
            return obj.get(this);
        }
    }
}
