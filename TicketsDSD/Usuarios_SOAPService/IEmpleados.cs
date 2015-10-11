using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Usuarios_SOAPService.Dominio;

namespace Usuarios_SOAPService
{
    [ServiceContract]
    public interface IEmpleados
    {
        [OperationContract]
        Empleado CrearEmpleado(string ApellidoEmpleado, string CorreoEmpleado, string CargoEmpleado, string TelefonoEmpleado, string AreaEmpleado, string Password, string Estado);
        [OperationContract]
        Empleado ObtenerEmpleado (int CodEmpleado);
        [OperationContract]
        Empleado ModificarEmpleado(int CodEmpleado, string ApellidoEmpleado, string CorreoEmpleado, string CargoEmpleado, string TelefonoEmpleado, string AreaEmpleado, string Password, string Estado);
        [OperationContract]
        Empleado EliminarEmpleado(int CodEmpleado);
        [OperationContract]
        List<Empleado> ListarEmpleados();

        [OperationContract]
        Empleado VerificarUsuario(string NombreEmpleado, string Password);


    }
}
