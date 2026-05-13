namespace Bilioteca.Entidades;

internal class ListaEspera
{
    private Guid Id { get; set; }
    public Guid GetGuid() => Id;
    public Guid LivroId { get; set; }
    public Livro Livro { get; set; }
    public Guid UsuarioId { get; set; }
    public UsuarioSistema Usuario { get; set; }
    public DateTime DataEntrada { get; set; }
    public int Posicao { get; set; }
}
