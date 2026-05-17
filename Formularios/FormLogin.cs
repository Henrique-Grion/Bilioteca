using Bilioteca;
using Bilioteca.Entidades;

namespace Biblioteca;

public partial class FormLogin : Form
{
    public FormLogin()
    {
        InitializeComponent();
    }

    private void ButtonEntrar_Click(object sender, EventArgs e)
    {
        string loginDigitado = TextBoxUsuario.Text;
        string senhaDigitada = TextBoxSenha.Text;
        if (string.IsNullOrWhiteSpace(loginDigitado) || string.IsNullOrWhiteSpace(senhaDigitada))
        {
            MessageBox.Show("Por favor, preencha ambos os campos de login e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        using BancoDados db = new();
        UsuarioSistema? us = db.Usuarios.FirstOrDefault(u => u.Usuario == loginDigitado);
        if (us == null || !us.Autenticar(senhaDigitada))
        {
            Logger.Instance.Informacao($"Tentativa de login falhou para o usuário '{loginDigitado}'.");
            MessageBox.Show("Credenciais inválidas. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        Logger.Instance.Informacao($"Usuário '{loginDigitado}' logou com sucesso.");
        MessageBox.Show("Login realizado com suceso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        Program.UsuarioLogado = us;
        DialogResult = DialogResult.OK;
        Close();
    }

    private void ButtonEsqueci_Click(object sender, EventArgs e)
    {
        new FormEsqueci().ShowDialog();
    }

    private void ButtonCancelar_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
