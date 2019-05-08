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
            int max = (int.MaxValue - 1) / 2;
            int min = max * -1;

            int[] randomArr = Enumerable.Repeat(min, max).Select(x => rnd.Next(min, max)).Take(size).ToArray();
            watch.Start();
            Algorithm.MinDistance(randomArr);
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        public static long MD2_ExecutionTimeTest(int size, Random rnd)
        {
            var watch = new System.Diagnostics.Stopwatch();
            int max = (int.MaxValue - 1) / 2;
            int min = max * -1;

            int[] randomArr = Enumerable.Repeat(min, max).Select(x => rnd.Next(min, max)).Take(size).ToArray();
            watch.Start();
            Algorithm.MinDistance2(randomArr);
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        public static int MD1_BasicOperationsTest(int size, Random rnd)
        {
            int max = (int.MaxValue - 1) / 2;
            int min = max * -1;

            int[] randomArr = Enumerable.Repeat(min, max).Select(x => rnd.Next(min, max)).Take(size).ToArray();

            return Algorithm.MinDistanceBO(randomArr);
        }

        public static int MD2_BasicOperationsTest(int size, Random rnd)
        {
            int max = (int.MaxValue - 1) / 2;
            int min = max * -1;

            int[] randomArr = Enumerable.Repeat(min, max).Select(x => rnd.Next(min, max)).Take(size).ToArray();

            return Algorithm.MinDistance2BO(randomArr);
        }
    }
}
