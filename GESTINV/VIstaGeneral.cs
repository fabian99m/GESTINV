﻿using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Controlador;
using Vista.ModificarProducto;
using Modelo.DTO;

namespace GESTINV
{
    public partial class Form1 : MaterialForm
    {
        InventarioControlador inv_controlador = new InventarioControlador();
        OrdenControlador orden_controlador = new OrdenControlador();

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
            TablaInventario.HideSelection = true;
            TablaOrdenes.HideSelection = true;
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
            TablaInventario.HideSelection = true;
            TablaOrdenes.HideSelection = true;
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
                MessageBox.Show("Ingrese todos los datos para añadir!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LimpiarPantalla();
            RefrescarTablaInvetario();
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
            RefrescarTablaInvetario();
            RefrescaraTablaOrden();
            this.Refresh();
        }

        private void RefrescaraTablaOrden()
        {
            orden_controlador.ConsultarOrden(TablaOrdenes);
        }

        private void RefrescarTablaInvetario()
        {
            inv_controlador.ConsultarProductos(TablaInventario);
        }

        private void RefrescarTablaInvetario(String atributo, String valor)
        {
            inv_controlador.ConsultarProductos(TablaInventario, atributo, valor);
        }


        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            TablaInventario.Items.Clear();
            RefrescarTablaInvetario();
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
                TablaInventario.Items.Clear();
                RefrescarTablaInvetario("id", TextConsulta.Text);
            }

            if (RbNombre.Checked)
            {
                TablaInventario.Items.Clear();
                RefrescarTablaInvetario("nombre", TextConsulta.Text);
            }

            if (RbCategoria.Checked)
            {
                TablaInventario.Items.Clear();
                RefrescarTablaInvetario("categoria", TextConsulta.Text);
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            if (TablaInventario.SelectedItems.Count > 0)
            {
                String id = TablaInventario.SelectedItems[0].SubItems[0].Text;
                String nombre = TablaInventario.SelectedItems[0].SubItems[1].Text;
                String precio = TablaInventario.SelectedItems[0].SubItems[2].Text;
                String stock = TablaInventario.SelectedItems[0].SubItems[3].Text;
                String stockMin = TablaInventario.SelectedItems[0].SubItems[4].Text;
                String categoria = TablaInventario.SelectedItems[0].SubItems[5].Text;
                ModificarProducto_view Modificar_view = new ModificarProducto_view(id, nombre, precio, stock, stockMin, categoria);
                Modificar_view.ShowDialog();
                TablaInventario.Items.Clear();
                RefrescarTablaInvetario();     
            }
            else
            {
                MessageBox.Show("Seleccione un producto para modificar!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (TablaInventario.SelectedItems.Count > 0)
            {
              String id = TablaInventario.SelectedItems[0].Text;
              String nombre = TablaInventario.SelectedItems[0].SubItems[1].Text;
              string message ="¿ Quieres eliminar el producto : "+nombre+"-"+id+" ?";
              String caption = "Eliminar producto";
              var resultado = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,MessageBoxIcon.Question);

               if (resultado == DialogResult.Yes)
                {
                  inv_controlador.EliminarProductos(id);
                  TablaInventario.Items.Clear();
                  RefrescarTablaInvetario();
                  MessageBox.Show("Producto eliminado con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
            {
                MessageBox.Show("Seleccione un producto para eliminar!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            orden_controlador.RegistrarOrden(new ProductoDTO(TextID2.Text, inv_controlador.BuscarNombreProducto(TextID2.Text)),"Entrada", Time.Value.ToString(), Convert.ToInt32(TextCantidad.Text));
            TablaOrdenes.Items.Clear();
            RefrescaraTablaOrden();
        }

        private void TextCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TextID2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}