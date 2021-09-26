// The StringBuilder class

using System;
using System.Text;

namespace StringBuilders
{
    class StringBuilder_02
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Welcome, ");
            sb.Append("traveller");

            Console.WriteLine(sb);

            sb.AppendLine(".");
            sb.Append("I am a wizard");

            Console.WriteLine(sb);

            int amount = 150;
            StringBuilder total = new StringBuilder("Total: ");
            total.AppendFormat("{0:c}", amount);
            Console.WriteLine(total);
        }
    }
}
