using Bilioteca.Formularios;
using Microsoft.EntityFrameworkCore;

namespace Bilioteca;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        InicializarBancoDeDados();

        ApplicationConfiguration.Initialize();
        Application.Run(new Principal());
    }

    private static void InicializarBancoDeDados()
    {
        using BancoDados db = new();
        db.Database.Migrate();
    }
}