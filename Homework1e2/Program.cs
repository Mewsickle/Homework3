using System;

namespace Homework1e2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Программа для расчета ИМТ";
            Console.WriteLine("Здравствуйте, Юзер!");

            Console.WriteLine("Пожалуйста введите свой вес (в кг)");
            string InputWeight = Console.ReadLine();
            double w;
            w = Convert.ToDouble(InputWeight);

            Console.WriteLine("Пожалуйста введите свой рост (в сантиметрах)"); 
            string InputHeight = Console.ReadLine();
            double h;
            h = Convert.ToDouble(InputHeight);

            double imt;
            imt = w / (h/100 * h/100);


            Console.WriteLine($"Ваш ИМТ  = {imt:F2}");


            Console.ReadLine();

        }
    }
}
