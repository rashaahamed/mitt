// The switch statement

/*
 *  The 'switch' statement is a complex decision-making structure in which a
 *  single value is evaluated and flow is redirected to the first matching
 *  branch, known as a 'case' statement
 */

using System;

namespace Switch_01
{
    class Switch_01
    {
        static void Main(string[] args)
        {
            int num = 2;

            switch (num)
            {
                case 1:
                    Console.WriteLine("One");
                    break;

                case 2:
                    Console.WriteLine("Two");
                    break;

                case 3:
                    Console.WriteLine("Three");
                    break;

                default:
                    Console.WriteLine("Something else");
                    break;
            }
        }
    }
}
