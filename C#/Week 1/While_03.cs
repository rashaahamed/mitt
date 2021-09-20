// The do-while statement

using System;

namespace While_03
{
    class While_03
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            int result = 14, i = 10;

            do
            {
                i--;
                if (i == 8)
                    keepGoing = false;
                    result -= 2;
            } while (keepGoing);

            Console.WriteLine(result);
        }
    }
}
