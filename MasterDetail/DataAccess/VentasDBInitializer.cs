using MasterDetail.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace MasterDetail.DataAccess
{
    public class VentasDBInitializer:DropCreateDatabaseIfModelChanges<VentasDBContext>
    {
        protected override void Seed(VentasDBContext context)
        {
            IList<TipoVenta> defaultTiposVenta = new List<TipoVenta>()
            {
                new TipoVenta(){Nombre = "Al Contado"},
                new TipoVenta(){Nombre = "Al Credito"},
            };
            context.TiposVenta.AddRange(defaultTiposVenta);
            
            IList<Categoria> defaultCats = new List<Categoria>()
            {
                new Categoria(){Nombre = "General"},
            };
            context.Categorias.AddRange(defaultCats);


            var admin = new Colaborador() 
            { 
                DNI = "0703200101235", 
                Nombre = "Administrador", 
                Clave = "12345678",
                Puesto = new Puesto() { Nombre = "Administrador"}
            };

            context.Colaboradores.Add(admin);


            base.Seed(context);
        }
    }
}
