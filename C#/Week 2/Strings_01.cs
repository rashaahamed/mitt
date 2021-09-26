// String x StringBuilder (mutability)

/*
 * Mutability means that once an instance of the class has been created, it can
 * be modified by appending, removing, replacing, or inserting characters
 */

using System;
using System.Text;

namespace Strings
{
    class Strings_01
    {
        public void Complete(string greet1, StringBuilder greet2)
        {
            String.Concat(greet1, " Brazil");
            greet2.Append(" Canada");
        }

        static void Main()
        {
            string str = "Hello";
            StringBuilder sbd = new StringBuilder("Hello");

            Strings_01 test = new Strings_01();

            test.Complete(str, sbd);
            Console.WriteLine($"{str} | {sbd}");
        }
    }
}
