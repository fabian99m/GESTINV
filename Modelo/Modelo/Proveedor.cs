using System;

namespace Modelo.DTO
{
    public class Proveedor
    {
        String id;
        String nombre;
        String telefono;
        String email;

        public Proveedor( string nombre, string telefono, string email)
        {    
            this.nombre = nombre;
            this.telefono = telefono;
            this.email = email;
        }

        public String Id
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
