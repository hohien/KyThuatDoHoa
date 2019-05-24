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

        AppClock pinwheel = new AppClock();
        AppSun appSun = new AppSun(); 

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
            pinwheel.draw(HeToaDo);
            appSun.draw(HeToaDo);
        }
        AppTruck truck = new AppTruck();

    private void Coach_Click(object sender, EventArgs e)
    {
            //body
            truck.draw(HeToaDo);
    }

    //btn Quay
    private void button2_Click(object sender, EventArgs e)
    {
            //AppLine.work = true;
            AppLine line = new AppLine(new Point(0, 0), new Point(0, 50), Color.DarkGreen);
            //line1
            line.draw(HeToaDo);
            //background
            pinwheel.startAnimate(HeToaDo);
            appSun.startAnimate(HeToaDo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pinwheel.onStopAnimate();
            truck.onStopAnimate();
            appSun.onStopAnimate();
        }
        private void button3_Click(object sender, EventArgs e)
        {

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
            truck.onStopAnimate();
        }
    }
 }