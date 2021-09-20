using System;

namespace Strings
{
    class Strings
    {
        static void Main(string[] args)
        {
            // Declare without initializing
            string str1;

            // Initialize to null
            str1 = null;
            Console.WriteLine("Null: " + str1);  // Prints an empty string

            // Initialize as an empty string. Use the Empty constant instead of
            // the literal ""
            string str2 = String.Empty;
            Console.WriteLine("Empty: " + str2);   // Prints an empty string

            // Initialize with a regular string literal
            string str3 = "Hello C#";
            str3.ToUpper();  // Strings are immutable
            Console.WriteLine(str3);

            // Use System.String if you prefer
            System.String str4 = "Using System.String";
            Console.WriteLine(str4);

            // Implicit typed local variable
            var str5 = "I'm still a strongly-typed string";
            Console.WriteLine(str5);

            // Constant string
            const string str6 = "You can't get rid of me";
            Console.WriteLine(str6);

            // Use the String constructor only when creating a string from a
            // char, char[], or sbyte
            char[] letters = {'S', 't', 'r', 'i', 'n', 'g'};
            string str7 = new string(letters);
            Console.WriteLine(str7);

            string str8 = "C#";
            Console.WriteLine(str8[0]);
            Console.WriteLine(str8[1]);
        }
    }
}
