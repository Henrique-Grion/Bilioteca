# Guia de Migrações, Banco de Dados e Uso do Entity Framework Core

Este projeto utiliza **Entity Framework Core + SQLite** para persistência de dados.  
O EF Core trabalha com **migrações**, que são arquivos gerados automaticamente para criar e atualizar o banco conforme as entidades evoluem.

---

## Importante: Não modifique manualmente a pasta `Migrations/`

A pasta **Migrations** contém arquivos gerados automaticamente pelo Entity Framework Core.

Esses arquivos:

- **não devem ser editados manualmente**
- **não devem ser renomeados**
- **não devem ser movidos**
- **não devem ser excluídos**
- **não devem ser alterados diretamente no código**

Alterações manuais podem corromper o histórico do banco e impedir futuras migrações.

Toda mudança no banco deve ser feita **somente via comandos do EF Core**.

---

## Como criar uma migração

Sempre que você:

- criar uma nova entidade
- alterar propriedades de uma entidade existente
- adicionar ou remover tabelas
- alterar relacionamentos

Você deve gerar uma nova migração.

### Comando a ser executado no terminal do Package Manager Console (Visual Studio), Exibir > Outras Janelas > Console do Gerenciador de Pacotes:

```powershell
Add-Migration <NomeDaMigracao>
```

Entidades representam as tabelas do banco de dados. Sendo elas classes localizadas na pasta Entidades/
Ao criar uma nova entidade, é necessário adicionar a propriedade `DbSet<NomeDaEntidade>` na classe `BancoDados` para que o EF Core reconheça a nova tabela.

## Utilizando o banco de dados

Para acessar o banco de dados, utilize a classe `BancoDados`, instanciando-a utilizando a palavra chave `using` para garantir que os recursos sejam liberados corretamente:
```csharp
using BancoDados banco = new();
// Exemplo de uso: Listar todos os livors
List<Livro> livros = banco.Livros.ToList();
```
