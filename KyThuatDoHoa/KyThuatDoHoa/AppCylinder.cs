using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa
{
    class AppCylinder
    {
        private AppPoint3D p;
        private int radius, height;

        
        internal AppPoint3D P { get => p; set => p = value; }
        public int Radius { get => radius; set => radius = value; }
        public int Height { get => height; set => height = value; }

        public AppCylinder()
        {
            p = new AppPoint3D(0,0,0);
            radius = 100;
            height = 50;
        }
        public AppCylinder(AppPoint3D point, int r, int h)
        {
            p = point;
            radius = r;
            height = h;
        }
    }
}
