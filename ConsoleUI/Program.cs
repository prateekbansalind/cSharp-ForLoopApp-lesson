using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //example 1
            //as per my defination of for loop, for loop is something that we can use if we want to iterate something for a finite number of times.

            string[] firstNames = new string[] { "Prateek", "Ram", "John" };

            for (int i = 0; i < firstNames.Length; i++)
            {
                Console.WriteLine($"{firstNames[i]}"); 
            }


            Console.WriteLine();


            //example 2:

            List<string> lastNames = new List<string>();

            lastNames.Add("Bansal");
            lastNames.Add("Vilas");
            lastNames.Add("Harrison");

            for (int i = 0; i < lastNames.Count; i++)
            {
                Console.WriteLine($"{lastNames[i]}"); 
            }


            Console.ReadLine();
        }
    }
}