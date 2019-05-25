using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace KyThuatDoHoa
{
    public class AppTruck : AppShape
    {
        private AppCircle wheel1, wheel2;
        private bool isAnimating = false;
        private AppRectangle background, container, head, headWindow;
        private AppLine lw1, lw2, lw3, lw4;
        private SynchronizationContext context;
        private IAppTruckListener appTruckListener;

        public IAppTruckListener AppTruckListener { get => appTruckListener; set => appTruckListener = value; }

        public AppTruck()
        {
            context = SynchronizationContext.Current;

            background = new AppRectangle(new Point(-350, 130), new Point(350, 130), new Point(350, -130), new Point(-350, -130), Color.LightBlue);

            // head = new AppRectangle(new Point(-350, 130), new Point(350, 130), new Point(350, -130), new Point(-350, -130), Color.LightBlue);
            wheel1 = new AppCircle(24, new Point(-300, -50), Color.Gray);
            wheel2 = new AppCircle(24, new Point(-150, -50), Color.Gray);

            container = new AppRectangle(new Point(-340, 50), new Point(-105, 50), new Point(-105, -50), new Point(-340, -50), Color.Black);
            head = new AppRectangle(new Point(-105, 15), new Point(-30, 15), new Point(-30, -50), new Point(-105, -50), Color.Black);
            headWindow = new AppRectangle(new Point(-90, 0), new Point(-50, 0), new Point(-50, -30), new Point(-90, -30), Color.Gray);

            lw1 = new AppLine(new Point(-300,-30), new Point(-300,-70), Color.White);
            lw2 = new AppLine(new Point(-320, -50), new Point(-280, -50), Color.White);

            lw3 = new AppLine(new Point(-150, -30), new Point(-150, -70), Color.White);
            lw4 = new AppLine(new Point(-170, -50), new Point(-130, -50), Color.White);
        }


        public void startAnimate(Panel panel)
        {
            isAnimating = true;
            Thread ballT = new Thread(() => onMove(panel));
            Thread s = new Thread(this.playSoundTruck);
            s.Start();
            ballT.Start();
        }
        public void playSoundTruck()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.truck);

            sound.PlaySync();
        }

        public override void draw(Panel panel)
        {

            fillbackground(panel);
            container.draw(panel);
            head.draw(panel);
 
            headWindow.draw(panel);
            headWindow.fill(panel);

            wheel1.draw(panel);
            wheel1.fill(panel);
           

            wheel2.draw(panel);
            wheel2.fill(panel);

            lw1.draw(panel);
            lw2.draw(panel);
            lw3.draw(panel);
            lw4.draw(panel);
        }
        public void onRotateWheel(Panel panel, AppLine l1, AppLine l2)
        {

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
                context.Send((object state) => {
                    if (appTruckListener != null) appTruckListener.onTruckChangePosition(toString());
                }, null);
                count++;
                if (count == 35)
                {
                    break;
                }
                
                clean(panel);
                tinhtien(panel, dx, dy);
                onRotateWheel(panel, lw1, lw2, wheel1.Point, 15);
                onRotateWheel(panel, lw3, lw4, wheel2.Point, 15);

                Thread.Sleep(400);
            }

        }
        public void onRotateWheel(Panel panel, AppLine l1, AppLine l2, Point p, int hsg)
        {
            l1.rotate(panel, p, hsg);
            l2.rotate(panel, p, hsg);
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

            headWindow.tinhtien(panel, dx, dy);
            headWindow.fill(panel);
            
            // container.fill(panel);
            wheel1.fill(panel);
            wheel2.fill(panel);

            lw1.tinhtien(panel, dx, dy);
            lw2.tinhtien(panel, dx, dy);


            lw3.tinhtien(panel, dx, dy);
            lw4.tinhtien(panel, dx, dy);
        }

        public void clean(Panel panel)
        {
            background.fill(panel);
        }

        public String toString()
        {
            String result = "";
            String bg = "Background:\n";
            bg += "\t" + background.toString();

            result += bg;

            String circle1 = "Wheel 1 circle :\n";
            circle1 += "\t" + this.wheel1.toString();
            result += circle1;

            String circle2 = "Wheel 2 circle:\n";
            circle2 += "\t" + this.wheel1.toString();
            result += circle2;

            String container = "Container rectangle:\n";
            container += this.container.toString();

            result += container;

            String head = "head rectangle:\n";
            head += this.head.toString();

            result += head;

            String l1 = "Wheel 1 Line 1:"+"\n";
            l1 += lw1.toString();

            result += l1;

            String l2 = "Wheel 1 Line 2:" + "\n";
            l2 += lw2.toString();

            result += l2;

            String l3 = "Wheel 2 Line 1:" + "\n";
            l3 += lw3.toString();

            result += l3;

            String l4 = "Wheel 2 Line 2:" + "\n";
            l4 += lw4.toString();

            result += l4;

            String window = "Window:\n";
            window += this.headWindow.toString();

            result += window;
            return result;
        }
    }
}
