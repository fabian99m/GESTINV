using System;


namespace Modelo.DTO
{
    class OrdenDTO
    {

        ProductoDTO producto;
        String tipo;
        int cantidad;
        string fecha;

        public OrdenDTO(ProductoDTO producto, string tipo, int cantidad, string fecha)
        {
            this.producto = producto;
            this.tipo = tipo;
            this.cantidad = cantidad;
            this.fecha = fecha;
        }

        public ProductoDTO Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public String Tipo
        {
            get { return tipo; }
            set {  tipo = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
