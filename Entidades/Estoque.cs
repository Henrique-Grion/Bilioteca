namespace Bilioteca.Entidades;

internal class Estoque
{
    private Guid Id { get; set; }
    public Guid GetGuid() => Id;
    public Guid LivroId { get; set; }
    public Livro Livro { get; set; }
    public int QuantidadeTotal { get; set; }
    public int QuantidadeDisponivel { get; set; }
}
