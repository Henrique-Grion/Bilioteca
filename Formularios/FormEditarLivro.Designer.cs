namespace Bilioteca.Formularios
{
    partial class FormEditarLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarLivro));
            LabelTitulo = new Label();
            TextBoxTitulo = new TextBox();
            LabelAutor = new Label();
            TextBoxAutor = new TextBox();
            LabelAnoPublicacao = new Label();
            NumericUpDownAnoPublicacao = new NumericUpDown();
            ComboBoxGenero = new ComboBox();
            LabelGenero = new Label();
            IdiomaComboBox = new ComboBox();
            LabelIdioma = new Label();
            NumericUpDownPaginas = new NumericUpDown();
            LabelPaginas = new Label();
            ButtonSalvar = new Button();
            ButtonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownAnoPublicacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPaginas).BeginInit();
            SuspendLayout();
            // 
            // LabelTitulo
            // 
            LabelTitulo.AutoSize = true;
            LabelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTitulo.Location = new Point(12, 9);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(52, 21);
            LabelTitulo.TabIndex = 0;
            LabelTitulo.Text = "Título:";
            // 
            // TextBoxTitulo
            // 
            TextBoxTitulo.Location = new Point(59, 6);
            TextBoxTitulo.Name = "TextBoxTitulo";
            TextBoxTitulo.Size = new Size(243, 23);
            TextBoxTitulo.TabIndex = 1;
            // 
            // LabelAutor
            // 
            LabelAutor.AutoSize = true;
            LabelAutor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelAutor.Location = new Point(12, 38);
            LabelAutor.Name = "LabelAutor";
            LabelAutor.Size = new Size(52, 21);
            LabelAutor.TabIndex = 2;
            LabelAutor.Text = "Autor:";
            // 
            // TextBoxAutor
            // 
            TextBoxAutor.Location = new Point(58, 35);
            TextBoxAutor.Name = "TextBoxAutor";
            TextBoxAutor.Size = new Size(244, 23);
            TextBoxAutor.TabIndex = 3;
            // 
            // LabelAnoPublicacao
            // 
            LabelAnoPublicacao.AutoSize = true;
            LabelAnoPublicacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelAnoPublicacao.Location = new Point(12, 67);
            LabelAnoPublicacao.Name = "LabelAnoPublicacao";
            LabelAnoPublicacao.Size = new Size(140, 21);
            LabelAnoPublicacao.TabIndex = 4;
            LabelAnoPublicacao.Text = "Ano de Publicação:";
            // 
            // NumericUpDownAnoPublicacao
            // 
            NumericUpDownAnoPublicacao.Location = new Point(127, 64);
            NumericUpDownAnoPublicacao.Name = "NumericUpDownAnoPublicacao";
            NumericUpDownAnoPublicacao.Size = new Size(175, 23);
            NumericUpDownAnoPublicacao.TabIndex = 5;
            // 
            // ComboBoxGenero
            // 
            ComboBoxGenero.FormattingEnabled = true;
            ComboBoxGenero.Location = new Point(65, 93);
            ComboBoxGenero.Name = "ComboBoxGenero";
            ComboBoxGenero.Size = new Size(237, 23);
            ComboBoxGenero.TabIndex = 6;
            // 
            // LabelGenero
            // 
            LabelGenero.AutoSize = true;
            LabelGenero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelGenero.Location = new Point(12, 96);
            LabelGenero.Name = "LabelGenero";
            LabelGenero.Size = new Size(64, 21);
            LabelGenero.TabIndex = 7;
            LabelGenero.Text = "Gênero:";
            // 
            // IdiomaComboBox
            // 
            IdiomaComboBox.FormattingEnabled = true;
            IdiomaComboBox.Location = new Point(65, 151);
            IdiomaComboBox.Name = "IdiomaComboBox";
            IdiomaComboBox.Size = new Size(237, 23);
            IdiomaComboBox.TabIndex = 8;
            // 
            // LabelIdioma
            // 
            LabelIdioma.AutoSize = true;
            LabelIdioma.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelIdioma.Location = new Point(12, 154);
            LabelIdioma.Name = "LabelIdioma";
            LabelIdioma.Size = new Size(61, 21);
            LabelIdioma.TabIndex = 9;
            LabelIdioma.Text = "Idioma:";
            // 
            // NumericUpDownPaginas
            // 
            NumericUpDownPaginas.Location = new Point(86, 122);
            NumericUpDownPaginas.Name = "NumericUpDownPaginas";
            NumericUpDownPaginas.Size = new Size(216, 23);
            NumericUpDownPaginas.TabIndex = 10;
            // 
            // LabelPaginas
            // 
            LabelPaginas.AutoSize = true;
            LabelPaginas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelPaginas.Location = new Point(12, 124);
            LabelPaginas.Name = "LabelPaginas";
            LabelPaginas.Size = new Size(89, 21);
            LabelPaginas.TabIndex = 11;
            LabelPaginas.Text = "Nº Páginas:";
            // 
            // ButtonSalvar
            // 
            ButtonSalvar.Location = new Point(227, 237);
            ButtonSalvar.Name = "ButtonSalvar";
            ButtonSalvar.Size = new Size(75, 23);
            ButtonSalvar.TabIndex = 12;
            ButtonSalvar.Text = "Salvar";
            ButtonSalvar.UseVisualStyleBackColor = true;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Location = new Point(146, 237);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(75, 23);
            ButtonCancelar.TabIndex = 13;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.UseVisualStyleBackColor = true;
            // 
            // FormEditarLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 272);
            Controls.Add(ButtonCancelar);
            Controls.Add(ButtonSalvar);
            Controls.Add(LabelPaginas);
            Controls.Add(NumericUpDownPaginas);
            Controls.Add(LabelIdioma);
            Controls.Add(IdiomaComboBox);
            Controls.Add(LabelGenero);
            Controls.Add(ComboBoxGenero);
            Controls.Add(NumericUpDownAnoPublicacao);
            Controls.Add(LabelAnoPublicacao);
            Controls.Add(TextBoxAutor);
            Controls.Add(LabelAutor);
            Controls.Add(TextBoxTitulo);
            Controls.Add(LabelTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditarLivro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Livro";
            ((System.ComponentModel.ISupportInitialize)NumericUpDownAnoPublicacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPaginas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTitulo;
        private TextBox TextBoxTitulo;
        private Label LabelAutor;
        private TextBox TextBoxAutor;
        private Label LabelAnoPublicacao;
        private NumericUpDown NumericUpDownAnoPublicacao;
        private ComboBox ComboBoxGenero;
        private Label LabelGenero;
        private ComboBox IdiomaComboBox;
        private Label LabelIdioma;
        private NumericUpDown NumericUpDownPaginas;
        private Label LabelPaginas;
        private Button ButtonSalvar;
        private Button ButtonCancelar;
    }
}