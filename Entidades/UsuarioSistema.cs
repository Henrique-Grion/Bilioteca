namespace Bilioteca.Entidades;

using Bilioteca.Utils;

enum TipoUsuario
{
    Funcionario,
    Leitor
}

internal class UsuarioSistema
{
    private Guid Id { get; set; }
    public Guid GetGuid() => Id;
    public string Nome { get; set; }
    public string Email { get; set; }
    private string Usuario { get; set; }
    private string Senha { get; set; }
    public TipoUsuario Tipo { get; set; }
    public int Idade { get; set; }
    public bool EhFuncionario => Tipo == TipoUsuario.Funcionario;
    public bool EhLeitor => Tipo == TipoUsuario.Leitor;
    public void DefinirSenha(string senha)
    {
        Senha = PasswordHasher.Hash(senha);
    }
    public bool Autenticar(string usuario, string senha)
    {
        return PasswordHasher.Verify(senha, Senha);
    }
}
