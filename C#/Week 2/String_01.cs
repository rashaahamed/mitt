// The String class

/*
 * A string is a sequential collection of characters that's used to represent
 * text. A String object is a sequential collection of System.Char objects that
 * represent a string; The value of the String object is the content of the
 * sequential collection of System.Char objects, and that value is immutable.
 * The maximum size of a String object in memory is 2GB, or about 1 billion
 * characters
 */

using System;

namespace Strings
{
    class String_01
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

            Console.WriteLine(str1 == str2);  // False

            // System.NullReferenceException
            // Console.WriteLine(str1.Equals(str2));

            // Initialize with a regular string literal
            string str3 = "Hello C#";
            str3.ToUpper();  // Strings are immutable
            Console.WriteLine(str3);
        }
    }
}
