// Local functions

using static System.Console;

namespace Methods
{
    class Methods
    {
        public static void Division(int a, int b)
        {
            bool Validate()
            {
                if (a > b && b > 0)
                    return true;
                else
                    return false;
            }

            WriteLine(Validate() ? a / b : "Invalid operation");
        }

        static void Main()
        {
            Division(10, 2);
        }
    }
}
