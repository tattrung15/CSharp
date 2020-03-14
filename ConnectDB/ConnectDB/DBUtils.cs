using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectDB
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DESKTOP-98KGMLF\SQLEXPRESS";

            string database = "Demo";
            string username = "sa";
            string password = "123";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
