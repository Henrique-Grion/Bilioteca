namespace Bilioteca.Entidades;

using Microsoft.AspNetCore.Identity;

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
    public string Usuario { get; set; }
    private string Senha { get; set; }
    public TipoUsuario Tipo { get; set; }
    public int Idade { get; set; }
    public bool EhFuncionario => Tipo == TipoUsuario.Funcionario;
    public bool EhLeitor => Tipo == TipoUsuario.Leitor;
    public void DefinirSenha(string senha)
    {
        PasswordHasher<UsuarioSistema> passwordHasher = new();
        Senha = passwordHasher.HashPassword(this, senha);
    }
    public bool Autenticar(string senha)
    {
        PasswordHasher<UsuarioSistema> passwordHasher = new();
        PasswordVerificationResult result = passwordHasher.VerifyHashedPassword(this, Senha, senha);
        return result == PasswordVerificationResult.Success || result == PasswordVerificationResult.SuccessRehashNeeded;
    }
}
