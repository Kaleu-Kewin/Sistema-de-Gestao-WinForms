namespace Dashboard.Forms
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            pnlTop = new Panel();
            tlpCards = new TableLayoutPanel();
            cbAcessoCompleto = new CardBase();
            cbCadastrados = new CardBase();
            cbComAcesso = new CardBase();
            cbSemAcesso = new CardBase();
            btnMinimizar = new Button();
            btnFechar = new Button();
            label2 = new Label();
            lblTitulo = new Label();
            imgIcons = new ImageList(components);
            tlpCadastro = new TableLayoutPanel();
            cadastroUsuario1 = new Dashboard.UserControls.CadastroUsuario();
            tlpListagem = new TableLayoutPanel();
            gbUsuarios = new Dashboard.UserControls.GridBase();
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
            pnlTop.Size = new Size(1200, 245);
            pnlTop.TabIndex = 8;
            // 
            // tlpCards
            // 
            tlpCards.ColumnCount = 4;
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.Controls.Add(cbAcessoCompleto, 3, 0);
            tlpCards.Controls.Add(cbCadastrados, 0, 0);
            tlpCards.Controls.Add(cbComAcesso, 1, 0);
            tlpCards.Controls.Add(cbSemAcesso, 2, 0);
            tlpCards.Dock = DockStyle.Fill;
            tlpCards.Location = new Point(0, 111);
            tlpCards.Name = "tlpCards";
            tlpCards.RowCount = 1;
            tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCards.Size = new Size(1200, 134);
            tlpCards.TabIndex = 6;
            // 
            // cbAcessoCompleto
            // 
            cbAcessoCompleto.BackColor = Color.White;
            cbAcessoCompleto.Dock = DockStyle.Fill;
            cbAcessoCompleto.Location = new Point(915, 1);
            cbAcessoCompleto.Margin = new Padding(15, 1, 35, 0);
            cbAcessoCompleto.MaximumSize = new Size(0, 130);
            cbAcessoCompleto.MinimumSize = new Size(260, 130);
            cbAcessoCompleto.Name = "cbAcessoCompleto";
            cbAcessoCompleto.Size = new Size(260, 130);
            cbAcessoCompleto.TabIndex = 4;
            // 
            // cbCadastrados
            // 
            cbCadastrados.BackColor = Color.White;
            cbCadastrados.Dock = DockStyle.Fill;
            cbCadastrados.Location = new Point(35, 1);
            cbCadastrados.Margin = new Padding(35, 1, 15, 0);
            cbCadastrados.MaximumSize = new Size(0, 130);
            cbCadastrados.MinimumSize = new Size(260, 130);
            cbCadastrados.Name = "cbCadastrados";
            cbCadastrados.Size = new Size(260, 130);
            cbCadastrados.TabIndex = 3;
            // 
            // cbComAcesso
            // 
            cbComAcesso.BackColor = Color.White;
            cbComAcesso.Dock = DockStyle.Fill;
            cbComAcesso.Location = new Point(315, 1);
            cbComAcesso.Margin = new Padding(15, 1, 15, 0);
            cbComAcesso.MaximumSize = new Size(0, 130);
            cbComAcesso.MinimumSize = new Size(260, 130);
            cbComAcesso.Name = "cbComAcesso";
            cbComAcesso.Size = new Size(270, 130);
            cbComAcesso.TabIndex = 1;
            // 
            // cbSemAcesso
            // 
            cbSemAcesso.BackColor = Color.White;
            cbSemAcesso.Dock = DockStyle.Fill;
            cbSemAcesso.Location = new Point(615, 1);
            cbSemAcesso.Margin = new Padding(15, 1, 15, 0);
            cbSemAcesso.MaximumSize = new Size(0, 130);
            cbSemAcesso.MinimumSize = new Size(260, 130);
            cbSemAcesso.Name = "cbSemAcesso";
            cbSemAcesso.Size = new Size(270, 130);
            cbSemAcesso.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            btnMinimizar.Location = new Point(5826, -3);
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
            btnFechar.Location = new Point(5873, -1);
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
            label2.Size = new Size(364, 49);
            label2.TabIndex = 1;
            label2.Text = "Gerencie usuários e suas permissões de acesso";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(30, 30, 0, 0);
            lblTitulo.Size = new Size(143, 62);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Usuários";
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
            tlpCadastro.Controls.Add(cadastroUsuario1, 0, 0);
            tlpCadastro.Dock = DockStyle.Top;
            tlpCadastro.Location = new Point(0, 245);
            tlpCadastro.Name = "tlpCadastro";
            tlpCadastro.RowCount = 1;
            tlpCadastro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCadastro.Size = new Size(1200, 425);
            tlpCadastro.TabIndex = 9;
            // 
            // cadastroUsuario1
            // 
            cadastroUsuario1.Dock = DockStyle.Fill;
            cadastroUsuario1.Location = new Point(35, 25);
            cadastroUsuario1.Margin = new Padding(35, 25, 35, 1);
            cadastroUsuario1.Name = "cadastroUsuario1";
            cadastroUsuario1.Size = new Size(1130, 399);
            cadastroUsuario1.TabIndex = 0;
            // 
            // tlpListagem
            // 
            tlpListagem.ColumnCount = 1;
            tlpListagem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpListagem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpListagem.Controls.Add(gbUsuarios, 0, 0);
            tlpListagem.Dock = DockStyle.Top;
            tlpListagem.Location = new Point(0, 670);
            tlpListagem.Name = "tlpListagem";
            tlpListagem.RowCount = 1;
            tlpListagem.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpListagem.Size = new Size(1200, 364);
            tlpListagem.TabIndex = 10;
            // 
            // gbUsuarios
            // 
            gbUsuarios.BackColor = Color.Transparent;
            gbUsuarios.Dock = DockStyle.Fill;
            gbUsuarios.Location = new Point(35, 25);
            gbUsuarios.Margin = new Padding(35, 25, 35, 25);
            gbUsuarios.Name = "gbUsuarios";
            gbUsuarios.Size = new Size(1130, 314);
            gbUsuarios.TabIndex = 0;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1200, 1000);
            Controls.Add(tlpListagem);
            Controls.Add(tlpCadastro);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "FrmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmUsuarios_Load;
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
        private TableLayoutPanel tlpCards;
        private CardBase cbCadastrados;
        private CardBase cbComAcesso;
        private CardBase cbSemAcesso;
        private CardBase cbAcessoCompleto;
        private ImageList imgIcons;
        private TableLayoutPanel tlpCadastro;
        private UserControls.CadastroUsuario cadastroUsuario1;
        private TableLayoutPanel tlpListagem;
        private UserControls.GridBase gbUsuarios;
    }
}