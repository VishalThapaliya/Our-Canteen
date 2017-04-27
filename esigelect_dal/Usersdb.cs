using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using bal = esigelec_bal ;

namespace esigelect_dal
{
   public  class Usersdb
    {

        Connectivity con = new Connectivity();
        SqlCommand sqlcmd = new SqlCommand();
        List<bal.Users> cList = new List<bal.Users>();

        public int save(bal.Users o)
        {
            sqlcmd = con.dbCommand("users_save");
            sqlcmd.Parameters.AddWithValue("@userid", o.userid);
            sqlcmd.Parameters.AddWithValue("@email", o.email);
            sqlcmd.Parameters.AddWithValue("@password", o.password);
            sqlcmd.Parameters.AddWithValue("@fullname", o.fullname);
            return sqlcmd.ExecuteNonQuery();

        }

        public int remove(bal.Users o)
        {
            sqlcmd = con.dbCommand("users_remove");
            sqlcmd.Parameters.AddWithValue("@userid", o.userid);
            return sqlcmd.ExecuteNonQuery();
        }

        public List<bal.Users> list()
        {
            
            sqlcmd = con.dbCommand("users_list");
            SqlDataReader sqldr = sqlcmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(sqldr);
            dList(dt);
            return cList;
            
        }

        public void checkLogin(bal.Users o)
        {
            sqlcmd = con.dbCommand("users_checklogin");
            sqlcmd.Parameters.AddWithValue("@username", o.email);
            sqlcmd.Parameters.AddWithValue("@password", o.password);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(sqldr);
            dList(dt);

            if (dt.Rows.Count > 0)
            {
                o.userid = Int32.Parse(dt.Rows[0]["userid"].ToString());
                o.fullname = dt.Rows[0]["fullname"].ToString();
                o.password = "@@@@@@@@@";
            }
            else
            {
                o = null;
            }
            
        }

        public List<bal.Users> get(bal.Users o)
        {

            sqlcmd = con.dbCommand("users_get");
            sqlcmd.Parameters.AddWithValue("@userid", o.userid);
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
                bal.Users c = new bal.Users();
                c.userid = Int32.Parse(dt.Rows[i]["userid"].ToString());
                c.email = dt.Rows[i]["email"].ToString();
                c.fullname = dt.Rows[i]["fullname"].ToString();
                cList.Add(c);
            }
 
        }

        //private List<T> ConvertToList<T>(DataTable dt)
        //{
        //    var columnNames = dt.Columns.Cast<DataColumn>()
        //        .Select(c => c.ColumnName)
        //        .ToList();

        //    var properties = typeof(T).GetProperties();

        //    return dt.AsEnumerable().Select(row =>
        //    {
        //        var objT = Activator.CreateInstance<T>();

        //        foreach (var pro in properties)
        //        {
        //            if (columnNames.Contains(pro.Name))
        //                pro.SetValue(objT, row[pro.Name] , null);
        //        }

        //        return objT;
        //    }).ToList();

        //}
    }
}
