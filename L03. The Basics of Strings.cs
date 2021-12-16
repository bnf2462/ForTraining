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
        // How to use string and method. (ST:2021/12/14 15:30)
            string MainHeroine = "Eustia";
            string SubHeroine = "Eris";
            Console.WriteLine($"The heroine are {MainHeroine} and {SubHeroine}.");

            Console.WriteLine($"The name {MainHeroine} has {MainHeroine.Length} letters.");
            Console.WriteLine($"The name {SubHeroine} has {SubHeroine.Length} letters.");

            // How to use trimming.
            string greeting = "    Hello world!    ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            // How to use replace, toupper & tolower method. (ET:2021/12/14 16:30)
            string sayHello = "Hello world!";
            Console.WriteLine(sayHello);

            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            Console.WriteLine($"{sayHello.ToUpper()}");
            Console.WriteLine(sayHello.ToLower());

            Console.ReadKey();
        }
    }
}
