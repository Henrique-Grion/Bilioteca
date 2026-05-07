using Bilioteca.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Bilioteca;

internal class BancoDados : DbContext
{
    public DbSet<Livro> Livros { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=biblioteca.db");
    }
}
