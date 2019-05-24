using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace KyThuatDoHoa
{
    public partial class MenuFormMain : Form
    {

        AppClock pinwheel;
        AppSun appSun;

        public MenuFormMain()
        {
            InitializeComponent();
        }

        private void HeToaDo_Paint(object sender, PaintEventArgs e)
        {
            AlgorithmDraws ad = new AlgorithmDraws();
            ad.heToaDo(HeToaDo);
        }

        private void MenuFormMain_Load(object sender, EventArgs e)
        {

        }


        //btnLine
        private void button1_Click(object sender, EventArgs e)
        {
            if (pinwheel != null) pinwheel.onStopAnimate(); 
            pinwheel = new AppClock();
            pinwheel.draw(HeToaDo);
            appSun = new AppSun();
            appSun.draw(HeToaDo);
        }
        AppTruck truck;

        private void Coach_Click(object sender, EventArgs e)
        {
            if (truck != null) truck.onStopAnimate();
            truck = new AppTruck();
            //body
            truck.draw(HeToaDo);
            

        }

        //btn Quay
        private void button2_Click(object sender, EventArgs e)
        {
            //background
            if (pinwheel != null) pinwheel.startAnimate(HeToaDo);
            if (appSun != null) appSun.startAnimate(HeToaDo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pinwheel != null) pinwheel.onStopAnimate();
           
            if (appSun != null) appSun.onStopAnimate();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (truck != null)
                truck.startAnimate(HeToaDo);
        }

        private void btnLine_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Clear 
            HeToaDo.Refresh();

        }

        private void button6_Click(object sender, EventArgs e)
        {
           if (truck!=null) truck.onStopAnimate();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            new _3DForm().Show();
        }
    }
}