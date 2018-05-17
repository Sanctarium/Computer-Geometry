using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //First();
            Second();
            Console.ReadKey();
        }
        public static void First()
        {
            //генерация массива отрезков
            int n = 4, maxCount = 0, count = 0;
            string numbers="", maxNumbers="";
            Line line = new Line(0, 0, 0, 0), maxLine = new Line(0, 0, 0, 0);
            Line[] lines = new Line[n];
            Random r = new Random();
            lines[0] = new Line(-2, 2, -2, 6);
            lines[1] = new Line(-1, 7, 5, 7);
            lines[2] = new Line(6, 6, 6, 2);
            lines[3] = new Line(5, 1, -1, 1);
            //for (int i = 0; i < n; i++)
            //{
            //    lines[i] = new Line(r.Next(1, n + 1), r.Next(1, n + 1), r.Next(1, n + 1), r.Next(1, n + 1));
            //    Console.WriteLine("{0}. ({1},{2}) ({3},{4})", i, lines[i].p1.x, lines[i].p1.y, lines[i].p2.x, lines[i].p2.y);
            //}

            for (int i = 0; i < 100000; i++)
            {
                line.p1.x = r.Next(-100, 100);
                line.p1.y = r.Next(-100, 100);
                line.p2.x = r.Next(-100, 100);
                line.p2.y = r.Next(-100, 100);
                for (int j = 0; j < lines.Length; j++)
                {
                    if (lines[j].IsCross(line.p1, line.p2))
                    {
                        count++;
                        numbers += j + " ";
                    }
                }
                if (maxCount < count)
                {
                    maxCount = count;
                    maxLine.p1.x = line.p1.x;
                    maxLine.p1.y = line.p1.y;
                    maxLine.p2.x = line.p2.x;
                    maxLine.p2.y = line.p2.y;
                    maxNumbers = (String)numbers.Clone();
                }
                numbers = "";
                count = 0;
            }

            Console.WriteLine("Прямая, имеющая общие точки с максимальным числом отрезков:\n" + GetLineString(maxLine.p1, maxLine.p2));
            Console.Write("Номера пересекаемых отрезков: "+maxNumbers);
        }
        static string GetLineString(Point p1, Point p2)
        {
            int a = p2.y - p1.y;
            int b = p1.x - p2.x;
            int c = (p1.y * p2.x - p1.x * p2.y);
            return a + "x + " + b + "y + " + c + "= 0";
        }

        public static void Second()
        {
            //input
            Console.WriteLine("Количество точек:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Точки:");
            int[] coords = new int[n];
            for (int i = 0; i < n; i++)
            {
                coords[i] = int.Parse(Console.ReadLine());
            }
            //ready
            Array.Sort(coords);
            if(coords.Length%2 == 1)
            {
                Console.WriteLine("Искомая точка:" + coords[coords.Length / 2]);
                return;
            }
            else
            {
                int p1 = coords[coords.Length / 2], p2 = coords[coords.Length / 2 - 1];
                double answer = (p1 + p2) / 2;
                Console.WriteLine("Искомая точка:" + answer);
                return;
            }
        }
    }

    class Line
    {
        public Point p1 { get; set; }
        public Point p2 { get; set; }

        public Line(int x1, int y1, int x2, int y2)
        {
            p1 = new Point(x1, y1);
            p2 = new Point(x2, y2);
        }
        static int GetZ(Point v1, Point v2)
        {
            return v1.x * v2.y - v2.x * v1.y;
        }
        static Point GetVectorCoords(Point p1, Point p2)
        {
            return new Point(p1.x - p2.x, p1.y - p2.y);
        }
        public bool IsCross(Point p3, Point p4)
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
        static bool CheckPointEdge(int x, int y, int x1, int y1, int x2, int y2)
        {
            double a = (x - x1) * (y2 - y1);
            double b = (y - y1) * (x2 - x1);
            if ((a == b) &&
                (((x >= x1 && x <= x2) || (x >= x2 && x <= x1)) && ((y >= y1 && y <= y2) || (y >= y2 && y <= y1))))
                return true;
            return false;
        }
    }
}
