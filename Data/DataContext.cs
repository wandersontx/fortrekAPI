using ForTrek.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ForTrek.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Marca> marcas {get; set;}
    }
}