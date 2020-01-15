using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DAO;
using Modelo.DTO;



namespace Controlador
{
   public class InventarioControlador
    {





        public void GuardarProductos(int id,String nombre)
        {
            InventarioDAO inv = new InventarioDAO();
            inv.GuardarProducto(new ProductoDTO(id,nombre));

        }


    }
}
