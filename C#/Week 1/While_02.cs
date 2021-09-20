// The do-while statement

// The 'do-while' statement executes instructions at least once

using System;

namespace While_02
{
    class While_02
    {
        static void Main(string[] args)
        {
            int x = 5;

            if (x == 5)
            {
                do
                {
                    Console.WriteLine(x);
                    x--;
                } while (x > 0);
            }
        }
    }
}
