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
            TituloLabel = new Label();
            TituloTextBox = new TextBox();
            AutorLabel = new Label();
            AutorTextBox = new TextBox();
            AnoPublicacaoLabel = new Label();
            AnoPublicacaoNumericUpDown = new NumericUpDown();
            GeneroComboBox = new ComboBox();
            GeneroLabel = new Label();
            IdiomaComboBox = new ComboBox();
            IdiomaLabel = new Label();
            PaginasNumericUpDown = new NumericUpDown();
            PaginasLabel = new Label();
            SalvarButton = new Button();
            CancelarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AnoPublicacaoNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaginasNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // TituloLabel
            // 
            TituloLabel.AutoSize = true;
            TituloLabel.Location = new Point(12, 9);
            TituloLabel.Name = "TituloLabel";
            TituloLabel.Size = new Size(41, 15);
            TituloLabel.TabIndex = 0;
            TituloLabel.Text = "Título:";
            // 
            // TituloTextBox
            // 
            TituloTextBox.Location = new Point(59, 6);
            TituloTextBox.Name = "TituloTextBox";
            TituloTextBox.Size = new Size(243, 23);
            TituloTextBox.TabIndex = 1;
            // 
            // AutorLabel
            // 
            AutorLabel.AutoSize = true;
            AutorLabel.Location = new Point(12, 38);
            AutorLabel.Name = "AutorLabel";
            AutorLabel.Size = new Size(40, 15);
            AutorLabel.TabIndex = 2;
            AutorLabel.Text = "Autor:";
            // 
            // AutorTextBox
            // 
            AutorTextBox.Location = new Point(58, 35);
            AutorTextBox.Name = "AutorTextBox";
            AutorTextBox.Size = new Size(244, 23);
            AutorTextBox.TabIndex = 3;
            // 
            // AnoPublicacaoLabel
            // 
            AnoPublicacaoLabel.AutoSize = true;
            AnoPublicacaoLabel.Location = new Point(12, 67);
            AnoPublicacaoLabel.Name = "AnoPublicacaoLabel";
            AnoPublicacaoLabel.Size = new Size(109, 15);
            AnoPublicacaoLabel.TabIndex = 4;
            AnoPublicacaoLabel.Text = "Ano de Publicação:";
            // 
            // AnoPublicacaoNumericUpDown
            // 
            AnoPublicacaoNumericUpDown.Location = new Point(127, 64);
            AnoPublicacaoNumericUpDown.Name = "AnoPublicacaoNumericUpDown";
            AnoPublicacaoNumericUpDown.Size = new Size(175, 23);
            AnoPublicacaoNumericUpDown.TabIndex = 5;
            // 
            // GeneroComboBox
            // 
            GeneroComboBox.FormattingEnabled = true;
            GeneroComboBox.Location = new Point(65, 93);
            GeneroComboBox.Name = "GeneroComboBox";
            GeneroComboBox.Size = new Size(237, 23);
            GeneroComboBox.TabIndex = 6;
            // 
            // GeneroLabel
            // 
            GeneroLabel.AutoSize = true;
            GeneroLabel.Location = new Point(12, 96);
            GeneroLabel.Name = "GeneroLabel";
            GeneroLabel.Size = new Size(48, 15);
            GeneroLabel.TabIndex = 7;
            GeneroLabel.Text = "Gênero:";
            // 
            // IdiomaComboBox
            // 
            IdiomaComboBox.FormattingEnabled = true;
            IdiomaComboBox.Location = new Point(65, 151);
            IdiomaComboBox.Name = "IdiomaComboBox";
            IdiomaComboBox.Size = new Size(237, 23);
            IdiomaComboBox.TabIndex = 8;
            // 
            // IdiomaLabel
            // 
            IdiomaLabel.AutoSize = true;
            IdiomaLabel.Location = new Point(12, 154);
            IdiomaLabel.Name = "IdiomaLabel";
            IdiomaLabel.Size = new Size(47, 15);
            IdiomaLabel.TabIndex = 9;
            IdiomaLabel.Text = "Idioma:";
            // 
            // PaginasNumericUpDown
            // 
            PaginasNumericUpDown.Location = new Point(86, 122);
            PaginasNumericUpDown.Name = "PaginasNumericUpDown";
            PaginasNumericUpDown.Size = new Size(216, 23);
            PaginasNumericUpDown.TabIndex = 10;
            // 
            // PaginasLabel
            // 
            PaginasLabel.AutoSize = true;
            PaginasLabel.Location = new Point(12, 124);
            PaginasLabel.Name = "PaginasLabel";
            PaginasLabel.Size = new Size(68, 15);
            PaginasLabel.TabIndex = 11;
            PaginasLabel.Text = "Nº Páginas:";
            // 
            // SalvarButton
            // 
            SalvarButton.Location = new Point(227, 237);
            SalvarButton.Name = "SalvarButton";
            SalvarButton.Size = new Size(75, 23);
            SalvarButton.TabIndex = 12;
            SalvarButton.Text = "Salvar";
            SalvarButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(146, 237);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(75, 23);
            CancelarButton.TabIndex = 13;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // EditarLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 272);
            Controls.Add(CancelarButton);
            Controls.Add(SalvarButton);
            Controls.Add(PaginasLabel);
            Controls.Add(PaginasNumericUpDown);
            Controls.Add(IdiomaLabel);
            Controls.Add(IdiomaComboBox);
            Controls.Add(GeneroLabel);
            Controls.Add(GeneroComboBox);
            Controls.Add(AnoPublicacaoNumericUpDown);
            Controls.Add(AnoPublicacaoLabel);
            Controls.Add(AutorTextBox);
            Controls.Add(AutorLabel);
            Controls.Add(TituloTextBox);
            Controls.Add(TituloLabel);
            Name = "EditarLivro";
            Text = "EditarLivro";
            ((System.ComponentModel.ISupportInitialize)AnoPublicacaoNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaginasNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TituloLabel;
        private TextBox TituloTextBox;
        private Label AutorLabel;
        private TextBox AutorTextBox;
        private Label AnoPublicacaoLabel;
        private NumericUpDown AnoPublicacaoNumericUpDown;
        private ComboBox GeneroComboBox;
        private Label GeneroLabel;
        private ComboBox IdiomaComboBox;
        private Label IdiomaLabel;
        private NumericUpDown PaginasNumericUpDown;
        private Label PaginasLabel;
        private Button SalvarButton;
        private Button CancelarButton;
    }
}