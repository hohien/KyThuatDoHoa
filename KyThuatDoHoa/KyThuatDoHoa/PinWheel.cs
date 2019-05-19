using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace KyThuatDoHoa
{
    public class PinWheel : AppShape
    {
        private AppLine l1, l2, l3, l4;

        public PinWheel()
        {
            l1 = new AppLine(new Point(0, 0), new Point(0, 50), Color.Yellow);
            l2 = new AppLine(new Point(0, 0), new Point(50, 0), Color.White);
            l3 = new AppLine(new Point(0, 0), new Point(0, -50), Color.Pink);
            l4 = new AppLine(new Point(0, 0), new Point(-50, 0), Color.Purple);
        }

        public void startAnimate(Panel panel)
        {
            Thread thread1 = new Thread(() => l1.rotate2(panel,new Point(0,0),15,Color.Yellow));
            Thread thread2 = new Thread(() => l2.rotate2(panel, new Point(0, 0), 15,Color.White));
            Thread thread3 = new Thread(() => l3.rotate2(panel, new Point(0, 0), 15, Color.Pink));
            Thread thread4 = new Thread(() => l4.rotate2(panel, new Point(0, 0), 15, Color.Purple));

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();



        }
        public override void draw(Panel panel)
        {
            //circle
            AppShape circle = new AppCircle(50, new Point(0, 0), Color.DarkGreen);
            circle.draw(panel);

            //Triangle
            AppShape triangle = new AppTriangle(new Point(0, -50), new Point(50, -150), new Point(-50, -150), Color.DarkGreen);
            triangle.draw(panel);
            
            l1.draw(panel);
            l2.draw(panel);
            l3.draw(panel);
            l4.draw(panel);
        }

        public override void rotate(Panel panel, Point p, int hsg)
        {
            throw new NotImplementedException();
        }
        public void fillbackground(Panel panel)
        {
            Point A = new Point(0, 0);
            Point B = new Point(0, 50);
            AppLine dt1 = new AppLine(A, B, Color.Blue);

            for (int i = 0; i <= 63; i++)
            {
                dt1.rotate(panel, A, 5);
            }
        }

    }
}
