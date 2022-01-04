using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // How to use branches (if). (ST:2021/12/14 21:50)
            int a = 5;
            int b = 7;

            if (a + b > 10)
            {
                Console.WriteLine($"The answer is greater than 10.");
            }
            else
            {
                Console.WriteLine($"The answer is smaller than 10.");
            }

            // How to use ==, && and || with branches (if).
            int x = 3;
            int y = 3;
            int z = 4;

            if ((x + y + z > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10.");
                Console.WriteLine("Or the 1st number is equal to the 2nd number.");
            }
            else
            {
                Console.WriteLine("The answer is smaller than 10.");
                Console.WriteLine("And the 1st number is not equal to the 2nd number.");
            }

            Console.ReadKey();
        }
    }
}
