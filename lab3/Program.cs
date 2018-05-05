using System;
using Lab1;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
           // first();
             //second();
            third();
        }
        static void first()
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
            double s =( 0.5) * ((p1.x - p3.x) * (p2.y - p3.y) - (p2.x - p3.x) * (p1.y - p3.y));
            if (s == 0)
                Console.WriteLine("Точки лежат на одной прямой");
            else Console.WriteLine("Точки не лежат на одной прямой");
        }
        static void second()
        {
            Console.WriteLine("Введите длину первой стороны");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину третьей стороны");
            int c = int.Parse(Console.ReadLine());
            if (a < b + c && b < a + c && c < a + b)
                Console.WriteLine("Такой треугольник существует");
            else
                Console.WriteLine("Такой треугольник не существует");
        }
        public static double Range(int x1, int y1, int x2, int y2) => Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

        static void third()
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
            double d, mx, sr, mn,e;
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
            else mn= p2_p3;
            if( p3_p1 < mn)
                mn= p3_p1;
            sr = p1_p2 + p2_p3 + p3_p1 - mx - mn;
            d = mn * mn + sr * sr;
            e = mx * mx;
            if (d-e>0.01) Console.WriteLine("Это остроугольный треугольник");
            else if(d-e<-0.01) Console.WriteLine("Это тупоугольный треугольник");
            else Console.WriteLine("Это прямоугольный треугольник");
        }
        static void fourth()
        {
            Console.WriteLine("Введите координаты центра первой окружности и её радиус");
            string[] input = Console.ReadLine().Split(' ');
            Point p1 = new Point(int.Parse(input[0]), int.Parse(input[1]));
            double r1 = int.Parse(input[2]);
            Console.WriteLine("Введите координаты центра второй окружности и её радиус");
            input = Console.ReadLine().Split(' ');
            Point p2 = new Point(int.Parse(input[0]), int.Parse(input[1]));
            double r2 = int.Parse(input[2]);
            double Oo = Range(p1.x, p1.y, p2.x, p2.y);
            if (Oo==0&&r1==r2)
            { Console.WriteLine("Окружности совпадают"); return; } 
            else
            { Console.WriteLine("Окружность лежит в другой"); return; }
            if (Oo > r1 + r2)
            { Console.WriteLine("Окружности не пересекаются"); return; }
            if (Oo == r1 + r2)
            {

            }



        }
    }
}
