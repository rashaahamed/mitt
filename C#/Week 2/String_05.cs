// Comparing strings

using System;

namespace Strings
{
    class String_05
    {
        static void Main(string[] args)
        {
            string name1 = "Jack Smith";
            string name2 = "Jack Smith";
            string name3 = new string("Jack Smith");
            string name4 = new string("Jack Smith");

            Console.WriteLine(name1 == name2);
            Console.WriteLine(name1.Equals(name2));

            Console.WriteLine(name1 == name3);
            Console.WriteLine(name1.Equals(name3));

            Console.WriteLine(name3 == name4);
            Console.WriteLine(name3.Equals(name4));

            Console.WriteLine(String.Equals(name1, name2));
            Console.WriteLine(String.Equals(name1, name3));
            Console.WriteLine(String.Equals(name3, name4));
        }
    }
}
