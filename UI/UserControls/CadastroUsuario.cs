using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Dashboard.Utils;

namespace Dashboard.UserControls
{
    public partial class CadastroUsuario : UserControl
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            AplicarBordas();
            ArredondarControls();
        }

        private void AplicarBordas()
        {
            Utils.AplicarBorda(pnlDashboard,     Enums.LadoBorda.Todos);
            Utils.AplicarBorda(pnlProdutos,      Enums.LadoBorda.Todos);
            Utils.AplicarBorda(pnlClientes,      Enums.LadoBorda.Todos);
            Utils.AplicarBorda(pnlVendas,        Enums.LadoBorda.Todos);
            Utils.AplicarBorda(pnlConfiguracoes, Enums.LadoBorda.Todos);
            Utils.AplicarBorda(pnlUsuarios,      Enums.LadoBorda.Todos);
        }

        private void ArredondarControls()
        {
            Utils.Arredondar(
                3, 
                txtNome, 
                txtEmail, 
                txtSenha,
                txtConfirmarSenha,
                cmbPerfil, 
                cmbStatus
            );

            Utils.ArredondarComBorda(5, 1, Color.Gainsboro, btnLimparCampos, btnCadastrarUsuario);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Utils.Arredondar(10, this);
        }
    }
}
