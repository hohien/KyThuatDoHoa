using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace KyThuatDoHoa
{
    public class AppCircle : AppShape
    {
        private int radius;
        private Point point;
        private Color color;

        public int Radius { get => radius; set => radius = value; }
        public Point Point { get => point; set => point = value; }
        public Color Color { get => color; set => color = value; }

        public AppCircle()
        {
            Radius = 0;
            Point = new Point(0, 0);
            Color = Color.DarkGreen;
        }
        public AppCircle(int radius, Point point, Color color)
        {
            this.Radius = radius;
            this.Point = new Point(point.X, point.Y);
            this.Color = color;
        }

        public override void draw(Panel panel)
        {
            AlgorithmDraws al = new AlgorithmDraws();
            al.Midpoint_circle(this, panel);
        }

        public void fill(Panel panel)
        {
            AlgorithmDraws al = new AlgorithmDraws();
            Graphics gp = panel.CreateGraphics();
            Point p = al.convertPoint(point);
            gp.FillEllipse(new SolidBrush(color), p.X-radius-4, p.Y-radius-4, (radius+4) * 2, (radius+4) * 2);
        }

        public override void rotate(Panel panel, Point p, int hsg)
        {

        }
    }
}
