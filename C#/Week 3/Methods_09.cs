// Parameter modifiers

/*
 * The default way a parameter is sent into a function is 'by value'. Simply
 * put, if you do not mark an argument with a parameter modifier, a copy of the
 * data is passed into the function
 *
 * default (none), ref, out, in, params
 */

using static System.Console;

namespace Methods
{
    class Person
    {
        string name;
        int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // If a reference type is passed by value, the callee may change the
        // values of the object's state data but not the object it is
        // referencing (a copy of the reference is passed to the method)
        static void ReferenceByValue(Person p)
        {
            p.age = 99;
            p = new Person("Jack", 30);
        }

        void Print() { WriteLine($"Name: {this.name}, age: {this.age}"); }

        static void Main()
        {
            Person steve = new Person("Steve", 25);
            steve.Print();

            ReferenceByValue(steve);
            steve.Print();
        }
    }
}
