// Data types

 /*
  * The .NET Common Language Runtime (CLR) offers two kinds of user-defined
  * objects: reference types, declared as 'class', and value types (or simple
  * types), declared as 'struct'
  */

using System;

namespace Types
{
    class Types
    {
        static void Main(string[] args)
        {
            // Declaration statement
            int a = 10;
            Console.WriteLine(a);

            // Implicitly typed local variable
            var b = 7;
            Console.WriteLine(b);

            // Gets the type of the current instance
            Console.WriteLine(b.GetType());

            bool isValid = true;
            Console.WriteLine(isValid);

            int c = -12345;
            Console.WriteLine(c);

            uint d = 12345;
            Console.WriteLine(d);

            long e = 987654321L;
            Console.WriteLine(e);

            byte f = 123;
            Console.WriteLine(f);

            float g = 123.45F;
            Console.WriteLine(g);

            float h = -123.45F;
            Console.WriteLine(h);

            double i = 6789.55;
            Console.WriteLine(i);

            double j = -6789.55;
            Console.WriteLine(j);
            Console.WriteLine(j.GetType());
        }
    }
}
