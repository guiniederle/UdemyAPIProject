using Microsoft.EntityFrameworkCore;
using ProAgil.webapi.Model;

namespace ProAgil.webapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Evento> Eventos { get; set; }
    }
}