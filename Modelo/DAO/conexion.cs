using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.DAO
{
    public class Conexion
    {
        protected const string connectionString = "datasource=remotemysql.com;port=3306;username=pf7UNUfjqi;password=3Jq7lpo46I;database=pf7UNUfjqi;";
        protected MySqlConnection databaseConnection = new MySqlConnection(connectionString);
    }
}
