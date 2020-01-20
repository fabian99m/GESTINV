using System;
using Modelo.DAO;
using Modelo.DTO;
using MaterialSkin.Controls;

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
            InvDAO.GuardarProducto(new ProductoDTO(id, nombre, precio, stock, stockMin, categoria));
        }

        public void ConsultarProductos(MaterialListView TablaDatos)
        {
            InvDAO.ConsultarProducto(TablaDatos);
        }

        public void ConsultarProductos(MaterialListView TablaDatos, String atributo, String valor)
        {
            InvDAO.ConsultarProducto(TablaDatos, atributo, valor);
        }

        public Boolean BuscarProducto(String id)
        {
            return this.InvDAO.BuscarProducto(id);
        }

        public void EliminarProductos(String id)
        {
            InvDAO.EliminarProductos(id);        
        }

        public void ModificarProductos(String id, String nombre, float precio, int stock, int stockMin, String categoria,String IdOld)
        {
            InvDAO.ModificarProductos(new ProductoDTO(id, nombre, precio, stock, stockMin, categoria),IdOld);
        }

        public String BuscarNombreProducto(String id)
        {
            return InvDAO.BuscarNombreProducto(id);
        }

    }

   }
