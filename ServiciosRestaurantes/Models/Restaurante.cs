using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServiciosRestaurantes.Models
{
    public class Restaurante
    {
        [Key]
        [Display(Name = "Identificador de Restaurante")]
        public int IdRestaurante { get; set; }

        [Required(ErrorMessage = "Debe ingresar el {0}")]
        [StringLength(50, ErrorMessage = "El {0} debe ser menor a {2} y mayor a {1} caracteres", MinimumLength = 4)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar el {0}")]
        [StringLength(50, ErrorMessage = "El {0} debe ser menor a {2} y mayor a {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Debe ingresar el {0}")]
        [Display(Name = "Teléfono")]
        [RegularExpression(@"^\(([0-9]{3})\)([0-9]{4})[\-]([0-9]{4})$", ErrorMessage = "El número no es un dato valido")]
        public string Telefono { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
        public virtual ICollection<Orden> Orden { get; set; }
    }
}
