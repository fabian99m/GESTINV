using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.DTO
{
   public class InventarioDTO
    {
        List<ProductoDTO> productoLista;

        public InventarioDTO()
        {
            this.productoLista = new List<ProductoDTO>();
        }

        public List<ProductoDTO> ProductoList
        { 
        
            get { return this.productoLista; }
            set { this.productoLista= value; }
        }

    }
}
