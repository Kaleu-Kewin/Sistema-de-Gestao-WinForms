using System;
using Dashboard.Forms;
using static Dashboard.Enums;
using static Dashboard.Utils;

namespace Dashboard
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            InicializarForm();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SelecionarButton((Button)sender);
            AbrirTela(new FrmDashboard());
        }   

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            SelecionarButton((Button)sender);
            AbrirTela(new FrmProdutos());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            SelecionarButton((Button)sender);
            AbrirTela(new FrmClientes());
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            SelecionarButton((Button)sender);
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            SelecionarButton((Button)sender);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            SelecionarButton((Button)sender);
        }

        //private void btnMinimizar_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}

        //private void btnFechar_MouseEnter(object sender, EventArgs e)
        //{
        //    btnFechar.BackColor = Color.FromArgb(210, 0, 0);
        //}

        //private void btnFechar_MouseLeave(object sender, EventArgs e)
        //{
        //    btnFechar.BackColor = Color.Transparent;
        //}

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.ForeColor  = Color.FromArgb(210, 0, 0);
            btnLogout.BackColor  = Color.FromArgb(255, 212, 212);
            btnLogout.ImageIndex = 8;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.ForeColor  = SystemColors.ControlText;
            btnLogout.BackColor  = Color.Transparent;
            btnLogout.ImageIndex = 7;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // == Eventos acima ==

        // == Métodos Auxiliares abaixo ==

        private void InicializarForm()
        {
            AjustarTela();
            AdicionarBordas();
            ArredondarButtons();

            AbrirTela(new FrmDashboard());
            SelecionarButton(btnDashboard);
        }

        private void AjustarTela()
        {
            Rectangle area = Screen.FromHandle(this.Handle).WorkingArea;
            this.Location  = area.Location;
            this.Size      = area.Size;
        }

        private void AdicionarBordas()
        {
            Utils.AplicarBorda(pnlMenuLateral,    LadoBorda.Direita);
            Utils.AplicarBorda(pnlTituloMenu,     LadoBorda.Direita);
            Utils.AplicarBorda(lblTituloMenu,     LadoBorda.Inferior);
            Utils.AplicarBorda(pnlParteBaixoMenu, LadoBorda.Superior);
            Utils.AplicarBorda(pnlParteBaixoMenu, LadoBorda.Direita);
        }

        private void ArredondarButtons()
        { 
            Utils.Arredondar(
                7, 
                btnLogout, 
                btnDashboard, 
                btnProdutos,
                btnClientes, 
                btnVendas, 
                btnUsuarios,
                btnConfiguracoes
            );
        }

        private void SelecionarButton(Button btnSelecionado)
        {
            foreach (var btn in pnlMenuLateral.Controls.OfType<Button>())
                btn.BackColor = Color.WhiteSmoke;

            btnSelecionado.BackColor = Color.Gainsboro;
        }

        private void AbrirTela(Form form)
        {
            pnlContainer.Controls.Clear();

            form.TopLevel        = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock            = DockStyle.Fill;

            pnlContainer.Controls.Add(form);
            form.Show();
        }
    }
}