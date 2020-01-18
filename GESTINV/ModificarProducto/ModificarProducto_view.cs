using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Controlador;


namespace Vista.ModificarProducto
{
    public partial class ModificarProducto_view : MaterialForm
    {
        InventarioControlador inv_controlador = new InventarioControlador();
        String aux;
        public ModificarProducto_view(String id , String nombre , String precio , String stock , String stockMin, String categoria)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.BLACK
            );
            TextID.Text = id;
            aux = id;
            TextNombre.Text = nombre;
            TextPrecio.Text = precio;
            TextStock.Text = stock;
            TextStockMin.Text = stockMin;
            TextCategoria.Text = categoria;
        }

        private void ModificarProducto_view_Load(object sender, EventArgs e)
        {

        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TextID.Text) && !String.IsNullOrEmpty(TextNombre.Text) && !String.IsNullOrEmpty(TextPrecio.Text)
              && !String.IsNullOrEmpty(TextStock.Text) && !String.IsNullOrEmpty(TextStockMin.Text) && !String.IsNullOrEmpty(TextCategoria.Text))
            {
                inv_controlador.ModificarProductos(TextID.Text, TextNombre.Text, float.Parse(TextPrecio.Text)
                 , Convert.ToInt32(TextStock.Text), Convert.ToInt32(TextStockMin.Text), TextCategoria.Text,aux);
                
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos para modificar!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void TextID_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TextPrecio_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TextStock_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TextStockMin_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
