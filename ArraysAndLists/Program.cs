using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            int[] Array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evens = new List<int>();
            var odds = new List<int>();

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            for (int i = 2; i <= 10; i+=2)
            {
                evens.Add(i);
                Console.WriteLine(i);
            }
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                    Console.WriteLine(i);
                }
                
            }

            
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
