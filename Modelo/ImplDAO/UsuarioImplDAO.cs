using System;
using Modelo.DTO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Modelo.DAO;

namespace Modelo.ImplDAO
{
   public class UsuarioImplDAO : ConexionBD, UsuarioDAO
    {

        public void IniciarSesion(UsuarioDTO user, Form login_form)
        {

            string query = "SELECT * FROM Usuario WHERE nombre='" + user.Nombre + "' and contrasena='" + user.Contrasena + "'";
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
                        if (reader.GetString(3).Equals("Admin"))
                        {
                            login_form.DialogResult = DialogResult.OK;
                        }
                        if (reader.GetString(3) == "Auxiliar")
                        {
                            login_form.DialogResult = DialogResult.No;
                        }
                    }
                }
                else
                {
                    login_form.DialogResult = DialogResult.Retry;
                    MessageBox.Show("Datos incorrectos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                login_form.DialogResult = DialogResult.Retry;
                //MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
