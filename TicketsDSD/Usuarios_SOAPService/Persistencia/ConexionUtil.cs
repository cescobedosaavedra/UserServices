using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Usuarios_SOAPService.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            return "Data Source=GSSPL00038;Initial Catalog=BD_Empleados;Integrated Security=True;";
            //return "Data Source = chio - hp; Initial Catalog = BD_Empleados; Integrated Security = True;";
        }
    }
}