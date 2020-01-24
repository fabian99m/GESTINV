using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Controlador;
using Modelo.DTO;

namespace Vista.Proveedor
{
    public partial class Proveedor_view : MaterialForm
    {
        ProveedorControlador proveedor_controlador = new ProveedorControlador();
        
        public Proveedor_view()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                (Primary)6732650, (Primary)9268835,
                (Primary)6732650, (Accent)6732650,
                TextShade.BLACK
            );
            TextTel.Select();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
        if(!String.IsNullOrEmpty(TextNombre.Text) && !String.IsNullOrEmpty(TextTel.Text) && !String.IsNullOrEmpty(TextEmail.Text))
            {
                proveedor_controlador.GuardarProovedor(new Modelo.DTO.Proveedor(TextNombre.Text, TextTel.Text, TextEmail.Text) );
                LimpiarPantalla();
            } else
            {
              MessageBox.Show("Ingrese todos los datos!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Dispose();
        }

        private void TextTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        public void LimpiarPantalla()
        {
            TextNombre.Text = "";
            TextTel.Text = "";
            TextEmail.Text = "";
        }
    }
}
