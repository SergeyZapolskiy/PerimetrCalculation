﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PerimetrCalculation
{
    public class Polygon
    {
        public Polygon(Point point1, Point point2, Point point3)
        {
            PointAll.Add(point1);
            PointAll.Add(point2);
            PointAll.Add(point3);
        }

        public Polygon(Point point1, Point point2, Point point3, Point point4)
        {
            PointAll.Add(point1);
            PointAll.Add(point2);
            PointAll.Add(point3);
            PointAll.Add(point4);
        }

        public Polygon(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            PointAll.Add(point1);
            PointAll.Add(point2);
            PointAll.Add(point3);
            PointAll.Add(point4); 
            PointAll.Add(point5);
        }

        private List<Point> _pointAll = new List<Point>();

        public List<Point> PointAll
        {
            get => _pointAll;
            set => _pointAll = value;
        }

        

        public double Perimeter()
        {
            double p = 0;
            double d = 0;
            int xt = PointAll[PointAll.Count - 1].X;
            int yt = PointAll[PointAll.Count - 1].Y;
            int dx = 0;
            int dy = 0;
            foreach (var obj in PointAll)
            {
                dx = (obj.X - xt) * (obj.X - xt);
                dy = (obj.Y - yt) * (obj.Y - yt);
                xt = obj.X;
                yt = obj.Y;
                d = Math.Sqrt(dx+dy);
                p += d;
            }
            return p;
        }
    }
}
