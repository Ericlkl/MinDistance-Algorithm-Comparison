using System;
namespace Assignment
{
    public class Algorithm
    {
        public static int MinDistance(int [] A)
        {
            //  Input : Array A[0 ... n-1] of numbers
            //  Output : Minimum distance between two of its elements
            int dmin = int.MaxValue;

            for (int i = 0; i < A.Length; i++)
            {
                for(int j = 0; j< A.Length; j++)
                {
                    if ((i != j) && ( Math.Abs(A[i] - A[j]) < dmin))
                    {
                        dmin = Math.Abs(A[i] - A[j]);
                    }
                }
            }

            return dmin;
        }

        public static int MinDistance2(int[] A)
        {
            //  Input : An Array A[0 ... n-1] of numbers
            //  Output : The minimum distance d between two of its elements
            int dmin = int.MaxValue;

            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    int temp = Math.Abs(A[i] - A[j]);

                    if (temp < dmin)
                    {
                        dmin = temp;
                    }
                }
            }

            return dmin;
        }

        public static int MinDistanceBO(int[] A)
        {
            //  Input : Array A[0 ... n-1] of numbers
            //  Output : Basic Operation takes for this algorithm
            int dmin = int.MaxValue;
            int basicOperations = 0;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    basicOperations++;
                    if ((i != j) && (Math.Abs(A[i] - A[j]) < dmin))
                    {
                        dmin = Math.Abs(A[i] - A[j]);
                    }
                }
            }

            return basicOperations;
        }

        public static int MinDistance2BO(int[] A)
        {
            //  Input : An Array A[0 ... n-1] of numbers
            //  Output : Basic Operation takes for this algorithm
            int basicOperations = 0;
            int dmin = int.MaxValue;

            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    basicOperations++;
                    int temp = Math.Abs(A[i] - A[j]);

                    basicOperations++;
                    if (temp < dmin)
                    {
                        dmin = temp;
                    }
                }
            }

            return basicOperations;
        }

    }
}
