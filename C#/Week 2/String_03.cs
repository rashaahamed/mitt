// Verbatim literal strings

/* A verbatim literal string is prefixed with @ and does not support escape
 * sequences
 */

using System;

namespace Strings
{
    class String_03
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            int c = a + b;

            Console.WriteLine($"{a} + {b} = {c}");

            Console.WriteLine("\\\\computer\\user\\files\\");
            Console.WriteLine(@"\\computer\user\files\");
            Console.WriteLine(@"Printing ""double quotes""");
        }
    }
}
