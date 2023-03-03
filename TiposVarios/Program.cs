using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integral type variables.
            int a = 12;
            short b = 50;
            long c = 10L;
            ulong d = 30UL;

            // Print variables.
            Console.WriteLine($"{a}\n{b}\n{c}\n{d}");

            // Char variables   
            char square = '\u25A1';
            char circle = '\u25CB';

            // Print chars
            Console.WriteLine($"\n{square}\n{circle}");
        }
    }
}
