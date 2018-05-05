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
            first();
            Console.ReadKey();
        }
        static void first()
        {
            Point[] points = InputPoints("input.txt");
            Point p1, p2, p3, p1_2;
            for (int k = 0; k < points.Length - 1; k++)
            {
                p1 = points[k];
                p1_2 = points[k + 1];
                for (int i = 0, j = i + 1; i <= points.Length - 2 && j <= points.Length - 1; i++, j++)
                {
                    if (i == k - 1 || i == k || j == k || i == k + 1) continue;
                    p2 = points[i];
                    p3 = points[j];
                    if (IsCross(p1, p1_2, p2, p3))
                    {
                        Console.WriteLine("Есть пересечение. Не простой");
                        return;
                    }
                }
            }
            p1 = points[points.Length - 3];
            p1_2 = points[points.Length - 2];
            p2 = points[points.Length-1];
            p3 = points[0];
            if (IsCross(p1, p1_2, p2, p3))
            {
                Console.WriteLine("Есть пересечение. Не простой");
                return;
            }
            Console.WriteLine("Нет пересечений. Простой");


            //8
            //2 1
            //1 3
            //1 6
            //3 2
            //4 2
            //6 6
            //6 3
            //5 1

            //9
            //1 3
            //0 4
            //2 6
            //3 5
            //5 7
            //5 3
            //3 3
            //4 1
            //3 0
        }
        static Point GetVectorCoords(Point p1, Point p2)
        {
            return new Point(p1.x - p2.x, p1.y - p2.y);
        }
        static Point[] InputPoints(string path)
        {
            string[] input = File.ReadAllLines("input.txt");
            Point[] points = new Point[int.Parse(input[0])];
            string[] temp;
            for (int i = 0, j = 1; i < points.Length; i++, j++)
            {
                temp = input[j].Split();
                points[i] = new Point(int.Parse(temp[0]), int.Parse(temp[1]));
            }
            return points;
        }
        static int GetZ(Point v1, Point v2)
        {
            return v1.x * v2.y - v2.x * v1.y;
        }
        static bool IsCross(Point p1, Point p2, Point p3, Point p4)
        {
            Point v = GetVectorCoords(p1, p2);
            Point v1 = GetVectorCoords(p1, p3);
            Point v2 = GetVectorCoords(p1, p4);
            int z1 = GetZ(v, v1);
            int z2 = GetZ(v, v2);
            if (z1 * z2 > 0) return false;
            v = GetVectorCoords(p3, p4);
            v1 = GetVectorCoords(p3, p1);
            v2 = GetVectorCoords(p3, p2);
            z1 = GetZ(v, v1);
            z2 = GetZ(v, v2);
            if (z1 * z2 > 0) return false;
            return true;
        }

        static void second()
        {

            Point[] points = InputPoints("input.txt");
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
            Point[] points = InputPoints("input.txt");
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
