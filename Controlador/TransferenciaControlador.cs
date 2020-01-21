using Modelo.DAO;
using Modelo.DTO;
using System;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace Controlador
{
  public class TransferenciaControlador
    {
        TransferenciaDAO Orden;


        public TransferenciaControlador()
        {
            this.Orden = new TransferenciaDAO();
        }

        public void RegistrarEntrada(ProductoDTO producto, String fecha, int cantidad,String proveedor)
        {
          Boolean res =   Orden.RegistrarEntrada(producto, fecha, cantidad,proveedor);
            if(res)
            {
                MessageBox.Show("Entrada guardada satisfactoriamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Entrada guardada sin éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RegistrarSalida(ProductoDTO producto, String fecha, int cantidad)
        {
            Boolean res = Orden.RegistrarSalida(producto, fecha, cantidad);
            if (res)
            {
                MessageBox.Show("Salida guardada satisfactoriamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Salida guardada sin éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ConsultarEntrada(MaterialListView TablaOrden)
        {
            Orden.ConsultarEntrada(TablaOrden);
        }

        public void ConsultarSalida(MaterialListView TablaOrden)
        {
            Orden.ConsultarSalida(TablaOrden);
        }
    }


}
