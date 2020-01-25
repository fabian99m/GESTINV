using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Controlador;
using Modelo.DTO;


namespace Vista.Login
{
    public partial class Login : MaterialForm
    {
        UsuarioControlador user_controlador = new UsuarioControlador();

        public Login()
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
            TextNombre.Select();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TextNombre.Text) && !String.IsNullOrEmpty(TextContrasena.Text))
            {
                user_controlador.IniciarSesion(new Usuario(TextNombre.Text, TextContrasena.Text), this);
            } else
            {
                MessageBox.Show("Ingrese todos los datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);             
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

        private void TextNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
