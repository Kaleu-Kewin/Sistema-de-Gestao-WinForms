namespace Dashboard.UI.UserControls
{
    partial class ConfiguracoesEmpresa
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
            panel1 = new Panel();
            btnSalvar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtEndereco = new TextBox();
            label7 = new Label();
            txtCidade = new TextBox();
            label8 = new Label();
            cmbEstado = new ComboBox();
            label9 = new Label();
            txtEmail = new TextBox();
            txtSite = new TextBox();
            txtCEP = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtRazaoSocial = new TextBox();
            txtCNPJ = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTelefone = new TextBox();
            lblDescricao = new Label();
            lblTitulo = new Label();
            pnlContainer.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.White;
            pnlContainer.Controls.Add(panel1);
            pnlContainer.Controls.Add(tableLayoutPanel1);
            pnlContainer.Controls.Add(lblDescricao);
            pnlContainer.Controls.Add(lblTitulo);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(955, 345);
            pnlContainer.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSalvar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 299);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 47);
            panel1.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalvar.BackColor = Color.Gray;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(760, 7);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(180, 34);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar Empresa";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33444F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33112F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33444F));
            tableLayoutPanel1.Controls.Add(txtEndereco, 0, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(txtCidade, 1, 5);
            tableLayoutPanel1.Controls.Add(label8, 1, 4);
            tableLayoutPanel1.Controls.Add(cmbEstado, 2, 5);
            tableLayoutPanel1.Controls.Add(label9, 2, 4);
            tableLayoutPanel1.Controls.Add(txtEmail, 2, 1);
            tableLayoutPanel1.Controls.Add(txtSite, 1, 3);
            tableLayoutPanel1.Controls.Add(txtCEP, 2, 3);
            tableLayoutPanel1.Controls.Add(label6, 2, 2);
            tableLayoutPanel1.Controls.Add(label5, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(txtRazaoSocial, 0, 1);
            tableLayoutPanel1.Controls.Add(txtCNPJ, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtTelefone, 0, 3);
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
            tableLayoutPanel1.Size = new Size(955, 235);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = Color.FromArgb(235, 235, 235);
            txtEndereco.BorderStyle = BorderStyle.None;
            txtEndereco.Dock = DockStyle.Top;
            txtEndereco.Font = new Font("Segoe UI Semilight", 12F);
            txtEndereco.Location = new Point(25, 194);
            txtEndereco.Margin = new Padding(25, 5, 15, 3);
            txtEndereco.Multiline = true;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = " Av. Exemplo, 123 - Centro";
            txtEndereco.Size = new Size(278, 29);
            txtEndereco.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Bottom;
            label7.Font = new Font("Segoe UI Semilight", 12F);
            label7.Location = new Point(3, 168);
            label7.Name = "label7";
            label7.Padding = new Padding(20, 0, 0, 0);
            label7.Size = new Size(312, 21);
            label7.TabIndex = 37;
            label7.Text = "Endereço";
            // 
            // txtCidade
            // 
            txtCidade.BackColor = Color.FromArgb(235, 235, 235);
            txtCidade.BorderStyle = BorderStyle.None;
            txtCidade.Dock = DockStyle.Top;
            txtCidade.Font = new Font("Segoe UI Semilight", 12F);
            txtCidade.Location = new Point(333, 194);
            txtCidade.Margin = new Padding(15, 5, 15, 3);
            txtCidade.Multiline = true;
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = " Cidade";
            txtCidade.Size = new Size(288, 29);
            txtCidade.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Bottom;
            label8.Font = new Font("Segoe UI Semilight", 12F);
            label8.Location = new Point(321, 168);
            label8.Name = "label8";
            label8.Padding = new Padding(10, 0, 0, 0);
            label8.Size = new Size(312, 21);
            label8.TabIndex = 35;
            label8.Text = "Cidade";
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
            cmbEstado.Location = new Point(651, 194);
            cmbEstado.Margin = new Padding(15, 5, 15, 3);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(289, 29);
            cmbEstado.TabIndex = 34;
            cmbEstado.ValueMember = "Value";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Bottom;
            label9.Font = new Font("Segoe UI Semilight", 12F);
            label9.Location = new Point(639, 168);
            label9.Name = "label9";
            label9.Padding = new Padding(10, 0, 0, 0);
            label9.Size = new Size(313, 21);
            label9.TabIndex = 33;
            label9.Text = "Estado";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(235, 235, 235);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Dock = DockStyle.Top;
            txtEmail.Font = new Font("Segoe UI Semilight", 12F);
            txtEmail.Location = new Point(651, 62);
            txtEmail.Margin = new Padding(15, 5, 15, 3);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " email@exemplo.com";
            txtEmail.Size = new Size(289, 29);
            txtEmail.TabIndex = 32;
            // 
            // txtSite
            // 
            txtSite.BackColor = Color.FromArgb(235, 235, 235);
            txtSite.BorderStyle = BorderStyle.None;
            txtSite.Dock = DockStyle.Top;
            txtSite.Font = new Font("Segoe UI Semilight", 12F);
            txtSite.Location = new Point(333, 127);
            txtSite.Margin = new Padding(15, 5, 15, 3);
            txtSite.Multiline = true;
            txtSite.Name = "txtSite";
            txtSite.PlaceholderText = " www.minhaempresa.com";
            txtSite.Size = new Size(288, 29);
            txtSite.TabIndex = 23;
            // 
            // txtCEP
            // 
            txtCEP.BackColor = Color.FromArgb(235, 235, 235);
            txtCEP.BorderStyle = BorderStyle.None;
            txtCEP.Dock = DockStyle.Top;
            txtCEP.Font = new Font("Segoe UI Semilight", 12F);
            txtCEP.Location = new Point(651, 127);
            txtCEP.Margin = new Padding(15, 5, 25, 3);
            txtCEP.Multiline = true;
            txtCEP.Name = "txtCEP";
            txtCEP.PlaceholderText = " 00000-00";
            txtCEP.Size = new Size(279, 29);
            txtCEP.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Bottom;
            label6.Font = new Font("Segoe UI Semilight", 12F);
            label6.Location = new Point(639, 101);
            label6.Name = "label6";
            label6.Padding = new Padding(10, 0, 0, 0);
            label6.Size = new Size(313, 21);
            label6.TabIndex = 20;
            label6.Text = "CEP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Bottom;
            label5.Font = new Font("Segoe UI Semilight", 12F);
            label5.Location = new Point(321, 101);
            label5.Name = "label5";
            label5.Padding = new Padding(10, 0, 0, 0);
            label5.Size = new Size(312, 21);
            label5.TabIndex = 19;
            label5.Text = "Site";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI Semilight", 12F);
            label4.Location = new Point(3, 101);
            label4.Name = "label4";
            label4.Padding = new Padding(20, 0, 0, 0);
            label4.Size = new Size(312, 21);
            label4.TabIndex = 16;
            label4.Text = "Telefone";
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.BackColor = Color.FromArgb(235, 235, 235);
            txtRazaoSocial.BorderStyle = BorderStyle.None;
            txtRazaoSocial.Dock = DockStyle.Top;
            txtRazaoSocial.Font = new Font("Segoe UI Semilight", 12F);
            txtRazaoSocial.Location = new Point(25, 62);
            txtRazaoSocial.Margin = new Padding(25, 5, 15, 3);
            txtRazaoSocial.Multiline = true;
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.PlaceholderText = " Minha empresa LTDA";
            txtRazaoSocial.Size = new Size(278, 27);
            txtRazaoSocial.TabIndex = 15;
            // 
            // txtCNPJ
            // 
            txtCNPJ.BackColor = Color.FromArgb(235, 235, 235);
            txtCNPJ.BorderStyle = BorderStyle.None;
            txtCNPJ.Dock = DockStyle.Top;
            txtCNPJ.Font = new Font("Segoe UI Semilight", 12F);
            txtCNPJ.Location = new Point(333, 62);
            txtCNPJ.Margin = new Padding(15, 5, 15, 3);
            txtCNPJ.Multiline = true;
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.PlaceholderText = " 00.000.000/0000-00";
            txtCNPJ.Size = new Size(288, 27);
            txtCNPJ.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semilight", 12F);
            label3.Location = new Point(639, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 35, 0, 0);
            label3.Size = new Size(313, 57);
            label3.TabIndex = 10;
            label3.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Semilight", 12F);
            label2.Location = new Point(321, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 35, 0, 0);
            label2.Size = new Size(312, 57);
            label2.TabIndex = 9;
            label2.Text = "CNPJ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semilight", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 35, 0, 0);
            label1.Size = new Size(312, 57);
            label1.TabIndex = 0;
            label1.Text = "Razão Social";
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = Color.FromArgb(235, 235, 235);
            txtTelefone.BorderStyle = BorderStyle.None;
            txtTelefone.Dock = DockStyle.Top;
            txtTelefone.Font = new Font("Segoe UI Semilight", 12F);
            txtTelefone.Location = new Point(25, 127);
            txtTelefone.Margin = new Padding(25, 5, 15, 3);
            txtTelefone.Multiline = true;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = " (00) 00000-0000";
            txtTelefone.Size = new Size(278, 29);
            txtTelefone.TabIndex = 18;
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
            lblDescricao.Size = new Size(269, 21);
            lblDescricao.TabIndex = 5;
            lblDescricao.Text = "Informações cadastrais da empresa";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(20, 20, 0, 0);
            lblTitulo.Size = new Size(172, 43);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Dados da Empresa";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ConfiguracoesEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContainer);
            Name = "ConfiguracoesEmpresa";
            Size = new Size(955, 345);
            Load += ConfiguracoesEmpresa_Load;
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Label lblDescricao;
        private Label lblTitulo;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtSite;
        private TextBox txtCEP;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtRazaoSocial;
        private TextBox txtCNPJ;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtCidade;
        private Label label8;
        private ComboBox cmbEstado;
        private Label label9;
        private TextBox txtEndereco;
        private Panel panel1;
        private Button btnSalvar;
    }
}
