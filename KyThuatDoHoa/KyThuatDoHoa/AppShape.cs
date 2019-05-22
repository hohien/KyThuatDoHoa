using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace KyThuatDoHoa
{
    public abstract class AppShape
    {
        public abstract void draw(Panel panel);
        public abstract void rotate(Panel panel, Point p, int hsg);



    }
}
