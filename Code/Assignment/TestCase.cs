using System;
using NUnit.Framework;

namespace Assignment
{
    [TestFixture]
    public class TestCase
    {
        public int[] inputArray;
        [Test()]
        public void Small_To_Big()
        {
            inputArray = new int[] { 2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61 };
            Assert.That(Algorithm.MinDistance(inputArray) == 1);
            Assert.That(Algorithm.MinDistance2(inputArray) == 1);
        }

        [Test()]
        public void Big_To_Small()
        {
            inputArray = new int[] { 61,59,53,47,43,41,37,31,29,23,19,17,13,11,7,5,3,2 };
            Assert.That(Algorithm.MinDistance(inputArray) == 1);
            Assert.That(Algorithm.MinDistance2(inputArray) == 1);
        }

        [Test()]
        public void Duplicate_Number_In_Set()
        {
            inputArray = new int[] { 1, 65535, 65535, 3, 6, 2, 0, 2, 7 }; ;
            Assert.That(Algorithm.MinDistance(inputArray) == 0);
            Assert.That(Algorithm.MinDistance2(inputArray) == 0);
        }

        [Test()]
        public void Duplicate_Number_At_Begin_And_End()
        {
            inputArray = new int[] { 65535, 65535, 3, 6, 2, 0, 2, 7 , 65535}; ;
            Assert.That(Algorithm.MinDistance(inputArray) == 0);
            Assert.That(Algorithm.MinDistance2(inputArray) == 0);
        }

        [Test()]
        public void RandomPosition()
        {
            int[] array = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61 };
            inputArray = Helper.ShuffleArray(array);

            Assert.That(Algorithm.MinDistance(inputArray) == 1);
            Assert.That(Algorithm.MinDistance2(inputArray) == 1);
        }

        [Test()]
        public void NegativeValues()
        {
            inputArray = new int[] { -9, -23, -32, 0  }; ;
            Assert.That(Algorithm.MinDistance(inputArray) == 9);
            Assert.That(Algorithm.MinDistance2(inputArray) == 9);
        }
    }
}
