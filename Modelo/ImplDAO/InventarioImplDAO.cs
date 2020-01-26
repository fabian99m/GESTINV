using System;
using System.Collections.Generic;
using Modelo.DAO;
using Modelo.DTO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Modelo.ImplDAO
{
    public class InventarioImplDAO : ConexionBD,InventarioDAO
    {
        public Inventario inventarioDTO = new Inventario();

        public InventarioImplDAO()
        {
            this.ConsultarProducto();
        }

        public Boolean GuardarProducto(Producto producto)
        {
            Boolean res = false;
            string query = "INSERT INTO Producto(id, nombre,precio,stock,stockMin,categoria) VALUES ('" + producto.ID + "','" + producto.Nombre + "'," +
            "'" + producto.Precio + "','" + producto.Stock + "','" + producto.StockMin + "','" + producto.Categoria + "')";

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                res = true;
            }
            catch (Exception ex)
            { }
            return res;
        }

        public List<String[]> ConsultarProducto()
        {
            string query = "SELECT * FROM Producto";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            List<String[]> datos = new List<string[]>();
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                // Si se encontraron datos
                if (reader.HasRows)
                {
                    inventarioDTO.ProductoList.Clear();
                    while (reader.Read())
                    {
                        String aux;
                        aux = (Convert.ToInt32(reader.GetString(3)) <= Convert.ToInt32(reader.GetString(4))) ? "Sí" : "No";
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), aux };
                        datos.Add(row);

                        inventarioDTO.ProductoList.Add(
                        new Producto(reader.GetString(0), reader.GetString(1), float.Parse(reader.GetString(2)), Convert.ToInt32(reader.GetString(3)), Convert.ToInt32(reader.GetString(4)), reader.GetString(5)));
                    }
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex.Message);
            }
            return datos;
        }

        public List<String[]> ConsultarProducto(String atributo, String valor)
        {

            string query = "SELECT * FROM Producto WHERE " + atributo + "='" + valor + "' ";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            List<String[]> datos = new List<string[]>();
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Si se encontraron datos
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String aux;
                        aux = (Convert.ToInt32(reader.GetString(3)) <= Convert.ToInt32(reader.GetString(4))) ? "Sí" : "No";
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), aux };
                        datos.Add(row);
                    }
                    databaseConnection.Close();
                }
                else
                {
                    databaseConnection.Close();
                    MessageBox.Show("Producto no encontrado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ConsultarProducto();
                }
            }
            catch (Exception ex)
            {
                //TablaDatos.Items.Clear();            
            }
            return datos;
        }

        public int ValidarStock(String id, int Stocknuevo)
        {
            int aux = 0;
            Producto producto = BuscarProducto(id);

            if ((producto.Stock - Stocknuevo) > 0)
            {
                // a punto de agortase
                if ((producto.Stock - Stocknuevo) <= producto.StockMin)
                {
                    aux = 1;
                }
                // disponibilidad por encima del mínimo
                else
                {
                    aux = 2;
                }
                //agotado
            }
            else
            {
                aux = 3;
            }
            return aux;
        }


        public String BuscarNombreProducto(String id)
        {
            String nombre = "";
            foreach (Producto i in inventarioDTO.ProductoList)
            {
                if (id.Equals(i.ID))
                {
                    nombre = i.Nombre;
                }
            }
            return nombre;
        }



        public Boolean ComprobarExistencia(String id)
        {
            string query = "SELECT * FROM Producto WHERE id=" + id + "";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            Boolean aux = false;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    aux = true;
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            { }
            return aux;
        }

        public Producto BuscarProducto(String id)
        {
            Producto producto = null;
            string query = "SELECT * FROM Producto WHERE id=" + id + "";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        producto =
                            new Producto(reader.GetString(0), reader.GetString(1), float.Parse(reader.GetString(2)), Convert.ToInt32(reader.GetString(3)), Convert.ToInt32(reader.GetString(4)), reader.GetString(5));
                    }
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            { }

            return producto;
        }

        public Boolean EliminarProductos(String id)
        {
            Boolean res = false;
            string query = "DELETE FROM Producto WHERE id=" + id + "";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                res = true;

            }
            catch (Exception ex)
            { }
            return res;
        }

        public Boolean ModificarProductos(Producto producto, String id)
        {
            Boolean res = false;
            string query = "UPDATE Producto SET nombre='" + producto.Nombre + "' , precio=" + producto.Precio + "" +", stockMin=" + producto.StockMin + " ,Categoria='" + producto.Categoria + "' WHERE id=" + id + "";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                res = true;
            }
            catch (Exception ex)
            { }
            return res;
        }

        public void ModificarStock(String id, int Stocknuevo, String tipo)
        {
            String query = "";
            if (tipo.Equals("Entrada"))
            {
                query = "UPDATE Producto SET stock=stock +" + Stocknuevo + " WHERE id=" + id + "";
            }
            if (tipo.Equals("Salida"))
            {

                query = "UPDATE Producto SET stock=stock -" + Stocknuevo + " WHERE id=" + id + "";
            }

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
            { }
        }
    }
}
