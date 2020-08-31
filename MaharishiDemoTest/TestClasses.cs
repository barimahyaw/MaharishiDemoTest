using System.Linq;
using static System.Math;

namespace MaharishiDemoTest
{
    public static class TestClasses
    {
        public static int NextPerfectSquare(int n)
        {
            return n < 0 ? 0 : (int)Pow((int)Sqrt(n) + 1, 2);
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
            return a.Count(t => t == a.Sum());
        }

        public static int StantonMeasure(int[] a)
        {
            return a.Count(t => t == a.Count(t1 => t1 == 1));
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
