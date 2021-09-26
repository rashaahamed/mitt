// String methods

using System;
using static System.Console;

namespace Strings
{
    class String_04
    {
        static void Main(string[] args)
        {
            string name = "Andre Specht";
            WriteLine(name.ToLower());
            WriteLine(name.ToUpper());
            WriteLine(name.Substring(6));
            WriteLine(name.EndsWith('x'));

            string[] arr = name.Split(" ");
            WriteLine($"{arr[1]}, {arr[0]}");

            CharEnumerator ce = name.GetEnumerator();
            while(ce.MoveNext())
                Write(ce.Current + " ");

            WriteLine();
        }
    }
}
