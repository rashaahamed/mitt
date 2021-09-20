using System;

namespace Continue
{
    class Continue
    {
        static void Main(string[] args)
        {
            int count = 0;

            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= 4; col++)
                {
                    if (row * col % 2 == 0)
                        continue;
                        count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
