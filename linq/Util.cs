using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Util
    {
        public static void Heading()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("--- LINQ Exercises with students ---");
            Console.WriteLine("Translated everything to english to let the whole world understand this instead of only Sweden :)");
            Console.ResetColor();
        }

        public static void SubHeading(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public static void SubSubHeading(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
