using System;

/*1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
а) используя склеивание;
б) используя форматированный вывод;
в) используя вывод со знаком $.

Студент Ким Алексей.
*/


namespace Homework1e1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Анкета";
            Console.WriteLine("Здравствуйте, Юзер!");
            Console.WriteLine("Введите свое имя");
            string InputName = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию");
            string InputSecondName = Console.ReadLine();
            Console.WriteLine("Введите свой возраст");
            string InputAge = Console.ReadLine();
            Console.WriteLine("Введите свой вес");
            string InputWeight = Console.ReadLine();

           
            Console.WriteLine("Ваше имя: " + InputName + ", Ваша фамилия: " + InputSecondName + ", Ваш возраст: " + InputAge + ", Ваш вес: " + InputWeight + ".");
            Console.WriteLine("Ваше имя: {0}, Ваша фамилия: {1}, Ваш возраст: {2}, Ваш вес: {3}.", InputName, InputSecondName, InputAge, InputWeight);
            Console.WriteLine($"Ваше имя: {InputName}, Ваша фамилия: {InputSecondName}, Ваш возраст: {InputAge}, Ваш вес: {InputWeight}.");
           
            Console.ReadLine();
            
        }
    }
}
