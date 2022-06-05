using System;

namespace Homework1e3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Программа для расчета расстояния между координатами";
            Console.WriteLine("Здравствуйте, Юзер!");
            Console.WriteLine("Пожалуйста введите координату первой точки Х");
            string InputX1 = Console.ReadLine();
            Console.WriteLine("Пожалуйста введите координату первой точки Y");
            string InputY1 = Console.ReadLine();
            Console.WriteLine("Пожалуйста введите координату второй точки X");
            string InputX2 = Console.ReadLine();
            Console.WriteLine("Пожалуйста введите координату второй точки Y");
            string InputY2 = Console.ReadLine();


            double x1 = double.Parse(InputX1);
            double y1 = double.Parse(InputY1);
            double x2 = double.Parse(InputX2);
            double y2 = double.Parse(InputY2);


            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"Расстояние между двумя точками координат = {r:F2}");
            Console.WriteLine($"Расстояние между двумя точками координат = {CoorDist(x1, x2, y1, y2):F2}");



            static double CoorDist(double x1, double x2, double y1, double y2)  // метод расчета расстояния для задания б*
            {

                double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                return r;

            }
        }

    }
}
