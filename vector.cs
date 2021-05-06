using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Vector
    {
        public Vector(double x1, double y1, double z1)
        {
            x = x1;
            y = y1;
            z = z1;
        }
        public double x;
        public double y;
        public double z;
        public double Length()
        {
            return Math.Sqrt(x * x + y + y + z * z); // Sqrt - возведение в квадрат
        }
        public static Vector operator +(Vector l, Vector r) // sum
        {
            return new Vector(l.x + r.x, l.y + r.y, l.z + r.z);
        }
        public static Vector operator -(Vector l, Vector r)
        {
            return new Vector(l.x - r.x, l.y - r.y, l.z - r.z);
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", x, y, z);
            // return base.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Начальные координаты вектора
            Console.WriteLine("Введите значение x1 вектора а: ");
            double xx1 = Convert.ToDouble(Console.ReadKey());
            Console.WriteLine("Введите значение y1 вектора а: ");
            double yy1 = Convert.ToDouble(Console.ReadKey());
            Console.WriteLine("Введите значение z1 вектора а: ");
            double zz1 = Convert.ToDouble(Console.ReadKey());
            // Конечные координаты вектора
            Console.WriteLine("Введите значение x2 вектора а: ");
            double xx2 = Convert.ToDouble(Console.ReadKey());
            Console.WriteLine("Введите значение y2 вектора а: ");
            double yy2 = Convert.ToDouble(Console.ReadKey());
            Console.WriteLine("Введите значение z2 вектора а: ");
            double zz2 = Convert.ToDouble(Console.ReadKey());
            // начальные координаты 2-го вектора
            Console.WriteLine("Введите значение x1 вектора b: ");
            double xx1 = Convert.ToDouble(Console.ReadKey());
            Console.WriteLine("Введите значение y1 вектора b: ");
            double yy1 = Convert.ToDouble(Console.ReadKey());
            Console.WriteLine("Введите значение z1 вектора b: ");
            double zz1 = Convert.ToDouble(Console.ReadKey());
            // Конечные координаты 2-го вектора
            Console.WriteLine("Введите значение x2 вектора b: ");
            double xx2 = Convert.ToDouble(Console.ReadKey());
            Console.WriteLine("Введите значение y2 вектора b: ");
            double yy2 = Convert.ToDouble(Console.ReadKey());
            Console.WriteLine("Введите значение z2 вектора b: ");
            double zz2 = Convert.ToDouble(Console.ReadKey());
            // Ввод данных
            Vector y1 = new Vector(xx2 - xx1, yy1 - yy2, zz1 - zz2);
            Vector v2 = new Vector(xx22 - xx2, yy22 - yy2, yy22 - yy2);
            Vector v3 = v1 + v2;
            Vector v4 = v1 - v2;
            double m = v1 * v2;
            double c = Vector.Cos(v1, v2);
            double len1 = v1.Length();
            double len2 = v2.Length();
            int test = 0;
            // Добавим обработку ошибок
            try
            {
                len1 = v1.Length();
                len2 = v2.Length();
 
                if (len1 == 0 || len2 == 0)
                {
                    throw new Exception("Вектор не может быть нулевым");
                
                }
            }
            catch (Exception e)
                {
                    Console.WriteLine("\nОшибка: " + e.Message);
                    test = 10;
                }
            // Вывод данных на экран
            if (test != 10)
                {
                    Console.WriteLine();
                    Console.Write("Вектор a: ");
                    Console.WriteLine(v1);
                    Console.Write("Вектор б: ");
                    Console.WriteLine(v2);
                    Console.Write("Вектор а+б: ");
                    Console.WriteLine(v3);
                    Console.Write("Вектор а-б: ");
                    Console.WriteLine(v4);
                    Console.Write("Вектор а*б: ");
                    Console.WriteLine(m);
                    Console.Write("Косинус угла между векторами a и б: ");
                    Console.WriteLine(c);
                    Console.Write("Длина вектора 1: ");
                    Console.WriteLine(len1);
                    Console.Write("Длина вектора 2: ");
                    Console.WriteLine(len2);
                }
        Console.ReadKey();
 
    }        

        }
    }
}