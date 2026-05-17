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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            ButtonEntrar = new Button();
            ButtonEsqueci = new Button();
            TextBoxUsuario = new TextBox();
            TextBoxSenha = new TextBox();
            LabelUsuario = new Label();
            LabelSenha = new Label();
            ButtonCancelar = new Button();
            SuspendLayout();
            // 
            // ButtonEntrar
            // 
            ButtonEntrar.Location = new Point(257, 201);
            ButtonEntrar.Name = "ButtonEntrar";
            ButtonEntrar.Size = new Size(75, 23);
            ButtonEntrar.TabIndex = 0;
            ButtonEntrar.Text = "Entrar";
            ButtonEntrar.UseVisualStyleBackColor = true;
            ButtonEntrar.Click += ButtonEntrar_Click;
            // 
            // ButtonEsqueci
            // 
            ButtonEsqueci.Location = new Point(12, 201);
            ButtonEsqueci.Name = "ButtonEsqueci";
            ButtonEsqueci.Size = new Size(115, 23);
            ButtonEsqueci.TabIndex = 1;
            ButtonEsqueci.Text = "Esqueci a Senha";
            ButtonEsqueci.UseVisualStyleBackColor = true;
            ButtonEsqueci.Click += ButtonEsqueci_Click;
            // 
            // TextBoxUsuario
            // 
            TextBoxUsuario.Location = new Point(82, 47);
            TextBoxUsuario.Name = "TextBoxUsuario";
            TextBoxUsuario.Size = new Size(227, 23);
            TextBoxUsuario.TabIndex = 2;
            // 
            // TextBoxSenha
            // 
            TextBoxSenha.Location = new Point(82, 96);
            TextBoxSenha.Name = "TextBoxSenha";
            TextBoxSenha.Size = new Size(227, 23);
            TextBoxSenha.TabIndex = 3;
            TextBoxSenha.UseSystemPasswordChar = true;
            // 
            // LabelUsuario
            // 
            LabelUsuario.AutoSize = true;
            LabelUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelUsuario.Location = new Point(12, 49);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(64, 21);
            LabelUsuario.TabIndex = 4;
            LabelUsuario.Text = "Usuário";
            // 
            // LabelSenha
            // 
            LabelSenha.AutoSize = true;
            LabelSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSenha.Location = new Point(12, 98);
            LabelSenha.Name = "LabelSenha";
            LabelSenha.Size = new Size(53, 21);
            LabelSenha.TabIndex = 5;
            LabelSenha.Text = "Senha";
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Location = new Point(176, 201);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(75, 23);
            ButtonCancelar.TabIndex = 6;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 236);
            Controls.Add(ButtonCancelar);
            Controls.Add(LabelSenha);
            Controls.Add(LabelUsuario);
            Controls.Add(TextBoxSenha);
            Controls.Add(TextBoxUsuario);
            Controls.Add(ButtonEsqueci);
            Controls.Add(ButtonEntrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Entrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonEntrar;
        private Button ButtonEsqueci;
        private TextBox TextBoxUsuario;
        private TextBox TextBoxSenha;
        private Label LabelUsuario;
        private Label LabelSenha;
        private Button ButtonCancelar;
    }
}