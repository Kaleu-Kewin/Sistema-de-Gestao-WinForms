namespace Dashboard.Forms
{
    partial class FrmConfiguracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracoes));
            pnlTop = new Panel();
            tlpCards = new TableLayoutPanel();
            cmEmpresa = new Dashboard.UI.UserControls.CardModulo();
            cmAparencia = new Dashboard.UI.UserControls.CardModulo();
            cmNotificacao = new Dashboard.UI.UserControls.CardModulo();
            cmSeguranca = new Dashboard.UI.UserControls.CardModulo();
            btnMinimizar = new Button();
            btnFechar = new Button();
            label2 = new Label();
            lblTitulo = new Label();
            imgIcons = new ImageList(components);
            tlpButtons = new TableLayoutPanel();
            btnSeguranca = new Button();
            btnNotificacoes = new Button();
            btnAparencia = new Button();
            btnEmpresa = new Button();
            tlpFormulario = new TableLayoutPanel();
            pnlTop.SuspendLayout();
            tlpCards.SuspendLayout();
            tlpButtons.SuspendLayout();
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
            pnlTop.Size = new Size(1263, 218);
            pnlTop.TabIndex = 6;
            // 
            // tlpCards
            // 
            tlpCards.ColumnCount = 4;
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.Controls.Add(cmEmpresa, 0, 0);
            tlpCards.Controls.Add(cmAparencia, 1, 0);
            tlpCards.Controls.Add(cmNotificacao, 2, 0);
            tlpCards.Controls.Add(cmSeguranca, 3, 0);
            tlpCards.Dock = DockStyle.Fill;
            tlpCards.Location = new Point(0, 111);
            tlpCards.Name = "tlpCards";
            tlpCards.RowCount = 1;
            tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCards.Size = new Size(1263, 107);
            tlpCards.TabIndex = 7;
            // 
            // cmEmpresa
            // 
            cmEmpresa.Dock = DockStyle.Fill;
            cmEmpresa.Location = new Point(35, 1);
            cmEmpresa.Margin = new Padding(35, 1, 10, 0);
            cmEmpresa.MaximumSize = new Size(0, 100);
            cmEmpresa.MinimumSize = new Size(260, 100);
            cmEmpresa.Name = "cmEmpresa";
            cmEmpresa.Size = new Size(270, 100);
            cmEmpresa.TabIndex = 5;
            // 
            // cmAparencia
            // 
            cmAparencia.Dock = DockStyle.Fill;
            cmAparencia.Location = new Point(325, 1);
            cmAparencia.Margin = new Padding(10, 1, 10, 0);
            cmAparencia.MaximumSize = new Size(0, 100);
            cmAparencia.MinimumSize = new Size(260, 100);
            cmAparencia.Name = "cmAparencia";
            cmAparencia.Size = new Size(295, 100);
            cmAparencia.TabIndex = 6;
            // 
            // cmNotificacao
            // 
            cmNotificacao.Dock = DockStyle.Fill;
            cmNotificacao.Location = new Point(640, 1);
            cmNotificacao.Margin = new Padding(10, 1, 10, 0);
            cmNotificacao.MaximumSize = new Size(0, 100);
            cmNotificacao.MinimumSize = new Size(260, 100);
            cmNotificacao.Name = "cmNotificacao";
            cmNotificacao.Size = new Size(295, 100);
            cmNotificacao.TabIndex = 7;
            // 
            // cmSeguranca
            // 
            cmSeguranca.Dock = DockStyle.Fill;
            cmSeguranca.Location = new Point(955, 1);
            cmSeguranca.Margin = new Padding(10, 1, 35, 0);
            cmSeguranca.MaximumSize = new Size(0, 100);
            cmSeguranca.MinimumSize = new Size(260, 100);
            cmSeguranca.Name = "cmSeguranca";
            cmSeguranca.Size = new Size(273, 100);
            cmSeguranca.TabIndex = 8;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            btnMinimizar.Location = new Point(4002, -3);
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
            btnFechar.Location = new Point(4049, -1);
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
            label2.Size = new Size(374, 49);
            label2.TabIndex = 1;
            label2.Text = "Personalize e ajuste as configurações do sistema";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(30, 30, 0, 0);
            lblTitulo.Size = new Size(209, 62);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Configurações";
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
            imgIcons.Images.SetKeyName(10, "company_3.png");
            imgIcons.Images.SetKeyName(11, "company_2.png");
            imgIcons.Images.SetKeyName(12, "company.png");
            imgIcons.Images.SetKeyName(13, "security.png");
            imgIcons.Images.SetKeyName(14, "notification_2.png");
            imgIcons.Images.SetKeyName(15, "notification.png");
            imgIcons.Images.SetKeyName(16, "palette.png");
            imgIcons.Images.SetKeyName(17, "building.png");
            // 
            // tlpButtons
            // 
            tlpButtons.ColumnCount = 4;
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtons.Controls.Add(btnSeguranca, 3, 0);
            tlpButtons.Controls.Add(btnNotificacoes, 2, 0);
            tlpButtons.Controls.Add(btnAparencia, 1, 0);
            tlpButtons.Controls.Add(btnEmpresa, 0, 0);
            tlpButtons.Dock = DockStyle.Top;
            tlpButtons.Location = new Point(0, 218);
            tlpButtons.Name = "tlpButtons";
            tlpButtons.RowCount = 1;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpButtons.Size = new Size(1263, 69);
            tlpButtons.TabIndex = 7;
            // 
            // btnSeguranca
            // 
            btnSeguranca.BackColor = Color.White;
            btnSeguranca.Cursor = Cursors.Hand;
            btnSeguranca.Dock = DockStyle.Fill;
            btnSeguranca.FlatAppearance.BorderColor = Color.Gainsboro;
            btnSeguranca.FlatAppearance.BorderSize = 0;
            btnSeguranca.FlatStyle = FlatStyle.Flat;
            btnSeguranca.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSeguranca.Location = new Point(955, 15);
            btnSeguranca.Margin = new Padding(10, 15, 35, 15);
            btnSeguranca.Name = "btnSeguranca";
            btnSeguranca.Size = new Size(273, 39);
            btnSeguranca.TabIndex = 3;
            btnSeguranca.Text = "Segurança";
            btnSeguranca.UseVisualStyleBackColor = false;
            btnSeguranca.Click += btnSeguranca_Click;
            // 
            // btnNotificacoes
            // 
            btnNotificacoes.BackColor = Color.White;
            btnNotificacoes.Cursor = Cursors.Hand;
            btnNotificacoes.Dock = DockStyle.Fill;
            btnNotificacoes.FlatAppearance.BorderColor = Color.Gainsboro;
            btnNotificacoes.FlatAppearance.BorderSize = 0;
            btnNotificacoes.FlatStyle = FlatStyle.Flat;
            btnNotificacoes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnNotificacoes.Location = new Point(640, 15);
            btnNotificacoes.Margin = new Padding(10, 15, 10, 15);
            btnNotificacoes.Name = "btnNotificacoes";
            btnNotificacoes.Size = new Size(295, 39);
            btnNotificacoes.TabIndex = 2;
            btnNotificacoes.Text = "Notificações";
            btnNotificacoes.UseVisualStyleBackColor = false;
            btnNotificacoes.Click += btnNotificacoes_Click;
            // 
            // btnAparencia
            // 
            btnAparencia.BackColor = Color.White;
            btnAparencia.Cursor = Cursors.Hand;
            btnAparencia.Dock = DockStyle.Fill;
            btnAparencia.FlatAppearance.BorderColor = Color.Gainsboro;
            btnAparencia.FlatAppearance.BorderSize = 0;
            btnAparencia.FlatStyle = FlatStyle.Flat;
            btnAparencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAparencia.Location = new Point(325, 15);
            btnAparencia.Margin = new Padding(10, 15, 10, 15);
            btnAparencia.Name = "btnAparencia";
            btnAparencia.Size = new Size(295, 39);
            btnAparencia.TabIndex = 1;
            btnAparencia.Text = "Aparência";
            btnAparencia.UseVisualStyleBackColor = false;
            btnAparencia.Click += btnAparencia_Click;
            // 
            // btnEmpresa
            // 
            btnEmpresa.BackColor = Color.White;
            btnEmpresa.Cursor = Cursors.Hand;
            btnEmpresa.Dock = DockStyle.Fill;
            btnEmpresa.FlatAppearance.BorderColor = Color.Gainsboro;
            btnEmpresa.FlatAppearance.BorderSize = 0;
            btnEmpresa.FlatStyle = FlatStyle.Flat;
            btnEmpresa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpresa.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpresa.ImageList = imgIcons;
            btnEmpresa.Location = new Point(35, 15);
            btnEmpresa.Margin = new Padding(35, 15, 10, 15);
            btnEmpresa.Name = "btnEmpresa";
            btnEmpresa.Size = new Size(270, 39);
            btnEmpresa.TabIndex = 0;
            btnEmpresa.Text = "Empresa";
            btnEmpresa.UseVisualStyleBackColor = false;
            btnEmpresa.Click += btnEmpresa_Click;
            // 
            // tlpFormulario
            // 
            tlpFormulario.BackColor = Color.WhiteSmoke;
            tlpFormulario.ColumnCount = 1;
            tlpFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpFormulario.Dock = DockStyle.Top;
            tlpFormulario.Location = new Point(0, 287);
            tlpFormulario.Name = "tlpFormulario";
            tlpFormulario.RowCount = 1;
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpFormulario.Size = new Size(1263, 407);
            tlpFormulario.TabIndex = 8;
            // 
            // FrmConfiguracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 694);
            Controls.Add(tlpFormulario);
            Controls.Add(tlpButtons);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConfiguracoes";
            Text = "FrmConfiguracoes";
            Load += FrmConfiguracoes_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            tlpCards.ResumeLayout(false);
            tlpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Button btnMinimizar;
        private Button btnFechar;
        private Label label2;
        private Label lblTitulo;
        private TableLayoutPanel tlpCards;
        private ImageList imgIcons;
        private UI.UserControls.CardModulo cmEmpresa;
        private UI.UserControls.CardModulo cmAparencia;
        private UI.UserControls.CardModulo cmNotificacao;
        private UI.UserControls.CardModulo cmSeguranca;
        private TableLayoutPanel tlpButtons;
        private Button btnEmpresa;
        private Button btnSeguranca;
        private Button btnNotificacoes;
        private Button btnAparencia;
        private TableLayoutPanel tlpFormulario;
    }
}