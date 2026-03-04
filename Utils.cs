using System;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using static Dashboard.Enums;

namespace Dashboard
{
    public static class Utils
    {
        public static List<object> EnumParaComboBox<T>() where T : Enum
        {
            //Adicionar no comboBox:

            // - DisplayMember = "Text"
            // - ValueMember   = "Value"

            return Enum.GetValues(typeof(T))
                .Cast<T>()
                .Select(e => new
                {
                    Value = e,
                    Text = GetDescription((Enum)(object)e)
                })
                .Cast<object>()
                .ToList();
        }

        public static string GetDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)
                Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));

            return attribute == null ? value.ToString() : attribute.Description;
        }

        public static void AplicarBorda(Control control, LadoBorda lado, int espessura = 1, Color? cor = null) // retirar dps
        {
            control.Paint += (sender, e) =>
            {
                Color corFinal = cor ?? Color.LightGray;

                using (Pen pen = new Pen(corFinal, espessura))
                {
                    switch (lado)
                    {
                        case LadoBorda.Superior:
                            e.Graphics.DrawLine(pen, 0, 0, control.Width, 0);
                            break;

                        case LadoBorda.Inferior:
                            e.Graphics.DrawLine(pen, 0, control.Height - espessura, control.Width, control.Height - espessura);
                            break;

                        case LadoBorda.Esquerda:
                            e.Graphics.DrawLine(pen, 0, 0, 0, control.Height);
                            break;

                        case LadoBorda.Direita:
                            e.Graphics.DrawLine(pen, control.Width - espessura, 0, control.Width - espessura, control.Height);
                            break;
                    }
                }
            };

            control.Invalidate();
        }

        public static void Arredondar(int raio, params Control[] controls)
        {
            if (raio <= 0 || controls == null || controls.Length == 0)
                return;

            foreach (var control in controls)
            {
                if (control == null)
                    continue;

                void AtualizarRegion()
                {
                    Rectangle rect = new Rectangle(0, 0, control.Width, control.Height);

                    using (GraphicsPath path = new GraphicsPath())
                    {
                        int d = raio * 2;

                        path.StartFigure();

                        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
                        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
                        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
                        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

                        path.CloseFigure();

                        control.Region = new Region(path);
                    }
                }

                control.Resize += (s, e) => AtualizarRegion();

                AtualizarRegion();
            }
        }

        public static void ArredondarComBorda( // nao funciona para TextBox..
            int raio,
            int espessuraBorda,
            Color corBorda,
            params Control[] controls)
        {
            foreach (var control in controls)
            {
                if (control == null || raio <= 0)
                    continue;

                control.Paint += (s, e) =>
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    Rectangle rect = new Rectangle(0, 0, control.Width - 1, control.Height - 1);
                    int d = raio * 2;

                    using (GraphicsPath path = new GraphicsPath())
                    {
                        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
                        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
                        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
                        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
                        path.CloseFigure();

                        control.Region = new Region(path);

                        using (Pen pen = new Pen(corBorda, espessuraBorda))
                        {
                            e.Graphics.DrawPath(pen, path);
                        }
                    }
                };

                control.Resize += (s, e) => control.Invalidate();

                if (control is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
            }
        }
    }
}
