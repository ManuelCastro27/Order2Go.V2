using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServiciosRestaurantes.Models
{
    public class Venta : Producto
    {
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Debe ingresar la {0}")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public float Cantidad { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Display(Name = "Total Venta")]
        public float VentaTotal { get { return (float)(Precio * (decimal)Cantidad); } set { }}
    }
}
