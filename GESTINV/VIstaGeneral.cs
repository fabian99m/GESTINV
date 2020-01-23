using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Controlador;
using Vista.ModificarProducto;
using Modelo.DTO;
using Vista.Proveedor;
using System.Collections.Generic;
using System.Drawing;
using Vista.Alerta;

namespace GESTINV
{
    public partial class Vista : MaterialForm
    {
        InventarioControlador inv_controlador = new InventarioControlador();
        TransferenciaControlador transferencia_controlador = new TransferenciaControlador();
        ProveedorControlador proveedor_controlador = new ProveedorControlador();

        public Vista()
        {
            //vista de admin
         
            IniciarVista(); 
            this.LabelUser.Text = "Admin";               
        }

        public Vista(int valor)
        {
            //vista de auxiliar
            
            IniciarVista();
            materialTabControl2.Controls.Remove(tabPage1);
            materialTabControl1.Controls.Remove(tabPage6);
            this.LabelUser.Text = "Auxiliar";              
            ModificarProducto.Visible = false;
            EliminarProducto.Visible = false;
        }

        public void IniciarVista()
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
            RbId.Select();
            TablaInventario.HideSelection = true;
            TablaEntrada.HideSelection = true;
            TablaSalida.HideSelection = true;
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
            RefrescaraTablaEntrada();
            refrescarTablaSalida();
            this.Refresh();
            CargarProveedor();
        }

        public void CargarProveedor()
        {       
            List<String> lista_proveedor = proveedor_controlador.ConsultarProveedores();
            if (lista_proveedor.Count > 0) {             
                cbProveedor.DataSource = lista_proveedor;
                cbProveedor.Refresh();
            }  
        }

        private void RefrescaraTablaEntrada()
            
        {
            TablaEntrada.Items.Clear();
           transferencia_controlador.ConsultarEntrada(TablaEntrada);
        }

        private void refrescarTablaSalida()
        {
            TablaSalida.Items.Clear();
            transferencia_controlador.ConsultarSalida(TablaSalida);
        }

        private void RefrescarTablaInvetario()
        {
            TablaInventario.Items.Clear();
            inv_controlador.ConsultarProductos(TablaInventario);
        }

        private void RefrescarTablaInvetario(String atributo, String valor)
        {
            inv_controlador.ConsultarProductos(TablaInventario, atributo, valor);
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            RefrescarTablaInvetario();
            TextConsulta.Text = "";
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

        private void btnModificarProducto_Click(object sender, EventArgs e)
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
                  
                }
            } else
            {
                MessageBox.Show("Seleccione un producto para eliminar!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardarEntrada_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TextID2.Text) && !String.IsNullOrEmpty(TextCantidad.Text))
            {
                if (inv_controlador.BuscarExistenciaProducto(TextID2.Text))
                {
                    transferencia_controlador.RegistrarEntrada(new ProductoDTO(TextID2.Text, inv_controlador.BuscarNombreProducto(TextID2.Text)),Time.Value.ToString(), Convert.ToInt32(TextCantidad.Text), cbProveedor.SelectedItem.ToString());                  
                    RefrescaraTablaEntrada();
                    LImpiarentrada();
                    RefrescarTablaInvetario();
                } else
                {
                    MessageBox.Show("Producto no existente en inventario!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
            {
                MessageBox.Show("Ingrese todos los datos para guardar!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void LImpiarentrada()
        {
            TextID2.Text = "";
            TextCantidad.Text = "";
            cbProveedor.SelectedIndex = 0;
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
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedor_view proveedor = new Proveedor_view();
            proveedor.ShowDialog();
            CargarProveedor();
        }

        private void btnGuardarSalida_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TextID3.Text) && !String.IsNullOrEmpty(TextCantidad2.Text))
            {
                if (inv_controlador.BuscarExistenciaProducto(TextID3.Text))
                {
                   int res = transferencia_controlador.RegistrarSalida(new ProductoDTO(TextID3.Text,  inv_controlador.BuscarNombreProducto(TextID3.Text) ), Time.Value.ToString(), Convert.ToInt32(TextCantidad2.Text));
                    RefrescarTablaInvetario();
                    refrescarTablaSalida();                   
                    if(res!=2)
                    {
                        Alertar(TextID3.Text,res);   
                    }
                    LimpiarSalida();
                }
                else
                {
                    MessageBox.Show("Producto no existente en inventario!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos para guardar!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } 

        private void Alertar(String id,int res)
        {
            if(res==1)
            {
                Alerta2.BalloonTipText = "Producto " + inv_controlador.BuscarNombreProducto(id) + " a punto de agortarse!, click para tomar acciones al respecto.";
            } 
            if(res==3)
            {
                Alerta2.BalloonTipText = "Producto " + inv_controlador.BuscarNombreProducto(id) + " agotado!, click para tomar acciones al respecto.";
            }
            Alerta2.Icon = SystemIcons.Warning;
            Alerta2.Text = "Producto en escasez!!!";
            Alerta2.Visible = true;        
            Alerta2.BalloonTipTitle = "Alerta!";
            Alerta2.ShowBalloonTip(100);
        }

        private void LimpiarSalida()
        {
            TextID3.Text = "";
            TextCantidad2.Text = "";
        }

        private void TextCantidad2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void Alerta2_BalloonTipClicked(object sender, EventArgs e)
        {
            Alerta a = new Alerta();
            a.ShowDialog();
        }
    }
}