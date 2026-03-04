namespace Dashboard.Controls
{
    partial class CadastroProdutos
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
            tableLayoutPanel1 = new TableLayoutPanel();
            txtPreco = new TextBox();
            txtDescricao = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtCodigo = new TextBox();
            cmbCategoria = new ComboBox();
            txtNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtQuantidade = new TextBox();
            btnCadastrarProduto = new Button();
            btnLimpar = new Button();
            pnlContainer = new Panel();
            tableLayoutPanel1.SuspendLayout();
            pnlContainer.SuspendLayout();
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
            lblTitulo.Size = new Size(139, 43);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Novo Produto";
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
            lblDescricao.Size = new Size(393, 21);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = "Preencha os campos para cadastrar um novo produto";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33444F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33112F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33444F));
            tableLayoutPanel1.Controls.Add(txtPreco, 1, 3);
            tableLayoutPanel1.Controls.Add(txtDescricao, 2, 3);
            tableLayoutPanel1.Controls.Add(label6, 2, 2);
            tableLayoutPanel1.Controls.Add(label5, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(txtCodigo, 0, 1);
            tableLayoutPanel1.Controls.Add(cmbCategoria, 2, 1);
            tableLayoutPanel1.Controls.Add(txtNome, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtQuantidade, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.Size = new Size(900, 194);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // txtPreco
            // 
            txtPreco.BackColor = Color.FromArgb(235, 235, 235);
            txtPreco.BorderStyle = BorderStyle.None;
            txtPreco.Dock = DockStyle.Top;
            txtPreco.Font = new Font("Segoe UI Semilight", 12F);
            txtPreco.Location = new Point(315, 130);
            txtPreco.Margin = new Padding(15, 5, 15, 3);
            txtPreco.Multiline = true;
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = " 0";
            txtPreco.Size = new Size(269, 29);
            txtPreco.TabIndex = 23;
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.FromArgb(235, 235, 235);
            txtDescricao.BorderStyle = BorderStyle.None;
            txtDescricao.Dock = DockStyle.Top;
            txtDescricao.Font = new Font("Segoe UI Semilight", 12F);
            txtDescricao.Location = new Point(614, 130);
            txtDescricao.Margin = new Padding(15, 5, 25, 3);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = " Breve descrição do produto";
            txtDescricao.Size = new Size(261, 29);
            txtDescricao.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Bottom;
            label6.Font = new Font("Segoe UI Semilight", 12F);
            label6.Location = new Point(602, 104);
            label6.Name = "label6";
            label6.Padding = new Padding(10, 0, 0, 0);
            label6.Size = new Size(295, 21);
            label6.TabIndex = 20;
            label6.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Bottom;
            label5.Font = new Font("Segoe UI Semilight", 12F);
            label5.Location = new Point(303, 104);
            label5.Name = "label5";
            label5.Padding = new Padding(10, 0, 0, 0);
            label5.Size = new Size(293, 21);
            label5.TabIndex = 19;
            label5.Text = "Preço (R$)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI Semilight", 12F);
            label4.Location = new Point(3, 104);
            label4.Name = "label4";
            label4.Padding = new Padding(20, 0, 0, 0);
            label4.Size = new Size(294, 21);
            label4.TabIndex = 16;
            label4.Text = "Quantidade";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(235, 235, 235);
            txtCodigo.BorderStyle = BorderStyle.None;
            txtCodigo.Dock = DockStyle.Fill;
            txtCodigo.Font = new Font("Segoe UI Semilight", 12F);
            txtCodigo.Location = new Point(25, 63);
            txtCodigo.Margin = new Padding(25, 5, 15, 3);
            txtCodigo.Multiline = true;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(260, 27);
            txtCodigo.TabIndex = 15;
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.FromArgb(235, 235, 235);
            cmbCategoria.Dock = DockStyle.Fill;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FlatStyle = FlatStyle.Flat;
            cmbCategoria.Font = new Font("Segoe UI Semilight", 12F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(614, 63);
            cmbCategoria.Margin = new Padding(15, 5, 25, 3);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(261, 29);
            cmbCategoria.TabIndex = 14;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(235, 235, 235);
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Dock = DockStyle.Fill;
            txtNome.Font = new Font("Segoe UI Semilight", 12F);
            txtNome.Location = new Point(315, 63);
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
            label3.Size = new Size(295, 58);
            label3.TabIndex = 10;
            label3.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Semilight", 12F);
            label2.Location = new Point(303, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 35, 0, 0);
            label2.Size = new Size(293, 58);
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
            label1.Size = new Size(294, 58);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // txtQuantidade
            // 
            txtQuantidade.BackColor = Color.FromArgb(235, 235, 235);
            txtQuantidade.BorderStyle = BorderStyle.None;
            txtQuantidade.Dock = DockStyle.Top;
            txtQuantidade.Font = new Font("Segoe UI Semilight", 12F);
            txtQuantidade.Location = new Point(25, 130);
            txtQuantidade.Margin = new Padding(25, 5, 15, 3);
            txtQuantidade.Multiline = true;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PlaceholderText = " 0";
            txtQuantidade.Size = new Size(260, 29);
            txtQuantidade.TabIndex = 18;
            // 
            // btnCadastrarProduto
            // 
            btnCadastrarProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCadastrarProduto.BackColor = Color.Gray;
            btnCadastrarProduto.FlatAppearance.BorderSize = 0;
            btnCadastrarProduto.FlatStyle = FlatStyle.Flat;
            btnCadastrarProduto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarProduto.ForeColor = Color.White;
            btnCadastrarProduto.Location = new Point(695, 262);
            btnCadastrarProduto.Name = "btnCadastrarProduto";
            btnCadastrarProduto.Size = new Size(180, 34);
            btnCadastrarProduto.TabIndex = 5;
            btnCadastrarProduto.Text = "+ Cadastrar Produto";
            btnCadastrarProduto.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpar.BackColor = Color.WhiteSmoke;
            btnLimpar.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Location = new Point(614, 264);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 34);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.White;
            pnlContainer.Controls.Add(btnLimpar);
            pnlContainer.Controls.Add(btnCadastrarProduto);
            pnlContainer.Controls.Add(tableLayoutPanel1);
            pnlContainer.Controls.Add(lblDescricao);
            pnlContainer.Controls.Add(lblTitulo);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(900, 300);
            pnlContainer.TabIndex = 0;
            // 
            // CadastroProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlContainer);
            Name = "CadastroProdutos";
            Size = new Size(900, 300);
            Load += CadastroProdutos_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblDescricao;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtPreco;
        private TextBox txtDescricao;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtCodigo;
        private ComboBox cmbCategoria;
        private TextBox txtNome;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtQuantidade;
        private Button btnCadastrarProduto;
        private Button btnLimpar;
        private Panel pnlContainer;
    }
}
