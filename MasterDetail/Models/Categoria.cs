using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetail.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Producto> Productos { get; set; }
        public override string ToString() => Nombre;
    }
}
