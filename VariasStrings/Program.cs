using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string normalString = "Hello world!\n";
            string normalString2 = "\"\tHello world!\n\"";
            string verbatimString = @"Hello world!\n";
            string verbatimString2 = @"""\tHello world!\n""";
            string normalSquare = "\u25A1";
            string verbatimCircle = @"\u25CB";


            Console.WriteLine(normalString);
            Console.WriteLine(normalString2);
            Console.WriteLine(verbatimString);
            Console.WriteLine(verbatimString2);
            Console.WriteLine(normalSquare);
            Console.WriteLine(verbatimCircle);
        }
    }
}
