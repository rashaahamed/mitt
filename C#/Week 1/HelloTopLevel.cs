// Hello world (top-level elements)

/*
 * Starting in C# 9, you don't have to explicitly include a Main method in a
 * console application project. Instead, you can use the top-level statements
 * feature to minimize the code you have to write. In this case, the compiler
 * generates a class and Main method entry point for the application
 */

using System;

int a = 5;
int b = 7;
int c = a + b;

Console.WriteLine(a + " + " + b + " = " + c);

// Composite formatting
Console.WriteLine("{0} + {1} = {2}", a, b, c);

// String interpolation
Console.WriteLine($"{a} + {b} = {c}");
