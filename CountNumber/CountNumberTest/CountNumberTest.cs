using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountNumber;
namespace CountNumberTest
{
    [TestClass]
    public class CountNumberTest
    {
        [TestMethod]
        public void CountNumber_01()
        {
            //arrange
            int[] numberArray = { 1, 10, 4, 2, 4, 5 };
            int[] expectedResult = { 5, 1, 0, 0, 0, 0, 0, 0, 0, 0 };

            //act
            CountNumbers count = new CountNumbers();
            int[] actualResult = count.Counter(numberArray);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(actualResult[i], expectedResult[i]);
            }
        }

        [TestMethod]
        public void CountNumber_02()
        {
            //arrange
            int[] numberArray = { 1, 10, -4, 2, 4, 5 };
            int[] expectedResult = { };

            //act
            CountNumbers count = new CountNumbers();
            int[] actualResult = count.Counter(numberArray);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(actualResult[i], expectedResult[i]);
            }
        }

        [TestMethod]
        public void CountNumber_03()
        {
            //arrange
            int[] numberArray = { 5, 5, 5, 5, 5, 5, 5 };
            int[] expectedResult = { 7, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            //act
            CountNumbers count = new CountNumbers();
            int[] actualResult = count.Counter(numberArray);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(actualResult[i], expectedResult[i]);
            }
        }

        [TestMethod]
        public void CountNumber_04()
        {
            //arrange
            int[] numberArray = { 5, 5, 5,'#','s', 5, 5 };
            int[] expectedResult = { };

            //act
            CountNumbers count = new CountNumbers();
            int[] actualResult = count.Counter(numberArray);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(actualResult[i], expectedResult[i]);
            }
        }
    }
}
