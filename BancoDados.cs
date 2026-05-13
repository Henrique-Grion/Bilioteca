using Bilioteca.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Bilioteca;

internal class BancoDados : DbContext
{
    public DbSet<Livro> Livros { get; set; }
    public DbSet<Estoque> Estoques { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=biblioteca.db");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // ESTOQUE
        modelBuilder.Entity<Estoque>()
            .HasKey("Id");

        modelBuilder.Entity<Estoque>()
            .Property<Guid>("Id")
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<Estoque>()
            .HasOne(e => e.Livro)
            .WithOne(l => l.Estoque)
            .HasForeignKey<Estoque>(e => e.LivroId);


        // USUARIO
        modelBuilder.Entity<UsuarioSistema>()
            .HasKey("Id");

        modelBuilder.Entity<UsuarioSistema>()
            .Property<Guid>("Id")
            .ValueGeneratedOnAdd();


        // LIVRO
        modelBuilder.Entity<Livro>()
            .HasKey("Id");

        modelBuilder.Entity<Livro>()
            .Property<Guid>("Id")
            .ValueGeneratedOnAdd();


        // EMPRESTIMO
        modelBuilder.Entity<Emprestimo>()
            .HasKey("Id");

        modelBuilder.Entity<Emprestimo>()
            .Property<Guid>("Id")
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<Emprestimo>()
            .HasOne(e => e.Leitor)
            .WithMany()
            .HasForeignKey(e => e.LeitorId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Emprestimo>()
            .HasOne(e => e.Funcionario)
            .WithMany()
            .HasForeignKey(e => e.FuncionarioId)
            .OnDelete(DeleteBehavior.Restrict);


        // LISTA ESPERA
        modelBuilder.Entity<ListaEspera>()
            .HasKey("Id");

        modelBuilder.Entity<ListaEspera>()
            .Property<Guid>("Id")
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<ListaEspera>()
            .HasOne(le => le.Livro)
            .WithMany()
            .HasForeignKey(le => le.LivroId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ListaEspera>()
            .HasOne(le => le.Usuario)
            .WithMany()
            .HasForeignKey(le => le.UsuarioId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ListaEspera>()
            .HasIndex(le => new { le.LivroId, le.UsuarioId })
            .IsUnique();

        base.OnModelCreating(modelBuilder);
    }
}
