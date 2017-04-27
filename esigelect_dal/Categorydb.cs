using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using bal = esigelec_bal;

namespace esigelect_dal
{
    public class Categorydb
    {
        Connectivity con = new Connectivity();
        SqlCommand sqlcmd = new SqlCommand();
        List<bal.Category> cList = new List<bal.Category>();

        public int save(bal.Category o)
        {
            sqlcmd = con.dbCommand("category_save");
            sqlcmd.Parameters.AddWithValue("@catid", o.catid);
            sqlcmd.Parameters.AddWithValue("@categoryname", o.categoryname);
            sqlcmd.Parameters.AddWithValue("@image", o.image);
            return sqlcmd.ExecuteNonQuery();

        }

        public int remove(bal.Category o)
        {
            sqlcmd = con.dbCommand("category_remove");
            sqlcmd.Parameters.AddWithValue("@catid", o.catid);
            return sqlcmd.ExecuteNonQuery();
        }

        public List<bal.Category> list()
        {
            
            sqlcmd = con.dbCommand("category_list");
            SqlDataReader sqldr = sqlcmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(sqldr);
            dList(dt);
            return cList;
            
        }

        public List<bal.Category> get(bal.Category o)
        {

            sqlcmd = con.dbCommand("category_get");
            sqlcmd.Parameters.AddWithValue("@catid", o.catid);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(sqldr);
            dList(dt);

            return cList;

        }


        void dList(DataTable dt)
        {
         
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bal.Category c = new bal.Category();
                c.catid = Int32.Parse(dt.Rows[i]["catid"].ToString());
                c.categoryname = dt.Rows[i]["categoryname"].ToString();
                c.image = dt.Rows[i]["image"].ToString();
                cList.Add(c);
            }
 
        }
    }
}
