using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Usuarios_SOAPService.Dominio;
using Usuarios_SOAPService.Persistencia;

namespace Usuarios_SOAPService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EstadosPrioridadREST" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EstadosPrioridadREST.svc or EstadosPrioridadREST.svc.cs at the Solution Explorer and start debugging.
    public class EstadosPrioridadREST : IEstadosPrioridadREST
    {

            private EstadoRESTDAO dao = new EstadoRESTDAO();
            private PrioridadRESTDAO dao2 = new PrioridadRESTDAO();

            public Estado CrearEstadoREST(Estado estadoACrear)
            {
                return dao.Crear(estadoACrear);
            }

            public Estado ObtenerEstadoREST(string codigo)
            {
                return dao.Obtener(codigo);
            }

            public Estado ModificarEstadoREST(Estado estadoAModificar)
            {
                return dao.Modificar(estadoAModificar);
            }

            public void EliminarEstadoREST(string codigo)
            {
                dao.Eliminar(codigo);
            }

            public List<Estado> ListarEstadoREST()
            {
                return dao.ListarTodos();
            }


        //Para Prioridad
            //public Prioridad CrearPrioridadREST(Prioridad prioridadACrear)
            //{
            //    return dao2.Crear(prioridadACrear);
            //}

            //public Prioridad ObtenerPrioridadREST(string codigo)
            //{
            //    return dao2.Obtener(codigo);
            //}

            //public Prioridad ModificarPrioridadREST(Prioridad prioridadAModificar)
            //{
            //    return dao2.Modificar(prioridadAModificar);
            //}

            //public void EliminarPrioridadREST(string codigo)
            //{
            //    dao.Eliminar(codigo);
            //}

            //public List<Prioridad> ListarprioridadREST()
            //{
            //    return dao2.ListarTodos();
            //}
        }
    
}
