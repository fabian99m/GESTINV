using System;


namespace Modelo.DTO
{
    class Transferencia
    {

        Producto producto;
        String tipo;
        int cantidad;
        string fecha;

        public Transferencia(Producto producto, string tipo, int cantidad, string fecha)
        {
            this.producto = producto;
            this.tipo = tipo;
            this.cantidad = cantidad;
            this.fecha = fecha;
        }

        public Producto Producto
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
