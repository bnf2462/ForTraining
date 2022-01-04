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
            var names = new List<string> { "<name>", "Eustia", "Collet" };

            names.Add("Caim");
            names.Add("Adzar");
            names.Add("Zephir");

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // Console.WriteLine(names[1]);

            /* Do it in the other way. (ET:2021/12/17 23:10)
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()}!");
            }
            */

            Console.WriteLine();
            
            // How to use sort, search, and Index Lists.
            var index = names.IndexOf("Caim");
            Console.WriteLine($"Found Caim at {index}.");

            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}.");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}.");
            }

            Console.ReadKey();
        }
    }
}
