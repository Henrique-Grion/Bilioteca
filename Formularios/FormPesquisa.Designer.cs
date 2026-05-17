namespace Bilioteca.Formularios
{
    partial class FormPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisa));
            TextBoxTermos = new TextBox();
            ComboBoxCampoBusca = new ComboBox();
            LabelCampoBusca = new Label();
            label3 = new Label();
            LabelIdioma = new Label();
            ComboBoxIdioma = new ComboBox();
            LabelGenero = new Label();
            LabelAno = new Label();
            ComboBoxGenero = new ComboBox();
            LabelAnoAte = new Label();
            LabelTermos = new Label();
            ButtonCancelar = new Button();
            ButtonAplicar = new Button();
            GroupBoxBusca = new GroupBox();
            GrupBoxFiltros = new GroupBox();
            NumericUpDownAnoAte = new NumericUpDown();
            NumericUpDownAnoDe = new NumericUpDown();
            GroupBoxBusca.SuspendLayout();
            GrupBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownAnoAte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownAnoDe).BeginInit();
            SuspendLayout();
            // 
            // TextBoxTermos
            // 
            TextBoxTermos.Location = new Point(99, 77);
            TextBoxTermos.Name = "TextBoxTermos";
            TextBoxTermos.Size = new Size(209, 23);
            TextBoxTermos.TabIndex = 0;
            // 
            // ComboBoxCampoBusca
            // 
            ComboBoxCampoBusca.FormattingEnabled = true;
            ComboBoxCampoBusca.Items.AddRange(new object[] { "Título", "Autor" });
            ComboBoxCampoBusca.Location = new Point(99, 32);
            ComboBoxCampoBusca.Name = "ComboBoxCampoBusca";
            ComboBoxCampoBusca.Size = new Size(209, 23);
            ComboBoxCampoBusca.TabIndex = 2;
            // 
            // LabelCampoBusca
            // 
            LabelCampoBusca.Font = new Font("Segoe UI", 12F);
            LabelCampoBusca.Location = new Point(6, 19);
            LabelCampoBusca.Name = "LabelCampoBusca";
            LabelCampoBusca.Size = new Size(87, 50);
            LabelCampoBusca.TabIndex = 3;
            LabelCampoBusca.Text = "Campo para busca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(142, 139);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 4;
            // 
            // LabelIdioma
            // 
            LabelIdioma.AutoSize = true;
            LabelIdioma.Font = new Font("Segoe UI", 12F);
            LabelIdioma.Location = new Point(6, 21);
            LabelIdioma.Name = "LabelIdioma";
            LabelIdioma.Size = new Size(58, 21);
            LabelIdioma.TabIndex = 6;
            LabelIdioma.Text = "Idioma";
            // 
            // ComboBoxIdioma
            // 
            ComboBoxIdioma.FormattingEnabled = true;
            ComboBoxIdioma.Items.AddRange(new object[] { "Português", "Inglês", "Espanhol", "Françes", "Alemão", "Outro" });
            ComboBoxIdioma.Location = new Point(99, 19);
            ComboBoxIdioma.Name = "ComboBoxIdioma";
            ComboBoxIdioma.Size = new Size(209, 23);
            ComboBoxIdioma.TabIndex = 9;
            // 
            // LabelGenero
            // 
            LabelGenero.AutoSize = true;
            LabelGenero.Font = new Font("Segoe UI", 12F);
            LabelGenero.Location = new Point(6, 50);
            LabelGenero.Name = "LabelGenero";
            LabelGenero.Size = new Size(61, 21);
            LabelGenero.TabIndex = 8;
            LabelGenero.Text = "Gênero";
            // 
            // LabelAno
            // 
            LabelAno.AutoSize = true;
            LabelAno.Font = new Font("Segoe UI", 12F);
            LabelAno.Location = new Point(6, 79);
            LabelAno.Name = "LabelAno";
            LabelAno.Size = new Size(62, 21);
            LabelAno.TabIndex = 10;
            LabelAno.Text = "Ano de:";
            // 
            // ComboBoxGenero
            // 
            ComboBoxGenero.FormattingEnabled = true;
            ComboBoxGenero.Items.AddRange(new object[] { "Ficção", "Filosofia", "Romance", "Aventura", "Ciência", "História" });
            ComboBoxGenero.Location = new Point(99, 48);
            ComboBoxGenero.Name = "ComboBoxGenero";
            ComboBoxGenero.Size = new Size(209, 23);
            ComboBoxGenero.TabIndex = 13;
            // 
            // LabelAnoAte
            // 
            LabelAnoAte.AutoSize = true;
            LabelAnoAte.Font = new Font("Segoe UI", 12F);
            LabelAnoAte.Location = new Point(187, 79);
            LabelAnoAte.Name = "LabelAnoAte";
            LabelAnoAte.Size = new Size(33, 21);
            LabelAnoAte.TabIndex = 12;
            LabelAnoAte.Text = "Até";
            // 
            // LabelTermos
            // 
            LabelTermos.AutoSize = true;
            LabelTermos.Font = new Font("Segoe UI", 12F);
            LabelTermos.Location = new Point(6, 75);
            LabelTermos.Name = "LabelTermos";
            LabelTermos.Size = new Size(60, 21);
            LabelTermos.TabIndex = 1;
            LabelTermos.Text = "Termos";
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Location = new Point(294, 256);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(75, 23);
            ButtonCancelar.TabIndex = 15;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // ButtonAplicar
            // 
            ButtonAplicar.Location = new Point(375, 256);
            ButtonAplicar.Name = "ButtonAplicar";
            ButtonAplicar.Size = new Size(75, 23);
            ButtonAplicar.TabIndex = 16;
            ButtonAplicar.Text = "Aplicar";
            ButtonAplicar.UseVisualStyleBackColor = true;
            ButtonAplicar.Click += ButtonAplicar_Click;
            // 
            // GroupBoxBusca
            // 
            GroupBoxBusca.Controls.Add(LabelCampoBusca);
            GroupBoxBusca.Controls.Add(TextBoxTermos);
            GroupBoxBusca.Controls.Add(ComboBoxCampoBusca);
            GroupBoxBusca.Controls.Add(LabelTermos);
            GroupBoxBusca.Location = new Point(12, 12);
            GroupBoxBusca.Name = "GroupBoxBusca";
            GroupBoxBusca.Size = new Size(438, 111);
            GroupBoxBusca.TabIndex = 17;
            GroupBoxBusca.TabStop = false;
            GroupBoxBusca.Text = "Busca";
            // 
            // GrupBoxFiltros
            // 
            GrupBoxFiltros.Controls.Add(NumericUpDownAnoAte);
            GrupBoxFiltros.Controls.Add(NumericUpDownAnoDe);
            GrupBoxFiltros.Controls.Add(ComboBoxGenero);
            GrupBoxFiltros.Controls.Add(LabelAnoAte);
            GrupBoxFiltros.Controls.Add(LabelAno);
            GrupBoxFiltros.Controls.Add(ComboBoxIdioma);
            GrupBoxFiltros.Controls.Add(LabelGenero);
            GrupBoxFiltros.Controls.Add(LabelIdioma);
            GrupBoxFiltros.Location = new Point(12, 129);
            GrupBoxFiltros.Name = "GrupBoxFiltros";
            GrupBoxFiltros.Size = new Size(438, 111);
            GrupBoxFiltros.TabIndex = 18;
            GrupBoxFiltros.TabStop = false;
            GrupBoxFiltros.Text = "Filtros";
            // 
            // NumericUpDownAnoAte
            // 
            NumericUpDownAnoAte.Location = new Point(226, 77);
            NumericUpDownAnoAte.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            NumericUpDownAnoAte.Name = "NumericUpDownAnoAte";
            NumericUpDownAnoAte.Size = new Size(82, 23);
            NumericUpDownAnoAte.TabIndex = 15;
            // 
            // NumericUpDownAnoDe
            // 
            NumericUpDownAnoDe.Location = new Point(99, 77);
            NumericUpDownAnoDe.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            NumericUpDownAnoDe.Name = "NumericUpDownAnoDe";
            NumericUpDownAnoDe.Size = new Size(82, 23);
            NumericUpDownAnoDe.TabIndex = 14;
            // 
            // Pesquisa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 291);
            Controls.Add(GrupBoxFiltros);
            Controls.Add(GroupBoxBusca);
            Controls.Add(ButtonCancelar);
            Controls.Add(label3);
            Controls.Add(ButtonAplicar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Pesquisa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Filtros";
            GroupBoxBusca.ResumeLayout(false);
            GroupBoxBusca.PerformLayout();
            GrupBoxFiltros.ResumeLayout(false);
            GrupBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownAnoAte).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownAnoDe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxTermos;
        private ComboBox ComboBoxCampoBusca;
        private Label LabelCampoBusca;
        private Label label3;
        private Label LabelIdioma;
        private ComboBox ComboBoxIdioma;
        private Label LabelGenero;
        private Label LabelAno;
        private ComboBox ComboBoxGenero;
        private Label LabelAnoAte;
        private Label LabelTermos;
        private Button ButtonCancelar;
        private Button ButtonAplicar;
        private GroupBox GroupBoxBusca;
        private GroupBox GrupBoxFiltros;
        private NumericUpDown NumericUpDownAnoAte;
        private NumericUpDown NumericUpDownAnoDe;
    }
}