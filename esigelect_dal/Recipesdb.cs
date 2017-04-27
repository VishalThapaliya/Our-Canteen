using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using bal = esigelec_bal;

namespace esigelect_dal
{
    public class Recipesdb
    {
        Connectivity con = new Connectivity();
        SqlCommand sqlcmd = new SqlCommand();
        List<bal.Recipes> cList = new List<bal.Recipes>();

        public int save(bal.Recipes o)
        {
            sqlcmd = con.dbCommand("recipe_save");
            sqlcmd.Parameters.AddWithValue("@recipeid", o.recipeid);
            sqlcmd.Parameters.AddWithValue("@recipename", o.recipename);
            sqlcmd.Parameters.AddWithValue("@catid", o.category.catid);
            sqlcmd.Parameters.AddWithValue("@recipedesc", o.recipedesc);
            sqlcmd.Parameters.AddWithValue("@price", o.price);
            sqlcmd.Parameters.AddWithValue("@image", o.image);
            return sqlcmd.ExecuteNonQuery();

        }

        public int remove(bal.Recipes o)
        {
            sqlcmd = con.dbCommand("recipe_remove");
            sqlcmd.Parameters.AddWithValue("@recipeid", o.recipeid);
            return sqlcmd.ExecuteNonQuery();
        }

        public List<bal.Recipes> list()
        {

            sqlcmd = con.dbCommand("recipe_list");
            SqlDataReader sqldr = sqlcmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(sqldr);
            dList(dt);
            return cList;

        }

        public List<bal.Recipes> get(bal.Recipes o)
        {

            sqlcmd = con.dbCommand("recipe_get");
            sqlcmd.Parameters.AddWithValue("@recipeid",o.recipeid);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(sqldr);
            dList(dt);

            return cList;

        }

        public List<bal.Recipes> getbyCategory(int catid)
        {

            sqlcmd = con.dbCommand("recipe_get_bycategory");
            sqlcmd.Parameters.AddWithValue("@catid", catid);
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
                bal.Recipes c = new bal.Recipes();
                 c.recipeid = Int32.Parse(dt.Rows[i]["catid"].ToString());
                 c.recipename = dt.Rows[i]["recipename"].ToString();
                 c.recipedesc = dt.Rows[i]["recipedesc"].ToString();
                 c.price = Int32.Parse(dt.Rows[i]["price"].ToString());
                 //c.catid = Int32.Parse(dt.Rows[i]["catid"].ToString());
                 c.image = dt.Rows[i]["image"].ToString();

                 bal.Category cat = new bal.Category();
                 cat.catid = Int32.Parse(dt.Rows[i]["catid"].ToString());
                 cat.categoryname = dt.Rows[i]["categoryname"].ToString();
                 c.category = cat;

                 Commentdb combdb = new Commentdb();
                 c.commentList = combdb.getbyrecipe(c.recipeid);
                 
                cList.Add(c);
            }

        }
    }
}
