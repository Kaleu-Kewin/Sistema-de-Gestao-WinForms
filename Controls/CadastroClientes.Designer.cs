namespace Dashboard.Controls
{
    partial class CadastroClientes
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
            pnlContainer = new Panel();
            btnLimpar = new Button();
            btnCadastrar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            cmbEstado = new ComboBox();
            txtCidade = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtCodigo = new TextBox();
            cmbTipo = new ComboBox();
            txtNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCpfCnpj = new TextBox();
            lblDescricao = new Label();
            lblTitulo = new Label();
            pnlContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.White;
            pnlContainer.Controls.Add(btnLimpar);
            pnlContainer.Controls.Add(btnCadastrar);
            pnlContainer.Controls.Add(tableLayoutPanel1);
            pnlContainer.Controls.Add(lblDescricao);
            pnlContainer.Controls.Add(lblTitulo);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(900, 350);
            pnlContainer.TabIndex = 1;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpar.BackColor = Color.WhiteSmoke;
            btnLimpar.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Location = new Point(614, 307);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 34);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCadastrar.BackColor = Color.Gray;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(695, 307);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(180, 34);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "+ Cadastrar Cliente";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33444F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33112F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33444F));
            tableLayoutPanel1.Controls.Add(cmbEstado, 1, 5);
            tableLayoutPanel1.Controls.Add(txtCidade, 0, 5);
            tableLayoutPanel1.Controls.Add(label8, 1, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 3);
            tableLayoutPanel1.Controls.Add(txtTelefone, 2, 3);
            tableLayoutPanel1.Controls.Add(label6, 2, 2);
            tableLayoutPanel1.Controls.Add(label5, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(txtCodigo, 0, 1);
            tableLayoutPanel1.Controls.Add(cmbTipo, 2, 1);
            tableLayoutPanel1.Controls.Add(txtNome, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtCpfCnpj, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.Size = new Size(900, 235);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.FromArgb(235, 235, 235);
            cmbEstado.DisplayMember = "Text";
            cmbEstado.Dock = DockStyle.Fill;
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FlatStyle = FlatStyle.Flat;
            cmbEstado.Font = new Font("Segoe UI Semilight", 12F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.IntegralHeight = false;
            cmbEstado.Location = new Point(315, 194);
            cmbEstado.Margin = new Padding(15, 5, 15, 3);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(269, 29);
            cmbEstado.TabIndex = 31;
            cmbEstado.ValueMember = "Value";
            // 
            // txtCidade
            // 
            txtCidade.BackColor = Color.FromArgb(235, 235, 235);
            txtCidade.BorderStyle = BorderStyle.None;
            txtCidade.Dock = DockStyle.Top;
            txtCidade.Font = new Font("Segoe UI Semilight", 12F);
            txtCidade.Location = new Point(25, 194);
            txtCidade.Margin = new Padding(25, 5, 15, 3);
            txtCidade.Multiline = true;
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = " Cidade";
            txtCidade.Size = new Size(260, 29);
            txtCidade.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Bottom;
            label8.Font = new Font("Segoe UI Semilight", 12F);
            label8.Location = new Point(303, 168);
            label8.Name = "label8";
            label8.Padding = new Padding(10, 0, 0, 0);
            label8.Size = new Size(293, 21);
            label8.TabIndex = 25;
            label8.Text = "Estado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Bottom;
            label7.Font = new Font("Segoe UI Semilight", 12F);
            label7.Location = new Point(3, 168);
            label7.Name = "label7";
            label7.Padding = new Padding(20, 0, 0, 0);
            label7.Size = new Size(294, 21);
            label7.TabIndex = 24;
            label7.Text = "Cidade";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(235, 235, 235);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Dock = DockStyle.Top;
            txtEmail.Font = new Font("Segoe UI Semilight", 12F);
            txtEmail.Location = new Point(315, 127);
            txtEmail.Margin = new Padding(15, 5, 15, 3);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " email@exemplo.com";
            txtEmail.Size = new Size(269, 29);
            txtEmail.TabIndex = 23;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = Color.FromArgb(235, 235, 235);
            txtTelefone.BorderStyle = BorderStyle.None;
            txtTelefone.Dock = DockStyle.Top;
            txtTelefone.Font = new Font("Segoe UI Semilight", 12F);
            txtTelefone.Location = new Point(614, 127);
            txtTelefone.Margin = new Padding(15, 5, 25, 3);
            txtTelefone.Multiline = true;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = " (00) 00000-0000";
            txtTelefone.Size = new Size(261, 29);
            txtTelefone.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Bottom;
            label6.Font = new Font("Segoe UI Semilight", 12F);
            label6.Location = new Point(602, 101);
            label6.Name = "label6";
            label6.Padding = new Padding(10, 0, 0, 0);
            label6.Size = new Size(295, 21);
            label6.TabIndex = 20;
            label6.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Bottom;
            label5.Font = new Font("Segoe UI Semilight", 12F);
            label5.Location = new Point(303, 101);
            label5.Name = "label5";
            label5.Padding = new Padding(10, 0, 0, 0);
            label5.Size = new Size(293, 21);
            label5.TabIndex = 19;
            label5.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI Semilight", 12F);
            label4.Location = new Point(3, 101);
            label4.Name = "label4";
            label4.Padding = new Padding(20, 0, 0, 0);
            label4.Size = new Size(294, 21);
            label4.TabIndex = 16;
            label4.Text = "CPF / CNPJ";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(235, 235, 235);
            txtCodigo.BorderStyle = BorderStyle.None;
            txtCodigo.Dock = DockStyle.Top;
            txtCodigo.Font = new Font("Segoe UI Semilight", 12F);
            txtCodigo.Location = new Point(25, 62);
            txtCodigo.Margin = new Padding(25, 5, 15, 3);
            txtCodigo.Multiline = true;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(260, 27);
            txtCodigo.TabIndex = 15;
            // 
            // cmbTipo
            // 
            cmbTipo.BackColor = Color.FromArgb(235, 235, 235);
            cmbTipo.DisplayMember = "Text";
            cmbTipo.Dock = DockStyle.Fill;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FlatStyle = FlatStyle.Flat;
            cmbTipo.Font = new Font("Segoe UI Semilight", 12F);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(614, 62);
            cmbTipo.Margin = new Padding(15, 5, 25, 3);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(261, 29);
            cmbTipo.TabIndex = 14;
            cmbTipo.ValueMember = "Value";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(235, 235, 235);
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Dock = DockStyle.Top;
            txtNome.Font = new Font("Segoe UI Semilight", 12F);
            txtNome.Location = new Point(315, 62);
            txtNome.Margin = new Padding(15, 5, 15, 3);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = " Nome do produto";
            txtNome.Size = new Size(269, 27);
            txtNome.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semilight", 12F);
            label3.Location = new Point(602, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 35, 0, 0);
            label3.Size = new Size(295, 57);
            label3.TabIndex = 10;
            label3.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Semilight", 12F);
            label2.Location = new Point(303, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 35, 0, 0);
            label2.Size = new Size(293, 57);
            label2.TabIndex = 9;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semilight", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 35, 0, 0);
            label1.Size = new Size(294, 57);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.BackColor = Color.FromArgb(235, 235, 235);
            txtCpfCnpj.BorderStyle = BorderStyle.None;
            txtCpfCnpj.Dock = DockStyle.Top;
            txtCpfCnpj.Font = new Font("Segoe UI Semilight", 12F);
            txtCpfCnpj.Location = new Point(25, 127);
            txtCpfCnpj.Margin = new Padding(25, 5, 15, 3);
            txtCpfCnpj.Multiline = true;
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.PlaceholderText = " 000.000.000-00";
            txtCpfCnpj.Size = new Size(260, 29);
            txtCpfCnpj.TabIndex = 18;
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
            lblDescricao.Size = new Size(383, 21);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = "Preencha os campos para cadastrar um novo cliente";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(20, 20, 0, 0);
            lblTitulo.Size = new Size(130, 43);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Novo Cliente";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContainer);
            Name = "CadastroClientes";
            Size = new Size(900, 350);
            Load += CadastroClientes_Load;
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtCodigo;
        private ComboBox cmbTipo;
        private TextBox txtNome;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCpfCnpj;
        private Label lblDescricao;
        private Label lblTitulo;
        private TextBox txtCidade;
        private Label label8;
        private Label label7;
        private ComboBox cmbEstado;
        private Button btnLimpar;
        private Button btnCadastrar;
    }
}
