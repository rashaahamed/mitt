// Implicit typed local variables

/*
 * Local variables can be declared without giving an explicit type. The 'var'
 * keyword instructs the compiler to infer the type of the variable from the
 * expression on the right side of the initialization statement. The inferred
 * type may be a built-in type, an anonymous type, a user-defined type, or a
 * type defined in the .NET class library
 */

using System;

namespace Implicit
{
    class Implicit
    {
        static void Main(string[] args)
        {
            var name = "Jack Smith";
            var num = 34567;
            var salary = 55.450;
            var array = new[] { 1, 2, 3 };

            // Error: an implicitly typed local variable declarator must
            // include an initializer
            // var school;
            // school = "MITT";

            Console.WriteLine(name);
            Console.WriteLine(num);
            Console.WriteLine(salary);
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
