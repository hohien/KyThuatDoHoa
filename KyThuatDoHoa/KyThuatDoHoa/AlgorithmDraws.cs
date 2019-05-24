using System;
using System.Drawing;
using System.Windows.Forms;

namespace KyThuatDoHoa
{
    public class AlgorithmDraws
    {
        public Color[,] arrcolor = new Color[800, 360];

        public int round(double tds)
        {
            int tdm;
            double sodu = tds % 5;
            if (sodu != 0)
            {
                if (sodu >= 3) tdm = (int)(tds + 5 - sodu);
                else tdm = (int)(tds - sodu);
            }
            else tdm = (int)tds;
            return tdm;
        }
        public Point toado1(int x, int y)
        {
            return (new Point(x / 5 - 40, 40 - y / 5));
        }
        public Point toado2(int x, int y)
        {
            return (new Point(x * 5 + 200, 200 - 5 * y));
        }

        public void putpixel(int x, int y, Color m, Panel panel)
        {
            Point temp = convertPoint(new Point(x, y));
            x = temp.X;
            y = temp.Y;
            Graphics grfx = panel.CreateGraphics();
            SolidBrush b = new SolidBrush(m);

            grfx.FillEllipse(b, x - 3, y - 3, 6, 6);

        }
        public void DDA_Line(AppLine T, Panel panel) // Ve duong thang co dinh dang mau
        {
            Color m = T.Color;
            int Dx, Dy, count, temp_1, temp_2, dem = 1;
            int temp_3, temp_4;
            Dx = T.Point2.X - T.Point1.X;
            Dy = T.Point2.Y - T.Point1.Y;
            if (Math.Abs(Dy) > Math.Abs(Dx)) count = Math.Abs(Dy);
            else count = Math.Abs(Dx);
            float x, y, delta_X, delta_Y;
            if (count > 0)
            {
                delta_X = Dx;
                delta_X /= count;
                delta_Y = Dy;
                delta_Y /= count;
                x = T.Point1.X;
                y = T.Point1.Y;
                do
                {
                    temp_1 = round(x);
                    temp_2 = round(y);
                    putpixel(temp_1, temp_2, m, panel);
                    // temp_3 = temp_1;
                    // temp_4 = temp_2;
                    x += delta_X;
                    y += delta_Y;
                    --count;
                    dem++;
                } while (count != -1);

            }



        }


        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        private void put8pitxel(int x, int y, int cx, int cy, Color m, Panel panel)
        {
            putpixel(cx + x, cy + y, m, panel);
            putpixel(cx + x, cy - y, m, panel);
            putpixel(cx - x, cy + y, m, panel);
            putpixel(cx - x, cy - y, m, panel);
            putpixel(cx + y, cy + x, m, panel);
            putpixel(cx + y, cy - x, m, panel);
            putpixel(cx - y, cy + x, m, panel);
            putpixel(cx - y, cy - x, m, panel);
        }
        public void Midpoint_circle(AppCircle T, Panel panel)
        {
            int x, y, cx, cy, p, R;
            Color m = T.Color;
            cx = T.Point.X; cy = T.Point.Y;
            x = 0;
            y = R = T.Radius;
            int maxX = round((float)(Math.Sqrt(2) / 2 * R));
            // int maxX = Math.Sqrt(2) / 2 * R;
            p = 1 - R;
            put8pitxel(x, y, cx, cy, m, panel);
            while (x <= maxX)
            {
                if (p < 0) p += 2 * x + 3;
                else { p += 2 * (x - y) + 5; y -= 5; }
                x += 5;
                put8pitxel(x, y, cx, cy, m, panel);
            }

        }
        //Quay
        public Point nhanMT2(double[,] matran, double[] mang)
        {
            double[] mangtam;
            mangtam = new double[3];

            int dem = 0;
            for (int i = 0; i < 3; i++)
            {
                mangtam[i] = mang[0] * matran[0, dem] + mang[1] * matran[1, dem] + mang[2] * matran[2, dem];
                dem++;
            }

            Point pt = new Point(Convert.ToInt16(mangtam[0]), Convert.ToInt16(mangtam[1]));
            return pt;
        }

        public Point Quay(Point d1, Point d2, int hsg)// Quay 1 diem (x,y)quanh diem(xo,yo)1 goc a;
        {
            Point dd1, dd2;
            dd1 = this.toado1(d1.X, d1.Y);
            dd2 = this.toado1(d2.X, d2.Y);
            int x, y, xo, yo;
            x = dd1.X; y = dd1.Y; xo = dd2.X; yo = dd2.Y;
            int a = hsg;
            double[,] matran2;
            double[] mang;
            double c, s;
            mang = new double[3];
            matran2 = new double[3, 3];

            // ma tran tinh tien (xo,yo)ve goc toa do
            Point pt = Tinhtien(dd1, -xo, -yo);

            //Ma tran quay quanh goc toa do mot goc a;
            s = Math.Sin((Math.PI * a) / 180);
            c = Math.Cos((Math.PI * a) / 180);
            matran2[0, 0] = c; matran2[0, 1] = s; matran2[0, 2] = 0;
            matran2[1, 0] = -1 * s; matran2[1, 1] = c; matran2[1, 2] = 0;
            matran2[2, 0] = 0; matran2[2, 1] = 0; matran2[2, 2] = 1;
            mang[0] = pt.X; mang[1] = pt.Y; mang[2] = 1;
            Point pt1 = nhanMT2(matran2, mang);

            // ma tran doi diem ve toa do cu
            Point pt2 = Tinhtien(pt1, xo, yo);
            Point kq = this.toado2(pt2.X, pt2.Y);
            return kq;
        }

        int xCenter = 400;
        int yCenter = 180;

        public Point convertPoint(Point source)
        {
            int x = source.X;
            int y = source.Y;

            x = xCenter + x;
            y = yCenter - y;
            return new Point(x, y);
        }

        public Point Tinhtien(Point d1, int dx, int dy)
        {
            int x, y;
            x = d1.X; y = d1.Y;
            double[,] matran1;
            double[] mang;
            mang = new double[3];
            matran1 = new double[3, 3];

            //Ma tran cua phep tinh tien diem p theo vecter(dx,dy);
            matran1[0, 0] = 1; matran1[0, 1] = 0; matran1[0, 2] = 0;
            matran1[1, 0] = 0; matran1[1, 1] = 1; matran1[1, 2] = 0;
            matran1[2, 0] = dx; matran1[2, 1] = dy; matran1[2, 2] = 1;
            mang[0] = x; mang[1] = y; mang[2] = 1;
            Point pt2 = nhanMT2(matran1, mang);
            // Point kq = new Point(round(pt2.X), round(pt2.Y));
            return pt2;
        }
        public void heToaDo(Panel panel)
        {
            Graphics g = panel.CreateGraphics();
            for (int i = 0; i <= panel.Width; i++)
            {
                g.DrawLine(new Pen(Color.Gray), 5 * i, 0, 5 * i, 4000);
                g.DrawLine(new Pen(Color.Gray), 0, 5 * i, 4000, 5 * i);
            }
            trucToaDo(panel);
        }

        public void trucToaDo(Panel panel)
        {
            Graphics g = panel.CreateGraphics();
            g.DrawLine(new Pen(Color.Blue), 0, 180, 800, 180);
            g.DrawLine(new Pen(Color.Blue), 400, 0, 400, 400);
        }
        public void put4pitxel(int x, int y, int cx, int cy, Color m, Panel panel)
        {
            putpixel(x + cx, y + cy, m, panel);
            putpixel(-x + cx, y + cy, m, panel);
            putpixel(x + cx, -y + cy, m, panel);
            putpixel(-x + cx, -y + cy, m, panel);
        }
        public void Midpoint_elip(AppEllipse T, Panel panel)
        {
            int x, y, cx, cy, a, b;
            cx = T.point.X; cy = T.point.Y;
            a = T.a; b = T.b;
            Color m = T.mau;
            x = 0; y = b;
            int A, B;
            A = a * a;
            B = b * b;
            double p = B + A / 4 - A * b;
            x = 0;
            y = b;
            int Dx = 0;
            int Dy = 2 * A * y;
            put4pitxel(x, y, cx, cy, m, panel);

            while (Dx < Dy)
            {
                x++;
                Dx += 2 * B;
                if (p < 0)
                    p += B + Dx;
                else
                {
                    y--;
                    Dy -= 2 * A;
                    p += B + Dx - Dy;
                }
                putcolor1(round(x), round(y), cx, cy, m, panel);
                if (x % 5 == 0) put4pitxel(x, round(y), cx, cy, m, panel);


            }
            p = Math.Round(B * (x + 0.5f) * (x + 0.5f) + A * (y - 1) * (y - 1) - A * B);
            while (y > 0)
            {
                y--;
                Dy -= A * 2;
                if (p > 0)
                    p += A - Dy;
                else
                {
                    x++;
                    Dx += B * 2;
                    p += A - Dy + Dx;
                }
                putcolor1(round(x), round(y), cx, cy, m, panel);
                if (x % 5 == 0) put4pitxel(x, round(y), cx, cy, m, panel);

            }
        }
        public void putcolor1(int x, int y, int cx, int cy, Color m, Panel panel)
        {
            putpixel(x + cx, y + cy, m, panel);
            putpixel(-x + cx, y + cy, m, panel);
            putpixel(x + cx, -y + cy, m, panel);
            putpixel(-x + cx, -y + cy, m, panel);
        }
    }

}
