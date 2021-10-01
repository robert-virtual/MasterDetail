﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MasterDetail.Models
{
    [Table("TiposVenta")]
    public class TipoVenta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<Venta> Ventas { get; set; }
        public override string ToString() => Nombre;
    }
}
