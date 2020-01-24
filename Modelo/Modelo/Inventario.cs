using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.DTO
{
   public class Inventario
    {
        List<Producto> productoLista;

        public Inventario()
        {
            this.productoLista = new List<Producto>();
        }

        public List<Producto> ProductoList
        { 
        
            get { return this.productoLista; }
            set { this.productoLista= value; }
        }

    }
}
