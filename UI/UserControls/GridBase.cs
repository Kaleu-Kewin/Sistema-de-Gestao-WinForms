using Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dashboard.UserControls
{
    public partial class GridBase : UserControl
    {
        public GridBase()
        {
            InitializeComponent();
        }

        private void GridBase_Load(object sender, EventArgs e)
        {
            Utils.Arredondar(3, txtBuscar);
        }

        public void ConfigurarGrid(
            string titulo, 
            string descricao
        )
        {
            lblTitulo.Text    = titulo    ?? string.Empty;
            lblDescricao.Text = descricao ?? string.Empty;
        }

        public void SetDataSource(object data)
        {
            dgvDados.AutoGenerateColumns = true;
            dgvDados.DataSource = data;
        }

        public void AddColumn(DataGridViewColumn column)
        {
            dgvDados.Columns.Add(column);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Utils.Arredondar(10, this);
        }
    }
}
