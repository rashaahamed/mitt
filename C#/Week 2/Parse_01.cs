using System;

namespace Parse
{
    class Parse_01
    {
        static void Main(string[] args)
        {
            int numA = 12;
            int numB = 57;

            String strA = numA.ToString();
            String strB = numB.ToString();

            Console.WriteLine(strA.GetType());  // System.String
            Console.WriteLine(strB.GetType());  // System.String

            int numX = int.Parse(strA);
            int numY = Int32.Parse(strB);

            Console.WriteLine(numX.GetType());  // System.Int32
            Console.WriteLine(numY.GetType());  // System.Int32
        }
    }
}
