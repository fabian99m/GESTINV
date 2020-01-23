using Modelo.DAO;
using Modelo.DTO;
using System;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Collections.Generic;


namespace Controlador
{
    public class RegistroControlador
    {
        RegistroDAO registroDAO;


        public RegistroControlador()
        {
            this.registroDAO = new RegistroDAO();
        }

        public void RegistrarEntrada(ProductoDTO producto, String fecha, int cantidad, String proveedor)
        {
            Boolean res = registroDAO.RegistrarEntrada(producto, fecha, cantidad, proveedor);
            if (res)
            {
                MessageBox.Show("Entrada guardada satisfactoriamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Entrada guardada sin éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int RegistrarSalida(ProductoDTO producto, String fecha, int cantidad)
        {
            int res = registroDAO.RegistrarSalida(producto, fecha, cantidad);
            if (res == 1 || res == 2)
            {
                MessageBox.Show("Salida guardada satisfactoriamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cantidad de salida mayor a Stock actual, el producto quedará sin Stock en inventario!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return res;
        }

        public void ConsultarEntrada(MaterialListView TablaOrden)
        {
            List<String[]> datos = registroDAO.ConsultarEntrada();
            foreach (String[] item in datos)
            {
                var listViewItem = new ListViewItem(item);
                TablaOrden.Items.Add(listViewItem);
            }
        }

        public void ConsultarSalida(MaterialListView TablaSalida)
        {
            List<String[]> datos = registroDAO.ConsultarSalida();
            foreach (String[] item in datos)
            {
                var listViewItem = new ListViewItem(item);
                TablaSalida.Items.Add(listViewItem);
            }
        }

        public List<List<string>> ProductoMasVendido()
        {
            return this.registroDAO.ProductoMasVendido();
        }

    }
}
