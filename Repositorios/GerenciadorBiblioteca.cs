using Bilioteca.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bilioteca.Repositorios
{
    internal class GerenciadorBiblioteca
    {
        public List<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();
        public List<Estoque> Estoques { get; set; } = new List<Estoque>();

        public bool ProcessarEmprestimo(Livro livro, UsuarioSistema leitor, UsuarioSistema funcionario)
        {
            Estoque estoqueLivro = Estoques.FirstOrDefault(est => est.LivroId == livro.GetGuid());
            if (estoqueLivro == null || !estoqueLivro.PossuiDisponibilidade())
            {
                return false;
            }
            estoqueLivro.Emprestar();
            Emprestimo novoEmprestimo = new Emprestimo();
            novoEmprestimo.Emprestar(livro, leitor, funcionario);
            Emprestimos.Add(novoEmprestimo);

            return true;
        }
        public bool ProcessarDevolucao(Livro livro, UsuarioSistema leitor)
        {
            var emprestimo = Emprestimos.FirstOrDefault(e =>
                e.Livro.GetGuid() == livro.GetGuid() &&
                e.Leitor.GetGuid() == leitor.GetGuid() &&
                e.DataDevolucao == null);

            if (emprestimo != null)
            {
                emprestimo.Devolver();

                Estoque estoqueLivro = Estoques.FirstOrDefault(est => est.LivroId == livro.GetGuid());
                if (estoqueLivro != null)
                {
                    estoqueLivro.Devolver();
                }

                return true;
            }
            return false;
        }
    }
}
