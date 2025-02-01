using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketBert.Models
{
    public class CategoriaMd
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese nombre")]
        [Display(Name = "Nombre de categoria")]
        public string Nombre { get; set; }

        [Display(Name = "Orden de visualización")]
        [Range(1, 100, ErrorMessage = "El valor debe estar entre 1 y 100")]
        public int? Orden { get; set; }
    }
}
