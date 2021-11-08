using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurantes.Models
{
    public class Venta : Producto
    {
        [Key]
        public int IdVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal VentaTotal { get; set; }
        //public int IdProducto { get; set; }
    }
}
