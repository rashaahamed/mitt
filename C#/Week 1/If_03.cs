// The conditional operator (ternary operator)

/*
 *  The conditional operator is powerful and unique. Because it takes three
 *  operands, it is considered a ternary operator. The conditional operator
 *  provides a shorthand method of expressing a simple if-else statement
 */

using System;

namespace If_03
{
    class If_03
    {
        static void Main(string[] args)
        {
            int hour = 11;

            Console.WriteLine((hour < 12) ? "Morning" : "Afternoon");
        }
    }
}
