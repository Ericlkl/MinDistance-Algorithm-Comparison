using System;
namespace Assignment
{
    public class Helper
    {
        public static T[] ShuffleArray<T>(T[] array)
        {
            Random r = new Random();
            for (int i = array.Length; i > 0; i--)
            {
                int j = r.Next(i);
                T k = array[j];
                array[j] = array[i - 1];
                array[i - 1] = k;
            }

            return array;
        }
    }
}
