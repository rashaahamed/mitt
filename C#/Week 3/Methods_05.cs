// Local functions

using static System.Console;

namespace Methods
{
    class Methods
    {
        public static void Cube(int num)
        {
            WriteLine(Calc());

            int Calc() => num * num * num;
        }

        static void Main()
        {
            Cube(3);
        }
    }
}
