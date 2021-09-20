// The while statement

/*
 * The while loop has two important parts: a boolean expression that is tested
 * for true/false, and a statement or block of statements that is repeated as
 * long as the expression is true
 */

using System;

namespace While_01
{
    class While_01
    {
        static void Main(string[] args)
        {
            int x = 5;

            while (x > 0)
            {
                Console.WriteLine(x);
                x--;
            }
        }
    }
}
