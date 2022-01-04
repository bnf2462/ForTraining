using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // How to use System Library. (ST:2021/12/15 22:15)
            Console.WriteLine("Hello world!");
            // System.Console.WriteLine("Hello world!");

            // How to use loops (while).
            int aCounter = 0;
            while (aCounter < 10) 
            {
                Console.WriteLine($"Hello world! The counter is {aCounter}.");
                aCounter++;
            }

            int bCounter = 10;
            while (bCounter > 1)
            {
                Console.WriteLine($"Hello world! The counter is {bCounter}.");
                bCounter--;
            }

            // How to use loops (for).
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello world! The index is {index}.");
            }

            Console.ReadKey();
        }
    }
}
