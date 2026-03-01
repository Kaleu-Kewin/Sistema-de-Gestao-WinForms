using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class CardBase : UserControl
    {
        public CardBase()
        {
            InitializeComponent();
        }

        public void ConfigurarCard(
            string titulo, 
            string descricao, 
            string estatistica,
            Color? cor   = null,
            Image? icone = null
        )
        {
            lblEstatistica.ForeColor = cor ?? Color.ForestGreen;

            lblTitulo.Text      = titulo      ?? string.Empty;
            lblDescricao.Text   = descricao   ?? string.Empty;
            lblEstatistica.Text = estatistica ?? string.Empty;

            if (estatistica == "")
                lblDescricao.Padding = new Padding(15, 20, 0, 0);      

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
