using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using Controlador;
using System.Drawing;

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

                inv_controlador.GuardarProductos(TextId.Text, TextNombre.Text, float.Parse(TextPrecio.Text)
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
            if (!String.IsNullOrEmpty(TextConsulta.Text))
            {
                consulta();
            }
            else
            {
                MessageBox.Show("Ingrese un dato para la consulta!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarInventario_Event(object sender, EventArgs e)
        {
            RefrescarTabla();
            this.Refresh();
        }
        private void RefrescarTabla()
        {
            inv_controlador.ConsultarProductos(TablaDatos);
        }

        private void RefrescarTabla(String atributo, String valor)
        {
            inv_controlador.ConsultarProductos(TablaDatos, atributo, valor);
        }


        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            TablaDatos.Items.Clear();
            RefrescarTabla();
        }

        private void TextStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TextStockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TextPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TextId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TextConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                consulta();
            }
        }

        public void consulta()
        {
            if (RbId.Checked)
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

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (TablaDatos.SelectedItems.Count > 0)
            {
              String id = TablaDatos.SelectedItems[0].Text;
              string message ="Quieres eliminar el producto con ID:"+id+"";
              String caption = "Eliminar producto";
              var resultado = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,MessageBoxIcon.Question);

               if (resultado == DialogResult.Yes)
                {
                  inv_controlador.EliminarProductos(id);
                  TablaDatos.Items.Clear();
                  RefrescarTabla();
                  MessageBox.Show("Producto eliminado con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
            {
                MessageBox.Show("Seleccione un producto para eliminar!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}