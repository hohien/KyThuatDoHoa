using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace KyThuatDoHoa
{
    class AppSphere
    {
        private AppPoint3D p;
        private int radius;

        public int Radius { get => radius; set => radius = value; }
        internal AppPoint3D P { get => p; set => p = value; }

        public AppSphere()
        {
            p = new AppPoint3D();
            radius = 0;
        }
        public AppSphere(AppPoint3D point, int r)
        {
            p = point;
            radius = r;
        }
        public AppSphere(int x, int y, int z, int r)
        {
            p = new AppPoint3D(x, y, z);
            radius = r;
        }

        public void draw1(Panel panel)
        {
            int x1, y1, radius;
            x1 = 400 + p.X;
            y1 = 180 - p.Y;
            radius = this.radius;
            int xPanel = x1 - radius;
            int yPanel = y1 - radius;
            int d = 2 * radius;
            int x, y, p1;
            x = 0;
            y = radius;
            p1 = 1 - radius;

            Graphics g = panel.CreateGraphics();

            while (x < y)
            {
                g.FillRectangle(Brushes.Red, x + radius, radius - y, 1, 1);
                g.FillRectangle(Brushes.Red, y + radius, radius - x, 1, 1);
                g.FillRectangle(Brushes.Red, y + radius, radius - (-x), 1, 1);
                g.FillRectangle(Brushes.Red, x + radius, radius - (-y), 1, 1);
                g.FillRectangle(Brushes.Red, -x + radius, radius - (-y), 1, 1);
                g.FillRectangle(Brushes.Red, -y + radius, radius - (-x), 1, 1);
                g.FillRectangle(Brushes.Red, -y + radius, radius - x, 1, 1);
                g.FillRectangle(Brushes.Red, -x + radius, radius - y, 1, 1);

                if (p1 < 0) p1 = p1 + (2 * x + 3);
                else
                {
                    p1 = p1 + 2 * (x - y) + 5;
                    y--;
                }
                x++;

            }
        }

        public void draw2(Panel panel)
        {
            int x1, y1, radius;
            x1 = p.X;
            y1 = p.Y;
            radius = this.radius;

            int w = radius;
            int h = radius / 4;

            int xPanel = x1 - w;
            int yPanel = y1 - h;
            int x, y, fx, fy, a2, b2, p1;
            x = 0;
            y = h;
            a2 = w * w;
            b2 = h * h;
            fx = 0;
            fy = 2 * a2 * y;
            Graphics g = panel.CreateGraphics();
            g.FillRectangle(Brushes.Red, x + w, h - y, 1, 1);
            g.FillRectangle(Brushes.Red, -x + w, h - y, 1, 1);
            g.FillRectangle(Brushes.Red, x + w, h - (-y), 1, 1);
            g.FillRectangle(Brushes.Red, -x + w, h - (-y), 1, 1);
            p1 = (int)Math.Round(b2 - a2 * h + 0.25 * a2);//p=b2 - a2*b +a2/4
            while (fx < fy)
            {
                x++;
                fx += 2 * b2;
                if (p1 < 0)
                {
                    p1 += b2 * (2 * x + 3);//p=p + b2*(2x +3)
                }
                else
                {
                    y--;
                    p1 += b2 * (2 * x + 3) + a2 * (2 - 2 * y);//p=p +b2(2x +3) +a2(2-2y)
                    fy -= 2 * a2;
                }
                if ((x + w) % 4 == 0 | ((-x + w) % 4 == 0))
                {
                    //g.setColor(Color.yellow);
                    g.FillRectangle(Brushes.Red, x + w, h - y, 1, 1);
                    g.FillRectangle(Brushes.Red, -x + w, h - y, 1, 1);

                }
                //g.setColor(Color.red);
                g.FillRectangle(Brushes.Red, x + w, h - (-y), 1, 1);
                g.FillRectangle(Brushes.Red, -x + w, h - (-y), 1, 1);
            }
            p1 = (int)Math.Round(b2 * (x + 0.5) * (x + 0.5) + a2 * (y - 1) * (y - 1) - a2 * b2);
            //
            while (y > 0)
            {
                y--;
                fy -= 2 * a2;

                if (p1 >= 0)
                {
                    p1 += a2 * (3 - 2 * y); //p=p +a2(3-2y)
                }
                else
                {
                    x++;
                    fx += 2 * b2;
                    p1 += b2 * (2 * x + 2) + a2 * (3 - 2 * y);//p=p+ b2(2x +2) + a2(3-2y)
                }
                if ((x + w) % 4 == 0 | ((-x + w) % 4 == 0))
                {
                    //g.setColor(Color.yellow);
                    g.FillRectangle(Brushes.Red, x + w, h - y, 1, 1);
                    g.FillRectangle(Brushes.Red, -x + w, h - y, 1, 1);
                }
                //g.setColor(Color.red);
                g.FillRectangle(Brushes.Red, x + w, h - (-y), 1, 1);
                g.FillRectangle(Brushes.Red, -x + w, h - (-y), 1, 1);
            }
        }

    }
}
