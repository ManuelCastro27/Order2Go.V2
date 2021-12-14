using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiciosRestaurantes.Models
{
    public class VistaOrden
    {
        public Restaurante Restaurante { get; set; }
        public ICollection<OrdenProducto> Productos { get; set; }
    }
}
