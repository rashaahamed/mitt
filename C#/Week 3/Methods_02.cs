// Expression-bodied members

/*
 * C# 6.0 introduced expression-bodied members that shorten the syntax for
 * single-line methods
 */

using static System.Console;

namespace Methods
{
    class Methods
    {
        public void Greetings() => WriteLine("Welcome, friend");

        public void Message(string name) => WriteLine($"Hi, my name is {name}");

        public int Calc(int a, int b) => a + b;

        static void Main()
        {
            new Methods().Greetings();
            new Methods().Message("John Smith");
            WriteLine($"9 + 16 = {new Methods().Calc(9, 16)}");
        }
    }
}
