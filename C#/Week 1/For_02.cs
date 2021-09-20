// The foreach statement

/*
 *  The 'foreach' loop is designed to iterate once for every element in an
 *  array. Each time the loop iterate, it copies an array element to a variable
 */

using System;

namespace For_02
{
    class For_02
    {
        static void Main()
        {
            string[] names = { "John", "Paul", "George", "Ringo" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
