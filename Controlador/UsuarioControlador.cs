
using Modelo.DAO;
using Modelo.DTO;
using System.Windows.Forms;

namespace Controlador
{
    public class UsuarioControlador
    {

        UsuarioDAO user;

        public UsuarioControlador()
        {
            this.user = new UsuarioDAO();
        }

        public void IniciarSesion(UsuarioDTO user, Form login_form) 
        {
            this.user.IniciarSesion( user, login_form);
        }
    }
}
