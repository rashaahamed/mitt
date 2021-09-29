// Local functions

/*
 * A feature introduced in C# 7.0 is the ability to create methods within
 * methods, referred to officially as local functions. Local functions must be
 * private, can be static, and does not support overloading
 */

using static System.Console;

namespace Methods
{
    class Methods
    {
        public static void Repeat(string str)
        {
            int ctr = 4;
            PrintMessage();

            // Adding the 'static' modifier to a local method prevents it from
            // seeing the local variables and parameters of the enclosing method
            void PrintMessage()
            {
                for (int i = 0; i < ctr; i++)
                    WriteLine(str);
            }
        }

        static void Main()
        {
            Repeat("Hello world");
        }
    }
}
