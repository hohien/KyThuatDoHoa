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
    public class AppClock : AppShape
    {
        private AppLine l1, l2;
        private bool isAnimating = false;
        private int s;
        public AppClock()
        {
            l1 = new AppLine(new Point(0, 0), new Point(0, 51), Color.Black);
            l2 = new AppLine(new Point(0, 0), new Point(0, 51), Color.Gray);
        }

        public void startAnimate(Panel panel)
        {
            isAnimating = true;

            Thread thread1 = new Thread(() => onRotateH(panel, l1, new Point(0, 0), 30, Color.LightBlue, 1000));
            Thread thread2 = new Thread(() => onRotateS(panel, l2, new Point(0, 0), 15, Color.LightBlue, 1000));
            thread2.Start();
            thread1.Start();
        }

        public override void draw(Panel panel)
        {
           
            //circle
            AppShape circle = new AppCircle(58, new Point(0, 0), Color.DarkGreen);
            circle.draw(panel);

            //Triangle
            AppShape triangle = new AppTriangle(new Point(0, -58), new Point(50, -158), new Point(-50, -158), Color.DarkGreen);
            triangle.draw(panel);

            fillbackground(panel);
            l1.draw(panel);
            l2.draw(panel);

            Graphics grfx = panel.CreateGraphics();
            Font drawFont = new Font("Arial", 10,FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            AlgorithmDraws ad = new AlgorithmDraws();
            grfx.DrawString("12", drawFont, drawBrush, ad.convertPoint(new Point(-10, 70)));
            grfx.DrawString("3", drawFont, drawBrush, ad.convertPoint(new Point(65, 10)));
            grfx.DrawString("6", drawFont, drawBrush, ad.convertPoint(new Point(-5,-65)));
            grfx.DrawString("9", drawFont, drawBrush, ad.convertPoint(new Point(-70, 10)));
        }

        public override void rotate(Panel panel, Point p, int hsg)
        {
            throw new NotImplementedException();
        }
        public void fillbackground(Panel panel)
        {
            Point A = new Point(0, 0);
            Point B = new Point(0, 51);
            AppLine dt1 = new AppLine(A, B, Color.LightBlue);

            for (int i = 0; i <= 63; i++)
            {
                dt1.rotate(panel, A, 5);
            }
        }
        public void onRotateH(Panel panel, AppLine target, Point p, int hsg, Color color,int time)
        {
            // SoundPlayer wake = new SoundPlayer(Properties.Resources.clockWake);
            Color col = target.Color;

            while (isAnimating)
            {
                Thread.Sleep(time);
                if (s == 24)
                {
                    s = 0;
                    target.Color = color;
                    target.draw(panel);
                    target.Color = col;
                    target.rotate(panel, p, hsg);
                    l2.draw(panel);
                }
              
               // wake.PlaySync();
            }
        }

        public void onRotateS(Panel panel, AppLine target, Point p, int hsg, Color color, int time)
        {
            Color col = target.Color;
            SoundPlayer tat = new SoundPlayer(Properties.Resources.tat); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            SoundPlayer tuc = new SoundPlayer(Properties.Resources.tuc); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            bool isTuc = true;
            while (isAnimating)
            {
                Thread.Sleep(time);
                s += 1;
                if (isTuc)
                {
                    tuc.PlaySync();
                 
                } else
                {
                    tat.PlaySync();
                }
                

                isTuc = !isTuc;
                target.Color = color;
                target.draw(panel);
                l1.draw(panel);
                target.Color = col;
               
                target.rotate(panel, p, hsg);
                
                
            }
        }

        public void onStopAnimate()
        {
            isAnimating = false;
        }
    }

  
}
