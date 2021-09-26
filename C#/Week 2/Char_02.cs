// The Char struct

using System;

namespace Characters
{
    class Char_02
    {
        static void Main(string[] args)
        {
            char letter = 'a';
            char tab = '\t';
            char ponct = '.';
            char symbol = '+';
            string str = "Hello world";

            Console.WriteLine(Char.IsControl(tab));        // True
            Console.WriteLine(Char.IsLower(letter));       // True
            Console.WriteLine(Char.IsUpper(letter));       // False
            Console.WriteLine(Char.IsPunctuation(ponct));  // True
            Console.WriteLine(Char.IsSymbol(symbol));      // True
            Console.WriteLine(Char.IsWhiteSpace(str, 5));  // True
        }
    }
}
