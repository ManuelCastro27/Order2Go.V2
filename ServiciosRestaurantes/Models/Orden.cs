using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServiciosRestaurantes.Models
{
    public class Orden
    {
        [Key]
        public int IdOrden { get; set; }
        public DateTime FechaOrden { get; set; }
        public int IdRestaurante { get; set; }

        public virtual Restaurante Restaurante { get; set; }
        public virtual ICollection<DetalleOrden> DetallesOrden { get; set; }
    }
}
