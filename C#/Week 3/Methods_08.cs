// Named arguments

/*
 * Rather than identifying an argument by position, you can identify an
 * by name. Named arguments can occur in any order
 */

using static System.Console;

namespace Methods
{
    class Methods
    {
        static void Info(string name, int id)
        {
            WriteLine($"Name {name} | ID: {id}");
        }

        public static void Main() {
            string str = "Jack Smith";
            int num = 123654;

            Info(str, num);
            Info(id:num, name:str);
        }
    }
}
