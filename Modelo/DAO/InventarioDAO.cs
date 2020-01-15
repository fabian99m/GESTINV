using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.DTO;
using MySql.Data.MySqlClient;

namespace Modelo.DAO
{
    public class InventarioDAO
    {
        public InventarioDAO()
        {
        }

        public void GuardarProducto(ProductoDTO producto)
        {
            string connectionString = "datasource=remotemysql.com;port=3306;username=pf7UNUfjqi;password=3Jq7lpo46I;database=pf7UNUfjqi;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            string query = "INSERT INTO Producto(`id`, `nombre`) VALUES ('" + producto.ID + "','" + producto.Nombre + "')";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Producto insertado satisfactoriamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Producto insertado sin éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
