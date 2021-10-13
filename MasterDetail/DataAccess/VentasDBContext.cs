using MasterDetail.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace MasterDetail.DataAccess
{
    public class VentasDBContext:DbContext
    {
        public VentasDBContext():base("VentasDB")
        {
            Database.SetInitializer(new VentasDBInitializer());
        }

        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetallesVenta { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Puesto> Puestos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<TipoVenta> TiposVenta { get; set; }

    }
}
