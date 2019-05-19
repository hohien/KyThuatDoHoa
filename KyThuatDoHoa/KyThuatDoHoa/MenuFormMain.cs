using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace KyThuatDoHoa
{
    public partial class MenuFormMain : Form
    {
        public MenuFormMain()
        {
            InitializeComponent();
        }

        private void HeToaDo_Paint(object sender, PaintEventArgs e)
        {
            heToaDo();
        }
        public void heToaDo()
        {
            Graphics g = this.HeToaDo.CreateGraphics();
            // SolidBrush brush = new SolidBrush(Color.DarkSlateBlue);
            for (int i = 0; i <= 800; i++)
            {
                g.DrawLine(new Pen(Color.Gray), 5 * i, 0, 5 * i, 4000);
                g.DrawLine(new Pen(Color.Gray), 0, 5 * i, 4000, 5 * i);
            }
            g.DrawLine(new Pen(Color.Blue), 0, 180, 800, 180);
            g.DrawLine(new Pen(Color.Blue), 400, 0, 400, 400);
        }

        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        //Draw Line DDA


        private void MenuFormMain_Load(object sender, EventArgs e)
        {

        }


        //Line1
        public void Line2Quay()
        {
            /*
            Point  A = convertPoint(new Point(0, 0));
            Point B = convertPoint(new Point(0, -50));
            AppLine dt2 = new AppLine(A, B, Color.DarkGreen);
            DDA_Line(dt2);
            while (quay)
            {
                dt2 = new AppLine(A, B, Color.Blue);
                DDA_Line(dt2);                            // xoa cai cu di
                //System.Threading.Thread.Sleep(1);
                Point test;
                test = B;
                test = Quay(B, convertPoint(new Point(0, 0)),quay_lon);                // quay B quanh O
                B = test;

                dt2 = new AppLine(A, test, Color.Orange);
                DDA_Line(dt2);*/
    }
    public void Line1Quay()
    {
        /*
            Point A = convertPoint(new Point(0, 0));
            Point B = convertPoint(new Point(0, 50));
            AppLine dt2 = new AppLine(A, B, Color.DarkGreen);
            DDA_Line(dt2);
            while (quay)
            {
                dt2 = new AppLine(A, B, Color.Blue);
                DDA_Line(dt2);                            // xoa cai cu di
                //System.Threading.Thread.Sleep(1);
                Point test;
                test = B;
                test = Quay(B, convertPoint(new Point(0, 0)),quay_lon);                // quay B quanh O
                B = test;

                dt2 = new AppLine(A, test, Color.White);
                DDA_Line(dt2);
            }*/
    }

    public void Line3Quay()
    {
        /*
            Point A = convertPoint(new Point(0, 0));
            Point B = convertPoint(new Point(-50, 0));
            AppLine dt2 = new AppLine(A, B, Color.DarkGreen);
            DDA_Line(dt2);
            while (quay)
            {
                dt2 = new AppLine(A, B, Color.Blue);
                DDA_Line(dt2);                            // xoa cai cu di
                //System.Threading.Thread.Sleep(1);
                Point test;
                test = B;
                test = Quay(B, convertPoint(new Point(0, 0)),quay_lon);                // quay B quanh O
                B = test;

                dt2 = new AppLine(A, test, Color.LightPink);
                DDA_Line(dt2);
            }*/
    }
    public void Line4Quay()
    {

        /* Point A = convertPoint(new Point(0, 0));
         Point B = convertPoint(new Point(50, 0));
         AppLine dt2 = new AppLine(A, B, Color.DarkGreen);
         DDA_Line(dt2);
         while (quay)
         {
             dt2 = new AppLine(A, B, Color.Blue);
             DDA_Line(dt2);                            // xoa cai cu di
             //System.Threading.Thread.Sleep(1);
             Point test;
             test = B;
             test = Quay(B, convertPoint(new Point(0, 0)),quay_lon);                // quay B quanh O
             B = test;

             dt2 = new AppLine(A, test, Color.Yellow);
             DDA_Line(dt2);
         }*/
    }

        PinWheel pinwheel = new PinWheel();
        //btnLine
        private void button1_Click(object sender, EventArgs e)
    {
            pinwheel.draw(HeToaDo);













        /* //Thread
         Thread thread1 = new Thread(Line1Quay);
         Thread thread2 = new Thread(Line2Quay);
         Thread thread3 = new Thread(Line3Quay);
         Thread thread4 = new Thread(Line4Quay);


         //circle
         Point A = convertPoint(new Point(0, 0));
         Point B = convertPoint(new Point(50, 50));
         int bk = Math.Abs(A.X -B.X);
         AppCircle tr = new AppCircle(bk, A, Color.DarkGreen);
         Midpoint_circle(tr);

         //tamgiac

         //line1
         A = convertPoint(new Point(0, -50));
         B = convertPoint(new Point(-50, -150));
         AppLine dt = new AppLine(A, B, Color.DarkGreen);
         DDA_Line(dt);
         //line2
         A = convertPoint(new Point(0, -50));
         B = convertPoint(new Point(50, -150));
         dt = new AppLine(A, B, Color.DarkGreen);
         DDA_Line(dt);
         //line3
         A = convertPoint(new Point(-50, -150));
         B = convertPoint(new Point(50, -150));
         dt = new AppLine(A, B, Color.DarkGreen);
         DDA_Line(dt);

         //line1
         A = convertPoint(new Point(0, 0));
         B = convertPoint(new Point(0, 50));
         AppLine dt1 = new AppLine(A, B, Color.Blue);
         DDA_Line(dt1);

         A = convertPoint(new Point(0, 0));
         B = convertPoint(new Point(0, 50));
         for (int i=0;i<=63;i++)
         {
             dt1 = new AppLine(A, B, Color.Blue);
             DDA_Line(dt1);
             Point test;
             test = B;
             test = Quay(B, convertPoint(new Point(0, 0)),quay_nho);                // quay B quanh O
             B = test;

             dt1 = new AppLine(A, test, Color.Blue);
             DDA_Line(dt1);
         }

         thread1.Start();
         thread2.Start();
         thread3.Start();
         thread4.Start();

         */


    }



    public void backgroundright()
    {
        /*int x1 = 150;
        Point A = convertPoint(new Point(x1, 0));
        Point B = convertPoint(new Point(x1, 120));
        AppLine dt;
        //Background
        for (int i = x1; i >= 0; i--)
        {
            dt = new AppLine(A, B, Color.DarkGreen);
            DDA_Line(dt);
            A = convertPoint(new Point(i, 0));
            B = convertPoint(new Point(i, 120));

        }*/
    }
    public void backgroundleft()
    {
        /* int x1 = -150;
         Point A = convertPoint(new Point(x1, 0));
         Point B = convertPoint(new Point(x1, 120));
         AppLine dt;
         //Background
         for (int i = -150; i <= 0; i++)
         {
             dt = new AppLine(A, B, Color.DarkGreen);
             DDA_Line(dt);
             A = convertPoint(new Point(i, 0));
             B = convertPoint(new Point(i, 120));

         }*/
    }



    private void Coach_Click(object sender, EventArgs e)
    {

        AppShape ap = new AppRectangle(new Point(-140,100), new Point(0, 100), new Point(0, 20), new Point(-140, 20), Color.DarkGreen);
        ap.draw(HeToaDo);

        /*Thread thread1 = new Thread(backgroundleft);

        thread1.Start();
        backgroundright();
        int x1 = -150;
        Point A = convertPoint(new Point(x1, 0));
        Point B = convertPoint(new Point(x1, 120));
        AppLine dt;


        //rectangle
        //line1
        A = convertPoint(new Point(-140, 100));
        B = convertPoint(new Point(0, 100));
        dt = new AppLine(A, B, Color.Yellow);
        DDA_Line(dt);

        //line2
        A = convertPoint(new Point(-140, 20));
        B = convertPoint(new Point(0, 20));
        dt = new AppLine(A, B, Color.Yellow);
        DDA_Line(dt);

        //line3
        A = convertPoint(new Point(-140, 100));
        B = convertPoint(new Point(-140, 20));
        dt = new AppLine(A, B, Color.Yellow);
        DDA_Line(dt);

        //line4
        A = convertPoint(new Point(0, 100));
        B = convertPoint(new Point(0, 20));
        dt = new AppLine(A, B, Color.Yellow);
        DDA_Line(dt);

        //cabin
        //line1
        A = convertPoint(new Point(0, 65));
        B = convertPoint(new Point(30, 65));
        dt = new AppLine(A, B, Color.Yellow);
        DDA_Line(dt);
        //line2
        A = convertPoint(new Point(0, 20));
        B = convertPoint(new Point(30, 20));
        dt = new AppLine(A, B, Color.Yellow);
        DDA_Line(dt);
        //line3
        A = convertPoint(new Point(30, 20));
        B = convertPoint(new Point(30, 65));
        dt = new AppLine(A, B, Color.Yellow);
        DDA_Line(dt);

        //wheel
        A = convertPoint(new Point(-105, 20));
        B = convertPoint(new Point(-90, 50));
        AppCircle tr = new AppCircle(15, A, Color.Blue);
        Midpoint_circle(tr);

        A = convertPoint(new Point(-35, 20));
        tr = new AppCircle(15, A, Color.Blue);
        Midpoint_circle(tr);

*/



    }

    //btn Quay
    private void button2_Click(object sender, EventArgs e)
    {
            //AppLine.work = true;
            AppLine line = new AppLine(new Point(0, 0), new Point(0, 50), Color.DarkGreen);
            //line1
            line.draw(HeToaDo);
            //background
            pinwheel.fillbackground(HeToaDo);

            pinwheel.startAnimate(HeToaDo);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppLine.work = false;
        }
    }
 }