using System;
using GBStudyLib;

/*5.
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организовать в центре экрана.
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y).

   Студент Ким Алексей */

namespace Homework1e5
{
    internal class Program
    {

        /*
        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
            

        }
        */
        static void Main(string[] args)
        {
            Console.SetCursorPosition(50, 15);
            Console.WriteLine("Алексей, Ким, Москва.");
            new GBStudyLib.Print("Алексей, Ким, Москва.", 50, 18);
            Console.ReadLine(); 

        }
       
    }
}
