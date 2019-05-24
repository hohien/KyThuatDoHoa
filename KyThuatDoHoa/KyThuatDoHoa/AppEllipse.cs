using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyThuatDoHoa
{
    public class AppEllipse: AppShape
    {

        public Point point;
        public int a, b ;
        public Color mau;
        public AppEllipse(Point t, int aa, int bb, Color m)
        {
            point = t;
            a = aa; b = bb;
            mau = m;
        }

        public override void draw(Panel panel)
        {
            AlgorithmDraws ad = new AlgorithmDraws();
            ad.Midpoint_elip(this, panel);
        }

        public override void rotate(Panel panel, Point p, int hsg)
        {
            throw new NotImplementedException();
        }

        public override void tinhtien(Panel panel,  int dx, int dy)
        {
            throw new NotImplementedException();
        }

        public void fill(Panel panel)
        {
            AlgorithmDraws ad = new AlgorithmDraws();
            Point a = ad.convertPoint(point);
            Graphics g = panel.CreateGraphics();
            SolidBrush myBrush = new SolidBrush(mau);
            g = panel.CreateGraphics();
            g.FillEllipse(myBrush, new Rectangle(a.X-this.a, a.Y-this.b, this.a*2, this.b*2));
            myBrush.Dispose();
            g.Dispose();
        }
    }
}
