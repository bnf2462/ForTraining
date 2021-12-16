using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // How to use "/" in int. (ST:2021/12/14 16:50)
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;

            Console.WriteLine($"quotient: {d}.");
            Console.WriteLine($"remainder: {e}.");

            // The int max.value and min.value that computer can use.
            int max = int.MaxValue;
            int min = int.MinValue;

            Console.WriteLine(max);
            Console.WriteLine(min);

            Console.WriteLine($"The range of integer is {min} to {max}.");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}.");

            // How to use double type. (ET:2021/12/14 17:10)
            double l = 5;
            double m = 4;
            double n = 2;
            double o = (l + m) / n;
            
            Console.WriteLine(o);

            double dmax = double.MaxValue;
            double dmin = double.MinValue;

            Console.WriteLine(dmax);
            Console.WriteLine(dmin);

            Console.WriteLine($"The range of double is {dmin} to {dmax}.");

            double x = 1.0 / 3.0;
            
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
