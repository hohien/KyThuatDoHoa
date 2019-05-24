using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace KyThuatDoHoa
{
   
    class AppRectangular
    {
        private int dx;
        private int dy;
        private int dz;

        public int Dx { get => dx; set => dx = value; }
        public int Dy { get => dy; set => dy = value; }
        public int Dz { get => dz; set => dz = value; }

        public AppRectangular()
        {

        }

        public AppRectangular(int dx,int dy, int dz)
        {
            this.dx = dx;
            this.dy = dy;
            this.Dz = dz;
        }

        public void Draw(Panel panel)
        {
            //x
            //dut
            AppLine alx = new AppLine(new Point(0,0), new Point(dx,0), Color.DarkGreen);
            alx.draw2(panel);
            //z
            AppLine alz = new AppLine(new Point(0, 0), new Point(-dz, -dz), Color.DarkGreen);
            alz.draw2(panel);
            //lien
            alz = new AppLine(new Point(-dz, -dz), new Point(-dz + dx, -dz), Color.DarkGreen);
            alz.draw(panel);
            alz = new AppLine(new Point(dx, 0), new Point(-dz + dx, -dz), Color.DarkGreen);
            alz.draw(panel);



            // Ben hong
            //dut
            AppLine aly = new AppLine(new Point(0, 0), new Point(0, dy), Color.DarkGreen);
            aly.draw2(panel);
            //lien
            alz = new AppLine(new Point(-dz, -dz), new Point(-dz, -dz+dy), Color.DarkGreen);
            alz.draw(panel);

            alz = new AppLine(new Point(-dz+dx, -dz), new Point(-dz + dx, -dz+dy), Color.DarkGreen);
            alz.draw(panel);

            alz = new AppLine(new Point(dx, 0), new Point(dx, dy), Color.DarkGreen);
            alz.draw(panel);


            // Day tren
            alz = new AppLine(new Point(-dz, -dz+dy), new Point(0,dy), Color.DarkGreen);
            alz.draw(panel);

            alz = new AppLine(new Point(-dz+dx, -dz+dy), new Point(dx, dy), Color.DarkGreen);
            alz.draw(panel);

            alz = new AppLine(new Point(-dz, -dz+dy), new Point(-dz+dx,-dz+dy), Color.DarkGreen);
            alz.draw(panel);

            alz = new AppLine(new Point(0, dy), new Point(dx,dy), Color.DarkGreen);
            alz.draw(panel);

        }



    }
}
