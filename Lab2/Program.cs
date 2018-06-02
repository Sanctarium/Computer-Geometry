using System;
using Lab1;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // First();
            //  Second();
            // Third();
            //  Fourth();

            //Fifth();
            Sixth();
            //Seventh();
            //Eighth();
            Console.ReadKey();
        }
        static void First()
        {
            Console.WriteLine("Введите координаты первой точки");
            string[] input = Console.ReadLine().Split(' ');
            Point p1 = new Point(int.Parse(input[0]), int.Parse(input[1]));
            Console.WriteLine("Введите координаты второй точки");
            input = Console.ReadLine().Split(' ');
            Point p2 = new Point(int.Parse(input[0]), int.Parse(input[1]));
            int a = p2.y - p1.y;
            int b = p1.x - p2.x;
            int c = (p1.y * p2.x - p1.x * p2.y);
            Console.WriteLine("{0}x + {1}y + {2} = 0", a, b, c);
        }
        static void Second()
        {
            Console.WriteLine("Введите координаты первой точки");
            string[] input = Console.ReadLine().Split(' ');
            Point p1 = new Point(int.Parse(input[0]), int.Parse(input[1]));
            Console.WriteLine("Введите координаты второй точки");
            input = Console.ReadLine().Split(' ');
            Point p2 = new Point(int.Parse(input[0]), int.Parse(input[1]));
            Console.WriteLine("Введите координаты третьей точки");
            input = Console.ReadLine().Split(' ');
            Point p3 = new Point(int.Parse(input[0]), int.Parse(input[1]));
            int a = p2.y - p1.y;
            int b = p1.x - p2.x;
            int new_a = b;
            int new_b = -a;
            int new_c = a * p3.y - b * p3.x;
            Console.WriteLine("{0}x + {1}y + {2} = 0", new_a, new_b, new_c);
        }
        static void Third()
        {
            Console.WriteLine("Введите коэффициенты a,b,c");
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            Console.WriteLine("Введите координаты точки");
            input = Console.ReadLine().Split(' ');
            Point p = new Point(int.Parse(input[0]), int.Parse(input[1]));
            int new_a = b;
            int new_b = -a;
            int new_c = a * p.y - b * p.x;
            Console.WriteLine("{0}x + {1}y + {2} = 0", new_a, new_b, new_c);
        }
        static void Fourth()
        {
            Console.WriteLine("Введите координаты первой точки");
            string[] input = Console.ReadLine().Split(' ');
            Point p1 = new Point(int.Parse(input[0]), int.Parse(input[1]));
            Console.WriteLine("Введите координаты второй точки");
            input = Console.ReadLine().Split(' ');
            Point p2 = new Point(int.Parse(input[0]), int.Parse(input[1]));
            int a = p2.y - p1.y;
            int b = p1.x - p2.x;
            int c = (p1.y * p2.x - p1.x * p2.y);
            Console.WriteLine("Введите расстояние");
            int range = int.Parse(Console.ReadLine());
            double new_c = range * Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) - a * p1.x - b * p1.y;
            double new_c1 = 2 * c - new_c;
            Console.WriteLine("{0}x + {1}y + {2} = 0", a, b, new_c);
            Console.WriteLine("{0}x + {1}y + {2} = 0", a, b, new_c1);

        }
        static void Fifth()
        {
            double new_c;
            double new_c1;
            Console.WriteLine("Введите коэффициенты a,b,c");
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            Console.WriteLine("Введите расстояние");
            double range = double.Parse(Console.ReadLine());
            if (a == 0 || b == 0)
            {
                new_c = c - range;
                new_c1 = c + range;
            }
            else
            {
                Point p1 = GetPointOnLine(1, a, b, c);
                new_c = range * Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) - a * p1.x - b * p1.y;
                new_c1 = 2 * c - new_c;
            }

            Console.WriteLine("{0}x + {1}y + {2} = 0", a, b, new_c);
            Console.WriteLine("{0}x + {1}y + {2} = 0", a, b, new_c1);
        }
        static Point GetPointOnLine(int x, int a, int b, int c)
        {
            return new Point(x, (a * x + c) / (-b));
        }
        static void Sixth()
        {
            Console.WriteLine("Введите координаты вершины угла");
            string[] input = Console.ReadLine().Split(' ');
            DPoint p = new DPoint(int.Parse(input[0]), int.Parse(input[1]));
            Console.WriteLine("Введите координаты первой точки");
            input = Console.ReadLine().Split(' ');
            DPoint p1 = new DPoint(int.Parse(input[0]), int.Parse(input[1]));
            Console.WriteLine("Введите координаты второй точки");
            input = Console.ReadLine().Split(' ');
            DPoint p2 = new DPoint(int.Parse(input[0]), int.Parse(input[1]));
            double r = Range(p.x, p.y, p1.x, p1.y) / Range(p.x, p.y, p2.x, p2.y);
            DPoint point = new DPoint((p1.x + r * p2.x) / (1 + r), (p1.y + r * p2.y) / (1 + r));
            Console.WriteLine(point.x + " " + point.y);
            double a = point.y - p.y;
            double b = p.x - point.x;
            double c = (p.y * point.x - p.x * point.y);
            Console.WriteLine("{0}x + {1}y + {2} = 0", a, b, c);
        }
        static double Range(double x1, double y1, double x2, double y2) => Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        static void Seventh()
        {
            Console.WriteLine("Введите координаты первой точки");
            string[] input = Console.ReadLine().Split(' ');
            DPoint p1 = new DPoint(int.Parse(input[0]), int.Parse(input[1]));
            Console.WriteLine("Введите координаты второй точки");
            input = Console.ReadLine().Split(' ');
            DPoint p2 = new DPoint(int.Parse(input[0]), int.Parse(input[1]));
            Console.WriteLine("Введите координаты третьей точки");
            input = Console.ReadLine().Split(' ');
            DPoint p3 = new DPoint(int.Parse(input[0]), int.Parse(input[1]));
            double b = (p1.x * p1.x * p3.x - p1.x * p1.x * p2.x + p1.x * p2.y * p2.y - p1.x * p3.y * p3.y + p1.x * p2.x - p1.x * p3.x * p3.x - p2.x * p2.x * p3.x + p2.x * p2.x * p2.x - p2.x * p2.y * p2.y + p2.x * p3.y * p3.y - p2.x * p2.x * p2.x + p2.x * p3.x * p3.x + p3.x * p1.y * p1.y - p2.x * p1.y * p1.y - p3.x * p2.y * p2.y + p2.x * p2.y * p2.y) / (2 * p1.x * p2.y - 2 * p1.x * p3.y + 2 * p2.x * p3.y + 2 * p1.y * p3.x - 2 * p1.y * p2.x - 2 * p3.x * p2.y);
            double a = (-(p2.y * p2.y) + 2 * p2.y * b + p3.y * p3.y - 2 * p3.y * b - (p2.x * p2.x) + p3.x * p3.x) / (2 * (-p2.x + p3.x));
            double r = Math.Sqrt(Math.Pow(p1.x - a, 2) + Math.Pow(p1.y - b, 2));
            Console.WriteLine("(x-{0})^2+(y-{1})^2={2}^2", a, b, r);
        }
        static void Eighth()
        {

            Console.WriteLine("Введите координаты центра окружности и её радиус");
            string[] input = Console.ReadLine().Split(' ');
            Point center = new Point(int.Parse(input[0]), int.Parse(input[1]));
            double r = int.Parse(input[2]);
            Console.WriteLine("Введите координаты точки");
            input = Console.ReadLine().Split(' ');
            Point point = new Point(int.Parse(input[0]), int.Parse(input[1]));

        }
        static bool IsOk(Point p1, Point p2, Point p3)
        {
            bool isOk = false;
            double d, mx, sr, mn, e;
            double p1_p2 = Range(p1.x, p1.y, p2.x, p2.y);
            double p2_p3 = Range(p2.x, p2.y, p3.x, p3.y);
            double p3_p1 = Range(p3.x, p3.y, p1.x, p1.y);
            if (p1_p2 > p2_p3)
                mx = p1_p2;
            else
                mx = p2_p3;
            if (p3_p1 > mx)
                mx = p3_p1;
            if (p1_p2 < p2_p3)
                mn = p1_p2;
            else mn = p2_p3;
            if (p3_p1 < mn)
                mn = p3_p1;
            sr = p1_p2 + p2_p3 + p3_p1 - mx - mn;
            d = mn * mn + sr * sr;
            e = mx * mx;
            if (d - e > 0.01) isOk=false;
            else if (d - e < -0.01) isOk = false;
            else isOk = true;
            return isOk;
        }
    }
}