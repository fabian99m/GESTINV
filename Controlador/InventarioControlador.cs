using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Datos;


namespace Controlador
{
   public class InventarioControlador
    {









        public void GuardarProductos(int id, String nombre,float precio , int stock , int stockMin, String categoria)
        {
            
            using (EntidadesInv db = new EntidadesInv())
            {
                Producto p = new Producto();
                p.id = id;
                p.nombre = nombre;
                p.precio = precio;
                p.stock = stock;
                p.stockMin = stockMin;
                p.categoria = categoria;
                db.Producto.Add(p);
                db.SaveChanges();
              
            }
            
        }


    }
}
