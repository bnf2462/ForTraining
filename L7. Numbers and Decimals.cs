using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // How to use numbers and decimals. (ST:2021/12/14 21:30)
            decimal dmax = decimal.MaxValue;
            decimal dmin = decimal.MinValue;

            Console.WriteLine($"The range of decimal is {dmin} to {dmax}.");
                        
            // The difference between double and decimal.
            double a = 1.0;
            double b = 3.0;

            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;

            Console.WriteLine(c / d);
            
            // The range of different type of values.
            int imax = int.MaxValue;
            int imin = int.MinValue;

            Console.WriteLine($"The range of integer is {imin} to {imax}.");

            long lmax = long.MaxValue;
            long lmin = long.MinValue;

            Console.WriteLine($"The range of long is {lmin} to {lmax}.");
            
            short smax = short.MaxValue;
            short smin = short.MinValue;

            Console.WriteLine($"The range of short is {smin} to {smax}.");

            // How to calculate a circle area. (ET:2021/12/14 21:50)
            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.Write(area);

            Console.ReadKey();
        }
    }
}
