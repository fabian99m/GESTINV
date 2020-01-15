using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Modelo.DTO;
using MySql.Data.MySqlClient;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Modelo.DAO
{
    public class InventarioDAO : ConexionBD
    {
        InventarioDTO inventario = new InventarioDTO(new List<ProductoDTO>());
        
        public InventarioDAO()
        {
        }

        public void GuardarProducto(ProductoDTO producto)
        {

          string query = "INSERT INTO Producto(id, nombre,precio,stock,stockMin,categoria) VALUES ('" + producto.ID + "','" + producto.Nombre + "'," +
          "'" + producto.Precio + "','" + producto.Stock + "','" + producto.StockMin + "','" + producto.Categoria + "')";
            
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

        public void ConsultarProducto( MaterialListView TablaDatos)
        {
            string query = "SELECT * FROM Producto";        
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
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                        var listViewItem = new ListViewItem(row);
                       TablaDatos.Items.Add(listViewItem);
                       
                    }
                }
                else
                {
                    MessageBox.Show("No hay productos en inventario!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ConsultarProducto(MaterialListView TablaDatos, String atributo , String valor)
        {
            string connectionString = "datasource=remotemysql.com;port=3306;username=pf7UNUfjqi;password=3Jq7lpo46I;database=pf7UNUfjqi;";
            string query = "SELECT * FROM Producto WHERE " + atributo + "='" + valor + "' ";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
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
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                        var listViewItem = new ListViewItem(row);
                        TablaDatos.Items.Add(listViewItem);
                    }
                }
                else
                {
                    MessageBox.Show("Producto no encontrado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //RefrescarTabla();
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                TablaDatos.Items.Clear();
                MessageBox.Show(ex.Message);
            }
        }

        public void EliminarProductos(String id)
        {
            string query = "DELETE FROM Producto WHERE id="+id+"";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 

        public void ModificarProductos(ProductoDTO producto,String id)
        {
            string query = "UPDATE Producto SET id="+producto.ID+", nombre='"+producto.Nombre+"' , precio="+producto.Precio+"" +
                ",stock="+producto.Stock+",stockMin="+producto.StockMin+" ,Categoria='"+producto.Categoria+"' WHERE id="+id+"";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
