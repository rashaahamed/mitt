// The if-else statement

/*
 *  The 'if-else' statement will execute one group of statements if its boolean
 *  expression is true, or another group if its boolean expression is false
 *  The 'else' block is optional
 */

using System;

namespace If_01
{
    class If_01
    {
        static void Main(string[] args)
        {
            int hour = 10;
            int count = 1;

            if (hour > 12)
                Console.WriteLine("Good morning");
                Console.WriteLine(count++);
        }
    }
}
