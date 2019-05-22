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
    class AppXe: AppShape
    {
        private AppRectangle background;
        private bool isAnimating = false;
        private int s;
        public AppXe()
        {
            background = new AppRectangle(new Point(-50,50), new Point(50,50), new Point(50,-50),new Point(-50,-50), Color.Black);
        }

        public void startAnimate(Panel panel)
        {
            isAnimating = true;


        }

        public override void draw(Panel panel)
        {
            background.draw(panel);
            background.fill(panel);
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
