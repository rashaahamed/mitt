// Operators

using System;

namespace Operators
{
    class Operators
    {
        static void Main(string[] args)
        {
            int a = 5, b = 7, c = 9, d = 10;

            double e, f, g;
            e = f = g = 10.0;

            Console.WriteLine(a + b + c);
            Console.WriteLine(a * b * c);
            Console.WriteLine(e + f + g);

            double result = e + f * g;

            // Composite Format string {0}
            Console.WriteLine("{0} + {1} * {2} = {3}", e, f, g, result);

            Console.WriteLine(e == f);
            Console.WriteLine(d == e);

            Console.WriteLine("'d' is " + d++);
            Console.WriteLine("'d' is " + d);


            int x = 9;
            int y = 8 + 7 - --x;    // x == 8
            int z = 3 * y - x / 2;  // y == 7
            Console.WriteLine(z);   // z == 17


            // if-else without curly braces
            if (d % 2 == 0)
                Console.WriteLine("{0} is a even number", d);
            else
                Console.WriteLine("{0} is an odd number", d);

            String res = (d > 0) ? "Greater than 0" : "Equals 0";
            Console.WriteLine(res);
        }
    }
}
