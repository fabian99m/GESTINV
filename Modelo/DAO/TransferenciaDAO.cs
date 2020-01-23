using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Modelo.DTO;
using MaterialSkin.Controls;
using System.Collections.Generic;

namespace Modelo.DAO
{
   public class TransferenciaDAO : ConexionBD
    {

        InventarioDAO inventario = new InventarioDAO();
     
        public Boolean RegistrarEntrada(ProductoDTO producto, String fecha , int cantidad,String proveedor)
        {
            Boolean res = false;
            string query = "INSERT INTO Entrada(id,nombre,fecha,cantidad,proveedor) VALUES ('"+producto.ID+"', '"+producto.Nombre+"',  '"+fecha+"', "+cantidad+",'"+proveedor+"') ";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                res = true;      
                databaseConnection.Close();

                inventario.ModificarStock(producto.ID, cantidad,"Entrada");
               
            }
            catch (Exception ex)
            { }
            return res;
        }

        public int RegistrarSalida(ProductoDTO producto, String fecha, int cantidad)
        {
           int  res = inventario.ValidarStock(producto.ID, cantidad);        
            try
            {           
                if (res!=3)
                {              
                    string query = "INSERT INTO Salida(id,nombre,fecha,cantidad) VALUES ('" + producto.ID + "', '" + producto.Nombre + "',  '" + fecha + "', " + cantidad + ") ";
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();                   
                    databaseConnection.Close();
                    inventario.ModificarStock(producto.ID, cantidad, "Salida");
                } else
                {
                    string query = "INSERT INTO Salida(id,nombre,fecha,cantidad) VALUES ('" + producto.ID + "', '" + producto.Nombre + "',  '" + fecha + "', " + inventario.BuscarProducto(producto.ID).Stock+ ") ";
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


    }
}
