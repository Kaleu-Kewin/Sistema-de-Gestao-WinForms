using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dashboard.UserControls
{
    public partial class CadastroVendas : UserControl
    {
        public CadastroVendas()
        {
            InitializeComponent();
        }

        private void CadastroVendas_Load(object sender, EventArgs e)
        {
            Inicializar();

            var produtos = new List<dynamic>
            {
                new { Produto = "Produto A", Qtde = 2, Preco = 50.00, Subtotal = 100.00 },
                new { Produto = "Produto B", Qtde = 1, Preco = 30.00, Subtotal = 30.00 },
                new { Produto = "Produto C", Qtde = 3, Preco = 20.00, Subtotal = 60.00 },
                new { Produto = "Produto D", Qtde = 2, Preco = 50.00, Subtotal = 100.00 },
                new { Produto = "Produto E", Qtde = 1, Preco = 30.00, Subtotal = 30.00 },
                new { Produto = "Produto F", Qtde = 2, Preco = 50.00, Subtotal = 100.00 },
            };

            dgvDados.DataSource = produtos;
        }

        private void Inicializar()
        {
            ArredondarControls();
        }

        private void ArredondarControls()
        {
            Utils.Arredondar(
                3,
                txtCodigo,
                txtData,
                txtQuantidade,
                cmbCliente,
                cmbProdutos,
                cmbStatus
            );

            Utils.ArredondarComBorda(
                3,
                1,
                Color.Gainsboro,
                btnLimpar1,
                btnCadastrarProduto,
                btnAdicionar,
                btnRegistrarVenda
            );
        }

        private void picCalendario_Click(object sender, EventArgs e)
        {
            if (mcCalendarioExibir.Visible)
            {
                mcCalendarioExibir.Visible = false;
                return;
            }

            Point posicaoTela = picCalendario.PointToScreen(Point.Empty);
            Point posicaoFormulario = this.PointToClient(posicaoTela);

            mcCalendarioExibir.Location = new Point(
                posicaoFormulario.X,
                posicaoFormulario.Y + picCalendario.Height
            );

            mcCalendarioExibir.BringToFront();
            mcCalendarioExibir.Visible = true;
        }

        private void mcCalendarioExibir_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtData.Text = e.Start.ToString("dd/MM/yyyy");
            mcCalendarioExibir.Visible = false;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (mcCalendarioExibir.Visible &&
                !mcCalendarioExibir.Bounds.Contains(e.Location))
            {
                mcCalendarioExibir.Visible = false;
            }
        }
    }
}
