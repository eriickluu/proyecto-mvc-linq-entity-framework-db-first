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
        [Required]
        [StringLength(100, ErrorMessage ="Longuitud maxima 100")]
        [Display(Name ="Nombre cliente")]
        public string nombre { get; set; }
        [Display(Name = "Apellido Paterno")]
        [StringLength(100, ErrorMessage = "Longuitud maxima 150")]
        [Required]
        public string aPaterno { get; set; }
        [Display(Name = "Apellido Materno")]
        [StringLength(100, ErrorMessage = "Longuitud maxima 150")]
        [Required]
        public string aMaterno { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Longuitud maxima 200")]
        [EmailAddress(ErrorMessage ="Ingrese un email valido.")]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Direccion")]
        [StringLength(100, ErrorMessage = "Longuitud maxima 200")]
        public string direccion { get; set; }
        [Display(Name = "Sexo")]
        public int idsexo { get; set; }
        [Display(Name = "Telefono FIjo")]
        [Required]
        [StringLength(100, ErrorMessage = "Longuitud maxima 10")]
        public string telefonoFijo { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Longuitud maxima 10")]
        [Display(Name = "Telefono Celular")]
        public string telefonoCelular { get; set; }
        public int bhabilitado { get; set; }
    }
}