// Method overloading

/*
 * Method overloading occurs when there are different method signatures with
 * the same name but different type parameters
 *
 * Method signature: name and parameter types in order (not the parameter names,
 * nor the return type)
 */

using System;
using static System.Console;

namespace Methods
{
    class Methods
    {
        public static void Method(string s) => WriteLine("1");
        public static void Method(string[] s) => WriteLine("2");
        public static void Method(object o) => WriteLine("3");
        public static void Method(string s, string t) => WriteLine("4");

        public static void Main() {
            Method("a");
            Method(new int[] {1, 2, 3});
            Method("a", "b");
            Method(new string[] { "a", "b" });
        }
    }
}
