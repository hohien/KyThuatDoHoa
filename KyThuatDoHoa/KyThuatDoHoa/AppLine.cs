using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KyThuatDoHoa
{
   public class AppLine
    {
        private Point point1;
        private Point point2;
        private Color color;
        private double alpha, b1;
        private int b;

        public Color Color { get => color; set => color = value; }
        public Point Point1 { get => point1; set => point1 = value; }
        public Point Point2 { get => point2; set => point2 = value; }

        public AppLine()
        {
            Point1 = new Point(0, 0);
            Point2 = new Point(0, 0);
            Color = Color.DarkGreen;
            alpha = 0;
            b1 = b = 0;
        }
        public AppLine(Point p1, Point p2, Color m)
        {
            int d1 = p1.X; int r1 = p1.Y; int d2 = p2.X; int r2 = p2.Y;
            Point1 = p1;
            Point2 = p2;
            Color = m;
            if (d1 == d2) alpha = 0;
            else alpha = (r1 - r2) / (d1 - d2);
            b1 = r1 - alpha * d1;
            b = Convert.ToInt16(b1);
        }
        public void setpro(Point p1, Point p2, Color m)
        {
            Point1 = p1;
            Point2 = p2;
            Color = m;
        }
        public AppLine getpro()
        {
            AppLine item = new AppLine(Point1, Point2, Color);
            return item;
        }
        public double gethsg()
        { return alpha; }
        public int getb()
        { return b; }
    
    
    
}
}
