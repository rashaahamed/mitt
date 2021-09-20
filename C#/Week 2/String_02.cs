// The String class

using System;

namespace Strings
{
    class String_02
    {
        static void Main(string[] args)
        {
            // Use System.String if you prefer
            System.String str1 = "Using System.String";
            Console.WriteLine(str1);

            // Implicit typing (local variable)
            var str2 = "I'm still a strongly-typed string";
            Console.WriteLine(str2);

            // Constant string
            const string str3 = "You can't get rid of me";
            Console.WriteLine(str3);

            // Use the String constructor only when creating a string from a
            // char, char[], or sbyte
            char[] letters = {'S', 't', 'r', 'i', 'n', 'g'};
            string str4 = new string(letters);
            Console.WriteLine(str4);


            string str5 = "C# is awesome";
            Console.WriteLine($"{str5[0]}{str5[1]}");

            for (int i = 0; i < str5.Length; i++)
            {
              Console.Write(str5[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
