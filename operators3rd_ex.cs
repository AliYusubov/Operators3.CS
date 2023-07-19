using System;
using System.Diagnostics.Metrics;

namespace ALi
{
    class NumberManipulator
    {

        static void Main(string[] args)
        {
            int a = 6;
            int b = 5;
            int c = 4;
            int d = 3;
            int e = 2;

            int result = a-- * --b + e++ / c - ++d / a * b++ - --e * c;

            Console.WriteLine("Initial values:");
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
            Console.WriteLine($"d: {d}");
            Console.WriteLine($"e: {e}");

            Console.WriteLine("\nExpression Result:");
            Console.WriteLine($"Result = {result}");

        }


    }
}