using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.DTO
{
    public class ProductoDTO
    {
        int id;
        String nombre;
        float precio { get; set; }
        int stock { get; set; }
        int stockMin { get; set; }
        String categoria { get; set; }

        public ProductoDTO(int id, string nombre, float precio, int stock, int stockMin, string categoria)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            this.stockMin = stockMin;
            this.categoria = categoria;
        }

        public ProductoDTO(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;      
        }

        public int ID
        {
          get{return id; }
          set { id = value;}
        }

        public String Nombre
        {
          get{return nombre;}
          set{nombre = value;}
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public int StockMin
        {
            get { return stockMin; }
            set { stockMin = value; }
        }

        public String Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

    }
}
