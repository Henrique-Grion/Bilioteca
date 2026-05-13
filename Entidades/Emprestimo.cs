namespace Bilioteca.Entidades;

internal class Emprestimo
{
    private Guid Id { get; set; }
    public Guid GetGuid() => Id;

    public Guid LeitorId { get; set; }
    public UsuarioSistema Leitor { get; set; }

    public Guid LivroId { get; set; }
    public Livro Livro { get; set; }

    public DateTime DataEmprestimo { get; set; }
    public DateTime? DataDevolucao { get; set; }

    public Guid? FuncionarioId { get; set; }
    public UsuarioSistema Funcionario { get; set; }
}
