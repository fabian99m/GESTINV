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
    public class InventarioDAO : Conexion
    {
        public InventarioDAO()
        {
        }

        public void GuardarProducto(ProductoDTO producto)
        {
            
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
