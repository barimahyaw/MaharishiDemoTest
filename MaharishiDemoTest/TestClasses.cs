using System;
using System.Linq;

namespace MaharishiDemoTest
{
    public static class TestClasses
    {
        public static int NextPerfectSquare(int n)
        {
            var nextPerfectSquare = 0;

            if (n < 0) return nextPerfectSquare;
            var sqrtResult = Math.Sqrt(n);
            var baseNumber = (int)sqrtResult;
            var nextNumber = baseNumber + 1;
            nextPerfectSquare = (int)Math.Pow(nextNumber, 2);

            return nextPerfectSquare;
        }

        public static int NUpCount(int[] a, int n)
        {
            var nUpCount = 0;
            var partialSum = 0;
            for (var i = a.Length - 1; i >= 0; i--)
            {
                var previousPartialSum = partialSum;
                partialSum += a[i];
                if (previousPartialSum <= n && partialSum > n)
                {
                    nUpCount++;
                }
            }
            return nUpCount;
        }

        public static int SumFactor(int[] a)
        {
            var sum = a.Sum();
            return a.Count(t => t == sum);
        }

        public static int StantonMeasure(int[] a)
        {
            var onesCount = a.Count(t => t == 1);
            return a.Count(t => t == onesCount);
        }

        public static int PrimeCount(int start, int end)
        {
            var primeCount = 0;
            for (var number = start; number <= end; number++)
            {
                if (number <= 1) continue;
                var isPrime = true;
                for (var divider = 2; divider * 2 <= number; divider++)
                {
                    if (number % divider != 0) continue;
                    isPrime = false;
                    break;
                }
                if (isPrime)
                    primeCount++;
            }
            return primeCount;
        }
    }
}
