namespace Dashboard.Controls
{
    partial class CadastroVendas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroVendas));
            pnlContainer = new Panel();
            pnlBottom = new Panel();
            btnLimpar1 = new Button();
            btnRegistrarVenda = new Button();
            tblProdutos = new TableLayoutPanel();
            dgvDados = new DataGridView();
            label6 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAdicionar = new Button();
            txtQuantidade = new TextBox();
            cmbProdutos = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label5 = new Label();
            mcCalendarioExibir = new MonthCalendar();
            btnLimpar = new Button();
            btnCadastrarProduto = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            cmbCliente = new ComboBox();
            label4 = new Label();
            txtCodigo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbStatus = new ComboBox();
            panel1 = new Panel();
            picCalendario = new PictureBox();
            txtData = new MaskedTextBox();
            lblDescricao = new Label();
            lblTitulo = new Label();
            pnlContainer.SuspendLayout();
            pnlBottom.SuspendLayout();
            tblProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCalendario).BeginInit();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.White;
            pnlContainer.Controls.Add(pnlBottom);
            pnlContainer.Controls.Add(tblProdutos);
            pnlContainer.Controls.Add(tableLayoutPanel2);
            pnlContainer.Controls.Add(label5);
            pnlContainer.Controls.Add(mcCalendarioExibir);
            pnlContainer.Controls.Add(btnLimpar);
            pnlContainer.Controls.Add(btnCadastrarProduto);
            pnlContainer.Controls.Add(tableLayoutPanel1);
            pnlContainer.Controls.Add(lblDescricao);
            pnlContainer.Controls.Add(lblTitulo);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(974, 506);
            pnlContainer.TabIndex = 1;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(btnLimpar1);
            pnlBottom.Controls.Add(btnRegistrarVenda);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 451);
            pnlBottom.Margin = new Padding(3, 10, 3, 3);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(0, 10, 0, 0);
            pnlBottom.Size = new Size(974, 55);
            pnlBottom.TabIndex = 16;
            // 
            // btnLimpar1
            // 
            btnLimpar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpar1.BackColor = Color.WhiteSmoke;
            btnLimpar1.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnLimpar1.FlatStyle = FlatStyle.Flat;
            btnLimpar1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLimpar1.Location = new Point(689, 12);
            btnLimpar1.Margin = new Padding(20);
            btnLimpar1.Name = "btnLimpar1";
            btnLimpar1.Size = new Size(75, 34);
            btnLimpar1.TabIndex = 12;
            btnLimpar1.Text = "Limpar";
            btnLimpar1.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarVenda
            // 
            btnRegistrarVenda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRegistrarVenda.BackColor = Color.Gray;
            btnRegistrarVenda.FlatAppearance.BorderSize = 0;
            btnRegistrarVenda.FlatStyle = FlatStyle.Flat;
            btnRegistrarVenda.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarVenda.ForeColor = Color.White;
            btnRegistrarVenda.Location = new Point(769, 12);
            btnRegistrarVenda.Margin = new Padding(20);
            btnRegistrarVenda.Name = "btnRegistrarVenda";
            btnRegistrarVenda.Size = new Size(180, 34);
            btnRegistrarVenda.TabIndex = 11;
            btnRegistrarVenda.Text = "+ Registrar Venda";
            btnRegistrarVenda.UseVisualStyleBackColor = false;
            // 
            // tblProdutos
            // 
            tblProdutos.ColumnCount = 1;
            tblProdutos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblProdutos.Controls.Add(dgvDados, 0, 0);
            tblProdutos.Controls.Add(label6, 0, 1);
            tblProdutos.Dock = DockStyle.Top;
            tblProdutos.Location = new Point(0, 276);
            tblProdutos.Name = "tblProdutos";
            tblProdutos.RowCount = 2;
            tblProdutos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblProdutos.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tblProdutos.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblProdutos.Size = new Size(974, 176);
            tblProdutos.TabIndex = 15;
            // 
            // dgvDados
            // 
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;
            dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDados.BackgroundColor = Color.White;
            dgvDados.BorderStyle = BorderStyle.None;
            dgvDados.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvDados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDados.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDados.Dock = DockStyle.Fill;
            dgvDados.EnableHeadersVisualStyles = false;
            dgvDados.GridColor = SystemColors.Window;
            dgvDados.Location = new Point(25, 25);
            dgvDados.Margin = new Padding(25, 25, 25, 1);
            dgvDados.Name = "dgvDados";
            dgvDados.ReadOnly = true;
            dgvDados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDados.RowHeadersVisible = false;
            dgvDados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvDados.Size = new Size(924, 126);
            dgvDados.TabIndex = 14;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label6.Location = new Point(25, 152);
            label6.Margin = new Padding(25, 0, 25, 0);
            label6.Name = "label6";
            label6.Size = new Size(924, 24);
            label6.TabIndex = 15;
            label6.Text = "Total                       R$ 0.000,00";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.Controls.Add(btnAdicionar, 2, 1);
            tableLayoutPanel2.Controls.Add(txtQuantidade, 1, 1);
            tableLayoutPanel2.Controls.Add(cmbProdutos, 0, 1);
            tableLayoutPanel2.Controls.Add(label8, 1, 0);
            tableLayoutPanel2.Controls.Add(label9, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 196);
            tableLayoutPanel2.Margin = new Padding(3, 3, 3, 10);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel2.Size = new Size(974, 80);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(235, 235, 235);
            btnAdicionar.Dock = DockStyle.Fill;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = SystemColors.WindowText;
            btnAdicionar.Location = new Point(867, 44);
            btnAdicionar.Margin = new Padding(15, 3, 25, 3);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(82, 33);
            btnAdicionar.TabIndex = 26;
            btnAdicionar.Text = "+ Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // txtQuantidade
            // 
            txtQuantidade.BackColor = Color.FromArgb(235, 235, 235);
            txtQuantidade.BorderStyle = BorderStyle.None;
            txtQuantidade.Dock = DockStyle.Top;
            txtQuantidade.Font = new Font("Segoe UI Semilight", 12F);
            txtQuantidade.Location = new Point(794, 46);
            txtQuantidade.Margin = new Padding(15, 5, 15, 3);
            txtQuantidade.Multiline = true;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(43, 29);
            txtQuantidade.TabIndex = 24;
            txtQuantidade.Text = " 1";
            // 
            // cmbProdutos
            // 
            cmbProdutos.BackColor = Color.FromArgb(235, 235, 235);
            cmbProdutos.DisplayMember = "Text";
            cmbProdutos.Dock = DockStyle.Fill;
            cmbProdutos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProdutos.FlatStyle = FlatStyle.Flat;
            cmbProdutos.Font = new Font("Segoe UI Semilight", 12F);
            cmbProdutos.FormattingEnabled = true;
            cmbProdutos.Location = new Point(25, 46);
            cmbProdutos.Margin = new Padding(25, 5, 15, 3);
            cmbProdutos.Name = "cmbProdutos";
            cmbProdutos.Size = new Size(739, 29);
            cmbProdutos.TabIndex = 22;
            cmbProdutos.ValueMember = "Value";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Bottom;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(782, 4);
            label8.Name = "label8";
            label8.Padding = new Padding(10, 20, 0, 0);
            label8.Size = new Size(67, 37);
            label8.TabIndex = 9;
            label8.Text = "Qtde";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Bottom;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(3, 4);
            label9.Name = "label9";
            label9.Padding = new Padding(20, 20, 0, 0);
            label9.Size = new Size(773, 37);
            label9.TabIndex = 0;
            label9.Text = "Produto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(0, 159);
            label5.Name = "label5";
            label5.Padding = new Padding(20, 20, 0, 0);
            label5.Size = new Size(139, 37);
            label5.TabIndex = 9;
            label5.Text = "Adicionar Produto";
            // 
            // mcCalendarioExibir
            // 
            mcCalendarioExibir.Location = new Point(495, -69);
            mcCalendarioExibir.Name = "mcCalendarioExibir";
            mcCalendarioExibir.TabIndex = 8;
            mcCalendarioExibir.Visible = false;
            mcCalendarioExibir.DateSelected += mcCalendarioExibir_DateSelected;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpar.BackColor = Color.WhiteSmoke;
            btnLimpar.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Location = new Point(1388, 264);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 34);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarProduto
            // 
            btnCadastrarProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCadastrarProduto.BackColor = Color.Gray;
            btnCadastrarProduto.FlatAppearance.BorderSize = 0;
            btnCadastrarProduto.FlatStyle = FlatStyle.Flat;
            btnCadastrarProduto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarProduto.ForeColor = Color.White;
            btnCadastrarProduto.Location = new Point(1469, 262);
            btnCadastrarProduto.Name = "btnCadastrarProduto";
            btnCadastrarProduto.Size = new Size(180, 34);
            btnCadastrarProduto.TabIndex = 5;
            btnCadastrarProduto.Text = "+ Cadastrar Produto";
            btnCadastrarProduto.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.00145F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9989624F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0014515F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9981327F));
            tableLayoutPanel1.Controls.Add(cmbCliente, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 3, 0);
            tableLayoutPanel1.Controls.Add(txtCodigo, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(cmbStatus, 3, 1);
            tableLayoutPanel1.Controls.Add(panel1, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.Size = new Size(974, 95);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // cmbCliente
            // 
            cmbCliente.BackColor = Color.FromArgb(235, 235, 235);
            cmbCliente.DisplayMember = "Text";
            cmbCliente.Dock = DockStyle.Fill;
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.FlatStyle = FlatStyle.Flat;
            cmbCliente.Font = new Font("Segoe UI Semilight", 12F);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(258, 61);
            cmbCliente.Margin = new Padding(15, 5, 15, 3);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(213, 29);
            cmbCliente.TabIndex = 18;
            cmbCliente.ValueMember = "Value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI Semilight", 12F);
            label4.Location = new Point(732, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 35, 0, 0);
            label4.Size = new Size(239, 56);
            label4.TabIndex = 16;
            label4.Text = "Status";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(235, 235, 235);
            txtCodigo.BorderStyle = BorderStyle.None;
            txtCodigo.Dock = DockStyle.Top;
            txtCodigo.Font = new Font("Segoe UI Semilight", 12F);
            txtCodigo.Location = new Point(25, 61);
            txtCodigo.Margin = new Padding(25, 5, 15, 3);
            txtCodigo.Multiline = true;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(203, 29);
            txtCodigo.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI Semilight", 12F);
            label3.Location = new Point(489, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 35, 0, 0);
            label3.Size = new Size(237, 56);
            label3.TabIndex = 10;
            label3.Text = "Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI Semilight", 12F);
            label2.Location = new Point(246, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 35, 0, 0);
            label2.Size = new Size(237, 56);
            label2.TabIndex = 9;
            label2.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI Semilight", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 35, 0, 0);
            label1.Size = new Size(237, 56);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.FromArgb(235, 235, 235);
            cmbStatus.DisplayMember = "Text";
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.Font = new Font("Segoe UI Semilight", 12F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(744, 61);
            cmbStatus.Margin = new Padding(15, 5, 25, 3);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(205, 29);
            cmbStatus.TabIndex = 20;
            cmbStatus.ValueMember = "Value";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 235, 235);
            panel1.Controls.Add(picCalendario);
            panel1.Controls.Add(txtData);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(501, 61);
            panel1.Margin = new Padding(15, 5, 15, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 29);
            panel1.TabIndex = 21;
            // 
            // picCalendario
            // 
            picCalendario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCalendario.Cursor = Cursors.Hand;
            picCalendario.Image = (Image)resources.GetObject("picCalendario.Image");
            picCalendario.Location = new Point(171, 7);
            picCalendario.Name = "picCalendario";
            picCalendario.Size = new Size(16, 16);
            picCalendario.SizeMode = PictureBoxSizeMode.Zoom;
            picCalendario.TabIndex = 7;
            picCalendario.TabStop = false;
            picCalendario.Click += picCalendario_Click;
            // 
            // txtData
            // 
            txtData.BackColor = Color.FromArgb(235, 235, 235);
            txtData.BorderStyle = BorderStyle.None;
            txtData.Dock = DockStyle.Bottom;
            txtData.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtData.Location = new Point(0, 7);
            txtData.Margin = new Padding(0);
            txtData.Mask = "  00/00/0000";
            txtData.Name = "txtData";
            txtData.Size = new Size(213, 22);
            txtData.TabIndex = 24;
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
            lblDescricao.Size = new Size(330, 21);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = "Preencha os campos e adicione os produtos";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(20, 20, 0, 0);
            lblTitulo.Size = new Size(124, 43);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Nova Venda";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CadastroVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContainer);
            Name = "CadastroVendas";
            Size = new Size(974, 506);
            Load += CadastroVendas_Load;
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            pnlBottom.ResumeLayout(false);
            tblProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCalendario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Button btnCadastrarProduto;
        private Label lblDescricao;
        private Label lblTitulo;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtCodigo;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private ComboBox cmbCliente;
        private ComboBox cmbStatus;
        private Panel panel1;
        private MaskedTextBox txtData;
        private PictureBox picCalendario;
        private MonthCalendar mcCalendarioExibir;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label8;
        private Label label9;
        private ComboBox cmbProdutos;
        private TextBox txtQuantidade;
        private Button btnAdicionar;
        private TableLayoutPanel tblProdutos;
        public DataGridView dgvDados;
        private Label label6;
        private Panel pnlBottom;
        private Button btnLimpar;
        private Button btnLimpar1;
        private Button btnRegistrarVenda;
    }
}
