using Bilioteca.Entidades;
using Bilioteca.Formularios;
using Microsoft.EntityFrameworkCore;

namespace Bilioteca;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        InicializarBancoDeDados();

        // Exemplo de uso do banco de dados (Vocês apaguem depois, mas só pra testarem se tá funcionando na máquina de vcs,
        // OBS: Tem que instalar os pacotes do nuget
        // normalmente o visual stuido ja instala, mas se não clica com o botão direito na solução, depois em
        // "Restaurar pacotes do nuget" e espera instalar tudo, depois é só rodar o projeto e ver se tá funcionando)
        // Verifica se o banco de dados foi criado em bin/Debug/net10.0/BancoDados.db, se tiver o arquivo, tá funcionando, se não tiver,
        // tem algo errado, aí é só me chamar que eu ajudo a resolver
        using BancoDados db = new();
        Livro l = new()
        {
            AnoPublicacao = 2024,
            Autor = "Autor Exemplo",
            Titulo = "Título Exemplo"
        };
        db.Livros.Add(l);
        db.SaveChanges();
        Livro? l2 = db.Livros.AsQueryable().FirstOrDefault(x => x.Id == 1);
        if (l2 != null)
        {
            MessageBox.Show($"Livro encontrado: {l2.Titulo} por {l2.Autor}, publicado em {l2.AnoPublicacao}");
        }
        else
        {
            MessageBox.Show("Livro não encontrado.");
        }
        // FIM DO EXEMPLO PODE APAGAR ATÉ AQUI

        // OUTRA COISA IMPORTANTE: Se possível utilizem branchs diferentes da main para desenvolver as funcionalidades,
        // ai quando estiver pronto é só fazer um pull request para a main, n precisa esperar eu fazer o pull request, podem fazer o de vocês mesmo,
        // isso evita muita dor de cabeça na hora de resolver conflitos, se alguem n conseguir ou tiver alguma dúvida, é só me chamar que eu ajudo.

        // Por padrão eu estava colocando os formulários detro da pasta Formularios, mas podem mudar, bem tranquilo,

        // As "tabelas" do banco são as classes dentro da pasta Entidades ai se quiserem adicionar é só criar uma nova classe lá,
        // e depois adicionar uma propriedade do tipo DbSet<NomeDaClasse> no BancoDados.cs, e depois adicionar a migração (ta explicado no README)
        // e depois rodar o projeto que ele já cria o banco de dados atualizado, não precisa fazer mais nada, é bem tranquilo.
        // Vou tentar ir de atrás da questão do email, ai vão vendo o que tem que fazer, e se tiver alguma dúvida é só me chamar, que eu ajudo a resolver.

        ApplicationConfiguration.Initialize();
        Application.Run(new Principal());
    }

    private static void InicializarBancoDeDados()
    {
        using BancoDados db = new();
        db.Database.Migrate();
    }
}