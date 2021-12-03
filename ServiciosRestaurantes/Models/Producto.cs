using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServiciosRestaurantes.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        [Display(Name = "Producto")]
        public string Nombre { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        [Display(Name = "Restaurante")]
        public int IdComercio { get; set; }

        public virtual Restaurante Restaurante { get; set; }
    }
}
