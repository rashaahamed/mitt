// Understanding methods

/*
 * A method is a means of grouping together a sequence of statements to perform
 * a particular action or compute a particular result. This provides greater
 * structure and organization for the statements that compose a program.
 * A method that return a value to the caller is commonly referred to as a
 * function, while methods that do not return a value are commonly referred to
 * as a method
 */

using static System.Console;

namespace Methods
{
    class Methods
    {
        // No return type and no parameters
        public void Greetings()
        {
            WriteLine("Welcome, friend");
        }

        // No return type and one parameter
        public void Message(string name)
        {
            WriteLine($"Hi, my name is {name}");
        }

        // Static, return type (int) and two parameters
        public static int Calc(int a, int b)
        {
            return a + b;
        }

        static void Main()
        {
            new Methods().Greetings();
            new Methods().Message("John Smith");

            WriteLine($"9 + 16 = {Calc(9, 16)}");
        }
    }
}
