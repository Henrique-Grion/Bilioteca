namespace Bilioteca.Entidades;

enum Genero
{
    Ficcao,
    NaoFiccao,
    Romance,
    Aventura,
    Ciencia,
    Historia
}

enum Idioma
{
    Portugues,
    Ingles,
    Espanhol,
    Frances,
    Alemao,
    Outro
}

internal class Livro
{
    private Guid Id { get; set; }
    public Guid GetGuid() => Id;
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }
    public Genero Genero { get; set; }
    public Idioma Idioma { get; set; }
    public int Paginas { get; set; }
    public Estoque? Estoque { get; set; }
}
