namespace Dashboard
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pnlMenuLateral = new Panel();
            btnUsuarios = new Button();
            imgIcons = new ImageList(components);
            btnConfiguracoes = new Button();
            btnVendas = new Button();
            btnClientes = new Button();
            btnProdutos = new Button();
            btnDashboard = new Button();
            pnlParteBaixoMenu = new Panel();
            btnLogout = new Button();
            pnlTituloMenu = new Panel();
            lblTituloMenu = new Label();
            pnlContainer = new Panel();
            pnlMenuLateral.SuspendLayout();
            pnlParteBaixoMenu.SuspendLayout();
            pnlTituloMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            pnlMenuLateral.Controls.Add(btnUsuarios);
            pnlMenuLateral.Controls.Add(btnConfiguracoes);
            pnlMenuLateral.Controls.Add(btnVendas);
            pnlMenuLateral.Controls.Add(btnClientes);
            pnlMenuLateral.Controls.Add(btnProdutos);
            pnlMenuLateral.Controls.Add(btnDashboard);
            pnlMenuLateral.Controls.Add(pnlParteBaixoMenu);
            pnlMenuLateral.Controls.Add(pnlTituloMenu);
            pnlMenuLateral.Dock = DockStyle.Left;
            pnlMenuLateral.Location = new Point(0, 0);
            pnlMenuLateral.Name = "pnlMenuLateral";
            pnlMenuLateral.Size = new Size(250, 700);
            pnlMenuLateral.TabIndex = 2;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.ImageIndex = 6;
            btnUsuarios.ImageList = imgIcons;
            btnUsuarios.Location = new Point(12, 331);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(3);
            btnUsuarios.Size = new Size(193, 45);
            btnUsuarios.TabIndex = 7;
            btnUsuarios.Text = "   Usuários";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
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
            // btnConfiguracoes
            // 
            btnConfiguracoes.Cursor = Cursors.Hand;
            btnConfiguracoes.FlatAppearance.BorderSize = 0;
            btnConfiguracoes.FlatStyle = FlatStyle.Flat;
            btnConfiguracoes.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnConfiguracoes.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracoes.ImageIndex = 0;
            btnConfiguracoes.ImageList = imgIcons;
            btnConfiguracoes.Location = new Point(12, 280);
            btnConfiguracoes.Name = "btnConfiguracoes";
            btnConfiguracoes.Padding = new Padding(3);
            btnConfiguracoes.Size = new Size(193, 45);
            btnConfiguracoes.TabIndex = 6;
            btnConfiguracoes.Text = "   Configurações";
            btnConfiguracoes.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracoes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfiguracoes.UseVisualStyleBackColor = false;
            btnConfiguracoes.Click += btnConfiguracoes_Click;
            // 
            // btnVendas
            // 
            btnVendas.Cursor = Cursors.Hand;
            btnVendas.FlatAppearance.BorderSize = 0;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnVendas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVendas.ImageIndex = 5;
            btnVendas.ImageList = imgIcons;
            btnVendas.Location = new Point(12, 229);
            btnVendas.Name = "btnVendas";
            btnVendas.Padding = new Padding(3);
            btnVendas.Size = new Size(193, 45);
            btnVendas.TabIndex = 5;
            btnVendas.Text = "   Vendas";
            btnVendas.TextAlign = ContentAlignment.MiddleLeft;
            btnVendas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnClientes
            // 
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.ImageIndex = 1;
            btnClientes.ImageList = imgIcons;
            btnClientes.Location = new Point(12, 178);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(3);
            btnClientes.Size = new Size(193, 45);
            btnClientes.TabIndex = 4;
            btnClientes.Text = "   Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Cursor = Cursors.Hand;
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.ImageIndex = 4;
            btnProdutos.ImageList = imgIcons;
            btnProdutos.Location = new Point(12, 127);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Padding = new Padding(3);
            btnProdutos.Size = new Size(193, 45);
            btnProdutos.TabIndex = 3;
            btnProdutos.Text = "   Produtos";
            btnProdutos.TextAlign = ContentAlignment.MiddleLeft;
            btnProdutos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.WhiteSmoke;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.ImageIndex = 2;
            btnDashboard.ImageList = imgIcons;
            btnDashboard.Location = new Point(12, 76);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(3);
            btnDashboard.Size = new Size(193, 45);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "   Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlParteBaixoMenu
            // 
            pnlParteBaixoMenu.BackgroundImageLayout = ImageLayout.None;
            pnlParteBaixoMenu.Controls.Add(btnLogout);
            pnlParteBaixoMenu.Dock = DockStyle.Bottom;
            pnlParteBaixoMenu.Location = new Point(0, 630);
            pnlParteBaixoMenu.Name = "pnlParteBaixoMenu";
            pnlParteBaixoMenu.Padding = new Padding(3);
            pnlParteBaixoMenu.Size = new Size(250, 70);
            pnlParteBaixoMenu.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.ImageIndex = 7;
            btnLogout.ImageList = imgIcons;
            btnLogout.Location = new Point(12, 13);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(3);
            btnLogout.Size = new Size(193, 45);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "   Sair";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnExit_Click;
            btnLogout.MouseEnter += btnLogout_MouseEnter;
            btnLogout.MouseLeave += btnLogout_MouseLeave;
            // 
            // pnlTituloMenu
            // 
            pnlTituloMenu.BackgroundImageLayout = ImageLayout.None;
            pnlTituloMenu.Controls.Add(lblTituloMenu);
            pnlTituloMenu.Dock = DockStyle.Top;
            pnlTituloMenu.Location = new Point(0, 0);
            pnlTituloMenu.Name = "pnlTituloMenu";
            pnlTituloMenu.Padding = new Padding(3);
            pnlTituloMenu.Size = new Size(250, 70);
            pnlTituloMenu.TabIndex = 0;
            // 
            // lblTituloMenu
            // 
            lblTituloMenu.Dock = DockStyle.Fill;
            lblTituloMenu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloMenu.Location = new Point(3, 3);
            lblTituloMenu.Margin = new Padding(5);
            lblTituloMenu.Name = "lblTituloMenu";
            lblTituloMenu.Padding = new Padding(10, 0, 0, 0);
            lblTituloMenu.Size = new Size(244, 64);
            lblTituloMenu.TabIndex = 0;
            lblTituloMenu.Text = "Nome da empresa";
            lblTituloMenu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlContainer
            // 
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(250, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1100, 700);
            pnlContainer.TabIndex = 4;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1350, 700);
            Controls.Add(pnlContainer);
            Controls.Add(pnlMenuLateral);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(2, 3, 2, 3);
            MinimumSize = new Size(1350, 700);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Dashboard_Load;
            pnlMenuLateral.ResumeLayout(false);
            pnlParteBaixoMenu.ResumeLayout(false);
            pnlTituloMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlMenuLateral;
        private Panel pnlTituloMenu;
        private Label lblTituloMenu;
        private Panel pnlParteBaixoMenu;
        private Button btnLogout;
        private Panel pnlContainer;
        private Button btnDashboard;
        private Button btnProdutos;
        private Button btnClientes;
        private Button btnVendas;
        private Button btnConfiguracoes;
        private Button btnUsuarios;
        private ImageList imgIcons;
    }
}
