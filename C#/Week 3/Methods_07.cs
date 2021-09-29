// Optional parameters

/*
 * C# allows you to create methods that can take optional arguments
 */

using static System.Console;

namespace Methods
{
    class Methods
    {
        static int Pow(int num, bool cube = false)
        {
            if (cube)
                return num * num * num;
            else
                return num * num;
        }

        public static void Main() {
            WriteLine(Pow(3));
            WriteLine(Pow(3, true));
        }
    }
}
