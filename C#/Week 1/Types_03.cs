// Reference types

/*
 * A reference type refers to an object. Unlike value types that hold their
 * values in the memory where the variable is allocated, reference types point
 * to an object by storing the memory address where the object is located
 */

using System;

namespace Types
{
    class Types
    {
        public string Name;

        static void Main()
        {
            Types reference = new Types();
            reference.Name = "John Doe";
            Console.WriteLine(reference.Name);

            string address = "123 Notre Dame Ave";
            Console.WriteLine(address);
        }
    }
}
