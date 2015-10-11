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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEstadosPrioridadREST" in both code and config file together.
    [ServiceContract]
    public interface IEstadosPrioridadREST
    {
        // Para Estado --------------

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Estado", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Estado CrearEstadoREST(Estado estadoACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Estado/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        Estado ObtenerEstadoREST(string codigo);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Estado", ResponseFormat = WebMessageFormat.Json)]
        Estado ModificarEstadoREST(Estado estadoAModificar);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Estado/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        void EliminarEstadoREST(string codigo);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Estados", ResponseFormat = WebMessageFormat.Json)]
        List<Estado> ListarEstadoREST();


        // Para Prioridad --------------

        //[OperationContract]
        //[WebInvoke(Method = "POST", UriTemplate = "Prioridad", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //Prioridad CrearPrioridadREST(Prioridad prioridadACrear);

        //[OperationContract]
        //[WebInvoke(Method = "GET", UriTemplate = "Prioridad/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        //Prioridad ObtenerPrioridadREST(string codigo);

        //[OperationContract]
        //[WebInvoke(Method = "PUT", UriTemplate = "Prioridad", ResponseFormat = WebMessageFormat.Json)]
        //Prioridad ModificarPrioridadREST(Prioridad prioridadAModificar);

        //[OperationContract]
        //[WebInvoke(Method = "DELETE", UriTemplate = "Prioridad/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        //void EliminarPrioridadREST(string codigo);

        //[OperationContract]
        //[WebInvoke(Method = "GET", UriTemplate = "Prioridades", ResponseFormat = WebMessageFormat.Json)]
        //List<Prioridad> ListarprioridadREST();
    }
}
