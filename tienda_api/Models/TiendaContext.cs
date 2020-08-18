using System;
using Microsoft.EntityFrameworkCore;
using tienda_api.Models;

namespace tienda_api.Models
{
    public class TiendaContext: DbContext
    {
        public TiendaContext(DbContextOptions<TiendaContext> options):base(options)
        {
        }

        public DbSet<Cargo> cargo { get; set; }

        public DbSet<tienda_api.Models.Empleado> Empleado { get; set; }

        public DbSet<tienda_api.Models.Tienda> Tienda { get; set; }
    }
}
