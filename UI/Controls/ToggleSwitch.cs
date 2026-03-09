using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace Dashboard.UI.Controls
{
    public class ToggleSwitch : Control
    {
        private bool _checked = false;

        public event EventHandler CheckedChanged;

        [Browsable(true)]
        [DefaultValue(false)]
        public bool Checked
        {
            get { return _checked; }
            set
            {
                if (_checked == value)
                    return;

                _checked = value;

                CheckedChanged?.Invoke(this, EventArgs.Empty);

                Invalidate();   
            }
        }

        [Browsable(true)]
        [ToolboxItem(true)]
        public ToggleSwitch()
        {
            this.Size = new Size(50, 25);

            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true
            );
        }

        protected override void OnClick(EventArgs e)
        {
            Checked = !Checked;
            base.OnClick(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int altura  = Height - 1;
            int largura = Width - 1;

            Color fundo = Checked ? Color.Black : Color.Gainsboro;

            using (GraphicsPath path = GetRoundedRectangle(new Rectangle(0, 0, largura, altura), altura))
            using (Brush b = new SolidBrush(fundo))
            {
                g.FillPath(b, path);
            }

            int circuloX = Checked ? Width - Height : 0;

            using (Brush b = new SolidBrush(Color.White))
            {
                g.FillEllipse(b, circuloX + 2, 2, Height - 4, Height - 4);
            }
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);

            path.CloseFigure();

            return path;
        }
    }
}