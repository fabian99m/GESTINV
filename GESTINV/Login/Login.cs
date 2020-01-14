using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace Vista.Login
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
           
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TextNombre.Text) && !String.IsNullOrEmpty(TextContrasena.Text))
            {
                string connectionString = "datasource=remotemysql.com;port=3306;username=pf7UNUfjqi;password=3Jq7lpo46I;database=pf7UNUfjqi;";
                string query = "SELECT * FROM Usuario WHERE nombre='" + TextNombre.Text + "' and contrasena='" + TextContrasena.Text + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
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
                                this.DialogResult = DialogResult.OK;
                            }
                            if (reader.GetString(3) == "Auxiliar")
                            {
                                this.DialogResult = DialogResult.No;
                            }
                        }
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Retry;
                        MessageBox.Show("Datos incorrectos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    databaseConnection.Close();
                    LimpiarPantalla();
                }
                catch (Exception ex)
                {
                    this.DialogResult = DialogResult.Retry;
                    LimpiarPantalla();
                    MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Ingrese datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void LimpiarPantalla()
        {
            TextNombre.Text = "";
            TextContrasena.Text = "";
        }

        
    }
}
