using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.DTO
{
    class InventarioDTO
    {
        List<ProductoDTO> productoList;

        public InventarioDTO()
        {
            this.productoList = new List<ProductoDTO>();
        }

        public List<ProductoDTO> ProductoList
        { 
        
            get { return this.productoList; }
            set { this.productoList= value; }
        }

    }
}
