namespace Dashboard.Forms
{
    partial class FrmProdutos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            pnlTop = new Panel();
            tlpCards = new TableLayoutPanel();
            cbTotalProdutos = new CardBase();
            cbEstoqueTotal = new CardBase();
            cbValorEstoque = new CardBase();
            btnMinimizar = new Button();
            btnFechar = new Button();
            label2 = new Label();
            lblTitulo = new Label();
            imgIcons = new ImageList(components);
            tlpCadastro = new TableLayoutPanel();
            cpCadastro = new Dashboard.UserControls.CadastroProdutos();
            tlpListagem = new TableLayoutPanel();
            gbProdutos = new Dashboard.UserControls.GridBase();
            pnlTop.SuspendLayout();
            tlpCards.SuspendLayout();
            tlpCadastro.SuspendLayout();
            tlpListagem.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.Transparent;
            pnlTop.Controls.Add(tlpCards);
            pnlTop.Controls.Add(btnMinimizar);
            pnlTop.Controls.Add(btnFechar);
            pnlTop.Controls.Add(label2);
            pnlTop.Controls.Add(lblTitulo);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1150, 245);
            pnlTop.TabIndex = 5;
            // 
            // tlpCards
            // 
            tlpCards.ColumnCount = 3;
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpCards.Controls.Add(cbTotalProdutos, 0, 0);
            tlpCards.Controls.Add(cbEstoqueTotal, 1, 0);
            tlpCards.Controls.Add(cbValorEstoque, 2, 0);
            tlpCards.Dock = DockStyle.Fill;
            tlpCards.Location = new Point(0, 111);
            tlpCards.Name = "tlpCards";
            tlpCards.RowCount = 1;
            tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCards.Size = new Size(1150, 134);
            tlpCards.TabIndex = 5;
            // 
            // cbTotalProdutos
            // 
            cbTotalProdutos.BackColor = Color.White;
            cbTotalProdutos.Dock = DockStyle.Fill;
            cbTotalProdutos.Location = new Point(35, 1);
            cbTotalProdutos.Margin = new Padding(35, 1, 15, 0);
            cbTotalProdutos.MaximumSize = new Size(0, 130);
            cbTotalProdutos.MinimumSize = new Size(260, 130);
            cbTotalProdutos.Name = "cbTotalProdutos";
            cbTotalProdutos.Size = new Size(333, 130);
            cbTotalProdutos.TabIndex = 3;
            // 
            // cbEstoqueTotal
            // 
            cbEstoqueTotal.BackColor = Color.White;
            cbEstoqueTotal.Dock = DockStyle.Fill;
            cbEstoqueTotal.Location = new Point(393, 1);
            cbEstoqueTotal.Margin = new Padding(10, 1, 10, 0);
            cbEstoqueTotal.MaximumSize = new Size(0, 130);
            cbEstoqueTotal.MinimumSize = new Size(260, 130);
            cbEstoqueTotal.Name = "cbEstoqueTotal";
            cbEstoqueTotal.Size = new Size(363, 130);
            cbEstoqueTotal.TabIndex = 1;
            // 
            // cbValorEstoque
            // 
            cbValorEstoque.BackColor = Color.White;
            cbValorEstoque.Dock = DockStyle.Fill;
            cbValorEstoque.Location = new Point(781, 1);
            cbValorEstoque.Margin = new Padding(15, 1, 35, 0);
            cbValorEstoque.MaximumSize = new Size(0, 130);
            cbValorEstoque.MinimumSize = new Size(260, 130);
            cbValorEstoque.Name = "cbValorEstoque";
            cbValorEstoque.Size = new Size(334, 130);
            cbValorEstoque.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            btnMinimizar.Location = new Point(2939, -3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(45, 27);
            btnMinimizar.TabIndex = 4;
            btnMinimizar.Text = "-";
            btnMinimizar.TextAlign = ContentAlignment.TopCenter;
            btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            btnFechar.Location = new Point(2986, -1);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(45, 25);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "X";
            btnFechar.TextAlign = ContentAlignment.BottomCenter;
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semilight", 12F);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(0, 62);
            label2.Name = "label2";
            label2.Padding = new Padding(33, 3, 0, 25);
            label2.Size = new Size(309, 49);
            label2.TabIndex = 1;
            label2.Text = "Cadastro e gerenciamento de produtos";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(30, 30, 0, 0);
            lblTitulo.Size = new Size(149, 62);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Produtos";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // imgIcons
            // 
            imgIcons.ColorDepth = ColorDepth.Depth32Bit;
            imgIcons.ImageStream = (ImageListStreamer)resources.GetObject("imgIcons.ImageStream");
            imgIcons.TransparentColor = Color.Transparent;
            imgIcons.Images.SetKeyName(0, "config.png");
            imgIcons.Images.SetKeyName(1, "custommers.png");
            imgIcons.Images.SetKeyName(2, "dashboard.png");
            imgIcons.Images.SetKeyName(3, "products.png");
            imgIcons.Images.SetKeyName(4, "products_2.png");
            imgIcons.Images.SetKeyName(5, "sales.png");
            imgIcons.Images.SetKeyName(6, "users.png");
            imgIcons.Images.SetKeyName(7, "logout.png");
            imgIcons.Images.SetKeyName(8, "logout_red.png");
            imgIcons.Images.SetKeyName(9, "graphs.png");
            // 
            // tlpCadastro
            // 
            tlpCadastro.ColumnCount = 1;
            tlpCadastro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCadastro.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpCadastro.Controls.Add(cpCadastro, 0, 0);
            tlpCadastro.Dock = DockStyle.Top;
            tlpCadastro.Location = new Point(0, 245);
            tlpCadastro.Name = "tlpCadastro";
            tlpCadastro.RowCount = 1;
            tlpCadastro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCadastro.Size = new Size(1150, 364);
            tlpCadastro.TabIndex = 6;
            // 
            // cpCadastro
            // 
            cpCadastro.BackColor = Color.White;
            cpCadastro.Dock = DockStyle.Fill;
            cpCadastro.Location = new Point(35, 25);
            cpCadastro.Margin = new Padding(35, 25, 35, 1);
            cpCadastro.Name = "cpCadastro";
            cpCadastro.Size = new Size(1080, 338);
            cpCadastro.TabIndex = 0;
            // 
            // tlpListagem
            // 
            tlpListagem.ColumnCount = 1;
            tlpListagem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpListagem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpListagem.Controls.Add(gbProdutos, 0, 0);
            tlpListagem.Dock = DockStyle.Top;
            tlpListagem.Location = new Point(0, 609);
            tlpListagem.Name = "tlpListagem";
            tlpListagem.RowCount = 1;
            tlpListagem.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpListagem.Size = new Size(1150, 364);
            tlpListagem.TabIndex = 7;
            // 
            // gbProdutos
            // 
            gbProdutos.BackColor = Color.Transparent;
            gbProdutos.Dock = DockStyle.Fill;
            gbProdutos.Location = new Point(35, 25);
            gbProdutos.Margin = new Padding(35, 25, 35, 1);
            gbProdutos.Name = "gbProdutos";
            gbProdutos.Size = new Size(1080, 338);
            gbProdutos.TabIndex = 0;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1150, 1000);
            Controls.Add(tlpListagem);
            Controls.Add(tlpCadastro);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "FrmProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProdutos";
            Load += FrmProdutos_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            tlpCards.ResumeLayout(false);
            tlpCadastro.ResumeLayout(false);
            tlpListagem.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Button btnMinimizar;
        private Button btnFechar;
        private Label label2;
        private Label lblTitulo;
        private ImageList imgIcons;
        private TableLayoutPanel tlpCadastro;
        private UserControls.CadastroProdutos cpCadastro;
        private TableLayoutPanel tlpListagem;
        private UserControls.GridBase lpListagem;
        private UserControls.GridBase gbProdutos;
        private TableLayoutPanel tlpCards;
        private CardBase cbTotalProdutos;
        private CardBase cbEstoqueTotal;
        private CardBase cbValorEstoque;
    }
}