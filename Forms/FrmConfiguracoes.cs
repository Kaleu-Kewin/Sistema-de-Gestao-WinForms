using Dashboard.UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dashboard.Forms
{
    public partial class FrmConfiguracoes : Form
    {
        public FrmConfiguracoes()
        {
            InitializeComponent();
        }

        private void FrmConfiguracoes_Load(object sender, EventArgs e)
        {
            InicializarForm();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            AddUserControl(new ConfiguracoesEmpresa());
        }

        private void btnAparencia_Click(object sender, EventArgs e)
        {
            AddUserControl(new ConfiguracoesAparencia());
        }

        private void btnNotificacoes_Click(object sender, EventArgs e)
        {
            //AddUserControl(new ConfiguracoesNotificacoes());
        }

        private void btnSeguranca_Click(object sender, EventArgs e)
        {
            //AddUserControl(new ConfiguracoesSeguranca());
        }

        private void InicializarForm()
        {
            ConfigurarCards();
            ArredondarButtons();
        }

        private void ConfigurarCards()
        {
            cmEmpresa.ConfigurarCard(
                titulo: "Empresa",
                descricao: "Dados cadastrais",
                icone: Properties.Resources.building
            );

            cmAparencia.ConfigurarCard(
                titulo: "Aparência",
                descricao: "Tema e exibição",
                icone: Properties.Resources.palette
            );

            cmNotificacao.ConfigurarCard(
                titulo: "Notificações",
                descricao: "Alertas e e-mails",
                icone: Properties.Resources.notification_2
            );

            cmSeguranca.ConfigurarCard(
                titulo: "Segurança",
                descricao: "Acesso e backup",
                icone: Properties.Resources.security
            );
        }

        private void ArredondarButtons()
        {
            Utils.ArredondarComBorda(
                3,
                1,
                Color.Gainsboro,
                btnEmpresa,
                btnAparencia,
                btnNotificacoes,
                btnSeguranca
            );
        }

        private void AddUserControl(UserControl userControl)
        {
            tlpFormulario.SuspendLayout();

            tlpFormulario.Controls.Clear();

            userControl.Dock = DockStyle.Fill;
            userControl.Margin = new Padding(35, 25, 35, 1);

            tlpFormulario.Controls.Add(userControl, 0, 0);
            tlpFormulario.Height = userControl.Height + 30;

            tlpFormulario.ResumeLayout();
        }
    }
}
