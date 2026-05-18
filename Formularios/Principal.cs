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

    private void ButtonEntrar_Click(object sender, EventArgs e)
    {
        FormLogin login = new();
        login.ShowDialog(this);
        if (login.DialogResult == DialogResult.OK)
        {
            ButtonEntrar.Visible = false;
            ButtonSair.Visible = true;
            ButtonNovoLivro.Visible = true;
            ButtonUsuarios.Visible = true;
        }
    }

    private void ButtonSair_Click(object sender, EventArgs e)
    {
        DialogResult = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (DialogResult == DialogResult.No)
            return;
        Program.UsuarioLogado = null;
        ButtonEntrar.Visible = true;
        ButtonSair.Visible = false;
        ButtonNovoLivro.Visible = false;
        ButtonUsuarios.Visible = false;
    }

    private void ButtonNovoLivro_Click(object sender, EventArgs e)
    {
        FormEditarLivro form = new();
        form.ShowDialog(this);
    }

    private void ButtonUsuarios_Click(object sender, EventArgs e)
    {
        FormUsuarios form = new();
        form.Show(this);
    }
}
