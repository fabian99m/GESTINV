
using Modelo.DTO;
using System.Windows.Forms;


namespace Modelo.DAO
{
    public interface UsuarioDAO
    {
      void IniciarSesion(UsuarioDTO user, Form login_form);        
    }
}
