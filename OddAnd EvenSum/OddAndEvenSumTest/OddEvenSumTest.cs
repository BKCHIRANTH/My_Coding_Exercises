using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OddAndEvenSum;
namespace OddAndEvenSumTest
{
    [TestClass]
    public class OddEvenSumTest
    {
        [TestMethod]
        public void oddEvenSum_01()
        {
            //arrange
            int range = 10;
            int[] expectedResult = { 30, 25 };

            //act
            OddEvenSum oddEven = new OddEvenSum();
            int[] actualResult=oddEven.OddEvenSumCalculate(range);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(actualResult[i], expectedResult[i]);
            }
        }

        [TestMethod]
        public void oddEvenSum_02()
        {
            //arrange
            int range = 0;
            int[] expectedResult = { 0, 0 };

            //act
            OddEvenSum oddEven = new OddEvenSum();
            int[] actualResult = oddEven.OddEvenSumCalculate(range);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(actualResult[i], expectedResult[i]);
            }
        }

        [TestMethod]
        public void oddEvenSum_03()
        {
            //arrange
            int range = -1;
            int[] expectedResult = { };

            //act
            OddEvenSum oddEven = new OddEvenSum();
            int[] actualResult = oddEven.OddEvenSumCalculate(range);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(actualResult[i], expectedResult[i]);
            }
        }

        [TestMethod]
        public void oddEvenSum_04()
        {
            //arrange
            //int range = 0;
            char range = 'k';
            int[] expectedResult = { };

            //act
            OddEvenSum oddEven = new OddEvenSum();
            int[] actualResult = oddEven.OddEvenSumCalculate(range);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(actualResult[i], expectedResult[i]);
            }
        }

        [TestMethod]
        public void oddEvenSum_05()
        {
            //arrange
            //int range = 0;
            //char range = 'k';
            string range = "hello";
            int[] expectedResult = { };

            //act
            OddEvenSum oddEven = new OddEvenSum();
            int[] actualResult = oddEven.OddEvenSumCalculate(range);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(actualResult[i], expectedResult[i]);
            }
        }
    }
}
