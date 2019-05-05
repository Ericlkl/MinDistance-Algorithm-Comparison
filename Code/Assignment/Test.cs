using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
    public static class Test
    {
        public static long MD1_ExecutionTimeTest(int size, Random rnd)
        {
            var watch = new System.Diagnostics.Stopwatch();

            int[] randomArr = Enumerable.Repeat(int.MinValue, int.MaxValue).Select(x => rnd.Next(int.MinValue, int.MaxValue)).Take(size).ToArray();
            watch.Start();
            Algorithm.MinDistance(randomArr);
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        public static long MD2_ExecutionTimeTest(int size, Random rnd)
        {
            var watch = new System.Diagnostics.Stopwatch();

            int[] randomArr = Enumerable.Repeat(int.MinValue, int.MaxValue).Select(x => rnd.Next(int.MinValue, int.MaxValue)).Take(size).ToArray();
            watch.Start();
            Algorithm.MinDistance2(randomArr);
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        public static int MD1_BasicOperationsTest(int size, Random rnd)
        {
            int[] randomArr = Enumerable.Repeat(int.MinValue, int.MaxValue).Select(x => rnd.Next(int.MinValue, int.MaxValue)).Take(size).ToArray();

            return Algorithm.MinDistanceBO(randomArr);
        }

        public static int MD2_BasicOperationsTest(int size, Random rnd)
        {
            int[] randomArr = Enumerable.Repeat(int.MinValue, int.MaxValue).Select(x => rnd.Next(int.MinValue, int.MaxValue)).Take(size).ToArray();

            return Algorithm.MinDistance2BO(randomArr);
        }
    }
}
