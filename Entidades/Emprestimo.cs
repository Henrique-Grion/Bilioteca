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
    public void Emprestar(Livro livro, UsuarioSistema leitor, UsuarioSistema funcionario)
    {
        Id = Guid.NewGuid();
        LivroId = livro.GetGuid();
        Livro = livro;
        LeitorId = leitor.GetGuid();
        Leitor = leitor;
        FuncionarioId = funcionario.GetGuid();
        Funcionario = funcionario;
        DataEmprestimo = DateTime.Now;
        DataDevolucao = null;
    }
    public void Devolver()
    {
        DataDevolucao = DateTime.Now;
    }
}
