using System;


// Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause). 
// Студент Ким Алексей


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

    public class Formulas
    {
       public bool IsOdd(int n)
        {

            return n % 2 == 0;


        }
        public int NumberSumm(int n)
        {
            int s = 0;
            while (n != 0)
            {
                s = s + n % 10;
                n = n / 10; 
            }
            return s;
        }
        public bool IsGood(int n)
        {
           if (n % NumberSumm(n) == 0) 
                return true;
           else return false;
        }

         

        }
    public class Complex
    {
        
            public double im;
            public double re;


            public Complex Minus(Complex x)
            {
                Complex y = new Complex();
                y.im = x.im - im;
                y.re = x.re - re;
                return y;
            }


            public Complex Multi(Complex x)
            {
                Complex y = new Complex();
                y.im = re * x.im + im * x.re;
                y.re = re * x.re + im * x.im;
                return y;
            }
            public string ToString()
            {
                return $"{re} + {im} * i";
            }

       


    }

}
