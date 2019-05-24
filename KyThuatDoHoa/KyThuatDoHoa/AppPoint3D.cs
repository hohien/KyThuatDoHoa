using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa
{
    class AppPoint3D
    {
        private int x, y, z;
        public AppPoint3D()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }
        public AppPoint3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }
    }
}
