﻿using System;

namespace Lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // first();
            // second();
            third();
          //  fourth();
           // fifth();
            Console.ReadKey();
        }
        static void First()
        {
            string[] Input;
            Point p1, p2;

            Console.WriteLine("Введите координаты первой точки");
            Input = Console.ReadLine().Split(' ');
            p1 = new Point(int.Parse(Input[0]), int.Parse(Input[1]));

            Console.WriteLine("Введите второй точки");
            Input = Console.ReadLine().Split(' ');
            p2 = new Point(int.Parse(Input[0]), int.Parse(Input[1]));

            double First = Math.Atan2(p1.y - Point.y0, p1.x - Point.x0) * 180 / Math.PI;
            if (First < 0)
                First += 360;
            double Second = Math.Atan2(p2.y - Point.y0, p2.x - Point.x0) * 180 / Math.PI;
            if (Second < 0)
                Second += 360;
            if (First > Second)
                Console.WriteLine("Первый угол больше второго");
            else if (First == Second)
                Console.WriteLine("Углы равны");
            else Console.WriteLine("Второй угол больше первого");
        }
        static void Second()
        {
            Console.WriteLine("Введите координаты точки A");
            string[] x = Console.ReadLine().Split(' ');
            double xa = double.Parse(x[0]);
            double ya = double.Parse(x[1]);
            Console.WriteLine("Введите координаты точки B");
            x = Console.ReadLine().Split(' ');
            double xb = double.Parse(x[0]);
            double yb = double.Parse(x[1]);
            Console.WriteLine("Введите координаты точки C");
            x = Console.ReadLine().Split(' ');
            double xc = double.Parse(x[0]);
            double yc = double.Parse(x[1]);
            if (((xa - xb) * (yc - yb) - (ya - yb) * (xc - xb)) == 0 && ((xa > xb && xa < xc) || (xa < xb && xa > xc)))
                Console.WriteLine("A принадлежит отрезку ВС");
            else Console.WriteLine("A не принадлежит отрезку ВС");
        }
        static void third()
        {
            Console.WriteLine("Введите a b ");
            string[] x = Console.ReadLine().Split(' ');
            double a = double.Parse(x[0]);
            double b = double.Parse(x[1]);
            Console.WriteLine("Введите х1 и у1");
            x = Console.ReadLine().Split(' ');
            double x1 = double.Parse(x[0]);
            double y1 = double.Parse(x[1]);
            Console.WriteLine("Введите х2 и у2");
            x = Console.ReadLine().Split(' ');
            double x2 = double.Parse(x[0]);
            double y2 = double.Parse(x[1]);
            if (x1 != x2)
            {
                double bnew = 1 * x1 * (y2 + y1) / (x2 - x1) + y1;
                double x_new = (bnew - b) / (a - (y2 - y1) / (x2 - x1));
                Console.WriteLine(x_new);
                if ((x1 >= x_new) && (x_new >= x2) || (x1 <= x_new) && (x_new <= x2))
                    Console.WriteLine("Прямая и отрезок пересекаются");
                else if(x_new==Double.PositiveInfinity||x_new==Double.NegativeInfinity)
                    Console.WriteLine("Прямая и отрезок совпадают");
                else
                    Console.WriteLine("Прямая и отрезок не пересекаются");
            }
            else
            {
                double y_new = a * x1 + b;
                if ((y1 >= y_new) && (y_new >= y2) || (y1 <= y_new) && (y_new <= y2))
                    Console.WriteLine("Прямая и отрезок пересекаются");
                else
                    Console.WriteLine("Прямая и отрезок не пересекаются");
            }
        }
        private static int vector_mult(int ax, int ay, int bx, int by) //векторное произведение
        {
            return ax * by - bx * ay;
        }
        static void fourth()
        {
            Console.WriteLine("Введите х1 и у1");
            string[] x = Console.ReadLine().Split(' ');
            int x1 = int.Parse(x[0]);
            int y1 = int.Parse(x[1]);
            Console.WriteLine("Введите х2 и у2");
            x = Console.ReadLine().Split(' ');
            int x2 = int.Parse(x[0]);
            int y2 = int.Parse(x[1]);
            Console.WriteLine("Введите х3 и у3");
            x = Console.ReadLine().Split(' ');
            int x3 = int.Parse(x[0]);
            int y3 = int.Parse(x[1]);
            Console.WriteLine("Введите х4 и у4");
            x = Console.ReadLine().Split(' ');
            int x4 = int.Parse(x[0]);
            int y4 = int.Parse(x[1]);
            int x_n = ((x1 * y2 - x2 * y1) * (x4 - x3) - (x3 * y4 - x4 * y3) * (x2 - x1)) / ((y1 - y2) * (x4 - x3) - (y3 - y4) * (x2 - x1)); ;
            int y_n= ((y3 - y4) * x_n - (x3 * y4 - x4 * y3)) / (x4 - x3);
            int v1 = vector_mult(x4 - x3, y4 - y3, x1 - x3, y1 - y3);
            int v2 = vector_mult(x4 - x3, y4 - y3, x2 - x3, y2 - y3);
            int v3 = vector_mult(x2 - x1, y2 - y1, y3 - x1, y3 - y1);
            int v4 = vector_mult(x2 - x1, y2 - y1, y4 - x1, y4 - y1);
            if ((v1 * v2) <= 0 && (v3 * v4) <= 0)
            if( (((x1 <= x_n)&&(x2 >= x_n) && (x3 <= x_n) && (x4 >= x_n))||((y1 <= y_n) && (y2 >= y_n) && (y3 <= y_n) && (y4 >= y_n))) )

            Console.WriteLine("Отрезки пересекаются");
            else
                Console.WriteLine("Отрезки не пересекаются");
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
        public static double Range(int x1, int y1, int x2, int y2) => Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        static double HalfPerimeter(int x1, int y1, int x2, int y2, int x3, int y3) =>
            (Range(x1, y1, x2, y2) + Range(x1, y1, x3, y3) + Range(x2, y2, x3, y3)) / 2;
        static double GeronSquare(int x1, int y1, int x2, int y2, int x3, int y3) =>
            Math.Sqrt(HalfPerimeter(x1, y1, x2, y2, x3, y3) * (HalfPerimeter(x1, y1, x2, y2, x3, y3) - Range(x1, y1, x2, y2)) * (HalfPerimeter(x1, y1, x2, y2, x3, y3) - Range(x1, y1, x3, y3)) * (HalfPerimeter(x1, y1, x2, y2, x3, y3) - Range(x2, y2, x3, y3)));
        static bool SquareCompare(int x1, int y1, int x2, int y2, int x3, int y3, int x, int y)
        {
            double a = GeronSquare(x1, y1, x2, y2, x3, y3) - GeronSquare(x1, y1, x2, y2, x, y) - GeronSquare(x1, y1, x, y, x3, y3) - GeronSquare(x, y, x2, y2, x3, y3);
            if (GeronSquare(x1, y1, x2, y2, x3, y3) - GeronSquare(x1, y1, x2, y2, x, y) - GeronSquare(x1, y1, x, y, x3, y3) - GeronSquare(x, y, x2, y2, x3, y3) < -0.1)
                return false;
            return true;
        }
        static void fifth()
        {
            Console.WriteLine("Введите х1 и у1");
            string[] x = Console.ReadLine().Split(' ');
            int x1 = int.Parse(x[0]);
            int y1 = int.Parse(x[1]);
            Console.WriteLine("Введите х2 и у2");
            x = Console.ReadLine().Split(' ');
            int x2 = int.Parse(x[0]);
            int y2 = int.Parse(x[1]);
            Console.WriteLine("Введите х3 и у3");
            x = Console.ReadLine().Split(' ');
            int x3 = int.Parse(x[0]);
            int y3 = int.Parse(x[1]);

            Console.WriteLine("Введите х4 и у4");
             x = Console.ReadLine().Split(' ');
            int x4 = int.Parse(x[0]);
            int y4 = int.Parse(x[1]);
            if (SquareCompare(x1, y1, x2, y2, x3, y3, x4, y4))
            {
                if (CheckPointEdge(x4, y4, x1, y1, x2, y2) || CheckPointEdge(x4, y4, x2, y2, x3, y3) || CheckPointEdge(x4, y4, x3, y3, x1, y1))
                    Console.WriteLine("Точка лежит на стороне треугольника");
                else Console.WriteLine("Точка лежит внутри треугольника");
            }
            else Console.WriteLine("Точка лежит вне треугольника");
        }
    }
}
