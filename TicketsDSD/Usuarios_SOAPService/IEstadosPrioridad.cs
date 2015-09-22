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
    public interface IEstadosPrioridad
    {
        [OperationContract]
        Estado ObtenerEstado(int value);
        [OperationContract]
        Prioridad ObtenerPrioridad(int value);
    }
}
