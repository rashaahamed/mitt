using System;

namespace Parse
{
    class Parse_02
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;

            // TryParse returns 0 if the string is null, Empty or not a number
            // The TryParse method is like the Parse method, except the
            // TryParse method does not throw an exception if the conversion
            // fails. The 'out' keyword passes a variable via reference
            _ = int.TryParse(null, out a);
            _ = int.TryParse("123", out b);

            Console.WriteLine(a);  // 0
            Console.WriteLine(b);  // 123

            // Discards (_) are placeholder variables that are intentionally
            // unused in application code. Discards are equivalent to
            // unassigned variables; they don't have a value. A discard
            // communicates intent to the compiler and others that read your
            // code: you intended to ignore the result of an expression

            Console.WriteLine(int.TryParse("123", out _));  // True
            Console.WriteLine(int.TryParse("Abc", out _));  // False
        }
    }
}
