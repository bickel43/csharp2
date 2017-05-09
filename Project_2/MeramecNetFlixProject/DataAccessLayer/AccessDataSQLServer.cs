using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//The System.Data.SqlClient reference is needed to access SQL Server database
using System.Data.SqlClient;

namespace MeramecNetFlixProject.DataAccessLayer
{
    public static class AccessDataSQLServer
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Server=198.209.220.125;Database=teamg;User ID=teamg;Password=teamg";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        //Add public methods to expose to the outside world

    }


}
