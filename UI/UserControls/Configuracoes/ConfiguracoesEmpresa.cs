using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Dashboard.UI.UserControls
{
    public partial class ConfiguracoesEmpresa : UserControl
    {
        public ConfiguracoesEmpresa()
        {
            InitializeComponent();
        }

        private void ConfiguracoesEmpresa_Load(object sender, EventArgs e)
        {
            ArredondarControls();

            cmbEstado.DataSource = Utils.EnumParaComboBox<Enums.Estados>();
        }

        private void ArredondarControls()
        {
            Utils.Arredondar(
                3,
                txtRazaoSocial,
                txtCEP,
                txtCidade,
                txtCNPJ,
                txtEndereco,
                txtSite,
                txtTelefone,
                txtEmail,
                cmbEstado
            );

            Utils.ArredondarComBorda(3, 1, Color.Gainsboro, btnSalvar);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Utils.Arredondar(10, this);
        }
    }
}
