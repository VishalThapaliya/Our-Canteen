using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Data;
using System.Data.SqlClient ;

namespace esigelect_dal
{
    class Connectivity
    {
        String str_con = ConfigurationManager.ConnectionStrings["dbcon"].ToString();

        SqlConnection dbConnection()
        {
            SqlConnection sqlcon = new SqlConnection(str_con);
            sqlcon.Open();
            return sqlcon;
        }

        public SqlCommand dbCommand(String strprocedure)
        {
            SqlCommand sqlcmd = new SqlCommand(strprocedure, dbConnection());
            sqlcmd.CommandType = CommandType.StoredProcedure;
            return sqlcmd;
        }
    }
}
