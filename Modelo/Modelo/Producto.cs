﻿using System;


namespace Modelo.DTO
{
    public class Producto
    {
        String id;
        String nombre;
        float precio;
        int stock;
        int stockMin;
        String categoria;

        public Producto()
        {
        }

        public Producto(String id, String nombre, float precio, int stock, int stockMin, string categoria)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            this.stockMin = stockMin;
            this.categoria = categoria;
        }
        public Producto(String nombre, float precio, int stockMin, string categoria)
        {         
            this.nombre = nombre;
            this.precio = precio;           
            this.stockMin = stockMin;
            this.categoria = categoria;
        }

        public Producto(String id, String nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }



        public String ID
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
