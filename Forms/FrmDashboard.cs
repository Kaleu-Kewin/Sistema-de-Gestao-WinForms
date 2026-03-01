using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dashboard.Forms
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            InicializarTela();
        }

        private void InicializarTela()
        {
            ConfigurarCards();
            //EstilizarGraficos();
            //CarregarDadosGraficos(); 
        }

        private void ConfigurarCards()
        {
            cbClientes.ConfigurarCard(
                titulo      : "Produtos",
                descricao   : "1.234",
                estatistica : "🡭 +12% este mês",
                cor         : Color.ForestGreen,
                icone       : imgIcons.Images["products_2.png"]
            );

            cbProdutos.ConfigurarCard(
                titulo      : "Clientes",
                descricao   : "5.632",
                estatistica : "🡭 +8% este mês",
                cor         : Color.ForestGreen,
                icone       : imgIcons.Images["custommers.png"]
            );

            cbVendas.ConfigurarCard(
                titulo      : "Vendas",
                descricao   : "R$ 84.320",
                estatistica : "🡭 +23% este mês",
                cor         : Color.ForestGreen,
                icone       : imgIcons.Images["sales.png"]
            );

            cbReceita.ConfigurarCard(
                titulo      : "Receita Mensal",
                descricao   : "R$ 312.500",
                estatistica : "🡮 -4% este mês",
                cor         : Color.Red,
                icone       : imgIcons.Images["graphs.png"]
            );
        }
    }
}
