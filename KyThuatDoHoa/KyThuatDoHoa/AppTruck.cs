using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace KyThuatDoHoa
{
    public class AppTruck : AppShape
    {
        private AppTruck t;
        private Point p1;
        private Point p2;
        private Point p3;
        private Point p4;
        private Point p5;
        private Point p6;
        private Point p7;
        private Point p8;
        private Point p9;
        private Point p10;
        private Color color = Color.DarkGreen;
        private Color colorwheel= Color.Black;
        private bool isAnimating = false;

        public Point P1 { get => p1; set => p1 = value; }
        public Point P2 { get => p2; set => p2 = value; }
        public Point P3 { get => p3; set => p3 = value; }
        public Point P4 { get => p4; set => p4 = value; }
        public Point P5 { get => p5; set => p5 = value; }
        public Point P6 { get => p6; set => p6 = value; }
        public Point P7 { get => p7; set => p7 = value; }
        public Point P8 { get => p8; set => p8 = value; }
        public Point P9 { get => p9; set => p9 = value; }
        public Point P10 { get => p10; set => p10 = value; }
        public Color Color { get => color; set => color = value; }
        public Color Colorwheel { get => colorwheel; set => colorwheel = value; }

        public AppTruck()
        {
            t = new AppTruck(new Point(-140, 100), new Point(0, 100), new Point(0, 20), new Point(-140, 20), new Point(0, 60), new Point(40, 60), new Point(40, 20), new Point(0, 20), new Point(-35, 20), new Point(-105, 20));
        }
        public AppTruck(Point p1, Point p2, Point p3, Point p4, Point p5, Point p6, Point p7, Point p8, Point p9, Point p10)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
            this.p6 = p6;
            this.p7 = p7;
            this.p8 = p8;
            this.p9 = p9;
            this.p10 = p10;
        }

        public void startAnimate(Panel panel)
        {
            isAnimating = true;
            Thread thread = new Thread(() => tinhtientruck(panel, t, new Point(-140, 100), new Point(0, 100), new Point(0, 20), new Point(-140, 20), new Point(0, 60), new Point(40, 60), new Point(40, 20), new Point(0, 20), new Point(-35, 20), new Point(-105, 20),10,0));
            thread.Start();
        }

        public override void draw(Panel panel)
        {
            fillbackground(panel);
            //Rectangle body
             AppRectangle rectangle = new AppRectangle(p1, p2, p3, p4, color);
            rectangle.draw(panel);
            //Rectangle cabin
            rectangle = new AppRectangle(p5, p6, p7, p8, color);
            rectangle.draw(panel);
            //circle wheel 
            AppCircle circle = new AppCircle(10,p9,colorwheel);
            circle.draw(panel);
            circle = new AppCircle(10, p10, colorwheel);
            circle.draw(panel);
        }
        public void draw1(Panel panel)
        {
            //Rectangle body
            AppRectangle rectangle = new AppRectangle(p1, p2, p3, p4, color);
            rectangle.draw(panel);
            //Rectangle cabin
            rectangle = new AppRectangle(p5, p6, p7, p8, color);
            rectangle.draw(panel);
            //circle wheel 
            AppCircle circle = new AppCircle(10, p9, colorwheel);
            circle.draw(panel);
            circle = new AppCircle(10, p10, colorwheel);
            circle.draw(panel);
        }

        public override void rotate(Panel panel, Point p, int hsg)
        {
            throw new NotImplementedException();
        }
        public void fillbackground(Panel panel)
        {
            Point A = new Point(-200, 0);
            Point B = new Point(300, 0);
            AppLine dt1;
            for (int i = 0; A.Y <=110; i++)
            {
                dt1 = new AppLine(A, B, Color.LightBlue);
                dt1.draw(panel);
                A.Y++;
                B.Y++;

            }
        }
       
       public void tinh_tien(Panel panel,AppTruck r, Point p1, Point p2, Point p3, Point p4, int dx, int dy)
        {
            while (true)
            {
                r.Color = Color.LightBlue;
                r.draw(panel);

                r.tinhtien(panel, p1, p2, p3, p4, dx, dy);
                dx = dx+5;
                Thread.Sleep(1000);
            }
            
        }

        public void onStopAnimate()
        {
            isAnimating = false;
        }

        public override void tinhtien(Panel panel, Point p1, Point p2, Point p3, Point p4, int dx, int dy)
        {
            throw new NotImplementedException();
        }

        public void tinhtientruck(Panel panel,AppTruck t, Point p1, Point p2, Point p3, Point p4, Point p5, Point p6, Point p7, Point p8, Point p9, Point p10, int dx, int dy)
        {
            int d = 10;
            while (true)
            {
                
                //delete truck
                t.color = Color.LightBlue;
                t.colorwheel = Color.LightBlue;
                t.draw1(panel);

                AlgorithmDraws ad = new AlgorithmDraws();
                t.color = Color.DarkGreen;
                t.colorwheel = Color.Black;
                t.p1 = ad.Tinhtien(p1, dx, dy);
                t.p2 = ad.Tinhtien(p2, dx, dy);
                t.p3 = ad.Tinhtien(p3, dx, dy);
                t.p4 = ad.Tinhtien(p4, dx, dy);
                t.p5 = ad.Tinhtien(p5, dx, dy);
                t.p6 = ad.Tinhtien(p6, dx, dy);
                t.p7 = ad.Tinhtien(p7, dx, dy);
                t.p8 = ad.Tinhtien(p8, dx, dy);
                t.p9 = ad.Tinhtien(p9, dx, dy);
                t.p10 = ad.Tinhtien(p10, dx, dy);
                t.draw1(panel);
                if (dx >= 100)
                {
                    d = -10;
                }

                if (dx <= -60) {
                    d = 10;
                }
                dx += d;
                

                Thread.Sleep(1000);
            }
            

        }
    }
    
  
}
