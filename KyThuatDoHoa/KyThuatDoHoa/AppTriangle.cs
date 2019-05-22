using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace KyThuatDoHoa
{
    public class AppTriangle : AppShape
    {
        private Point d1;
        private Point d2;
        private Point d3;

        public Color color;

      

        public AppTriangle(Point dd1, Point dd2, Point dd3, Color m)
        {
            // Point d;
            // if (dd1.Y> dd2.Y) { d = dd1; dd1 = dd2; dd2 = d; }
            D1 = new Point(dd1.X, dd1.Y);
            D2 = new Point(dd2.X, dd2.Y);
            D3 = new Point(dd3.X, dd3.Y);
            color = m;
        }

        public Point D1 { get => d1; set => d1 = value; }
        public Point D2 { get => d2; set => d2 = value; }
        public Point D3 { get => d3; set => d3 = value; }

       
    public override void draw(Panel panel)
        {
            AppLine ap = new AppLine(d1, d2, color);
            ap.draw(panel);

            ap.Point1 = d2; ap.Point2 = d3;
            ap.draw(panel);

            ap.Point1 = d3; ap.Point2 = d1;
            ap.draw(panel);

        }

        public override void rotate(Panel panel, Point p, int hsg)
        {
            throw new NotImplementedException();
        }

        public override void tinhtien(Panel panel, Point p1, Point p2, Point p3, Point p4, int dx, int dy)
        {
            throw new NotImplementedException();
        }

        
    }
}
