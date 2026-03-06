namespace Dashboard.Forms
{
    partial class FrmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendas));
            pnlTop = new Panel();
            tlpCards = new TableLayoutPanel();
            cbTotalVendas = new CardBase();
            cbVendasAprovadas = new CardBase();
            cbVendasPendentes = new CardBase();
            btnMinimizar = new Button();
            btnFechar = new Button();
            label2 = new Label();
            lblTitulo = new Label();
            imgIcons = new ImageList(components);
            tlpCadastro = new TableLayoutPanel();
            cvCadastroVendas = new Dashboard.Controls.CadastroVendas();
            tlpListagem = new TableLayoutPanel();
            gbVendas = new Dashboard.Controls.GridBase();
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
            pnlTop.Size = new Size(1137, 245);
            pnlTop.TabIndex = 7;
            // 
            // tlpCards
            // 
            tlpCards.ColumnCount = 3;
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpCards.Controls.Add(cbTotalVendas, 0, 0);
            tlpCards.Controls.Add(cbVendasAprovadas, 1, 0);
            tlpCards.Controls.Add(cbVendasPendentes, 2, 0);
            tlpCards.Dock = DockStyle.Fill;
            tlpCards.Location = new Point(0, 111);
            tlpCards.Name = "tlpCards";
            tlpCards.RowCount = 1;
            tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCards.Size = new Size(1137, 134);
            tlpCards.TabIndex = 5;
            // 
            // cbTotalVendas
            // 
            cbTotalVendas.BackColor = Color.White;
            cbTotalVendas.Dock = DockStyle.Fill;
            cbTotalVendas.Location = new Point(35, 1);
            cbTotalVendas.Margin = new Padding(35, 1, 15, 0);
            cbTotalVendas.MaximumSize = new Size(0, 130);
            cbTotalVendas.MinimumSize = new Size(260, 130);
            cbTotalVendas.Name = "cbTotalVendas";
            cbTotalVendas.Size = new Size(329, 130);
            cbTotalVendas.TabIndex = 3;
            // 
            // cbVendasAprovadas
            // 
            cbVendasAprovadas.BackColor = Color.White;
            cbVendasAprovadas.Dock = DockStyle.Fill;
            cbVendasAprovadas.Location = new Point(389, 1);
            cbVendasAprovadas.Margin = new Padding(10, 1, 10, 0);
            cbVendasAprovadas.MaximumSize = new Size(0, 130);
            cbVendasAprovadas.MinimumSize = new Size(260, 130);
            cbVendasAprovadas.Name = "cbVendasAprovadas";
            cbVendasAprovadas.Size = new Size(359, 130);
            cbVendasAprovadas.TabIndex = 1;
            // 
            // cbVendasPendentes
            // 
            cbVendasPendentes.BackColor = Color.White;
            cbVendasPendentes.Dock = DockStyle.Fill;
            cbVendasPendentes.Location = new Point(773, 1);
            cbVendasPendentes.Margin = new Padding(15, 1, 35, 0);
            cbVendasPendentes.MaximumSize = new Size(0, 130);
            cbVendasPendentes.MinimumSize = new Size(260, 130);
            cbVendasPendentes.Name = "cbVendasPendentes";
            cbVendasPendentes.Size = new Size(329, 130);
            cbVendasPendentes.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            btnMinimizar.Location = new Point(4826, -3);
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
            btnFechar.Location = new Point(4873, -1);
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
            label2.Size = new Size(326, 49);
            label2.TabIndex = 1;
            label2.Text = "Registros e acompanhamentos de vendas";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(30, 30, 0, 0);
            lblTitulo.Size = new Size(125, 62);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Vendas";
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
            imgIcons.Images.SetKeyName(10, "edit (1).png");
            imgIcons.Images.SetKeyName(11, "edit.png");
            imgIcons.Images.SetKeyName(12, "visible.png");
            imgIcons.Images.SetKeyName(13, "trash.png");
            // 
            // tlpCadastro
            // 
            tlpCadastro.ColumnCount = 1;
            tlpCadastro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCadastro.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpCadastro.Controls.Add(cvCadastroVendas, 0, 0);
            tlpCadastro.Dock = DockStyle.Top;
            tlpCadastro.Location = new Point(0, 245);
            tlpCadastro.Name = "tlpCadastro";
            tlpCadastro.RowCount = 1;
            tlpCadastro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCadastro.Size = new Size(1137, 558);
            tlpCadastro.TabIndex = 8;
            // 
            // cvCadastroVendas
            // 
            cvCadastroVendas.Dock = DockStyle.Fill;
            cvCadastroVendas.Location = new Point(35, 25);
            cvCadastroVendas.Margin = new Padding(35, 25, 35, 25);
            cvCadastroVendas.Name = "cvCadastroVendas";
            cvCadastroVendas.Size = new Size(1067, 508);
            cvCadastroVendas.TabIndex = 0;
            // 
            // tlpListagem
            // 
            tlpListagem.ColumnCount = 1;
            tlpListagem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpListagem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpListagem.Controls.Add(gbVendas, 0, 0);
            tlpListagem.Dock = DockStyle.Fill;
            tlpListagem.Location = new Point(0, 803);
            tlpListagem.Name = "tlpListagem";
            tlpListagem.RowCount = 1;
            tlpListagem.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpListagem.Size = new Size(1137, 258);
            tlpListagem.TabIndex = 9;
            // 
            // gbVendas
            // 
            gbVendas.BackColor = Color.Transparent;
            gbVendas.Dock = DockStyle.Fill;
            gbVendas.Location = new Point(35, 0);
            gbVendas.Margin = new Padding(35, 0, 35, 25);
            gbVendas.Name = "gbVendas";
            gbVendas.Size = new Size(1067, 233);
            gbVendas.TabIndex = 0;
            // 
            // FrmVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1137, 1061);
            Controls.Add(tlpListagem);
            Controls.Add(tlpCadastro);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "FrmVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVendas";
            Load += FrmVendas_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            tlpCards.ResumeLayout(false);
            tlpCadastro.ResumeLayout(false);
            tlpListagem.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private TableLayoutPanel tlpCards;
        private CardBase cbTotalVendas;
        private CardBase cbVendasAprovadas;
        private CardBase cbVendasPendentes;
        private Button btnMinimizar;
        private Button btnFechar;
        private Label label2;
        private Label lblTitulo;
        private ImageList imgIcons;
        private TableLayoutPanel tlpCadastro;
        private Controls.CadastroVendas cvCadastroVendas;
        private TableLayoutPanel tlpListagem;
        private Controls.GridBase gbVendas;
    }
}