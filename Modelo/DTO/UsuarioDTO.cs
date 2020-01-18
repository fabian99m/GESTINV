using System;


namespace Modelo.DTO
{
    public class UsuarioDTO
    {
        
        private String id;
        private String nombre;
        private String apellido;
        private String tipo;
        private String contrasena;

        public UsuarioDTO(string id, string nombre, string apellido, string tipo, string contrasena)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipo = tipo;
            this.contrasena = contrasena;
        }

        public UsuarioDTO(string nombre, string contrasena)
        {
            this.nombre= nombre;
            this.contrasena = contrasena;
        }


        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public String Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
    }
}
