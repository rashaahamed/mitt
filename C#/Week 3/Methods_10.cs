// Parameter modifiers (ref)

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

        // If a reference type is passed by reference, the callee may change
        // the values of the object's state data, as well as the object it is
        // referencing
        static void ReferenceByReference(ref Person p)
        {
            p.age = 99;
            p = new Person("Jack", 30);
        }

        void Print() { WriteLine($"Name: {this.name}, age: {this.age}"); }

        static void Main()
        {
            Person steve = new Person("Steve", 25);
            steve.Print();

            ReferenceByReference(ref steve);
            steve.Print();
        }
    }
}
