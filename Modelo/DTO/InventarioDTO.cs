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

        public InventarioDTO(List<ProductoDTO> productoList)
        {
            this.productoList = productoList;
        }

        public List<ProductoDTO> ProductoList
        { 
        
            get { return productoList; }
            set { productoList= value; }
        }

    }
}
