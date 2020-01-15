﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DAO;
using Modelo.DTO;
using MaterialSkin;
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

        public void EliminarProductos(String id)
        {
            InvDAO.EliminarProductos(id);        
        }

      }

   }
