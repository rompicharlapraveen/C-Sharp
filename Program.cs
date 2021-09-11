﻿using System;

namespace Methods
{
    class Program
    {
        // Call a Method
        /* static void Mymethod()
        {
            Console.WriteLine("Hello World");
        }
        static void Main(string[] args)
        {
            Mymethod();
        }
        */

        // Call a multiple methods
        /*static void Mymethod()
        {
            Console.WriteLine("Hello World");
        }
        static void Main(string[] args)
        {
            Mymethod();
            Mymethod();
            Mymethod();
        }
        */
        // Parameters and Arguments
        /*
         * static void MyMethod(string fname)
         {
             Console.WriteLine(fname + "\t" + "Rompicharla");
         }

         static void Main(string[] args)
         {
             MyMethod("Praveen");
             MyMethod("Srinu");
             MyMethod("Savitri");
         }
        */
        // Default Parameter
        /*
         * static void MyMethod(string country = "Norway")
         {
             Console.WriteLine(country);
         }

         static void Main(string[] args)
         {
             MyMethod("Sweden");
             MyMethod("India");
             MyMethod();
             MyMethod("USA");
         }
        */
        // Multiple Parameters
        /*
         static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }

        static void Main(string[] args)
        {
            MyMethod("Liam", 5);
            MyMethod("Jenny", 8);
            MyMethod("Anja", 31);
        }
        */
        // Return Values
        /*
         static int MyMethod(int x)
        {
            return 5 + x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(3));
        }
        */
        // Named Arguments
        /*
         static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }

        static void Main(string[] args)
        {
            MyMethod(child3: "John", child1: "Liam", child2: "Liam");
        }
        */
    }
}
