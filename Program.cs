using Bilioteca.Entidades;
using Bilioteca.Formularios;
using Microsoft.EntityFrameworkCore;

namespace Bilioteca;

internal static class Program
{
    public static ConfiguracaoSistema Configuracao { get; private set; } = new ConfiguracaoSistema();
    public readonly static string Versao = "1.0.0";
    public static UsuarioSistema? UsuarioLogado { get; set; }

    [STAThread]
    static void Main()
    {
        Logger.Instance.Informacao($"Iniciando a aplicação...");
        InicializarBancoDeDados();

        Logger.Instance.Informacao($"Carregando o arquivo de configuração do sistema.");
        Configuracao.Carregar();
        Logger.Instance.NivelMinimo = Configuracao.LogNivel;
        Logger.Instance.Informacao($"Configuração do sistema carregada com sucesso. Nível mínimo de log: {Logger.Instance.NivelMinimo}.");

        ApplicationConfiguration.Initialize();
        Principal principal = new()
        { 
            Text = $"Bilioteca - Versão {Versao}"
        };
        Application.Run(principal);

        Logger.Instance.Informacao($"Aplicação encerrada. Salvando a configuração do sistema.");
        Configuracao.Salvar();
        Logger.Instance.Informacao($"Configuração do sistema salva com sucesso. Encerrando a aplicação...");
    }

    private static void InicializarBancoDeDados()
    {
        Logger.Instance.Informacao("Inicializando o banco de dados, aplicando migrações pendentes.");
        using BancoDados db = new();
        db.Database.Migrate();
        Logger.Instance.Informacao("Banco de dados inicializado com sucesso.");
    }
}