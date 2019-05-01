using System;
using System.Linq;

namespace Assignment
{
    public static class Test
    {
        public static long MD1_ExecutionTimeTest(int size)
        {
            var watch = new System.Diagnostics.Stopwatch();
            Random rnd = new Random();
            int[] arr = Enumerable.Range(0, size).OrderBy(c => rnd.Next()).ToArray();
            watch.Start();
            Algorithm.MinDistance(arr);
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        public static long MD2_ExecutionTimeTest(int size)
        {
            var watch = new System.Diagnostics.Stopwatch();
            Random rnd = new Random();
            int[] arr = Enumerable.Range(0, size).OrderBy(c => rnd.Next()).ToArray();
            watch.Start();
            Algorithm.MinDistance2(arr);
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        public static int MD1_BasicOperationsTest(int size)
        {
            Random rnd = new Random();
            int[] arr = Enumerable.Range(0, size).OrderBy(c => rnd.Next()).ToArray();

            return Algorithm.MinDistanceBO(arr);
        }

        public static int MD2_BasicOperationsTest(int size)
        {
            Random rnd = new Random();
            int[] arr = Enumerable.Range(0, size).OrderBy(c => rnd.Next()).ToArray();

            return Algorithm.MinDistance2BO(arr);
        }
    }
}
