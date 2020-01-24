﻿
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Modelo.DTO;
using Modelo.ImplDAO;

namespace Controlador
{
    public class ProveedorControlador
    {
      ProveedorImplDAO ProveedorImpl;

        public ProveedorControlador()
        {
            this.ProveedorImpl = new ProveedorImplDAO();
        }


        public void GuardarProovedor(ProveedorDTO proveedor)
        {
             Boolean res = this.ProveedorImpl.GuardarProveedor(proveedor);
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
            return this.ProveedorImpl.ConsultarProveedores();
        }
    }
}
