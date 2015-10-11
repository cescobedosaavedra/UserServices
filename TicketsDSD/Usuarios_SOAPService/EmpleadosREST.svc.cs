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
    public class EmpleadosREST : IEmpleadosREST
    {
        private EmpleadoRESTDAO dao = new EmpleadoRESTDAO();
        public Empleado CrearEmpleadoREST(Empleado empleadoACrear)
        {
            return dao.Crear(empleadoACrear);
        }
        public Empleado ObtenerEmpleadoREST(string codigo)
        {
            return dao.Obtener(codigo);
        }
        public Empleado ObtenerNombreEmpleadoREST(string nombre)
        {
            return dao.ObtenerNombre(nombre);
        }
        public Empleado ModificarEmpleadoREST(Empleado empleadoAModificar)
        {
            return dao.Modificar(empleadoAModificar);
        }
        public Empleado ModificarCuentaLoginError(Empleado empleadoAModificar)
        {
            return dao.ModificarLoginError(empleadoAModificar);
        }
        public Empleado ModificarEstadoEmpleado(Empleado empleadoAModificar)
        {
            return dao.ModificarEstado(empleadoAModificar);
        }
        public void EliminarEmpleadoREST(string codigo)
        {
            dao.Eliminar(codigo);
        }

        public List<Empleado> ListarEmpleadosREST()
        {
            return dao.ListarTodos();
        }



    }

   
}
