using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Modelo.DAO;
using Modelo.DTO;
using MySql.Data.MySqlClient;

namespace Modelo.ImplDAO
{
   public class ProveedorImplDAO : ConexionBD,ProveedorDAO
    {
        public Boolean GuardarProveedor(Proveedor proveedor)
        {
            Boolean res = false;
            String query = "INSERT INTO Proveedor(nombre,telefono,email) VALUES ('" + proveedor.Nombre + "','" + proveedor.Telefono + "','" + proveedor.Email + "')";
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


        public List<String> ConsultarProveedores()
        {
            List<string> lista = new List<string>();
            String query = "SELECT nombre FROM Proveedor";
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
                        lista.Add(reader.GetString(0));
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            { }
            return lista;
        }

        public List<String[]> ConsultarProveedor(String valor,string tipo)
        {
            string query =  string.Empty;
            if (tipo.Equals("1"))
            {
                query = "SELECT * FROM Proveedor";
            } else
            {
                query = "SELECT * FROM Proveedor WHERE nombre='" + valor + "' ";
            }
             
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
                        
                        string[] row = { reader.GetString(1), reader.GetString(2),reader.GetString(3)};
                        datos.Add(row);
                    }
                    databaseConnection.Close();
                }
                else
                {
                    databaseConnection.Close();
                    MessageBox.Show("Proveedor no encontrado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.ConsultarProducto();
                }
            }
            catch (Exception ex)
            { }
            return datos;
        }

    }
}
