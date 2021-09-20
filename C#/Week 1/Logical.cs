// Logical operators

/*
 * The '&&' and '||' operators test for AND and OR conditions, respectively.
 * They are frequently used in conjunction with the '!' operator, which
 * expresses NOT
 */

using System;

namespace Logical
{
    class Logical
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 6;
            int c = 3;

            if (a > b && b > c)
                Console.WriteLine("a > b > c");


            bool money = false;
            bool job = true;

            if (money || job)
                Console.WriteLine("Buy a house");
        }
    }
}
