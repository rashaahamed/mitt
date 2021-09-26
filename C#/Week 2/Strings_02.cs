// String x StringBuilder (perfomance)

/*
 * Although the StringBuilder class generally offers better performance than
 * the String class, you should not automatically replace String with
 * StringBuilder whenever you want to manipulate strings. Performance depends
 * on the size of the string, the amount of memory to be allocated for the new
 * string, the system on which your code is executing, and the type of
 * operation
 */

using System;
using System.Text;
using System.Diagnostics;

namespace Strings
{
    class Strings_02
    {
        static void Main(string[] args)
        {
            string str = String.Empty;
            StringBuilder sbd = new StringBuilder();
            Stopwatch sw1 = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();

            sw1.Start();
            for (int i = 0; i < 100000; i++)
            {
                str += "*";
            }
            sw1.Stop();
            Console.WriteLine(sw1.ElapsedMilliseconds + " Ms");


            sw2.Start();
            for (int i = 0; i < 1000000; i++)
            {
                sbd.Append("*");
            }
            sw2.Stop();
            Console.WriteLine(sw2.ElapsedMilliseconds + " Ms");
        }
    }
}
