using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa
{
    public interface IAppClockListener
    {
        void onChangePostion(String inforChange);
    }
}
