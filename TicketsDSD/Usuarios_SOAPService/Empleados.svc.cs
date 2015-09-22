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
    public class Empleados : IEmpleados
    {
        private EmpleadoDAO empleadoDAO = null;

        public object CodEmpleado { get; private set; }

        private EmpleadoDAO EmpleadoDAO
        {
            get
            {
                if (empleadoDAO == null)
                    empleadoDAO = new EmpleadoDAO();
                return empleadoDAO;
            }
        }

        public Empleado CrearEmpleado(string ApellidoEmpleado, string CorreoEmpleado, string CargoEmpleado, string TelefonoEmpleado, string AreaEmpleado)
        {
            throw new NotImplementedException();
        }

        public Empleado CrearEmpleado(string nombreEmpleado, string apellidoEmpleado, string correoEmpleado, string cargoEmpleado, string telefonoEmpleado, string areaEmpleado)
        {
            Empleado empleadoACrear = new Empleado()
            {
                NombreEmpleado = nombreEmpleado,
                ApellidoEmpleado = apellidoEmpleado,
                CorreoEmpleado = correoEmpleado,
                CargoEmpleado = cargoEmpleado,
                TelefonoEmpleado = telefonoEmpleado,
                AreaEmpleado = areaEmpleado,
            };
            return EmpleadoDAO.Crear(empleadoACrear);

        }

        public void EliminarEmpleado(int CodEmpleado)
        {
            Empleado empleadoExistente = EmpleadoDAO.Obtener(CodEmpleado);
            EmpleadoDAO.Eliminar(empleadoExistente);
        }

        public List<Empleado> ListarEmpleados()
        {
            return EmpleadoDAO.ListarTodos().ToList();
        }

        public Empleado ModificarEmpleado(int CodEmpleado, string ApellidoEmpleado, string CorreoEmpleado, string CargoEmpleado, string TelefonoEmpleado, string AreaEmpleado)
        {
            throw new NotImplementedException();
        }

        public Empleado ModificarEmpleado(int codEmpleado, string nombreEmpleado, string apellidoEmpleado, string correoEmpleado, string cargoEmpleado, string telefonoEmpleado, string areaEmpleado)
        {
            Empleado empleadoAModificar = new Empleado()
            {
                CodEmpleado = codEmpleado,
                NombreEmpleado = nombreEmpleado,
                ApellidoEmpleado = apellidoEmpleado,
                CorreoEmpleado = correoEmpleado,
                CargoEmpleado = cargoEmpleado,
                TelefonoEmpleado = telefonoEmpleado,
                AreaEmpleado = areaEmpleado,
            };
            return EmpleadoDAO.Modificar(empleadoAModificar);

        }

        public Empleado ObtenerEmpleado(int CodEmpleado)
        {
            //Empleado emple = new Empleado();
            //emple.ApellidoEmpleado = "Escobedo";
            return EmpleadoDAO.Obtener(CodEmpleado);
            //return emple;
        }

        Empleado IEmpleados.EliminarEmpleado(int CodEmpleado)
        {
            throw new NotImplementedException();
        }
    }
}