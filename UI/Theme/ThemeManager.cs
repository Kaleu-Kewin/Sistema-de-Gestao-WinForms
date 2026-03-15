using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.UI.Theme
{
    public static class ThemeManager
    {
        public static Tema TemaAtual;

        public static void AplicarTema(Control control, Tema tema)
        {
            control.BackColor = tema.BackColor;
            control.ForeColor = tema.ForeColor;

            if (control is Button)
            {
                control.BackColor = tema.ButtonBack;
                control.ForeColor = tema.ButtonFore;
            }

            foreach (Control c in control.Controls)
            {
                AplicarTema(c, tema);
            }
        }
    }
}
