﻿using System;
using System.Collections.Generic;
using Modelo.DTO;


namespace Modelo.DAO
{
    public interface InventarioDAO 
    {

         Boolean GuardarProducto(Producto producto);

         List<String[]> ConsultarProducto();

         List<String[]> ConsultarProducto(String atributo, String valor);

         int ValidarStock(String id, int Stocknuevo);

         String BuscarNombreProducto(String id);

         Boolean ComprobarExistencia(String id);

         Producto BuscarProducto(String id);

         Boolean EliminarProductos(String id);

         Boolean ModificarProductos(Producto producto, String id);
       
         void ModificarStock(String id, int Stocknuevo, String tipo);
             
    }
}
