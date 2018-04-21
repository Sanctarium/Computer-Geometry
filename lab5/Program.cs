using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1;
using System.IO;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void first()
        {
            Point[] points = InputPoints("input.txt");
            Point p1, p1_2, p2, p3;
            for (int k = 0; k < points.Length; k++)
            {
                p1 = points[k];
                p1_2 = points[(k + 1) % points.Length];
                for (int i = k + 2; i < (k + points.Length - 2) % points.Length; i++)
                {
                    p2 = points[i];
                    for (int j = i + 1; j < (k + points.Length - 1) % points.Length; j++)
                    {
                        p3 = points[j];
                        if ((Check(p1, p2) * Check(p1, p2)) < 0)
                            Console.WriteLine("Есть пересечение. Не простой");
                        else
                            Console.WriteLine("Нет пересечений. Простой");
                    }
                }
            }
        }
        static Point[] InputPoints(string path)
        {
            string[] input = File.ReadAllLines("input.txt");
            Point[] points = new Point[int.Parse(input[0])];
            string[] temp;
            for (int i = 0, j = 1; i < points.Length; i++, j++)
            {
                temp = input[j].Split();
                points[i] = new Point(int.Parse(temp[0]), int.Parse(temp[2]));
            }
            return points;
        }
        static int Check(Point v1, Point v2)
        {
            return v1.x * v2.y - v2.x * v1.y;
        }


        static void second()
        {

            Point[] points=InputPoints("input.txt");
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
            Point[] points=InputPoints("input.txt");
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
