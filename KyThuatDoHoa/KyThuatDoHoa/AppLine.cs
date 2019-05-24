﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace KyThuatDoHoa
{
   public class AppLine :  AppShape
    {
        private Point point1;
        private Point point2;
        private Color color;
        private double alpha, b1;
        private int b;

        public Color Color { get => color; set => color = value; }
        public Point Point1 { get => point1; set => point1 = value; }
        public Point Point2 { get => point2; set => point2 = value; }

        public AppLine()
        {
            Point1 = new Point(0, 0);
            Point2 = new Point(0, 0);
            Color = Color.DarkGreen;
  
        }
        public AppLine(Point p1, Point p2, Color m)
        {
            Point1 = p1;
            Point2 = p2;
            Color = m;
        }

        public override void draw(Panel panel)
        {
            AlgorithmDraws al = new AlgorithmDraws();
            al.Bresenham_Line(this,panel);
        }


        public override void rotate(Panel panel, Point p, int hsg)
        {
            AlgorithmDraws ad = new AlgorithmDraws();
            point1 = ad.Quay(point1, p, hsg);
            point2 = ad.Quay(point2, p, hsg);
            this.draw(panel); 
        }

        public override void tinhtien(Panel panel, int dx, int dy)
        {
            throw new NotImplementedException();
        }

        
    }
}
