using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Usuarios_SOAPService.Dominio
{
    [DataContract] 
    public class Estado
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string EstadoTicket { get; set; }
    }
}