﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace KyThuatDoHoa
{
    public class AppCircle
    {
        private int radius;
        private Point point;
        private Color color;

        public int Radius { get => radius; set => radius = value; }
        public Point Point { get => point; set => point = value; }
        public Color Color { get => color; set => color = value; }

        public AppCircle()
        {
            Radius = 0;
            Point = new Point(0, 0);
            Color = Color.DarkGreen;
        }
        public AppCircle(int radius, Point point, Color color)
        {
            this.Radius = radius;
            this.Point = new Point(point.X, point.Y);
            this.Color = color;
        }
       
    }
}
