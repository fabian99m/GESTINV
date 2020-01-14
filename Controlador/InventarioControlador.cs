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









        public void GuardarProductos(int id, String nombre)
        {
            using (EntidadesInv db = new EntidadesInv())
            {
                Producto p = new Producto();
                p.id = id;
                p.nombre = nombre;
                db.Producto.Add(p);
                db.SaveChanges();
              
            }
        }


    }
}
