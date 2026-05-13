using Bilioteca.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UsuarioSistema usuario = new UsuarioSistema();

            string loginDigitado = txtUsuario.Text;
            string senhaDigitada = txtSenha.Text;

            if (usuario.Autenticar(loginDigitado, senhaDigitada))
            {
                MessageBox.Show("Login realizado com suceso.");
            }
        }

        private void btnEsqueci_Click(object sender, EventArgs e)
        {
            var formEsqueci = new FormEsqueci();
            formEsqueci.ShowDialog();
        }
    }
}
