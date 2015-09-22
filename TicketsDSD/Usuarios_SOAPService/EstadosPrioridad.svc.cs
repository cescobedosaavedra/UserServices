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
      public class EstadosPrioridad : IEstadosPrioridad
    {
        private EstadoDAO estadoDAO = null;
        public object IdEstado { get; private set; }

        private EstadoDAO EstadoDAO
        {
            get
            {
                if (estadoDAO == null)
                    estadoDAO = new EstadoDAO();
                return estadoDAO;
            }
        }

        private PrioridadDAO prioridadDAO = null;
        public object IdPrioridad { get; private set; }

        private PrioridadDAO PrioridadDAO
        {
            get
            {
                if (prioridadDAO == null)
                    prioridadDAO = new PrioridadDAO();
                return prioridadDAO;
            }
        }

        public Estado ObtenerEstado(int IdEstado)
        {
            //Empleado emple = new Empleado();
            //emple.ApellidoEmpleado = "Escobedo";
            return EstadoDAO.Obtener(IdEstado);
            //return emple;
        }

          public Prioridad ObtenerPrioridad(int IdPrioridad)
        {

            return PrioridadDAO.Obtener(IdPrioridad);
        }

    }
}
