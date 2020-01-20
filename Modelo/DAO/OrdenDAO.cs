using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Modelo.DTO;
using MaterialSkin.Controls;

namespace Modelo.DAO
{
   public class OrdenDAO : ConexionBD
    {

        InventarioDAO inventario = new InventarioDAO();
     
        public void RegistrarOrden(ProductoDTO producto, String tipo , String fecha , int cantidad,String proveedor)
        {
            string query = "INSERT INTO Orden(id,nombre,tipo,fecha,cantidad,proveedor) VALUES ('"+producto.ID+"', '"+producto.Nombre+"'," +
                "  '"+tipo+"' , '"+fecha+"', "+cantidad+",'"+proveedor+"') ";

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Orden guardada satisfactoriamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                databaseConnection.Close();

                inventario.ModificarStock(producto.ID, cantidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Orden guardada sin éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void ConsultarOrden(MaterialListView TablaOrden)
        {

            string query = "SELECT * FROM Orden";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Si se encontraron datos
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(2), reader.GetString(0), reader.GetString(1), reader.GetString(4), reader.GetString(5) };
                        var listViewItem = new ListViewItem(row);
                        TablaOrden.Items.Add(listViewItem);
                    }
                }
                else
                {
                    MessageBox.Show("No hay ordenes de productos!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
