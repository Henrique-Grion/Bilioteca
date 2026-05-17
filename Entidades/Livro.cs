namespace Bilioteca.Entidades;

public enum Genero
{
    Ficcao,
    Filosofia,
    Romance,
    Aventura,
    Ciencia,
    Historia
}

public enum Idioma
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
