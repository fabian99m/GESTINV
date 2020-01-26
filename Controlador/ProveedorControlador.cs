
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin.Controls;
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


        public void GuardarProovedor(Proveedor proveedor)
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

        public void ConsultarProvedor(MaterialListView TablaDatos, String id,string tipo)
        {
            TablaDatos.Items.Clear();
            List<String[]> datos = this.ProveedorImpl.ConsultarProveedor(id,tipo);
            foreach (String[] item in datos)
            {
                var listViewItem = new ListViewItem(item);
                TablaDatos.Items.Add(listViewItem);
            }
        }
    }
}
