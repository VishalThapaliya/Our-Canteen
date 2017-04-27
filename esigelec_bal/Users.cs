using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using dal = esigelect_dal;

namespace esigelec_bal
{
    public class Users
    {

        public string email { get; set; }
        public string fullname { get; set; }
        public string password { get; set; }
        public int userType { get; set; }
        public int userid { get; set; }


        public int save()
        {
            dal.Usersdb userobj = new dal.Usersdb();
            return userobj.save(this);
            
        }
        public int remove()
        {
            dal.Usersdb userobj = new dal.Usersdb();
            return userobj.remove(this);

        }

        public void checklogin()
        {
            dal.Usersdb userobj = new dal.Usersdb();
            userobj.checkLogin(this);

        }

        public List<Users> list()
        {
            dal.Usersdb userobj = new dal.Usersdb();
            return userobj.list();
        }


        public List<Users> get()
        {
            dal.Usersdb userobj = new dal.Usersdb();
            return userobj.get(this);
        }
        
    }
}
