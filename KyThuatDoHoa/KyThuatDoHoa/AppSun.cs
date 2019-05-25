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
    public class AppSun : AppShape
    {
        private AppCircle sun;
        private bool isAnimating = false;
        private IAppSunListener appSunListener;

        private SynchronizationContext context;

        public IAppSunListener AppSunListener { get => appSunListener; set => appSunListener = value; }

        public AppSun()
        {
            context = SynchronizationContext.Current;
            sun = new AppCircle(30, new Point(-260, 130), Color.Yellow);
        }
        public void onMove(Panel panel)
        {
            int dx = 10;
            int dy = 0;
            int count = 0;
     
            while (isAnimating)
            {

                context.Send((object state) => {
                    if (appSunListener != null) appSunListener.onSunChangePostition(toString());
                }, null);
                count++;
                if (count > 56)
                {
                    count = 0;
                    clean(panel);
                    sun.Point = new Point(-260, 130);
                } 
                
                clean(panel);
                tinhtien(panel, dx, dy);
                sun.fill(panel);
               
                
                Thread.Sleep(500);
            }

        }
        public void clean(Panel p)
        {
            Color c= sun.Color;
            sun.Color = Color.LightBlue;
            sun.draw(p);
            sun.fill(p);

            sun.Color = c;

        }
        public void startAnimate(Panel panel)
        {
            isAnimating = true;

            Thread thread1 = new Thread(() => onMove(panel));
         
            thread1.Start();
        }

        public override void draw(Panel panel)
        {
            sun.draw(panel);
            sun.fill(panel);
        }

        public override void rotate(Panel panel, Point p, int hsg)
        {
            throw new NotImplementedException();
        }
        public void fillbackground(Panel panel)
        {
            
        }
        

        public void onStopAnimate()
        {
            isAnimating = false;
        }

        public override void tinhtien(Panel panel, int dx, int dy)
        {
            sun.tinhtien(panel, dx, dy);
        }

        public String toString()
        {
            return "Sun circle: " + "\n" + "\t" + sun.toString();
        }
    }


}
