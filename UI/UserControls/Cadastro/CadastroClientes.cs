using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dashboard.UserControls
{
    public partial class CadastroClientes : UserControl
    {
        public CadastroClientes()
        {
            InitializeComponent();
        }

        private void CadastroClientes_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void Inicializar()
        {
            ArredondarControls();

            cmbEstado.DataSource = Utils.EnumParaComboBox<Enums.Estados>();
            cmbTipo.DataSource   = Utils.EnumParaComboBox<Enums.TipoPessoa>();
        }

        private void ArredondarControls ()
        {
            Utils.Arredondar(
                3,
                txtCodigo,
                txtNome,
                txtCidade,
                txtCpfCnpj,
                txtEmail,
                txtTelefone,
                cmbEstado,
                cmbTipo
            );

            Utils.ArredondarComBorda(
                5,
                1, 
                Color.Gainsboro, 
                btnLimpar, 
                btnCadastrar
            );
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Utils.Arredondar(10, this);
        }
    }
}
