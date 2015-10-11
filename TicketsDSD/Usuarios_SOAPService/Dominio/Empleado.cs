using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Usuarios_SOAPService.Dominio
{
    [DataContract]
    public class Empleado
    {
        [DataMember]
        public int CodEmpleado { get; set; }
        [DataMember]
        public string NombreEmpleado { get; set; }
        [DataMember]
        public string ApellidoEmpleado { get; set; }
        [DataMember]
        public string CorreoEmpleado { get; set; }
        [DataMember]
        public string CargoEmpleado { get; set; }
        [DataMember]
        public string TelefonoEmpleado { get; set; }
        [DataMember]
        public string AreaEmpleado { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember]
        public string Tipo { get; set; }
        [DataMember]
        public int LoginErrorCount { get; set; }
        
    }
}