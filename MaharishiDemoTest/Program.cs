using System;

namespace MaharishiDemoTest
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Sum Factor is " + TestClasses.SumFactor(new[] { 3, 0, 2, -5, 0 }));
            Console.ReadLine();
            Console.WriteLine($"Stanton Measure is {TestClasses.StantonMeasure(new[] { 1, 1, 2 })}");
            Console.ReadLine();
            Console.WriteLine($"Next Perfect Square of {3} is {TestClasses.NextPerfectSquare(3)}");
            Console.ReadLine();
            Console.WriteLine("5th Up Count is " + TestClasses.NUpCount(new[] { 2, 3, 1, -6, 8, -3, -1, 2 }, 5));
            Console.ReadLine();
            Console.WriteLine("Prime Count "+TestClasses.PrimeCount(1,10));
            Console.ReadLine();
        }
    }
}
