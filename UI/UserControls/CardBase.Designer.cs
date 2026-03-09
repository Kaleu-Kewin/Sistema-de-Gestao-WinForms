namespace Dashboard
{
    partial class CardBase
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardBase));
            pnlContainer = new Panel();
            pictureIcone = new PictureBox();
            lblEstatistica = new Label();
            lblDescricao = new Label();
            lblTitulo = new Label();
            imgIcon = new ImageList(components);
            pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureIcone).BeginInit();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.White;
            pnlContainer.Controls.Add(pictureIcone);
            pnlContainer.Controls.Add(lblEstatistica);
            pnlContainer.Controls.Add(lblDescricao);
            pnlContainer.Controls.Add(lblTitulo);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Margin = new Padding(10);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Padding = new Padding(1);
            pnlContainer.Size = new Size(260, 130);
            pnlContainer.TabIndex = 0;
            // 
            // pictureIcone
            // 
            pictureIcone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureIcone.Location = new Point(225, 20);
            pictureIcone.Name = "pictureIcone";
            pictureIcone.Size = new Size(16, 16);
            pictureIcone.TabIndex = 4;
            pictureIcone.TabStop = false;
            // 
            // lblEstatistica
            // 
            lblEstatistica.AutoSize = true;
            lblEstatistica.Dock = DockStyle.Top;
            lblEstatistica.Font = new Font("Segoe UI Semilight", 11F);
            lblEstatistica.ForeColor = Color.ForestGreen;
            lblEstatistica.Location = new Point(1, 84);
            lblEstatistica.Name = "lblEstatistica";
            lblEstatistica.Padding = new Padding(15, 2, 0, 0);
            lblEstatistica.Size = new Size(141, 22);
            lblEstatistica.TabIndex = 2;
            lblEstatistica.Text = "🡭 +10% esse mês";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Dock = DockStyle.Top;
            lblDescricao.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblDescricao.Location = new Point(1, 42);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Padding = new Padding(15, 10, 0, 0);
            lblDescricao.Size = new Size(143, 42);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "R$ 12.345";
            lblDescricao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI Semilight", 12F);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(1, 1);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(15, 20, 0, 0);
            lblTitulo.Size = new Size(64, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // imgIcon
            // 
            imgIcon.ColorDepth = ColorDepth.Depth32Bit;
            imgIcon.ImageStream = (ImageListStreamer)resources.GetObject("imgIcon.ImageStream");
            imgIcon.TransparentColor = Color.Transparent;
            imgIcon.Images.SetKeyName(0, "download.jpeg");
            // 
            // CardBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlContainer);
            MaximumSize = new Size(0, 130);
            MinimumSize = new Size(260, 130);
            Name = "CardBase";
            Size = new Size(260, 130);
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureIcone).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Label lblTitulo;
        private Label lblDescricao;
        private ImageList imgIcon;
        private PictureBox pictureIcone;
        private Label lblEstatistica;
    }
}
