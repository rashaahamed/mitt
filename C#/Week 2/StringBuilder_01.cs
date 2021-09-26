// The StringBuilder class

using System;
using System.Text;

namespace StringBuilders
{
    class StringBuilder_01
    {
        static void Main(string[] args)
        {
            StringBuilder sb1 = new StringBuilder();
            Console.WriteLine(sb1);           // Empty
            Console.WriteLine(sb1.Capacity);  // 16 (default)

            StringBuilder sb2 = new StringBuilder(32);
            Console.WriteLine(sb2.Capacity);  // 32

            StringBuilder sb3 = new StringBuilder("Hello");
            Console.WriteLine(sb3);           // Hello
            Console.WriteLine(sb3.Capacity);  // 16
            Console.WriteLine(sb3.Length);    // 5
            Console.WriteLine(sb3.GetType());  // System.Text.StringBuilder

            string str = "Hello";
            // Operator '==' cannot be applied to operands of type 'StringBuilder' and 'string'
            // Console.WriteLine(sb1 == str);
            Console.WriteLine(sb3.ToString() == str);    // True
            Console.WriteLine(sb3.Equals(str));          // True
            Console.WriteLine(str.Equals(sb3));          // False
            Console.WriteLine(String.Equals(str, sb3));  // False

        }
    }
}
