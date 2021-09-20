// Identifiers and variables

/*
 * Identifiers are the names that you use to identify the elements in your
 * programs, such as namespaces, classes, methods, and variables
 *
 * Naming convention
 * Classes, methods, public class members: PascalCase
 * Interfaces: IPascalCase
 * Private variables: _camelCase
 * Local variables, arguments: camelCase
 *
 * A variable is a storage location that holds a value. You can think of a
 * variable as a box in the computer’s memory that holds temporary information
 */

using System;

namespace Variables
{
    class Variables
    {
        // Member variables have default values
        public string FirstName;
        public static string LastName;

        private static int _userId;

        static void Main(string[] args)
        {
            // Local variables must be initialized before use
            // Error: use of unassigned local variable 'num'
            int num = 10;
            int _nu = 20;
            int _n_ = 30;
            int _12 = 40;
            int @if = 50;

            Console.WriteLine(num);
            Console.WriteLine(_nu);
            Console.WriteLine(_n_);
            Console.WriteLine(_12);
            Console.WriteLine(@if);  // verbatim identifier
        }
    }
}
