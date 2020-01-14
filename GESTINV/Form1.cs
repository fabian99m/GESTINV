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
using Controlador;

namespace GESTINV
{
    public partial class Form1 : MaterialForm
    {
        InventarioControlador inv_controlador = new InventarioControlador();

        public Form1()
        {
            //vista de admin

            InitializeComponent();      
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.BLACK
                
            );
            this.LabelUser.Text = "Admin";
        }


        public Form1(int num)
        {
            //vista de auxiliar

            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.BLACK
            );
        
            materialTabControl2.Controls.Remove(tabPage1);
            materialTabControl2.Controls.Remove(tabPage2);
            materialTabControl2.Controls.Remove(tabPage5);
            materialTabControl1.Controls.Remove(tabPage6);
            this.LabelUser.Text = "Auxiliar";
        }

        private void GuardarProductos_Click(object sender, EventArgs e)
        {
           string connectionString = "datasource=remotemysql.com;port=3306;username=pf7UNUfjqi;password=3Jq7lpo46I;database=pf7UNUfjqi;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            string query = "INSERT INTO Producto(`id`, `nombre`) VALUES ('"+Convert.ToInt32(id.Text)+"','"+nombre.Text+"')";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
 
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Producto insertado satisfactoriamente!","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Producto insertado sin éxito","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            LimpiarPantalla();
        }

        public void LimpiarPantalla()
        { 
            id.Text = "";
            nombre.Text = "";
            /*
            precio.Text = "";
            stockMin.Text = "";
            stock.Text = "";
            categoria.Text = "";
            */
        }
    }
}
