using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.UI.Theme
{
    public class Tema
    {
        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }

        public Color ButtonBack { get; set; }
        public Color ButtonFore { get; set; }
    }

    public static class Temas
    {
        public static Tema Claro = new Tema
        {
            BackColor  = Color.White,
            ForeColor  = Color.Black,

            ButtonBack = Color.Gainsboro,
            ButtonFore = Color.Black
        };

        public static Tema Escuro = new Tema
        {
            BackColor  = Color.FromArgb(32,32,32),
            ForeColor  = Color.White,

            ButtonBack = Color.FromArgb(64,64,64),
            ButtonFore = Color.White
        };
    }
}
