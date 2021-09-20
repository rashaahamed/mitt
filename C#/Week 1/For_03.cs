// The for statement

using System;

namespace For_02
{
    class For_02
    {
        static void Main()
        {
            int[,] grid = {
                {11, 12, 13, 14},
                {21, 22, 23, 24},
                {31, 32, 33, 34},
                {41, 42, 43, 44}
            };

            // Console.WriteLine(grid.Length);

            for (var i = 0; i < grid.GetLength(0); i++)
            {
                for (var j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write($"{grid[i, j]}\t");
                }
                Console.WriteLine();
            }

            // foreach (int num in grid)
            // {
            //    Console.WriteLine(num);
            // }
        }
    }
}
