using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // How to searching strings. (ST:2021/12/14 16:30)
            string songLyrics = "You say hello, I say goodbye";

            Console.WriteLine(songLyrics.Contains("hello"));
            Console.WriteLine(songLyrics.Contains("hi"));

            // Used in var type.
            var result = (songLyrics.Contains("hi"));
            Console.WriteLine(result);

            // Searching strings with startwith and endwith method. (ET:2021/12/14 16:40)
            result = (songLyrics.StartsWith("You"));
            Console.WriteLine(result);

            result = (songLyrics.EndsWith("hello"));
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
