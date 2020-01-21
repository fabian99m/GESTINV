
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Modelo.DAO;
using Modelo.DTO;

namespace Controlador
{
    public class ProveedorControlador
    {
        ProveedorDAO proveedor;

        public ProveedorControlador()
        {
            this.proveedor = new ProveedorDAO();
        }


        public void GuardarProovedor(ProveedorDTO proveedor)
        {
             Boolean res = this.proveedor.GuardarProveedor(proveedor);
            if(res)
            {
                MessageBox.Show("Proveedor insertado satisfactoriamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Proveedor insertado sin éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

         public List<String> ConsultarProveedores()
        {
            return this.proveedor.ConsultarProveedores();
        }
    }
}
