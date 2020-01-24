using System;
using System.Collections.Generic;
using Modelo.DTO;


namespace Modelo.DAO
{
    public interface ProveedorDAO 
    {
        Boolean GuardarProveedor(ProveedorDTO proveedor);

        List<String> ConsultarProveedores();
      
    }

}