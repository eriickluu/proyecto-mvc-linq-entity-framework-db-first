using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AplicacionWeb.Models
{
    public class SucursalCLS
    {
        [Display(Name = "Id Sucursal")]
        public int idsucursal { get; set; }

        [Display(Name ="Nombre Sucursal")]
        [StringLength(100, ErrorMessage ="Longitud maxima 100")]
        [Required]
        public string nombre { get; set; }

        [Display(Name = "Direccion")]
        [StringLength(200, ErrorMessage = "Longitud maxima 200")]
        [Required]
        public string direccion { get; set; }
        [Display(Name = "Telefono Sucursal")]
        [Required]
        [StringLength(10, ErrorMessage = "Longitud maxima 10")]
        public string telefono { get; set; }
        [Display(Name = "Email Sucursal")]
        [StringLength(100, ErrorMessage = "Longitud maxima 100")]
        [Required]
        [EmailAddress(ErrorMessage ="Ingrese un email valido")]
        public string email { get; set; }
        [Display(Name = "Fecha Apertura")]
        [DataType(DataType.Date)]
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy:MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fechaApertura { get; set; }
        public int bhabilitado { get; set; }

    }
}