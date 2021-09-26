// The Random class

/*
 * The Random class represents a pseudo-random number generator, which is an
 * algorithm that produces a sequence of numbers that meet certain statistical
 * requirements for randomness
 */

using System;

namespace RandomClass
{
    class Random_01
    {
        static void Main()
        {
            Random rand = new Random();
            int r1 = rand.Next();
            int r2 = rand.Next(1000);
            int r3 = rand.Next(1, 10);

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);

            double r4 = rand.NextDouble();
            Console.WriteLine(r4);
        }
    }
}
