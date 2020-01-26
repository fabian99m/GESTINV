using System;
using System.Collections.Generic;
using Modelo.DTO;


namespace Modelo.DAO
{
    public interface ProveedorDAO 
    {
        Boolean GuardarProveedor(Proveedor proveedor);

        List<String> ConsultarProveedores();
        List<String[]> ConsultarProveedor( String valor, string tipo);


    }

}