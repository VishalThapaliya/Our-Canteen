using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using dal = esigelect_dal;

namespace esigelec_bal
{
    public class Comments
    {
        public int commentid { get; set; }
        public string commentby { get; set; }
        public string comments { get; set; }
        public int recipeid { get; set; }

        public int save()
        {
            dal.Commentdb obj = new dal.Commentdb();
            return obj.save(this);

        }
        public int remove()
        {
            dal.Commentdb obj = new dal.Commentdb();
            return obj.remove(this);

        }



        public List<Comments> list()
        {
            dal.Commentdb obj = new dal.Commentdb();
            return obj.list();
        }


        public List<Comments> get()
        {
            dal.Commentdb obj = new dal.Commentdb();
            return obj.get(this);
        }
    }
}
