using System;

namespace Assignment
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int [] test1 = new int[]{ 0, 1 ,5, 65535, 65535, 65535, 65535, 65535 };
            int[] test2 = new int[] { 1, 0, 3, 7, 5, 65535, 65535, 65535, 65535 };
            int[] test3 = new int[] { 5, 3, 0, 65535, 1, 7, 65535, 65535, 65535 };
            int[] test4 = new int[] { 65535, 7, 65535, 0, 2, 65535, 3, 65535, 65535 };

            int[] test5 = new int[] { 65536, 5, 1, 2, 0, 3, 6, 9, 65535 };
            int[] test6 = new int[] { 65535, 65535, 65535, 3, 6, 65535 , 0, 2, 7 };
            int[] test7 = new int[] { 65535, 65535, 65535, 65535, 9, 5, 2, 0, 4};
            int[] test8 = new int[] { 65535, 65535, 65535, 65535, 65535, 7 ,4 ,8 };
            //Console.WriteLine( Math.Abs( test1[0] - test1[2] ));
            Console.WriteLine(Algorithm.MinDistance2(test1));

        }
    }
}
