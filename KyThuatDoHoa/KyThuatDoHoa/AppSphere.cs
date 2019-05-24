using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace KyThuatDoHoa
{
   public class AppSphere
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
        public AppSphere(int r)
        {
            radius = r;
        }
        
        public void draw(Panel panel)
        {
            // circle
            AppCircle ac = new AppCircle();
            ac.Radius = this.Radius;
            ac.draw(panel);

            //Radius
            AppLine ap = new AppLine(new Point(0,0),new Point(this.Radius,0), Color.DarkGreen);
            ap.draw(panel);

            //Eclip
            AppEllipse ae = new AppEllipse(new Point(0, 0), this.Radius, this.Radius / 2,Color.DarkGreen);
            ae.draw(panel);

        }



    }
}
