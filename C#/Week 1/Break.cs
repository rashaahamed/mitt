using System;

namespace Break
{
    class Break
    {
        static void Main(string[] args)
        {
            // A jagged array is an array whose elements are arrays, possibly
            // of different sizes. A jagged array is sometimes called an "array
            // of arrays"
            string[][] str = new string[2][];
            str[0] = new string[] { "a", "b", "c", "d" };
            str[1] = new string[] { "a", "b", "c" };

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str[i].Length; j++)
                {
                    Console.Write(str[i][j]);
                    if (str[i][j].Equals("b"))
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
