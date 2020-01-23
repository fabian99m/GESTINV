using System;
using Modelo.DAO;
using Modelo.DTO;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Controlador
{
    public class InventarioControlador
    {
        InventarioDAO InventarioDAO;

        public InventarioControlador()
        {
            this.InventarioDAO = new InventarioDAO();
        }

        public void GuardarProductos(String id, String nombre, float precio, int stock, int stockMin, String categoria)
        {
           Boolean res = InventarioDAO.GuardarProducto(new ProductoDTO(id, nombre, precio, stock, stockMin, categoria));
            if(res)
            {
                MessageBox.Show("Producto insertado satisfactoriamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Producto insertado sin éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ConsultarProductos(MaterialListView TablaDatos)
        {
             List<String[]> datos = InventarioDAO.ConsultarProducto();
            foreach (String[] item in datos) {
                var listViewItem = new ListViewItem(item);
                TablaDatos.Items.Add(listViewItem);
            }
        }

        public void ConsultarProductos(MaterialListView TablaDatos,String atributo, String valor)
        {
            List<String[]> datos = InventarioDAO.ConsultarProducto(atributo, valor);
            if (datos.Count > 0)
            {
                foreach (String[] item in datos)
                {
                    var listViewItem = new ListViewItem(item);
                    TablaDatos.Items.Add(listViewItem);
                }
            } else
            {
                ConsultarProductos(TablaDatos);
            }
        }

        public Boolean BuscarExistenciaProducto(String id)
        {
            return this.InventarioDAO.ComprobarExistencia(id);
        }

        public void EliminarProductos(String id)
        {
            Boolean res = InventarioDAO.EliminarProductos(id);   
            if(res)
            {
                MessageBox.Show("Producto eliminado con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Producto eliminado sin éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ModificarProductos(String id, String nombre, float precio, int stock, int stockMin, String categoria,String IdOld)
        {
          Boolean res = InventarioDAO.ModificarProductos(new ProductoDTO(id, nombre, precio, stock, stockMin, categoria),IdOld);
            if (res)
            {
                MessageBox.Show("Producto modificado con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Producto modificado sin éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public String BuscarNombreProducto(String id)
        {
            return InventarioDAO.BuscarNombreProducto(id);

        }

    }

   }
