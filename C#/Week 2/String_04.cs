// Comparing strings (CompareTo)

using System;

namespace Strings
{
    class String_04
    {
        static void Main(string[] args)
        {
            string name1 = "Aaron";
            string name2 = "Adam";
            string name3 = "Adam";
            string name4 = "Annie";

            // CompareTo compares the instance with a specified object or
            // String and returns an integer that indicates whether the
            // instance precedes, follows, or appears in the same position in
            // the sort order as the specified object or String

            Console.WriteLine(name1.CompareTo(name2));  // Aaron before Adam
            Console.WriteLine(name2.CompareTo(name3));
            Console.WriteLine(name4.CompareTo(name3));  // Annie after Adam
        }
    }
}
