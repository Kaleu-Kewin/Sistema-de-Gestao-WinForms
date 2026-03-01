using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dashboard.Forms
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            InicializarForm();
        }

        private void InicializarForm()
        {
            ConfigurarCards();
            ConfigurarGrid();
        }

        private void ConfigurarCards()
        {
            cbTotalProdutos.ConfigurarCard(
                titulo      : "Total de Produtos",
                descricao   : "15",
                estatistica : "",
                cor         : Color.Transparent,
                icone       : imgIcons.Images["products.png"]
            );

            cbEstoqueTotal.ConfigurarCard(
                titulo      : "Estoque Total",
                descricao   : "372",
                estatistica : "",
                cor         : Color.Transparent,
                icone       : imgIcons.Images["products.png"] 
            );

            cbValorEstoque.ConfigurarCard(
                titulo      : "Valor em Estoque",
                descricao   : "R$ 160.760,00",
                estatistica : "",
                cor         : Color.Transparent,
                icone       : imgIcons.Images["products.png"] 
            );
        }   

        private void ConfigurarGrid()
        {
            gbProdutos.ConfigurarGrid(
                titulo    : "Produtos Cadastrados",
                descricao : "15 Produto(s)"
            );

            var produtos = new List<dynamic>
            {
                new { ID = 1, Nome = "Produto A", Categoria = "Categoria 1", Preco = 100.00, Estoque = 10 },
                new { ID = 2, Nome = "Produto B", Categoria = "Categoria 2", Preco = 50.00,  Estoque = 20 },
                new { ID = 3, Nome = "Produto C", Categoria = "Categoria 1", Preco = 75.00,  Estoque = 15 },
                new { ID = 4, Nome = "Produto D", Categoria = "Categoria 3", Preco = 200.00, Estoque = 5  },
                new { ID = 5, Nome = "Produto E", Categoria = "Categoria 2", Preco = 120.00, Estoque = 8  }
            };

            gbProdutos.SetDataSource(produtos);
        }
    } 
}
