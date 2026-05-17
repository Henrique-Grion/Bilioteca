namespace Bilioteca.Formularios
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            dataGridView1 = new DataGridView();
            ColunaTitulo = new DataGridViewTextBoxColumn();
            ColunaAutor = new DataGridViewTextBoxColumn();
            ColunaAnoPublicacao = new DataGridViewTextBoxColumn();
            ColunaGenero = new DataGridViewTextBoxColumn();
            ColunaIdioma = new DataGridViewTextBoxColumn();
            ColunaPaginas = new DataGridViewTextBoxColumn();
            ColunaDisponivel = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ButtonFiltros = new Button();
            ButtonLimparFiltros = new Button();
            LabelQtdFiltros = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColunaTitulo, ColunaAutor, ColunaAnoPublicacao, ColunaGenero, ColunaIdioma, ColunaPaginas, ColunaDisponivel });
            dataGridView1.Location = new Point(12, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(776, 379);
            dataGridView1.TabIndex = 0;
            // 
            // ColunaTitulo
            // 
            ColunaTitulo.HeaderText = "Titulo";
            ColunaTitulo.Name = "ColunaTitulo";
            ColunaTitulo.ReadOnly = true;
            // 
            // ColunaAutor
            // 
            ColunaAutor.HeaderText = "Autor";
            ColunaAutor.Name = "ColunaAutor";
            ColunaAutor.ReadOnly = true;
            // 
            // ColunaAnoPublicacao
            // 
            ColunaAnoPublicacao.HeaderText = "Ano Publicação";
            ColunaAnoPublicacao.Name = "ColunaAnoPublicacao";
            ColunaAnoPublicacao.ReadOnly = true;
            // 
            // ColunaGenero
            // 
            ColunaGenero.HeaderText = "Gênero";
            ColunaGenero.Name = "ColunaGenero";
            ColunaGenero.ReadOnly = true;
            // 
            // ColunaIdioma
            // 
            ColunaIdioma.HeaderText = "Idioma";
            ColunaIdioma.Name = "ColunaIdioma";
            ColunaIdioma.ReadOnly = true;
            // 
            // ColunaPaginas
            // 
            ColunaPaginas.HeaderText = "Qtd. Páginas";
            ColunaPaginas.Name = "ColunaPaginas";
            ColunaPaginas.ReadOnly = true;
            // 
            // ColunaDisponivel
            // 
            ColunaDisponivel.HeaderText = "Disponível";
            ColunaDisponivel.Name = "ColunaDisponivel";
            ColunaDisponivel.ReadOnly = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.reload_refresh_update_icon_149403;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(696, 12);
            button1.Name = "button1";
            button1.Size = new Size(92, 41);
            button1.TabIndex = 1;
            button1.Text = "Buscar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // ButtonFiltros
            // 
            ButtonFiltros.Image = Properties.Resources.search_icon_icons_com_74448;
            ButtonFiltros.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonFiltros.Location = new Point(484, 12);
            ButtonFiltros.Name = "ButtonFiltros";
            ButtonFiltros.Size = new Size(83, 41);
            ButtonFiltros.TabIndex = 2;
            ButtonFiltros.Text = "Filtros";
            ButtonFiltros.TextAlign = ContentAlignment.MiddleRight;
            ButtonFiltros.UseVisualStyleBackColor = true;
            ButtonFiltros.Click += ButtonFiltros_Click;
            // 
            // ButtonLimparFiltros
            // 
            ButtonLimparFiltros.Image = Properties.Resources.eraser_icon_174533;
            ButtonLimparFiltros.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonLimparFiltros.Location = new Point(573, 12);
            ButtonLimparFiltros.Name = "ButtonLimparFiltros";
            ButtonLimparFiltros.Size = new Size(117, 41);
            ButtonLimparFiltros.TabIndex = 3;
            ButtonLimparFiltros.Text = "Limpar FIltros";
            ButtonLimparFiltros.TextAlign = ContentAlignment.MiddleRight;
            ButtonLimparFiltros.UseVisualStyleBackColor = true;
            ButtonLimparFiltros.Click += ButtonLimparFiltros_Click;
            // 
            // LabelQtdFiltros
            // 
            LabelQtdFiltros.AutoSize = true;
            LabelQtdFiltros.BackColor = Color.LightSteelBlue;
            LabelQtdFiltros.ForeColor = Color.Black;
            LabelQtdFiltros.Location = new Point(554, 12);
            LabelQtdFiltros.Name = "LabelQtdFiltros";
            LabelQtdFiltros.Size = new Size(13, 15);
            LabelQtdFiltros.TabIndex = 5;
            LabelQtdFiltros.Text = "0";
            // 
            // button2
            // 
            button2.Image = Properties.Resources.signout_106525;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(78, 41);
            button2.TabIndex = 6;
            button2.Text = "Entrar";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(LabelQtdFiltros);
            Controls.Add(ButtonLimparFiltros);
            Controls.Add(ButtonFiltros);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button ButtonFiltros;
        private Button ButtonLimparFiltros;
        private Label LabelQtdFiltros;
        private Button button2;
        private DataGridViewTextBoxColumn ColunaTitulo;
        private DataGridViewTextBoxColumn ColunaAutor;
        private DataGridViewTextBoxColumn ColunaAnoPublicacao;
        private DataGridViewTextBoxColumn ColunaGenero;
        private DataGridViewTextBoxColumn ColunaIdioma;
        private DataGridViewTextBoxColumn ColunaPaginas;
        private DataGridViewTextBoxColumn ColunaDisponivel;
    }
}