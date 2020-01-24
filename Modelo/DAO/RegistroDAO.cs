using System;
using Modelo.DTO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Modelo.ImplDAO;

namespace Modelo.DAO
{
    public interface RegistroDAO 
    {

         Boolean RegistrarEntrada(ProductoDTO producto, String fecha, int cantidad, String proveedor);

         int RegistrarSalida(ProductoDTO producto, String fecha, int cantidad);

         List<String[]> ConsultarEntrada();

         List<String[]> ConsultarSalida();
        
         List<List<string>> ReporteSalida();

         List<List<string>> ReporteEntrada();


        void EliminarSalida(String id);


         void EliminarEntrada(String id);
        
    }
}
