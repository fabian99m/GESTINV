﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Modelo.DTO;
using MySql.Data.MySqlClient;

namespace Modelo.DAO
{
    public class ProveedorDAO : ConexionBD
    {
        public void GuardarProveedor(ProveedorDTO proveedor)
        {
            String query = "INSERT INTO Proveedor(nombre,telefono,email) VALUES ('" + proveedor.Nombre + "','" + proveedor.Telefono + "','" + proveedor.Email + "')";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Proveedor insertado satisfactoriamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Proveedor insertado sin éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            {
               // MessageBox.Show("Proveedor insertado sin éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lista;
        }
    }

}