using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dashboard.Forms
{
    public partial class FrmVendas : Form
    {
        public FrmVendas()
        {
            InitializeComponent();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
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
            cbTotalVendas.ConfigurarCard(
                titulo: "Total em Vendas",
                descricao: "R$ 15.008,90",
                estatistica: "",
                cor: Color.Transparent,
                icone: imgIcons.Images["sales.png"]
            );

            cbVendasAprovadas.ConfigurarCard(
                titulo: "Aprovadas / Faturadas",
                descricao: "2",
                estatistica: "",
                cor: Color.Transparent,
                icone: imgIcons.Images["sales.png"]
            );

            cbVendasPendentes.ConfigurarCard(
                titulo: "Pendentes",
                descricao: "1",
                estatistica: "",
                cor: Color.Transparent,
                icone: imgIcons.Images["sales.png"]
            );
        }

        private void ConfigurarGrid()
        {
            gbVendas.ConfigurarGrid(
                titulo: "Vendas Registradas",
                descricao: "0 Venda(s)"
            );

            var vendas = new List<dynamic>
            {
                new { Codigo = "#001", Data = "01/03/2026", Cliente = "Cliente A", Total = 100.00, Status = "Aprovada", Itens = 3  },
                new { Codigo = "#002", Data = "02/03/2026", Cliente = "Cliente B", Total = 50.00,  Status = "Pendente", Itens = 5  },
                new { Codigo = "#003", Data = "03/03/2026", Cliente = "Cliente C", Total = 150.00, Status = "Faturada", Itens = 27 },
                new { Codigo = "#004", Data = "04/03/2026", Cliente = "Cliente D", Total = 100.00, Status = "Aprovada", Itens = 3  },
                new { Codigo = "#005", Data = "05/03/2026", Cliente = "Cliente E", Total = 50.00,  Status = "Pendente", Itens = 5  },
                new { Codigo = "#006", Data = "06/03/2026", Cliente = "Cliente F", Total = 150.00, Status = "Faturada", Itens = 27 },
            };

            gbVendas.SetDataSource(vendas);
        }
    }
}
