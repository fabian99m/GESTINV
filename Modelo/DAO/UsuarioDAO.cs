
using Modelo.DTO;
using System.Windows.Forms;


namespace Modelo.DAO
{
    public interface UsuarioDAO
    {
      void IniciarSesion(Usuario user, Form login_form);        
    }
}
