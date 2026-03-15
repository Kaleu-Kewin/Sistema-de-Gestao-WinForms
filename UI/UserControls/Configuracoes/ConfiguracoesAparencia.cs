using Dashboard.UI.Theme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dashboard.UI.UserControls
{
    public partial class ConfiguracoesAparencia : UserControl
    {
        public ConfiguracoesAparencia()
        {
            InitializeComponent();
        }

        private void ConfiguracoesAparencia_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void Inicializar()
        {
            ArredondarControls();
            CarregarCombosBox();
        }

        private void ArredondarControls()
        {
            Utils.Arredondar(
                3,
                cmbFormatoData,
                cmbIdioma,
                cmbItensPagina,
                cmbMoeda,
                cmbTema
            );

            Utils.ArredondarComBorda(3, 1, Color.Gainsboro, btnSalvar);
        }

        private void CarregarCombosBox()
        {
            cmbTema.DataSource        = Utils.EnumParaComboBox<Enums.Tema>();
            cmbFormatoData.DataSource = Utils.EnumParaComboBox<Enums.FormatoData>();
            cmbIdioma.DataSource      = Utils.EnumParaComboBox<Enums.Idioma>();
            cmbMoeda.DataSource       = Utils.EnumParaComboBox<Enums.Moeda>();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Utils.Arredondar(10, this);
        }

        private void cmbTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
    }
}