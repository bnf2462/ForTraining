using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // How to use array, list, and collections (ST:2021/12/17 23:00)
            var names = new List<string> { "<name>", "Eustia", "Collet"};

            names.Add("Caim");
            names.Remove("Eustia");

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine(names[1]);

            // Do it in the other way. (ET:2021/12/17 23:10)
            for (int i =0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()}!");
            }
            Console.ReadKey();
        }
    }
}
