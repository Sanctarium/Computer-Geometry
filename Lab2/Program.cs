using System;
using Lab1;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //First();
            //Second();
            //Third();
            //Fourth();
            //Fifth();
            //Sixth();
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
            double new_c = c + range * Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) - a * p1.x - b * p1.y;
            Console.WriteLine("{0}x + {1}y + {2} = 0", a, b, new_c);
        }
        static void Fifth()
        {
            Console.WriteLine("Введите коэффициенты a,b,c");
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            Console.WriteLine("Введите расстояние");
            int range = int.Parse(Console.ReadLine());
            Point p1 = new Point(0, c);
            double new_c = c + range * Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) - a * p1.x - b * p1.y;
            Console.WriteLine("{0}x + {1}y + {2} = 0", a, b, new_c);
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
            double r = Range(p.x, p.y, p1.x, p1.y)/Range(p.x, p.y, p2.x, p2.y);
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
            double ma = (p2.y - p1.y) / (p2.x - p1.x);
            double mb = (p3.y - p2.y) / (p3.x-p2.x);
            double x = (ma * mb * (p1.y - p3.y) + mb * (p1.x + p2.x) - ma * (p2.x + p3.x)) / (2 * mb - 2 * ma);
            double y = (-1 / ma) * (x - (p1.x + p2.x) / 2) + (p1.y + p2.y) / 2;
            double r = Range(p1.x, p1.y, x,y);

            Console.WriteLine("(x-{0})^2+(y-{1})^2={2}^2", x, y, r);
        }
        static void Eighth()
        {
            Console.WriteLine("Введите координаты центра окружности и её радиус");
            string[] input = Console.ReadLine().Split(' ');
            DPoint center = new DPoint(int.Parse(input[0]), int.Parse(input[1]));
            double r = int.Parse(input[2]);
            Console.WriteLine("Введите координаты точки");
            input = Console.ReadLine().Split(' ');
            Point point = new Point(int.Parse(input[0]), int.Parse(input[1]));

        }
    }
}
