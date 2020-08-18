using System;
using Microsoft.EntityFrameworkCore;

namespace tienda_api.Models
{
    public class TiendaContext: DbContext
    {
        public TiendaContext(DbContextOptions<TiendaContext> options):base(options)
        {
        }

        public DbSet<Cargo> cargos { get; set; }
    }
}
