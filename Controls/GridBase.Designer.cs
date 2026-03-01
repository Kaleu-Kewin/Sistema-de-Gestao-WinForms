namespace Dashboard.Controls
{
    partial class GridBase
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
            pnlContainer = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvDados = new DataGridView();
            txtBuscar = new TextBox();
            btnLimpar = new Button();
            btnCadastrarProduto = new Button();
            lblDescricao = new Label();
            lblTitulo = new Label();
            pnlContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.White;
            pnlContainer.Controls.Add(tableLayoutPanel1);
            pnlContainer.Controls.Add(txtBuscar);
            pnlContainer.Controls.Add(btnLimpar);
            pnlContainer.Controls.Add(btnCadastrarProduto);
            pnlContainer.Controls.Add(lblDescricao);
            pnlContainer.Controls.Add(lblTitulo);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(900, 300);
            pnlContainer.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvDados, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 84);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(900, 216);
            tableLayoutPanel1.TabIndex = 14;
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
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
            dgvDados.Location = new Point(25, 1);
            dgvDados.Margin = new Padding(25, 1, 25, 1);
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
            dgvDados.Size = new Size(850, 214);
            dgvDados.TabIndex = 14;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscar.BackColor = Color.FromArgb(235, 235, 235);
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Font = new Font("Segoe UI Semilight", 12F);
            txtBuscar.Location = new Point(696, 26);
            txtBuscar.Margin = new Padding(15, 5, 15, 3);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = " Buscar...";
            txtBuscar.Size = new Size(179, 27);
            txtBuscar.TabIndex = 12;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpar.BackColor = Color.WhiteSmoke;
            btnLimpar.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Location = new Point(1314, 264);
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
            btnCadastrarProduto.Location = new Point(1395, 262);
            btnCadastrarProduto.Name = "btnCadastrarProduto";
            btnCadastrarProduto.Size = new Size(180, 34);
            btnCadastrarProduto.TabIndex = 5;
            btnCadastrarProduto.Text = "+ Cadastrar Produto";
            btnCadastrarProduto.UseVisualStyleBackColor = false;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Dock = DockStyle.Top;
            lblDescricao.Font = new Font("Segoe UI Semilight", 12F);
            lblDescricao.ForeColor = SystemColors.ControlDarkDark;
            lblDescricao.Location = new Point(0, 43);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Padding = new Padding(20, 0, 0, 20);
            lblDescricao.Size = new Size(96, 41);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = "Descrição";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(20, 20, 0, 0);
            lblTitulo.Size = new Size(73, 43);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Titulo";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GridBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlContainer);
            Name = "GridBase";
            Size = new Size(900, 300);
            Load += GridBase_Load;
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Button btnLimpar;
        private Button btnCadastrarProduto;
        private Label lblDescricao;
        private Label lblTitulo;
        private TextBox txtBuscar;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvDados;
    }
}
