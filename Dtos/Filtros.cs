using Bilioteca.Entidades;

namespace Bilioteca.Dtos;

public class Filtros
{
    public enum CampoBusca
    {
        Titulo,
        Autor
    }

    public CampoBusca Campo { get; set; }
    public string Termo { get; set; } = string.Empty;
    public Idioma? Idioma { get; set; }
    public Genero? Genero { get; set; }
    public int? AnoPublicacaoDe { get; set; }
    public int? AnoPublicacaoAte { get; set; }  

    public int Contar()
    {
        return (string.IsNullOrWhiteSpace(Termo) ? 0 : 1) +
               (Idioma.HasValue ? 1 : 0) +
               (Genero.HasValue ? 1 : 0) +
               (AnoPublicacaoDe.HasValue ? 1 : 0) +
               (AnoPublicacaoAte.HasValue ? 1 : 0);
    }

    public void PreencherCom(Filtros outros)
    {
        Idioma = outros.Idioma;
        Genero = outros.Genero;
        AnoPublicacaoDe = outros.AnoPublicacaoDe;
        AnoPublicacaoAte = outros.AnoPublicacaoAte;
        Campo = outros.Campo;
        Termo = outros.Termo;
    }

    public void Limpar()
    {
        Campo = CampoBusca.Titulo;
        Termo = string.Empty;
        Idioma = null;
        Genero = null;
        AnoPublicacaoDe = null;
        AnoPublicacaoAte = null;
    }
}
