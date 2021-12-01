using ForTrek.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ForTrek.API.Data
{
    public class DataContext : DbContext
    {
        // base(options) -> passando o parâmetro recebido para construtor da super classe
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        // Serve para indicar que deve ser criada uma tabela locações para representar  um
        // modelo Locacao
        // public DbSet<Locacao> Locacoes { get; set; } 

        public DbSet<Marca> marcas {get; set;}
    }
}