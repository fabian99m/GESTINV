using System;
using Modelo.DTO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Modelo.DAO
{
    public class RegistroDAO : ConexionBD
    {

        InventarioDAO inventario = new InventarioDAO();

        public Boolean RegistrarEntrada(ProductoDTO producto, String fecha, int cantidad, String proveedor)
        {
            Boolean res = false;
            string query = "INSERT INTO Entrada(id,nombre,fecha,cantidad,proveedor) VALUES ('" + producto.ID + "', '" + producto.Nombre + "',  '" + fecha + "', " + cantidad + ",'" + proveedor + "') ";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                res = true;
                databaseConnection.Close();

                inventario.ModificarStock(producto.ID, cantidad, "Entrada");

            }
            catch (Exception ex)
            { }
            return res;
        }

        public int RegistrarSalida(ProductoDTO producto, String fecha, int cantidad)
        {
            int res = inventario.ValidarStock(producto.ID, cantidad);
            try
            {
                if (res != 3)
                {
                    string query = "INSERT INTO Salida(id,nombre,fecha,cantidad) VALUES ('" + producto.ID + "', '" + producto.Nombre + "',  '" + fecha + "', " + cantidad + ") ";
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                    inventario.ModificarStock(producto.ID, cantidad, "Salida");
                }
                else
                {
                    string query = "INSERT INTO Salida(id,nombre,fecha,cantidad) VALUES ('" + producto.ID + "', '" + producto.Nombre + "',  '" + fecha + "', " + inventario.BuscarProducto(producto.ID).Stock + ") ";
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                    inventario.ModificarStock(producto.ID, inventario.BuscarProducto(producto.ID).Stock, "Salida");
                }

            }
            catch (Exception ex)
            { }
            return res;
        }


        public List<String[]> ConsultarEntrada()
        {
            string query = "SELECT * FROM Entrada";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            List<String[]> datos = new List<string[]>();
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(2), reader.GetString(0), reader.GetString(1), reader.GetString(3), reader.GetString(4) };
                        datos.Add(row);
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            { }
            return datos;
        }

        public List<String[]> ConsultarSalida()
        {
            string query = "SELECT * FROM Salida";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            List<String[]> datos = new List<string[]>();
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(2), reader.GetString(0), reader.GetString(1), reader.GetString(3) };
                        datos.Add(row);
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            { }

            return datos;
        }

        public List<List<string>> ProductoMasVendido()
        {
            string query = "SELECT Salida.id, SUM(Salida.cantidad) AS TotalVentas FROM Salida GROUP BY Salida.id ORDER BY SUM(Salida.cantidad) DESC LIMIT 0 , 5";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            List<String> x = new List<String>();
            List<String> y = new List<String>();
            List<List<string>> unir = new List<List<string>>();
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {                       
                        x.Add(inventario.BuscarProducto(reader.GetString(0)).Nombre);
                        y.Add(reader.GetString(1));                     
                    }
                }
                unir.Add(x);
                unir.Add(y);
                databaseConnection.Close();
            }
            catch (Exception ex)
            { }
            return unir;

        }

        public void EliminarSalida(String id)
        {
            string query = "DELETE FROM Salida WHERE id=" + id + "";
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

        public void EliminarEntrada(String id)
        {
            string query = "DELETE FROM Entrada WHERE id=" + id + "";
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
