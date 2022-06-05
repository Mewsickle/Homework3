using System;

// Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause). 


namespace GBStudyLib
{
    public class Print
        {
        public Print(string msg, int x, int y)
         {
              Console.SetCursorPosition(x, y);
              Console.WriteLine(msg);

          }


    }
}
