using Modelo.DAO;
using Modelo.DTO;
using System;
using MaterialSkin.Controls;

namespace Controlador
{
  public class OrdenControlador
    {
        OrdenDAO Orden;


        public OrdenControlador()
        {
            this.Orden = new OrdenDAO();
        }

        public void RegistrarOrden(ProductoDTO producto, String tipo, String fecha, int cantidad)
        {
            Orden.RegistrarOrden(producto, tipo, fecha, cantidad);
        }

        public void ConsultarOrden(MaterialListView TablaOrden)
        {
            Orden.ConsultarOrden(TablaOrden);
        }

    }


}
