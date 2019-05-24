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
        private AppCircle wheel1, wheel2;
        private bool isAnimating = false;
        private AppRectangle background, container, head;
        public AppTruck()
        {
            background = new AppRectangle(new Point(-350, 130), new Point(350, 130), new Point(350, -130), new Point(-350, -130), Color.LightBlue);

            // head = new AppRectangle(new Point(-350, 130), new Point(350, 130), new Point(350, -130), new Point(-350, -130), Color.LightBlue);
            wheel1 = new AppCircle(24, new Point(-300, -50), Color.Gray);
            wheel2 = new AppCircle(24, new Point(-150, -50), Color.Gray);

            container = new AppRectangle(new Point(-340,50), new Point(-105,50), new Point(-105,-50), new Point(-340,-50), Color.Black);
            head = new AppRectangle(new Point(-105, 10), new Point(-30, 10), new Point(-30, -50), new Point(-105, -50), Color.Black);

        }


        public void startAnimate(Panel panel)
        {
            isAnimating = true;
            Thread ballT = new Thread(() =>  onMove(panel) );
            ballT.Start();
        }

        public override void draw(Panel panel)
        {
            
            fillbackground(panel);
            container.draw(panel);
            head.draw(panel);

            wheel1.draw(panel);
            wheel1.fill(panel);

            wheel2.draw(panel);
            wheel2.fill(panel);

            wheel1.fill(panel);
        }
     
        public override void rotate(Panel panel, Point p, int hsg)
        {
            throw new NotImplementedException();
        }
        public void fillbackground(Panel panel)
        {
            background.draw(panel);
            background.fill(panel);
        }
       
       public void onMove(Panel panel)
        {
            Color color;
            AlgorithmDraws ad = new AlgorithmDraws();
            int dx = 10;
            int dy = 0;
            int count = 0;
            while (isAnimating)
            {
                count++;
                if (count == 35)
                {
                    break;
                }
                      ;
                clean(panel);
                tinhtien(panel,dx, dy );
              
                Thread.Sleep(10);
            }
            
        }

        public void onStopAnimate()
        {
            isAnimating = false;
        }

        public override void tinhtien(Panel panel, int dx, int dy)
        {
            head.tinhtien(panel, dx, dy);
            container.tinhtien(panel, dx, dy);
            wheel1.tinhtien(panel, dx, dy);
            wheel2.tinhtien(panel, dx, dy);

            head.fill(panel);
            container.fill(panel);
            wheel1.fill(panel);
            wheel2.fill(panel);
        }

        public void clean(Panel panel)
        {
            background.fill(panel);
        }
        
        }
    }
