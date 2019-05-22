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
        public AppSun()
        {
            sun = new AppCircle(30, new Point(-200, 140), Color.GreenYellow);
        }
        public void onMove(Panel panel)
        {
            AlgorithmDraws ad = new AlgorithmDraws();
            
           
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
    }


}
