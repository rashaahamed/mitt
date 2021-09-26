// Reading and formatting inputs

using System;

namespace Inputs
{
    class Inputs
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();

            Console.Write("Enter an int (a): ");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a double (b): ");
            double d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your string: " + s);
            Console.WriteLine("a + b = " + (i + d));
        }
    }
}
