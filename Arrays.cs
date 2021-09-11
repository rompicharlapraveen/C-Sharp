using System;

namespace Arrays
{
    class Program
    {
        public static void Main()
        {
            // single dimensional array
            /*
             int[] a =new int[3];
             a[0]=10;
             a[1] = 20;
             a[2] = 30;
             Console.WriteLine(a[0]);
             Console.WriteLine(a[1]);
             Console.WriteLine(a[2]);
            */
            // two dimensional array
            /*
            int[,] arr2d = new int[3, 2]{
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };
            Console.WriteLine(arr2d[0, 0]); // return 1
            Console.WriteLine(arr2d[0, 1]); // return 2
            Console.WriteLine(arr2d[1, 0]); // return 3
            Console.WriteLine(arr2d[1, 1]); // return 4
            Console.WriteLine(arr2d[2, 0]); // return 5
            Console.WriteLine(arr2d[2, 1]); // return 6
            */
            // three dimensional array
            /* int[, ,] arr3d1 = new int[1, 2, 2]{
                { { 1, 2}, { 3, 4} }
            };

            int[, ,] arr3d2 = new int[2, 2, 2]{
                { {1, 2}, {3, 4} },
                { {5, 6}, {7, 8} }
            };

             int[, ,] arr3d3 = new int[2, 2, 3]{
                { { 1, 2, 3}, {4, 5, 6} },
                { { 7, 8, 9}, {10, 11, 12} }
            };

            Console.WriteLine( arr3d2[0, 0, 0]); // returns 1 
            Console.WriteLine(arr3d2[0, 0, 1]); // returns 2 
            Console.WriteLine(arr3d2[0, 1, 0]); // returns 3 
            Console.WriteLine(arr3d2[0, 1, 1]); // returns 4 
            Console.WriteLine(arr3d2[1, 0, 0]); // returns 5 
            Console.WriteLine(arr3d2[1, 0, 1]); // returns 6 
            Console.WriteLine(arr3d2[1, 1, 0]); // returns 7 
            Console.WriteLine(arr3d2[1, 1, 1]); // returns 8
            */
            // jagged array
            int[][] jArray = new int[2][]{
                new int[3]{1, 2, 3},

                new int[4]{4, 5, 6, 7}
        };

            Console.WriteLine(jArray[0][0]);
            Console.WriteLine(jArray[0][1]);
            Console.WriteLine(jArray[0][2]);
            Console.WriteLine(jArray[1][0]);
            Console.WriteLine(jArray[1][1]);
            Console.WriteLine(jArray[1][2]);
            Console.WriteLine(jArray[1][3]);
        }
    }
}
