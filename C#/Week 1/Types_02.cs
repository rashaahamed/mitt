// Data types

/*
 * Structs are similar to classes in that they represent data structures that
 * can contain data members and function members. However, unlike classes,
 * structs are value types and do not require heap allocation. A variable of a
 * struct type directly contains the data of the struct, whereas a variable of
 * a class type contains a reference to the data, the latter known as an object
 *
 * The simple types (value types) provided by C#, such as int, double, and
 * bool, are in fact all struct types. These types are identified through
 * reserved words, but these reserved words are simply aliases for predefined
 * struct types in the 'System' namespace
 */

using System;

namespace Types
{
    class Types
    {
        static void Main(string[] args)
        {
            int a = 10;
            System.Int32 b = 20;

            Console.WriteLine(a);
            Console.WriteLine(a.GetType());
            Console.WriteLine(a.ToString().GetType());

            Console.WriteLine(b);
            Console.WriteLine(b.GetType());

            Console.WriteLine(int.MaxValue);

            Console.WriteLine(5.ToString().GetType());
            Console.WriteLine(true.ToString().GetType());


            int x = int.Parse("123");
            int y = Int32.Parse("456");
            int z = System.Int32.Parse("789");

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
