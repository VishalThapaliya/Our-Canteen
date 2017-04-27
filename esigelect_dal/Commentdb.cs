using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using bal = esigelec_bal;


namespace esigelect_dal
{
    public class Commentdb
    {

        Connectivity con = new Connectivity();
        SqlCommand sqlcmd = new SqlCommand();
        List<bal.Comments> cList = new List<bal.Comments>();

        public int save(bal.Comments o)
        {
            sqlcmd = con.dbCommand("comments_save");
            sqlcmd.Parameters.AddWithValue("@commentid", o.commentid);
            sqlcmd.Parameters.AddWithValue("@commentby", o.commentby);
            sqlcmd.Parameters.AddWithValue("@comments", o.comments);
            sqlcmd.Parameters.AddWithValue("@recipeid", o.recipeid);
           
            return sqlcmd.ExecuteNonQuery();

        }

        public int remove(bal.Comments o)
        {
            sqlcmd = con.dbCommand("comments_remove");
            sqlcmd.Parameters.AddWithValue("@commentid", o.commentid);
            return sqlcmd.ExecuteNonQuery();
        }

        public List<bal.Comments> list()
        {

            sqlcmd = con.dbCommand("comments_list");
            SqlDataReader sqldr = sqlcmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(sqldr);
            dList(dt);
            return cList;

        }

        public List<bal.Comments> get(bal.Comments o)
        {

            sqlcmd = con.dbCommand("comments_get");
            sqlcmd.Parameters.AddWithValue("@commentid", o.commentid);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(sqldr);
            dList(dt);

            return cList;

        }

        public List<bal.Comments> getbyrecipe(int recipeid)
        {

            sqlcmd = con.dbCommand("comments_list_byrecipe");
            sqlcmd.Parameters.AddWithValue("@recipeid",recipeid);
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
                bal.Comments c = new bal.Comments();
                c.commentid = Int32.Parse(dt.Rows[i]["commentid"].ToString());
                c.commentby = dt.Rows[i]["commentby"].ToString();
                c.comments = dt.Rows[i]["comments"].ToString();
                cList.Add(c);
            }

        }
    }
}
