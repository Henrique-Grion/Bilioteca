using Biblioteca;
using Bilioteca.Dtos;
using Bilioteca.Entidades;

namespace Bilioteca.Formularios;

public partial class Principal : Form
{
    private readonly Filtros _filtros = new();
    public Principal()
    {
        InitializeComponent();
    }

    private void ButtonFiltros_Click(object sender, EventArgs e)
    {
        Logger.Instance.Informacao("Abrindo janela de filtros para seleção.");
        FormPesquisa p = new(_filtros);
        p.ShowDialog();
        if (p.DialogResult == DialogResult.OK)
        {
            Logger.Instance.Informacao("Aplicando filtros selecionados.");
            _filtros.PreencherCom(p.Filtros);
            AtualizarQtdFiltros();
        }
    }

    private void AtualizarQtdFiltros()
    {
        LabelQtdFiltros.Text = _filtros.Contar().ToString();
    }

    private void ButtonLimparFiltros_Click(object sender, EventArgs e)
    {
        Logger.Instance.Informacao("Limpando todos os filtros aplicados.");
        _filtros.Limpar();
        AtualizarQtdFiltros();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        FormLogin login = new();
        login.ShowDialog(this);
    }
}
