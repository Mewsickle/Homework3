using System;

/*4.Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
а) с использованием третьей переменной;
б) *без использования третьей переменной.
   
    Студент Ким Алексей */


namespace Homework1e4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, Юзер!");
            Console.Title = "Программа обмена значений двух данных";
            Console.WriteLine("Введите значение А");
            string InputA = Console.ReadLine();
            Console.WriteLine("Введите значение B");
            string InputB = Console.ReadLine();
            double a = double.Parse(InputA);
            double b = double.Parse(InputB);

            double c = a + b;
            a = c - a;
            b = c - b;
           
            Console.WriteLine($"{a}, {b}");

            /* решение без третьей переменной
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"{a}, {b}");
            */




            Console.ReadLine();

        }
    }
}
