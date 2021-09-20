// Numeric promotion

/*
 *  If one of an operator’s operands is a int, and the other operand is an
 *  double, C# will automatically convert the value of the int to a double
 */

using System;

namespace Promotion
{
    class Promotion
    {
        static void Main(string[] args)
        {
            int a = 5;
            double b = 5.0;

            // Error: cannot implicitly convert type 'double' to 'int'
            // int c = a + b;

            double d = a + b;

            Console.WriteLine(a == b);       // True
            Console.WriteLine(d.GetType());  // System.Double
        }
    }
}
