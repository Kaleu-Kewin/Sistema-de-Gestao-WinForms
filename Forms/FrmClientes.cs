using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Dashboard.Forms
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
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
            cbTotalClientes.ConfigurarCard(
                titulo: "Total de Clientes",
                descricao: "5",
                estatistica: "",
                cor: Color.Transparent,
                icone: imgIcons.Images["custommers.png"]
            );

            cbPessoaFisica.ConfigurarCard(
                titulo: "Pessoa Física",
                descricao: "3",
                estatistica: "",
                cor: Color.Transparent,
                icone: imgIcons.Images["custommers.png"]
            );

            cbPessoaJuridica.ConfigurarCard(
                titulo: "Pessoa Jurídica",
                descricao: "2",
                estatistica: "",
                cor: Color.Transparent,
                icone: imgIcons.Images["custommers.png"]
            );
        }

        private void ConfigurarGrid()
        {
            gbClientes.ConfigurarGrid(
                titulo: "Clientes Cadastrados",
                descricao: "5 Cliente(s)"
            );

            var clientes = new List<dynamic>
            {
                new { ID = 1, Nome = "João Silva",     Tipo = "PF", CPF_CNPJ = "123.456.789-00", Email = "joao@email.com", Cidade_UF = "São Paulo/SP" },
                new { ID = 2, Nome = "Maria Oliveira", Tipo = "PF", CPF_CNPJ = "987.654.321-00", Email = "maria@email.com", Cidade_UF = "Rio de Janeiro/RJ" },
                new { ID = 3, Nome = "Carlos Souza",   Tipo = "PF", CPF_CNPJ = "456.789.123-00", Email = "carlos@email.com", Cidade_UF = "Belo Horizonte/MG" },
                
                new { ID = 4, Nome = "Tech Solutions LTDA", Tipo = "PJ", CPF_CNPJ = "12.345.678/0001-99", Email = "contato@techsolutions.com", Cidade_UF = "Curitiba/PR" },
                new { ID = 5, Nome = "Mercado Central ME",  Tipo = "PJ", CPF_CNPJ = "98.765.432/0001-11", Email = "vendas@mercadocentral.com", Cidade_UF = "Porto Alegre/RS" }
            };

            gbClientes.SetDataSource(clientes);
        }
    }
}
