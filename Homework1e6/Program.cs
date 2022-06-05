using System;

 /* 6. Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

    Студент Ким Алексей */

namespace Homework1e6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Print(string msg, int x, int y)
            {
                Console.WriteLine(msg);
                Console.SetCursorPosition(x, y); 
              
            }
           
        }

    }
}
