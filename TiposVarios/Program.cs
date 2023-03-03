using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integral types variables.
            int a = 12;
            short b = 50;
            long c = 10L;
            ulong d = 30UL;

            // Print variables.
            Console.WriteLine($"{a}\n{b}\n{c}\n{d}");

            // Char variables.  
            char square = '\u25A1';
            char circle = '\u25CB';

            // Print chars.
            Console.WriteLine($"\n{square}\n{circle}");

            // Floating Point types variables
            float e = 1.234f;
            double f = 4.321;

            // Print variables.
            Console.WriteLine($"\n{e}\n{f}");

            // Booleans variables
            bool g = true;
            bool h = false;

            // Print bool
            Console.WriteLine($"\n{g}\n{h}");
        }
    }
}
