using System;

namespace Decision_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a = 10,b=20,c=30;
            int day=2;
            /* if (a < 20)
            {
                Console.WriteLine("True" );
            }
            */
            /* if(a>20)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
            */
            /* 
             if (a > b)
            {
                Console.WriteLine("a is big");
            }
            else if (b > c)
            {
                Console.WriteLine("b is big");
            }
            else
            {
                Console.WriteLine("c is big");
            }
            */
            switch(day)
            {
                case 1: Console.WriteLine("Mon");
                    break;
                case 2: Console.WriteLine("Tue");
                    break;
                case 3: Console.WriteLine("Wes");
                    break;
                default: Console.WriteLine("Invalid");
                    break;

            }
        }
    }
}
