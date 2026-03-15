using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dashboard.UI.UserControls
{
    public partial class CardModulo : UserControl
    {
        public CardModulo()
        {
            InitializeComponent();
        }

        private void CardModulo_Load(object sender, EventArgs e)
        {
            //
        }

        public void ConfigurarCard(
            string titulo,
            string descricao,
            Image? icone = null
        )
        {
            lblTitulo.Text    = titulo    ?? string.Empty;
            lblDescricao.Text = descricao ?? string.Empty;

            if (icone != null)
            {
                pictureIcone.Image    = icone;
                pictureIcone.SizeMode = PictureBoxSizeMode.Zoom;
            }

            this.Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Utils.Arredondar(10, this);
        }
    }
}
