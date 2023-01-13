using System;
using System.Collections.Generic;
using System.IO;
using TestClassLibrary;

namespace TestConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка существования треугольника;");
            Console.WriteLine("Вычисление его периметра и площади;");
            Console.WriteLine("Сохранение треугольника и вывод его параметров;");

            var triangle = new Triangle(0, 0, 0);
            Console.Write("Введите сторону а = ");
            triangle.a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону b = ");
            triangle.b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону c = ");
            triangle.c = Convert.ToDouble(Console.ReadLine());

            var jsonListTriangle = new List<Triangle>();

            string path = "test.json";            
            if (File.Exists(path))
            {
                jsonListTriangle = FileProvider.Read(path);
                File.Delete(path);
            }
            jsonListTriangle.Add(triangle);
            

            if (Triangle.IsExists(triangle, out double p, out double s))
            {
                Console.WriteLine("Периметр треугольника = " + p);
                Console.WriteLine("Площадь треугольника = " + s);

                FileProvider.Save("test.json", jsonListTriangle);
            }
            else
            {
                Console.WriteLine("Треугольника не сущетвует");
            }                           

            Console.WriteLine("Сохраненные треугольники:");
            int n = 1;
            foreach (var side in jsonListTriangle)
            {
                Console.WriteLine("Треугольник" + " " + n + ":");
                Console.WriteLine("a = " + side.a + ", b = " + side.b + ", c = " + side.c);
                n++;
            }
            Console.WriteLine("Нажмите что-нибудь для выхода");
            Console.ReadLine();
        }        
    }
}

