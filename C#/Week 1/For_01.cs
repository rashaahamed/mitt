// The for statement

/*
 *  A repetition control structure, which we refer to as a loop, executes a
 *  block of code multiple time in succession
 *
 *  for (initialization; booleanExpression; updateStatement)
 *  {
 *      statement(s);
 *  }
 */

using System;

namespace For_01
{
    class For_01
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
