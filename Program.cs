using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_1._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Assignment 1 : create prog to accept 2 integers and check whether equal or not
            Console.WriteLine("LET'S COMPARE NUMBERS");
            Console.WriteLine();

            Console.WriteLine("Enter The 1ST Number:");
            int num1 = Int32.Parse(Console.ReadLine()); // int 1
            
            Console.WriteLine("Enter The 2ND Number:");

            int num2 = Int32.Parse(Console.ReadLine()); // int 2
            
            // check whether num1 is equal to num2 or not
            if (num1 == num2)
            {
                Console.WriteLine();
                Console.WriteLine($"The number {num1} is equal to {num2}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"The number {num1} is NOT EQUAL to {num2}");
            }
            Console.ReadKey();
        }
    }
}
