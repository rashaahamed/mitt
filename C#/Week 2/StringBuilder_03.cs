// The StringBuilder class

using System;
using System.Text;

namespace StringBuilders
{
    class StringBuilder_03
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Welcome to Park");
            sb.Insert(11, "Jurassic ");
            Console.WriteLine(sb);

            sb.Remove(0, 11);
            Console.WriteLine(sb);
        }
    }
}
