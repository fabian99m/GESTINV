using MySql.Data.MySqlClient;


namespace Modelo.ImplDAO

{
    public class ConexionBD
    {
        //protected const string connectionString = "datasource=remotemysql.com;port=3306;username=pf7UNUfjqi;password=3Jq7lpo46I;database=pf7UNUfjqi;";
        protected const string connectionString = "datasource=localhost;port=3306;username=root;password=;database=gestinv;";
        // protected const string connectionString = "datasource=johnny.heliohost.org;port=3306;username=fabianjo;password=23053799;database=fabianjo_gestinv;";
        protected MySqlConnection databaseConnection = new MySqlConnection(connectionString);
    }

}