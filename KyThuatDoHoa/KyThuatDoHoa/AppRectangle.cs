using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace KyThuatDoHoa
{
   public class AppRectangle : AppShape
    {
        private Point d1;
        private Point d2;
        private Point d3;
        private Point d4;

        private Color color;

        public AppRectangle()
        {
            D1 = new Point(0, 0);
            D2 = new Point(0, 0);
            D3 = new Point(0, 0);
            D4 = new Point(0, 0);
            Color = Color.DarkGreen;
        }
        
        public AppRectangle(Point dd1, Point dd2, Point dd3, Point dd4, Color m)
        {
            // Point d;
            // if (dd1.Y> dd2.Y) { d = dd1; dd1 = dd2; dd2 = d; }
            D1 = new Point(dd1.X, dd1.Y);
            D2 = new Point(dd2.X, dd2.Y);
            D3 = new Point(dd3.X, dd3.Y);
            D4 = new Point(dd4.X, dd4.Y);
            Color = m;
        }

        public Point D1 { get => d1; set => d1 = value; }
        public Point D2 { get => d2; set => d2 = value; }
        public Point D3 { get => d3; set => d3 = value; }
        public Point D4 { get => d4; set => d4 = value; }
        public Color Color { get => color; set => color = value; }

        public override void draw(Panel panel)
        {
      
                AppLine ap = new AppLine(d1, d2, Color);
                ap.draw(panel);
         
                AppLine ap1 = new AppLine(d2, d3, Color);
                ap1.draw(panel);
         
                AppLine ap2 = new AppLine(d3, d4, Color);
                ap2.draw(panel);
          
                AppLine ap3 = new AppLine(d4, d1, Color);

                ap3.draw(panel);
        

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

        public override void tinhtien(Panel panel, int dx, int dy)
        {
            AlgorithmDraws ad = new AlgorithmDraws();
            d1 = ad.Tinhtien(d1, dx, dy);
            d2 = ad.Tinhtien(d2, dx, dy);
            d3 = ad.Tinhtien(d3, dx, dy);
            d4 = ad.Tinhtien(d4, dx, dy);
            this.draw(panel);
        }

        public String toString()
        {
            int w = Math.Abs(d2.X - d1.X);
            int h = Math.Abs(d1.Y - d3.Y);
            return "x = " + D1.X + " y = " + D1.Y + "\n" +"width = "+w+" height = "+h+"\n";
        }
    }
}
