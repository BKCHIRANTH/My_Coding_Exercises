using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciSequence;

namespace FibonacciSequenceTest
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void FibonacciSequenceTest_01()
        {
            //arrange
            int range = 5;
            string expectedResult = "01123";

            //act
            FibonacciSeries fibo = new FibonacciSeries();
            string actualResult = fibo.FibonacciSeriesCalculate(range-2);

            //assert
            Assert.AreEqual(actualResult, expectedResult);
           
        }

        [TestMethod]
        public void FibonacciSequenceTest_02()
        {
            //arrange
            int range = -1;
            string expectedResult = null;

            //act
            FibonacciSeries fibo = new FibonacciSeries();
            string actualResult = fibo.FibonacciSeriesCalculate(range-2);

            //assert
            Assert.AreEqual(actualResult, expectedResult);
           
        }

        [TestMethod]
        public void FibonacciSequenceTest_03()
        {
            //arrange
            int range = 1;
            string expectedResult = "0";

            //act
            FibonacciSeries fibo = new FibonacciSeries();
            string actualResult = fibo.FibonacciSeriesCalculateOne(range);

            //assert
            Assert.AreEqual(actualResult, expectedResult);

        }

        [TestMethod]
        public void FibonacciSequenceTest_04()
        {
            //arrange
            int range = 2;
            string expectedResult = "01";

            //act
            FibonacciSeries fibo = new FibonacciSeries();
            string actualResult = fibo.FibonacciSeriesCalculateTwo(range);

            //assert
            Assert.AreEqual(actualResult, expectedResult);

        }

        [TestMethod]
        public void FibonacciSequenceTest_05()
        {
            //arrange
            int range = 0;
            string expectedResult = " ";

            //act
            FibonacciSeries fibo = new FibonacciSeries();
            string actualResult = fibo.FibonacciSeriesCalculateZero(range);

            //assert
            Assert.AreEqual(actualResult, expectedResult);

        }

        [TestMethod]
        public void FibonacciSequenceTest_06()
        {
            //arrange
            
            char range = '*';
            string expectedResult = " ";

            //act
            FibonacciSeries fibo = new FibonacciSeries();
            string actualResult = fibo.FibonacciSeriesCalculateZero(range);

            //assert
            Assert.AreEqual(actualResult, expectedResult);

        }
    }
}
