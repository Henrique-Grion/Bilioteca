using Bilioteca.Dtos;
using Bilioteca.Entidades;

namespace Bilioteca.Formularios;

public partial class FormPesquisa : Form
{
    public Filtros Filtros { get; private set; } = new();
    public FormPesquisa(Filtros? filtros)
    {
        InitializeComponent();

        int anoAtual = DateTime.Now.Year;
        NumericUpDownAnoDe.Maximum = anoAtual;
        NumericUpDownAnoAte.Maximum = anoAtual;

        if (filtros != null)
        {
            ComboBoxCampoBusca.SelectedItem = filtros.Campo == Filtros.CampoBusca.Titulo ? "Título" : "Autor";
            TextBoxTermos.Text = filtros.Termo;
            string? idioma = filtros.Idioma switch
            {
                Idioma.Portugues => "Português",
                Idioma.Ingles => "Inglês",
                Idioma.Espanhol => "Espanhol",
                Idioma.Frances => "Francês",
                Idioma.Alemao => "Alemão",
                Idioma.Outro => "Outro",
                _ => null
            };
            ComboBoxIdioma.SelectedItem = idioma;
            string? genero = filtros.Genero switch
            {
                Genero.Ficcao => "Ficção",
                Genero.Filosofia => "Filosofia",
                Genero.Romance => "Romance",
                Genero.Aventura => "Aventura",
                Genero.Ciencia => "Ciência",
                Genero.Historia => "História",
                _ => null
            };
            ComboBoxGenero.SelectedItem = genero;
            NumericUpDownAnoDe.Value = filtros.AnoPublicacaoDe != null ? (decimal)filtros.AnoPublicacaoDe : 0;
            NumericUpDownAnoAte.Value = filtros.AnoPublicacaoAte != null ? (decimal)filtros.AnoPublicacaoAte : 0;
        }
        Filtros = filtros ?? new Filtros();
    }

    private void ButtonCancelar_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void ButtonAplicar_Click(object sender, EventArgs e)
    {
        Filtros.Campo = ComboBoxCampoBusca.SelectedItem?.ToString() == "Autor" ? Filtros.CampoBusca.Autor : Filtros.CampoBusca.Titulo;
        Filtros.Termo = TextBoxTermos.Text;
        Filtros.Idioma = ComboBoxIdioma.SelectedItem?.ToString() switch
        {
            "Português" => Idioma.Portugues,
            "Inglês" => Idioma.Ingles,
            "Espanhol" => Idioma.Espanhol,
            "Francês" => Idioma.Frances,
            "Alemão" => Idioma.Alemao,
            "Outro" => Idioma.Outro,
            _ => null
        };
        Filtros.Genero = ComboBoxGenero.SelectedItem?.ToString() switch
        {
            "Ficção" => Genero.Ficcao,
            "Filosofia" => Genero.Filosofia,
            "Romance" => Genero.Romance,
            "Aventura" => Genero.Aventura,
            "Ciência" => Genero.Ciencia,
            "História" => Genero.Historia,
            _ => null
        };
        int? anoDe = NumericUpDownAnoDe.Value > 0 ? (int)NumericUpDownAnoDe.Value : null;
        int? anoAte = NumericUpDownAnoAte.Value > 0 ? (int)NumericUpDownAnoAte.Value : null;
        if (anoDe != null && anoAte != null && anoDe > anoAte)
        {
            MessageBox.Show("O ano de publicação 'De'\nnão pode ser maior que o ano 'Até'.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        Filtros.AnoPublicacaoDe = anoDe;
        Filtros.AnoPublicacaoAte = anoAte;
        DialogResult = DialogResult.OK;
        Close();
    }
}
