using System;

namespace PerimetrCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1);
            Point point2 = new Point(2);
            Point point3 = new Point(3);
            Point point4 = new Point(4);
            Point point5 = new Point(5);
            Polygon polygon3 = new Polygon(point1, point2, point3);
            Polygon polygon4 = new Polygon(point1, point2, point3, point4);
            Polygon polygon5 = new Polygon(point1, point2, point3, point4, point5);
            double p3 = polygon3.Perimeter();
            double p4 = polygon4.Perimeter();
            double p5 = polygon5.Perimeter();
            Console.WriteLine($"Perimeter3 = {p3}\n Perimeter4 = {p4}\n Perimeter5 = {p5}");
        }
    }
}
