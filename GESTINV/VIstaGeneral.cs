using System;
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
            RbId.Select();
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
            materialTabControl1.Controls.Remove(tabPage6);
            this.LabelUser.Text = "Auxiliar";
            RbId.Select();
        }

        private void GuardarProductos_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TextId.Text) && !String.IsNullOrEmpty(TextNombre.Text) && !String.IsNullOrEmpty(TextPrecio.Text)
              && !String.IsNullOrEmpty(TextStock.Text) && !String.IsNullOrEmpty(TextStockMin.Text) && !String.IsNullOrEmpty(TextCategoria.Text))
            {

                inv_controlador.GuardarProductos(Convert.ToInt32(TextId.Text), TextNombre.Text, float.Parse(TextPrecio.Text)
                 , Convert.ToInt32(TextStock.Text), Convert.ToInt32(TextStockMin.Text), TextCategoria.Text);
                LimpiarPantalla();
            }
            else
            {
                MessageBox.Show("Ingrese datos para añadir!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LimpiarPantalla();
            RefrescarTabla();
        }

        public void LimpiarPantalla()
        {
            TextId.Text = "";
            TextNombre.Text = "";
            TextPrecio.Text = "";
            TextStockMin.Text = "";
            TextStock.Text = "";
            TextCategoria.Text = "";
        }

      
        private void Consulta_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
         if(RbId.Checked)
            {
                TablaDatos.Items.Clear();
                RefrescarTabla("id", TextConsulta.Text);
                
            }
         if (RbNombre.Checked)
            {
                TablaDatos.Items.Clear();
                RefrescarTabla("nombre", TextConsulta.Text);
            }
            if (RbCategoria.Checked)
            {
                TablaDatos.Items.Clear();
                RefrescarTabla("categoria", TextConsulta.Text);
            }
        }

        private void CargarInventario_Event(object sender, EventArgs e)
        {
            RefrescarTabla();
            this.Refresh();
        }
        private void RefrescarTabla()
        {
            string connectionString = "datasource=remotemysql.com;port=3306;username=pf7UNUfjqi;password=3Jq7lpo46I;database=pf7UNUfjqi;";
            string query = "SELECT * FROM Producto";
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
                    MessageBox.Show("No hay productos en inventario!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefrescarTabla(String atri , String valor)
        {
            string connectionString = "datasource=remotemysql.com;port=3306;username=pf7UNUfjqi;password=3Jq7lpo46I;database=pf7UNUfjqi;";
            string query = "SELECT * FROM Producto WHERE "+atri+"='"+valor+"' ";
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
                    MessageBox.Show("No hay productos en inventario!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                materialListView1.Items.Clear();
                MessageBox.Show(ex.Message);
            }
        }


        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
