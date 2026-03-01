namespace Dashboard.Forms
{
    partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            pnlContainer = new Panel();
            pnlTop = new Panel();
            btnMinimizar = new Button();
            btnFechar = new Button();
            tlpCards = new TableLayoutPanel();
            cbReceita = new CardBase();
            cbVendas = new CardBase();
            cbClientes = new CardBase();
            cbProdutos = new CardBase();
            label2 = new Label();
            label1 = new Label();
            imgIcons = new ImageList(components);
            pnlContainer.SuspendLayout();
            pnlTop.SuspendLayout();
            tlpCards.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.WhiteSmoke;
            pnlContainer.Controls.Add(pnlTop);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1150, 600);
            pnlContainer.TabIndex = 5;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.Transparent;
            pnlTop.Controls.Add(btnMinimizar);
            pnlTop.Controls.Add(btnFechar);
            pnlTop.Controls.Add(tlpCards);
            pnlTop.Controls.Add(label2);
            pnlTop.Controls.Add(label1);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1150, 245);
            pnlTop.TabIndex = 4;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            btnMinimizar.Location = new Point(1989, -3);
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
            btnFechar.Location = new Point(2036, -1);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(45, 25);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "X";
            btnFechar.TextAlign = ContentAlignment.BottomCenter;
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // tlpCards
            // 
            tlpCards.ColumnCount = 4;
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.Controls.Add(cbReceita, 3, 0);
            tlpCards.Controls.Add(cbVendas, 2, 0);
            tlpCards.Controls.Add(cbClientes, 1, 0);
            tlpCards.Controls.Add(cbProdutos, 0, 0);
            tlpCards.Dock = DockStyle.Fill;
            tlpCards.Location = new Point(0, 111);
            tlpCards.Name = "tlpCards";
            tlpCards.RowCount = 1;
            tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCards.Size = new Size(1150, 134);
            tlpCards.TabIndex = 2;
            // 
            // cbReceita
            // 
            cbReceita.AutoSize = true;
            cbReceita.BackColor = Color.White;
            cbReceita.Dock = DockStyle.Fill;
            cbReceita.Location = new Point(861, 3);
            cbReceita.Margin = new Padding(0, 3, 35, 3);
            cbReceita.MaximumSize = new Size(0, 130);
            cbReceita.MinimumSize = new Size(260, 130);
            cbReceita.Name = "cbReceita";
            cbReceita.Size = new Size(260, 130);
            cbReceita.TabIndex = 13;
            // 
            // cbVendas
            // 
            cbVendas.AutoSize = true;
            cbVendas.BackColor = Color.White;
            cbVendas.Dock = DockStyle.Fill;
            cbVendas.Location = new Point(589, 3);
            cbVendas.Margin = new Padding(15, 3, 20, 3);
            cbVendas.MaximumSize = new Size(0, 130);
            cbVendas.MinimumSize = new Size(260, 130);
            cbVendas.Name = "cbVendas";
            cbVendas.Size = new Size(260, 130);
            cbVendas.TabIndex = 12;
            // 
            // cbClientes
            // 
            cbClientes.AutoSize = true;
            cbClientes.BackColor = Color.White;
            cbClientes.Dock = DockStyle.Fill;
            cbClientes.Location = new Point(307, 3);
            cbClientes.Margin = new Padding(20, 3, 15, 3);
            cbClientes.MaximumSize = new Size(0, 130);
            cbClientes.MinimumSize = new Size(260, 130);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(260, 130);
            cbClientes.TabIndex = 11;
            // 
            // cbProdutos
            // 
            cbProdutos.AutoSize = true;
            cbProdutos.BackColor = Color.White;
            cbProdutos.Dock = DockStyle.Fill;
            cbProdutos.Location = new Point(35, 3);
            cbProdutos.Margin = new Padding(35, 3, 0, 3);
            cbProdutos.MaximumSize = new Size(0, 130);
            cbProdutos.MinimumSize = new Size(260, 130);
            cbProdutos.Name = "cbProdutos";
            cbProdutos.Size = new Size(260, 130);
            cbProdutos.TabIndex = 10;
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
            label2.Size = new Size(228, 49);
            label2.TabIndex = 1;
            label2.Text = "Visão geral do seu negócio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(30, 30, 0, 0);
            label1.Size = new Size(168, 62);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            label1.TextAlign = ContentAlignment.MiddleLeft;
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
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 600);
            Controls.Add(pnlContainer);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "FrmDashboard";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmDashboard_Load;
            pnlContainer.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            tlpCards.ResumeLayout(false);
            tlpCards.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Panel pnlTop;
        private Button btnMinimizar;
        private Button btnFechar;
        private TableLayoutPanel tlpCards;
        private CardBase cbReceita;
        private CardBase cbVendas;
        private CardBase cbClientes;
        private CardBase cbProdutos;
        private Label label2;
        private Label label1;
        private ImageList imgIcons;
    }
}