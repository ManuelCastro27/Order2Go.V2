using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServiciosRestaurantes.Models
{
    public class DetalleOrden
    {
        [Key]
        public int IdDetalleOrden { get; set; }
        
        public int IdOrden { get; set; }
        
        public int IdProducto { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public decimal Precio { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Debe ingresar la {0}")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public float Cantidad { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Display(Name = "Total Venta")]
        public decimal VentaTotal { get { return Precio * (decimal)Cantidad; } set { } }

        public virtual Orden Orden { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
