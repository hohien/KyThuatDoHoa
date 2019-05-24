using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyThuatDoHoa
{
    public partial class _3DForm : Form
    {
        public _3DForm()
        {
            InitializeComponent();
        }

        private void HeToaDo3D_Paint_1(object sender, PaintEventArgs e)
        {
            AlgorithmDraws ad = new AlgorithmDraws();
            ad.trucToaDo3D(HeToaDo3D);
        }

        private void _3DForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)            // enter x, y, z, radius,  draw sphere
        {
            AppSphere demo = new AppSphere(new AppPoint3D(100, 100, 100), 50);
            demo.draw1(HeToaDo3D);
            demo.draw2(HeToaDo3D);
        }

        private void button1_Click(object sender, EventArgs e)   // enter point, radius, height, draw cylinder
        {

        }
    }
}
