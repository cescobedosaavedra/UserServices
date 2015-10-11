using Usuarios_SOAPService.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Usuarios_SOAPService.Dominio;
using NHibernate.Criterion;

namespace Usuarios_SOAPService.Persistencia
{
    public class EmpleadoDAO : BaseDAO<Empleado, int>
    {


        public Empleado VerificarUsuario(string NombreEmpleado, string Password)
        {
            return NHibernateHelper.ObtenerSesion().
                CreateCriteria(typeof(Empleado)).
                Add(Restrictions.And(
                    Restrictions.Eq("NombreEmpleado", NombreEmpleado), Restrictions.And(
                        Restrictions.Eq("Password", Password), Restrictions.Eq("Estado", "A")))).
                UniqueResult<Empleado>();
        }
    }  
}