using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // How to use int. (ST:2021/12/14 16:40)
            int a = 60;
            int b = 30;
            int c = a + b;
            Console.WriteLine(c);

            // caculate in different way. (ET:2021/12/14 16:50)
            int d = a * b;
            Console.WriteLine(d);

            d = a / b;
            Console.WriteLine(d);

            d = a * (b + 20) / 2 * 15 + c;
            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}
