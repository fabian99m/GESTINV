using System;
using Modelo.DAO;
using Modelo.DTO;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace Controlador
{
    public class InventarioControlador
    {
        InventarioDAO InvDAO;

        public InventarioControlador()
        {
            this.InvDAO = new InventarioDAO();
        }

        public void GuardarProductos(String id, String nombre, float precio, int stock, int stockMin, String categoria)
        {
           Boolean res = InvDAO.GuardarProducto(new ProductoDTO(id, nombre, precio, stock, stockMin, categoria));
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
            InvDAO.ConsultarProducto(TablaDatos);
        }

        public void ConsultarProductos(MaterialListView TablaDatos, String atributo, String valor)
        {
            InvDAO.ConsultarProducto(TablaDatos, atributo, valor);
        }

        public Boolean BuscarExistenciaProducto(String id)
        {
            return this.InvDAO.ComprobarExistencia(id);
        }

        public void EliminarProductos(String id)
        {
            Boolean res = InvDAO.EliminarProductos(id);   
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
          Boolean res = InvDAO.ModificarProductos(new ProductoDTO(id, nombre, precio, stock, stockMin, categoria),IdOld);
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
            return InvDAO.BuscarNombreProducto(id);

        }

    }

   }
