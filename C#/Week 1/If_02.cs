// The if-else statement

using System;

namespace If_02
{
    class If_02
    {
        static void Main(string[] args)
        {
            string name = "John";
            bool valid = true;

            // The compiler can't define whether name is true or false
            // Cannot implicitly convert type `string' to `bool'
            // if (name) { Console.WriteLine("Welcome, " + name);
            // No 'truthy' and 'falsey' in C#!

            if (valid) { Console.WriteLine("This is valid"); }
        }
    }
}
