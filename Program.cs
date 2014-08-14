using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int j = 1; j <= 100; j++)
            //{
            //    string results = "";

            //    if (j % 3 == 0) results = "Fizz";
            //    if (j % 5 == 0) results = results + "Buzz";

            //    if (results.Length == 0) results = j.ToString();
            //    Console.WriteLine();
            //}

            {
                for (int j = 1; j <= 100; j++)
                {
                    if (j % 3 == 0 && j% 5 == 0)
                    Console.WriteLine("FizzBuzz");

                        else if (j % 3 == 0) 
                            Console.WriteLine("fizz");
                        else if (j % 5 == 0)

                            Console.WriteLine("buzz");
                    {
                        Console.ReadLine();
                    }
                }
            }
            
        }
    }
}
