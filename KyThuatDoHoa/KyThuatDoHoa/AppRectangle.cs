using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace KyThuatDoHoa
{
   public class AppRectangle : AppShape
    {
        private Point d1;
        private Point d2;
        private Point d3;
        private Point d4;
        
        public Color color;

        public AppRectangle()
        {
            D1 = new Point(0, 0);
            D2 = new Point(0, 0);
            D3 = new Point(0, 0);
            D4 = new Point(0, 0);
            color = Color.DarkGreen;
        }
        
        public AppRectangle(Point dd1, Point dd2, Point dd3, Point dd4, Color m)
        {
            // Point d;
            // if (dd1.Y> dd2.Y) { d = dd1; dd1 = dd2; dd2 = d; }
            D1 = new Point(dd1.X, dd1.Y);
            D2 = new Point(dd2.X, dd2.Y);
            D3 = new Point(dd3.X, dd3.Y);
            D4 = new Point(dd4.X, dd4.Y);
            color = m;
        }

        public Point D1 { get => d1; set => d1 = value; }
        public Point D2 { get => d2; set => d2 = value; }
        public Point D3 { get => d3; set => d3 = value; }
        public Point D4 { get => d4; set => d4 = value; }

        public override void draw(Panel panel)
        {
            AppLine ap = new AppLine(d1,d2,color);
            ap.draw(panel);
            ap.Point1 = d2; ap.Point2 = d3;
            ap.draw(panel);

            ap.Point1 = d3; ap.Point2 = d4;
            ap.draw(panel);

            ap.Point1 = d4; ap.Point2 = d1;
            ap.draw(panel);
        }

        public override void rotate(Panel panel, Point p, int hsg)
        {
            throw new NotImplementedException();
        }

        public void fill(Panel panel)
        {
            AlgorithmDraws ad = new AlgorithmDraws();
            Point[] arrPoint = new Point[] {ad.convertPoint(d1), ad.convertPoint(d2), ad.convertPoint(d3), ad.convertPoint(d4) };
            Graphics gp = panel.CreateGraphics();
            gp.FillPolygon(new SolidBrush(color), arrPoint);
        }
    }
}
