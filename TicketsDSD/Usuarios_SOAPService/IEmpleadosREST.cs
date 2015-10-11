using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Usuarios_SOAPService.Dominio;

namespace Usuarios_SOAPService
{
  [ServiceContract]
    public interface IEmpleadosREST
    
    {

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Usuarios", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Empleado CrearEmpleadoREST(Empleado usuarioACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Usuarios/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        Empleado ObtenerEmpleadoREST(string codigo);
        //Empleado ObtenerNombreEmpleadoREST(string codigo);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Usuario/{nombre}", ResponseFormat = WebMessageFormat.Json)]
        Empleado ObtenerNombreEmpleadoREST(string nombre);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Usuarios", ResponseFormat = WebMessageFormat.Json)]
        Empleado ModificarEmpleadoREST(Empleado usuarioAModificar);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Usuarios/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        void EliminarEmpleadoREST(string codigo);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Usuarios", ResponseFormat = WebMessageFormat.Json)]
        List<Empleado> ListarEmpleadosREST();

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Contador", ResponseFormat = WebMessageFormat.Json)]
        Empleado ModificarCuentaLoginError(Empleado usuarioAModificar);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Estado", ResponseFormat = WebMessageFormat.Json)]
        Empleado ModificarEstadoEmpleado(Empleado usuarioAModificar);  

    }
}
