namespace Biblioteca
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            btnEsqueci = new Button();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new Point(397, 257);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += this.btnLogin_Click;
            // 
            // btnEsqueci
            // 
            this.btnEsqueci.Location = new Point(276, 257);
            this.btnEsqueci.Name = "btnEsqueci";
            this.btnEsqueci.Size = new Size(115, 23);
            this.btnEsqueci.TabIndex = 1;
            this.btnEsqueci.Text = "Esqueci a Senha";
            this.btnEsqueci.UseVisualStyleBackColor = true;
            this.btnEsqueci.Click += this.btnEsqueci_Click;
            // 
            // boxUsuario
            // 
            this.txtUsuario.Location = new Point(251, 104);
            this.txtUsuario.Name = "boxUsuario";
            this.txtUsuario.Size = new Size(227, 23);
            this.txtUsuario.TabIndex = 2;
            // 
            // boxSenha
            // 
            txtSenha.Location = new Point(251, 153);
            txtSenha.Name = "boxSenha";
            txtSenha.Size = new Size(227, 23);
            txtSenha.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 112);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 4;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 161);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Senha";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(this.txtUsuario);
            Controls.Add(this.btnEsqueci);
            Controls.Add(this.btnLogin);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnEsqueci;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
    }
}