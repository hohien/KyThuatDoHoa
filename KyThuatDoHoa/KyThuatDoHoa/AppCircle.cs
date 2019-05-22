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

        public override void rotate(Panel panel, Point p, int hsg)
        {
        }

        public override void tinhtien(Panel panel, Point p1, Point p2, Point p3, Point p4, int dx, int dy)
        {
            throw new NotImplementedException();
        }

       
    }
}
