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
            // How to combine branches and loops. (ST:2021/12/16 16:30)
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"The answer is {sum}.");

            // (ET:2021/12/16 16:45)

            Console.ReadKey();
        }
    }
}
