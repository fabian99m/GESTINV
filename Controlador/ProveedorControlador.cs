
using System;
using System.Collections.Generic;
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
            this.proveedor.GuardarProveedor(proveedor);
        }

         public List<String> ConsultarProveedores()
        {
            return this.proveedor.ConsultarProveedores();
        }
    }
}
