using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace AplicacionWeb.Models
{
    public class ClienteCLS
    {
        [Display(Name ="Id Cliente")]
        public int idcliente { get; set; }
        [Display(Name ="Nombre cliente")]
        public string nombre { get; set; }
        [Display(Name = "Apellido Paterno")]
        public string aPaterno { get; set; }
        [Display(Name = "Apellido Materno")]
        public string aMaterno { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public int idsexo { get; set; }
        [Display(Name = "Telefono FIjo")]
        public string telefonoFijo { get; set; }
        public string telefonoCelular { get; set; }
    }
}