
using Modelo.ImplDAO;
using Modelo.DTO;
using System.Windows.Forms;

namespace Controlador
{
    public class UsuarioControlador
    {

       UsuarioImplDAO UserImpl;

        public UsuarioControlador()
        {
            this.UserImpl = new UsuarioImplDAO();
        }

        public void IniciarSesion(Usuario user, Form login_form) 
        {
            this.UserImpl.IniciarSesion( user, login_form);
        }
    }
}
