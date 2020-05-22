using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace AplicacionWeb.Models
{
    public class MarcaCLS
    {
        [Display(Name = "Id Marca")]
        public int idmarca { get; set; }

        [Display(Name = "Nombre Marca")]
        [Required]
        [StringLength(100, ErrorMessage ="La longitud maxima es 100")]
        public string nombre { get; set;  }

        [Display(Name = "Decripcion Marca")]
        [Required]
        [StringLength(100, ErrorMessage = "La longitud maxima es 200")]
        public string descripcion { get; set; }

        public int bhabilitado { get; set; }
    }
}