using Dashboard.UI.Controls;

namespace Dashboard.UserControls
{
    partial class CadastroUsuario
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
            tableLayoutPanel2 = new TableLayoutPanel();
            pnlConfiguracoes = new Panel();
            toggleSwitch6 = new ToggleSwitch();
            label13 = new Label();
            pnlUsuarios = new Panel();
            toggleSwitch5 = new ToggleSwitch();
            label12 = new Label();
            pnlVendas = new Panel();
            toggleSwitch4 = new ToggleSwitch();
            label11 = new Label();
            pnlClientes = new Panel();
            toggleSwitch3 = new ToggleSwitch();
            label10 = new Label();
            pnlProdutos = new Panel();
            toggleSwitch2 = new ToggleSwitch();
            label9 = new Label();
            pnlDashboard = new Panel();
            toggleSwitch1 = new ToggleSwitch();
            label6 = new Label();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            cmbStatus = new ComboBox();
            txtConfirmarSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            cmbPerfil = new ComboBox();
            txtEmail = new TextBox();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtSenha = new TextBox();
            pnlBottom = new Panel();
            btnLimparCampos = new Button();
            btnCadastrarUsuario = new Button();
            btnLimpar1 = new Button();
            btnRegistrarVenda = new Button();
            btnLimpar = new Button();
            btnCadastrarProduto = new Button();
            lblDescricao = new Label();
            lblTitulo = new Label();
            pnlContainer.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pnlConfiguracoes.SuspendLayout();
            pnlUsuarios.SuspendLayout();
            pnlVendas.SuspendLayout();
            pnlClientes.SuspendLayout();
            pnlProdutos.SuspendLayout();
            pnlDashboard.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.White;
            pnlContainer.Controls.Add(tableLayoutPanel2);
            pnlContainer.Controls.Add(label5);
            pnlContainer.Controls.Add(tableLayoutPanel1);
            pnlContainer.Controls.Add(pnlBottom);
            pnlContainer.Controls.Add(btnLimpar);
            pnlContainer.Controls.Add(btnCadastrarProduto);
            pnlContainer.Controls.Add(lblDescricao);
            pnlContainer.Controls.Add(lblTitulo);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1135, 408);
            pnlContainer.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Controls.Add(pnlConfiguracoes, 5, 0);
            tableLayoutPanel2.Controls.Add(pnlUsuarios, 4, 0);
            tableLayoutPanel2.Controls.Add(pnlVendas, 3, 0);
            tableLayoutPanel2.Controls.Add(pnlClientes, 2, 0);
            tableLayoutPanel2.Controls.Add(pnlProdutos, 1, 0);
            tableLayoutPanel2.Controls.Add(pnlDashboard, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 274);
            tableLayoutPanel2.Margin = new Padding(3, 3, 3, 10);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1135, 80);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // pnlConfiguracoes
            // 
            pnlConfiguracoes.Controls.Add(toggleSwitch6);
            pnlConfiguracoes.Controls.Add(label13);
            pnlConfiguracoes.Dock = DockStyle.Fill;
            pnlConfiguracoes.Location = new Point(955, 20);
            pnlConfiguracoes.Margin = new Padding(10, 20, 25, 20);
            pnlConfiguracoes.Name = "pnlConfiguracoes";
            pnlConfiguracoes.Size = new Size(155, 40);
            pnlConfiguracoes.TabIndex = 24;
            // 
            // toggleSwitch6
            // 
            toggleSwitch6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toggleSwitch6.Location = new Point(100, 8);
            toggleSwitch6.Name = "toggleSwitch6";
            toggleSwitch6.Size = new Size(48, 25);
            toggleSwitch6.TabIndex = 21;
            toggleSwitch6.Text = "tsConfiguracoes";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(3, 9);
            label13.Margin = new Padding(0);
            label13.Name = "label13";
            label13.Size = new Size(109, 21);
            label13.TabIndex = 20;
            label13.Text = "Configurações";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlUsuarios
            // 
            pnlUsuarios.Controls.Add(toggleSwitch5);
            pnlUsuarios.Controls.Add(label12);
            pnlUsuarios.Dock = DockStyle.Fill;
            pnlUsuarios.Location = new Point(766, 20);
            pnlUsuarios.Margin = new Padding(10, 20, 10, 20);
            pnlUsuarios.Name = "pnlUsuarios";
            pnlUsuarios.Size = new Size(169, 40);
            pnlUsuarios.TabIndex = 23;
            // 
            // toggleSwitch5
            // 
            toggleSwitch5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toggleSwitch5.Location = new Point(114, 8);
            toggleSwitch5.Name = "toggleSwitch5";
            toggleSwitch5.Size = new Size(48, 25);
            toggleSwitch5.TabIndex = 21;
            toggleSwitch5.Text = "tsUsuarios";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 9);
            label12.Margin = new Padding(0);
            label12.Name = "label12";
            label12.Size = new Size(70, 21);
            label12.TabIndex = 20;
            label12.Text = "Usuários";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlVendas
            // 
            pnlVendas.Controls.Add(toggleSwitch4);
            pnlVendas.Controls.Add(label11);
            pnlVendas.Dock = DockStyle.Fill;
            pnlVendas.Location = new Point(577, 20);
            pnlVendas.Margin = new Padding(10, 20, 10, 20);
            pnlVendas.Name = "pnlVendas";
            pnlVendas.Size = new Size(169, 40);
            pnlVendas.TabIndex = 22;
            // 
            // toggleSwitch4
            // 
            toggleSwitch4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toggleSwitch4.Location = new Point(113, 8);
            toggleSwitch4.Name = "toggleSwitch4";
            toggleSwitch4.Size = new Size(48, 25);
            toggleSwitch4.TabIndex = 21;
            toggleSwitch4.Text = "tsVendas";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 9);
            label11.Margin = new Padding(0);
            label11.Name = "label11";
            label11.Size = new Size(60, 21);
            label11.TabIndex = 20;
            label11.Text = "Vendas";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlClientes
            // 
            pnlClientes.Controls.Add(toggleSwitch3);
            pnlClientes.Controls.Add(label10);
            pnlClientes.Dock = DockStyle.Fill;
            pnlClientes.Location = new Point(388, 20);
            pnlClientes.Margin = new Padding(10, 20, 10, 20);
            pnlClientes.Name = "pnlClientes";
            pnlClientes.Size = new Size(169, 40);
            pnlClientes.TabIndex = 21;
            // 
            // toggleSwitch3
            // 
            toggleSwitch3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toggleSwitch3.Location = new Point(114, 8);
            toggleSwitch3.Name = "toggleSwitch3";
            toggleSwitch3.Size = new Size(48, 25);
            toggleSwitch3.TabIndex = 21;
            toggleSwitch3.Text = "tsClientes";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 9);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(65, 21);
            label10.TabIndex = 20;
            label10.Text = "Clientes";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlProdutos
            // 
            pnlProdutos.Controls.Add(toggleSwitch2);
            pnlProdutos.Controls.Add(label9);
            pnlProdutos.Dock = DockStyle.Fill;
            pnlProdutos.Location = new Point(199, 20);
            pnlProdutos.Margin = new Padding(10, 20, 10, 20);
            pnlProdutos.Name = "pnlProdutos";
            pnlProdutos.Size = new Size(169, 40);
            pnlProdutos.TabIndex = 20;
            // 
            // toggleSwitch2
            // 
            toggleSwitch2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toggleSwitch2.Location = new Point(113, 8);
            toggleSwitch2.Name = "toggleSwitch2";
            toggleSwitch2.Size = new Size(48, 25);
            toggleSwitch2.TabIndex = 21;
            toggleSwitch2.Text = "tsProdutos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 9);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(72, 21);
            label9.TabIndex = 20;
            label9.Text = "Produtos";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(toggleSwitch1);
            pnlDashboard.Controls.Add(label6);
            pnlDashboard.Dock = DockStyle.Fill;
            pnlDashboard.Location = new Point(25, 20);
            pnlDashboard.Margin = new Padding(25, 20, 10, 20);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(154, 40);
            pnlDashboard.TabIndex = 19;
            // 
            // toggleSwitch1
            // 
            toggleSwitch1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toggleSwitch1.Location = new Point(97, 8);
            toggleSwitch1.Name = "toggleSwitch1";
            toggleSwitch1.Size = new Size(48, 25);
            toggleSwitch1.TabIndex = 21;
            toggleSwitch1.Text = "tsDashboard";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 9);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(85, 21);
            label6.TabIndex = 20;
            label6.Text = "Dashboard";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(0, 233);
            label5.Name = "label5";
            label5.Padding = new Padding(20, 20, 0, 0);
            label5.Size = new Size(190, 41);
            label5.TabIndex = 18;
            label5.Text = "Permissões de Acesso";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33444F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33112F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33444F));
            tableLayoutPanel1.Controls.Add(cmbStatus, 2, 3);
            tableLayoutPanel1.Controls.Add(txtConfirmarSenha, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 2, 2);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(txtNome, 0, 1);
            tableLayoutPanel1.Controls.Add(cmbPerfil, 2, 1);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label7, 1, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Controls.Add(txtSenha, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.Size = new Size(1135, 169);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.FromArgb(235, 235, 235);
            cmbStatus.Dock = DockStyle.Top;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.Font = new Font("Segoe UI Semilight", 12F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(771, 130);
            cmbStatus.Margin = new Padding(15, 5, 25, 3);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(339, 29);
            cmbStatus.TabIndex = 24;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.BackColor = Color.FromArgb(235, 235, 235);
            txtConfirmarSenha.BorderStyle = BorderStyle.None;
            txtConfirmarSenha.Dock = DockStyle.Top;
            txtConfirmarSenha.Font = new Font("Segoe UI Semilight", 12F);
            txtConfirmarSenha.Location = new Point(393, 130);
            txtConfirmarSenha.Margin = new Padding(15, 5, 15, 3);
            txtConfirmarSenha.Multiline = true;
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PlaceholderText = " Repita a senha";
            txtConfirmarSenha.Size = new Size(348, 29);
            txtConfirmarSenha.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI Semilight", 12F);
            label1.Location = new Point(759, 104);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 0, 0, 0);
            label1.Size = new Size(373, 21);
            label1.TabIndex = 20;
            label1.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI Semilight", 12F);
            label2.Location = new Point(381, 104);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 0, 0, 0);
            label2.Size = new Size(372, 21);
            label2.TabIndex = 19;
            label2.Text = "Confirmar senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI Semilight", 12F);
            label4.Location = new Point(3, 104);
            label4.Name = "label4";
            label4.Padding = new Padding(20, 0, 0, 0);
            label4.Size = new Size(372, 21);
            label4.TabIndex = 16;
            label4.Text = "Senha";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(235, 235, 235);
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Dock = DockStyle.Top;
            txtNome.Font = new Font("Segoe UI Semilight", 12F);
            txtNome.Location = new Point(25, 61);
            txtNome.Margin = new Padding(25, 5, 15, 3);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = " Nome do usuário";
            txtNome.Size = new Size(338, 27);
            txtNome.TabIndex = 15;
            // 
            // cmbPerfil
            // 
            cmbPerfil.BackColor = Color.FromArgb(235, 235, 235);
            cmbPerfil.Dock = DockStyle.Top;
            cmbPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPerfil.FlatStyle = FlatStyle.Flat;
            cmbPerfil.Font = new Font("Segoe UI Semilight", 12F);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Location = new Point(771, 61);
            cmbPerfil.Margin = new Padding(15, 5, 25, 3);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(339, 29);
            cmbPerfil.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(235, 235, 235);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Dock = DockStyle.Top;
            txtEmail.Font = new Font("Segoe UI Semilight", 12F);
            txtEmail.Location = new Point(393, 61);
            txtEmail.Margin = new Padding(15, 5, 15, 3);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " email@gmail.com";
            txtEmail.Size = new Size(348, 27);
            txtEmail.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI Semilight", 12F);
            label3.Location = new Point(759, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 35, 0, 0);
            label3.Size = new Size(373, 56);
            label3.TabIndex = 10;
            label3.Text = "Perfil";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Bottom;
            label7.Font = new Font("Segoe UI Semilight", 12F);
            label7.Location = new Point(381, 0);
            label7.Name = "label7";
            label7.Padding = new Padding(10, 35, 0, 0);
            label7.Size = new Size(372, 56);
            label7.TabIndex = 9;
            label7.Text = "E-mail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Bottom;
            label8.Font = new Font("Segoe UI Semilight", 12F);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Padding = new Padding(20, 35, 0, 0);
            label8.Size = new Size(372, 56);
            label8.TabIndex = 0;
            label8.Text = "Nome";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(235, 235, 235);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Dock = DockStyle.Top;
            txtSenha.Font = new Font("Segoe UI Semilight", 12F);
            txtSenha.Location = new Point(25, 130);
            txtSenha.Margin = new Padding(25, 5, 15, 3);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = " Mínimo 6 caracteres";
            txtSenha.Size = new Size(338, 29);
            txtSenha.TabIndex = 18;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(btnLimparCampos);
            pnlBottom.Controls.Add(btnCadastrarUsuario);
            pnlBottom.Controls.Add(btnLimpar1);
            pnlBottom.Controls.Add(btnRegistrarVenda);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 353);
            pnlBottom.Margin = new Padding(3, 10, 3, 3);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(0, 10, 0, 0);
            pnlBottom.Size = new Size(1135, 55);
            pnlBottom.TabIndex = 16;
            // 
            // btnLimparCampos
            // 
            btnLimparCampos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimparCampos.BackColor = Color.WhiteSmoke;
            btnLimparCampos.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnLimparCampos.FlatStyle = FlatStyle.Flat;
            btnLimparCampos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimparCampos.Location = new Point(849, 11);
            btnLimparCampos.Name = "btnLimparCampos";
            btnLimparCampos.Size = new Size(75, 34);
            btnLimparCampos.TabIndex = 14;
            btnLimparCampos.Text = "Limpar";
            btnLimparCampos.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarUsuario
            // 
            btnCadastrarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCadastrarUsuario.BackColor = Color.Gray;
            btnCadastrarUsuario.FlatAppearance.BorderSize = 0;
            btnCadastrarUsuario.FlatStyle = FlatStyle.Flat;
            btnCadastrarUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarUsuario.ForeColor = Color.White;
            btnCadastrarUsuario.Location = new Point(930, 11);
            btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            btnCadastrarUsuario.Size = new Size(180, 34);
            btnCadastrarUsuario.TabIndex = 13;
            btnCadastrarUsuario.Text = "+ Cadastrar Usuário";
            btnCadastrarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnLimpar1
            // 
            btnLimpar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpar1.BackColor = Color.WhiteSmoke;
            btnLimpar1.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnLimpar1.FlatStyle = FlatStyle.Flat;
            btnLimpar1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLimpar1.Location = new Point(1624, 22);
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
            btnRegistrarVenda.Location = new Point(1704, 22);
            btnRegistrarVenda.Margin = new Padding(20);
            btnRegistrarVenda.Name = "btnRegistrarVenda";
            btnRegistrarVenda.Size = new Size(180, 34);
            btnRegistrarVenda.TabIndex = 11;
            btnRegistrarVenda.Text = "+ Registrar Venda";
            btnRegistrarVenda.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpar.BackColor = Color.WhiteSmoke;
            btnLimpar.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Location = new Point(2323, 264);
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
            btnCadastrarProduto.Location = new Point(2404, 262);
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
            lblDescricao.Padding = new Padding(20, 0, 0, 0);
            lblDescricao.Size = new Size(130, 21);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = "Código: #0000";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(20, 20, 0, 0);
            lblTitulo.Size = new Size(135, 43);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Novo Usuário";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContainer);
            Name = "CadastroUsuario";
            Size = new Size(1135, 408);
            Load += CadastroUsuario_Load;
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            pnlConfiguracoes.ResumeLayout(false);
            pnlConfiguracoes.PerformLayout();
            pnlUsuarios.ResumeLayout(false);
            pnlUsuarios.PerformLayout();
            pnlVendas.ResumeLayout(false);
            pnlVendas.PerformLayout();
            pnlClientes.ResumeLayout(false);
            pnlClientes.PerformLayout();
            pnlProdutos.ResumeLayout(false);
            pnlProdutos.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Panel pnlBottom;
        private Button btnLimpar1;
        private Button btnRegistrarVenda;
        private Button btnLimpar;
        private Button btnCadastrarProduto;
        private Label lblDescricao;
        private Label lblTitulo;
        private ToggleSwitch tsTeste;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtConfirmarSenha;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtNome;
        private ComboBox cmbPerfil;
        private TextBox txtEmail;
        private Label label3;
        private Label label7;
        private Label label8;
        private TextBox txtSenha;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel pnlDashboard;
        private ComboBox cmbStatus;
        private Label label6;
        private ToggleSwitch toggleSwitch1;
        private Panel pnlConfiguracoes;
        private ToggleSwitch toggleSwitch6;
        private Label label13;
        private Panel pnlUsuarios;
        private ToggleSwitch toggleSwitch5;
        private Label label12;
        private Panel pnlVendas;
        private ToggleSwitch toggleSwitch4;
        private Label label11;
        private Panel pnlClientes;
        private ToggleSwitch toggleSwitch3;
        private Label label10;
        private Panel pnlProdutos;
        private ToggleSwitch toggleSwitch2;
        private Label label9;
        private Button btnCadastrarUsuario;
        private Button btnLimparCampos;
    }
}
