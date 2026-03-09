using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Dashboard.UserControls
{
    public partial class CadastroProdutos : UserControl
    {
        public CadastroProdutos()
        {
            InitializeComponent();
        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            ArredondarControls();
        }

        private void ArredondarControls()
        {
            Utils.Arredondar(
                3, 
                txtCodigo,
                txtNome,
                cmbCategoria,
                txtQuantidade,
                txtPreco,
                txtDescricao
            );

            Utils.ArredondarComBorda(5, 1, Color.Gainsboro, btnLimpar, btnCadastrarProduto);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Utils.Arredondar(10, this);
        }
    }
}
