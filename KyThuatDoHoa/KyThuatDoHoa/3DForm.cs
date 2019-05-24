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
            ad.heToaDo3D(HeToaDo3D);
        }

        private void _3DForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)            // enter x, y, z, radius,  draw sphere
        {
            AppSphere ash = new AppSphere();
            ash.Radius = Convert.ToInt32(r.Text);
            ash.draw(HeToaDo3D);

        }

        private void button1_Click(object sender, EventArgs e)   // enter point, radius, height, draw cylinder
        {
            AppRectangular ar = new AppRectangular();
            ar.Dx = Convert.ToInt32(dx.Text);
            ar.Dy = Convert.ToInt32(dy.Text); 
            ar.Dz = Convert.ToInt32(dz.Text);
            ar.Draw(HeToaDo3D);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HeToaDo3D.Refresh();
            dx.Text = "";
            dy.Text = "";
            dz.Text = "";
            r.Text = "";

        }
    }
}
