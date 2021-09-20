// The switch statement

// 3
// 17.5
// double.NaN

using System;

namespace Switch_02
{
    class Switch_02
    {
        static void Main(string[] args)
        {
            double measurement = 3.5;

            switch (measurement)
            {
                case < 0.0:
                    Console.WriteLine($"Measured value is {measurement} too low");
                    break;

                case > 15.0:
                    Console.WriteLine($"Measured value is {measurement} too high");
                    break;

                case double.NaN:
                    Console.WriteLine("Failed measurement");
                    break;

                default:
                    Console.WriteLine($"Measured value is {measurement}");
                    
            }
        }
    }
}
