using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Servicios.Models
{
    public class Restaurante
    {
        [Key]
        public int IdRestaurante { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Telefono { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
