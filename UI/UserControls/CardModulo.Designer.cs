namespace Dashboard.UI.UserControls
{
    partial class CardModulo
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
            pictureIcone = new PictureBox();
            lblDescricao = new Label();
            lblTitulo = new Label();
            pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureIcone).BeginInit();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.White;
            pnlContainer.Controls.Add(pictureIcone);
            pnlContainer.Controls.Add(lblDescricao);
            pnlContainer.Controls.Add(lblTitulo);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Margin = new Padding(10);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Padding = new Padding(1);
            pnlContainer.Size = new Size(260, 100);
            pnlContainer.TabIndex = 1;
            // 
            // pictureIcone
            // 
            pictureIcone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureIcone.Location = new Point(185, 29);
            pictureIcone.Name = "pictureIcone";
            pictureIcone.Size = new Size(48, 48);
            pictureIcone.SizeMode = PictureBoxSizeMode.Zoom;
            pictureIcone.TabIndex = 4;
            pictureIcone.TabStop = false;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Dock = DockStyle.Top;
            lblDescricao.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.ForeColor = SystemColors.ControlDarkDark;
            lblDescricao.Location = new Point(1, 54);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Padding = new Padding(18, 0, 0, 0);
            lblDescricao.Size = new Size(94, 21);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Descrição";
            lblDescricao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(1, 1);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(15, 25, 0, 0);
            lblTitulo.Size = new Size(83, 53);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // CardModulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContainer);
            MaximumSize = new Size(0, 100);
            MinimumSize = new Size(260, 100);
            Name = "CardModulo";
            Size = new Size(260, 100);
            Load += CardModulo_Load;
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureIcone).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private PictureBox pictureIcone;
        private Label lblDescricao;
        private Label lblTitulo;
    }
}
