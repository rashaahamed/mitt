// IsDigit x IsNumber

/*
 * IsNumber() determines whether a Char is of any numeric Unicode category. In
 * addition to including digits, numbers include characters, fractions,
 * subscripts, superscripts, Roman numerals, currency numerators, and
 * encircled numbers. This method contrasts with the IsDigit() method, which
 * determines whether a Char is a radix-10 digit (0-9)
 *
 * Examples: 7, ¼, ٣, Ⅿ, ᠓
 */

using System;

namespace Characters
{
    class Char_03
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Char.IsNumber('7'));  // True
            Console.WriteLine(Char.IsNumber('¼'));  // True
            Console.WriteLine(Char.IsNumber('٣'));  // True
            Console.WriteLine(Char.IsNumber('Ⅿ'));  // True
            Console.WriteLine(Char.IsNumber('᠓'));  // True
        }
    }
}
