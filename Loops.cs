using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // int i, j, k = 1, n = 5;
            // int i = 0,;
            /* while (i < 5)
             {
                 Console.WriteLine(i);
                 i++;
             }
            */

            /* do
             {
                 Console.WriteLine(i);
                 i++;
             } while (i < 5);
            */

            /* for(i=1;i<n;i++)
            {
                for(j=1;j<n;j++)
                {
                    Console.Write("{0,3:D}",k);
                    k++;
                }
                Console.WriteLine();
            }
            */

            // Infinite Loop
            /* 
            for(; ; )
            {
                Console.WriteLine(1);
            }
           */

            // foreach statement
            /*
            Console.WriteLine("Print array:");
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            foreach(int item in a)
            {
                Console.WriteLine(item);
            }
            */
            // Break and Continue
           /* for(int i=0;i<10;i++)
            {
                if(i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
           */
           for(int i=0;i<10;i++)
            {
                if(i==4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}

