using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void second()
        {

            Point[] points;
            int n = points.Length;
            double firstsumm = 0;
            for (int i = 0; i < n - 1; i++)
            {
                firstsumm += points[i].x * points[i + 1].y;
            }
            double secondsumm = 0;
            for (int i = 0; i < n - 1; i++)
            {
                secondsumm += points[i + 1].x * points[i].y;
            }
            double square = 0.5 * Math.Abs(firstsumm + points[n - 1].x * points[0].y - secondsumm - points[1].x * points[n - 1].y);
            Console.WriteLine("Площадь данного многоугольника равна " + square);
        }
        static void third()
        {
            Point[] points;
            int n = points.Length;
            bool check = true;
            double lastsign;
            Point ab = new Point
                    (
                    points[1].x - points[0].x,
                    points[1].y - points[0].y);
            Point bc = new Point
                (
                points[2].x - points[1].x,
                points[2].y - points[1].y);
            double prod = ab.x * bc.y - ab.y * bc.x;
            lastsign = prod / Math.Abs(prod);
            ab = new Point
                    (
                    points[n - 2].x - points[n - 3].x,
                    points[n - 2].y - points[n - 3].y);
            bc = new Point
            (
            points[n - 1].x - points[n - 2].x,
            points[n - 1].y - points[n - 2].y);
            prod = ab.x * bc.y - ab.y * bc.x;
            if (prod / Math.Abs(prod) != lastsign)
                check = false;

            for (int i = 2; i < n - 2; i++)
            {
                ab = new Point
                    (
                    points[i].x - points[i - 1].x,
                    points[i].y - points[i - 1].y);
                bc = new Point
                (
                points[i + 1].x - points[i].x,
                points[i + 1].y - points[i].y);
                prod = ab.x * bc.y - ab.y * bc.x;
                if (prod / Math.Abs(prod) != lastsign)
                {
                    check = false;
                    break;
                }
            }
            if (check)
                Console.WriteLine("Многоугольник выпуклый");
            else
                Console.WriteLine("Многоугольник не выпуклый");

        }
    }
}
