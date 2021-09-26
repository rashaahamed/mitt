// The Char struct

/*
 * The Char Struct is used to represent a character as UTF-16 code unit. This
 * structure is defined under System namespace. Basically, this is used to
 * represent a Unicode character in .NET Framework
 *
 */

using System;

namespace Characters
{
    class Char_01
    {
        static void Main(string[] args)
        {
            char letter = 'a';
            char number = '5';
            char symbol = '@';

            Console.WriteLine(Char.IsLetter(letter));         // True
            Console.WriteLine(Char.IsDigit(letter));          // False
            Console.WriteLine(Char.IsLetterOrDigit(letter));  // True

            Console.WriteLine(Char.IsLetter(number));         // False
            Console.WriteLine(Char.IsDigit(number));          // True
            Console.WriteLine(Char.IsLetterOrDigit(number));  // True
            Console.WriteLine(Char.IsNumber(number));         // True

            Console.WriteLine(Char.IsLetterOrDigit(symbol));  // False
        }
    }
}
