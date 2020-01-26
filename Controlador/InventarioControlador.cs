using System;
using Modelo.ImplDAO;
using Modelo.DTO;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Controlador
{
    public class InventarioControlador
    {
        
        InventarioImplDAO InventarioImpl;

        public InventarioControlador()
        {
            this.InventarioImpl = new InventarioImplDAO();
        }

        public void GuardarProductos(String id, String nombre, float precio, int stock, int stockMin, String categoria)
        {
           Boolean res = InventarioImpl.GuardarProducto(new Producto(id, nombre, precio, stock, stockMin, categoria));
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
            
             List<String[]> datos = InventarioImpl.ConsultarProducto();
            foreach (String[] item in datos) {
                var listViewItem = new ListViewItem(item);
                TablaDatos.Items.Add(listViewItem);
            }
        }

        public void ConsultarProductos(MaterialListView TablaDatos,String atributo, String valor)
        {
            List<String[]> datos = InventarioImpl.ConsultarProducto(atributo, valor);
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
            return this.InventarioImpl.ComprobarExistencia(id);
        }

        public Producto BuscarProducto(String id)
        {
            return this.InventarioImpl.BuscarProducto(id);
        }

        public void EliminarProductos(String id)
        {
            Boolean res = InventarioImpl.EliminarProductos(id);   
            if(res)
            {
                MessageBox.Show("Producto eliminado con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Producto eliminado sin éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ModificarProductos( String nombre, float precio,  int stockMin, String categoria,String IdOld)
        {
          Boolean res = InventarioImpl.ModificarProductos(new Producto( nombre, precio,  stockMin, categoria),IdOld);
            if (res)
            {
                MessageBox.Show("Producto modificado con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Producto modificado sin éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

   }
