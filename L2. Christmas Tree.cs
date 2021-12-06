using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ChristmasTree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (i * 2 + 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
