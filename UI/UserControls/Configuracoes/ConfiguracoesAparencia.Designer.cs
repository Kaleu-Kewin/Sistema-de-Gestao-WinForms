namespace Dashboard.UI.UserControls
{
    partial class ConfiguracoesAparencia
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblDescricao = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbTema = new ComboBox();
            cmbIdioma = new ComboBox();
            cmbMoeda = new ComboBox();
            cmbFormatoData = new ComboBox();
            cmbItensPagina = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSalvar = new Button();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(20, 20, 0, 0);
            lblTitulo.Size = new Size(188, 43);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Aparência e Exibição";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Dock = DockStyle.Top;
            lblDescricao.Font = new Font("Segoe UI Semilight", 12F);
            lblDescricao.ForeColor = SystemColors.ControlDarkDark;
            lblDescricao.Location = new Point(0, 43);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Padding = new Padding(20, 0, 0, 0);
            lblDescricao.Size = new Size(425, 21);
            lblDescricao.TabIndex = 7;
            lblDescricao.Text = "Personalize a aparência e formatos de exibição do sistema";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI Semilight", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 35, 0, 0);
            label1.Size = new Size(305, 56);
            label1.TabIndex = 0;
            label1.Text = "Tema";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI Semilight", 12F);
            label2.Location = new Point(314, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 35, 0, 0);
            label2.Size = new Size(310, 56);
            label2.TabIndex = 9;
            label2.Text = "Idioma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI Semilight", 12F);
            label3.Location = new Point(630, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 35, 0, 0);
            label3.Size = new Size(309, 56);
            label3.TabIndex = 10;
            label3.Text = "Moeda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI Semilight", 12F);
            label4.Location = new Point(3, 100);
            label4.Name = "label4";
            label4.Padding = new Padding(20, 0, 0, 0);
            label4.Size = new Size(305, 21);
            label4.TabIndex = 16;
            label4.Text = "Formato de Data";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Bottom;
            label5.Font = new Font("Segoe UI Semilight", 12F);
            label5.Location = new Point(314, 100);
            label5.Name = "label5";
            label5.Padding = new Padding(10, 0, 0, 0);
            label5.Size = new Size(310, 21);
            label5.TabIndex = 19;
            label5.Text = "Itens por página";
            label5.Visible = false;
            // 
            // cmbTema
            // 
            cmbTema.BackColor = Color.FromArgb(235, 235, 235);
            cmbTema.DisplayMember = "Text";
            cmbTema.Dock = DockStyle.Fill;
            cmbTema.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTema.FlatStyle = FlatStyle.Flat;
            cmbTema.Font = new Font("Segoe UI Semilight", 12F);
            cmbTema.FormattingEnabled = true;
            cmbTema.IntegralHeight = false;
            cmbTema.Location = new Point(30, 61);
            cmbTema.Margin = new Padding(30, 5, 15, 3);
            cmbTema.Name = "cmbTema";
            cmbTema.Size = new Size(266, 29);
            cmbTema.TabIndex = 35;
            cmbTema.ValueMember = "Value";
            cmbTema.SelectedIndexChanged += cmbTema_SelectedIndexChanged;
            // 
            // cmbIdioma
            // 
            cmbIdioma.BackColor = Color.FromArgb(235, 235, 235);
            cmbIdioma.DisplayMember = "Text";
            cmbIdioma.Dock = DockStyle.Fill;
            cmbIdioma.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdioma.FlatStyle = FlatStyle.Flat;
            cmbIdioma.Font = new Font("Segoe UI Semilight", 12F);
            cmbIdioma.FormattingEnabled = true;
            cmbIdioma.IntegralHeight = false;
            cmbIdioma.Location = new Point(326, 61);
            cmbIdioma.Margin = new Padding(15, 5, 15, 3);
            cmbIdioma.Name = "cmbIdioma";
            cmbIdioma.Size = new Size(286, 29);
            cmbIdioma.TabIndex = 36;
            cmbIdioma.ValueMember = "Value";
            // 
            // cmbMoeda
            // 
            cmbMoeda.BackColor = Color.FromArgb(235, 235, 235);
            cmbMoeda.DisplayMember = "Text";
            cmbMoeda.Dock = DockStyle.Fill;
            cmbMoeda.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMoeda.FlatStyle = FlatStyle.Flat;
            cmbMoeda.Font = new Font("Segoe UI Semilight", 12F);
            cmbMoeda.FormattingEnabled = true;
            cmbMoeda.IntegralHeight = false;
            cmbMoeda.Location = new Point(642, 61);
            cmbMoeda.Margin = new Padding(15, 5, 30, 3);
            cmbMoeda.Name = "cmbMoeda";
            cmbMoeda.Size = new Size(270, 29);
            cmbMoeda.TabIndex = 37;
            cmbMoeda.ValueMember = "Value";
            // 
            // cmbFormatoData
            // 
            cmbFormatoData.BackColor = Color.FromArgb(235, 235, 235);
            cmbFormatoData.DisplayMember = "Text";
            cmbFormatoData.Dock = DockStyle.Fill;
            cmbFormatoData.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormatoData.FlatStyle = FlatStyle.Flat;
            cmbFormatoData.Font = new Font("Segoe UI Semilight", 12F);
            cmbFormatoData.FormattingEnabled = true;
            cmbFormatoData.IntegralHeight = false;
            cmbFormatoData.Location = new Point(30, 126);
            cmbFormatoData.Margin = new Padding(30, 5, 15, 3);
            cmbFormatoData.Name = "cmbFormatoData";
            cmbFormatoData.Size = new Size(266, 29);
            cmbFormatoData.TabIndex = 39;
            cmbFormatoData.ValueMember = "Value";
            // 
            // cmbItensPagina
            // 
            cmbItensPagina.BackColor = Color.FromArgb(235, 235, 235);
            cmbItensPagina.DisplayMember = "Text";
            cmbItensPagina.Dock = DockStyle.Fill;
            cmbItensPagina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItensPagina.FlatStyle = FlatStyle.Flat;
            cmbItensPagina.Font = new Font("Segoe UI Semilight", 12F);
            cmbItensPagina.FormattingEnabled = true;
            cmbItensPagina.IntegralHeight = false;
            cmbItensPagina.Location = new Point(326, 126);
            cmbItensPagina.Margin = new Padding(15, 5, 15, 3);
            cmbItensPagina.Name = "cmbItensPagina";
            cmbItensPagina.Size = new Size(286, 29);
            cmbItensPagina.TabIndex = 40;
            cmbItensPagina.ValueMember = "Value";
            cmbItensPagina.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.0148621F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.5456467F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33444F));
            tableLayoutPanel1.Controls.Add(cmbItensPagina, 1, 3);
            tableLayoutPanel1.Controls.Add(cmbFormatoData, 0, 3);
            tableLayoutPanel1.Controls.Add(cmbMoeda, 2, 1);
            tableLayoutPanel1.Controls.Add(cmbIdioma, 1, 1);
            tableLayoutPanel1.Controls.Add(cmbTema, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.Size = new Size(942, 162);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalvar.BackColor = Color.Gray;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(732, 6);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(180, 34);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar Aparência";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSalvar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 226);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 46);
            panel1.TabIndex = 9;
            // 
            // ConfiguracoesAparencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblDescricao);
            Controls.Add(lblTitulo);
            Name = "ConfiguracoesAparencia";
            Size = new Size(942, 275);
            Load += ConfiguracoesAparencia_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblDescricao;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbTema;
        private ComboBox cmbIdioma;
        private ComboBox cmbMoeda;
        private ComboBox cmbFormatoData;
        private ComboBox cmbItensPagina;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSalvar;
        private Panel panel1;
    }
}
