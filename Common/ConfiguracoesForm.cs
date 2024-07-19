using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layout.common
{
    public class ConfiguracoesForm
    {
        public static string connectionString { get; } = "Server=localhost;Database=biblioteca;User ID=root;Password=duzentos;";

        public static void ArredondarBordas(Control controle, int raio)
        {
            // Cria um GraphicsPath com cantos arredondados
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, raio, raio), 180, 90);
            path.AddArc(new Rectangle(controle.Width - raio, 0, raio, raio), 270, 90);
            path.AddArc(new Rectangle(controle.Width - raio, controle.Height - raio, raio, raio), 0, 90);
            path.AddArc(new Rectangle(0, controle.Height - raio, raio, raio), 90, 90);
            path.CloseFigure();

            // Define a região do controle com o path criado
            controle.Region = new Region(path);
        }

        public static void LoadControls(UserControl control,Panel panel)
        {
            panel.Controls.Clear();

            control.Dock = DockStyle.Fill;

            panel.Controls.Add(control);
        }

    }
}
