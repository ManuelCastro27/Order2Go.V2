﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Servicios.Models
{
    public class Venta : Producto
    {
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public float Cantidad { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public float VentaTotal { get { return (float)(Precio * (decimal)Cantidad); } }
    }
}
