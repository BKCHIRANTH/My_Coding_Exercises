using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OddOrEven;

namespace OddOrEvenTest
{
    [TestClass]
    public class OddEvenTest
    {
        [TestMethod]
        public void IsEven_01()
        {
            //3A Approach
            //arrange
            int test1 = 0;
            var expectedResult1 = true;

            //act
            OddEven oddeven1 = new OddEven();
            var actualResult1 = oddeven1.OddOrEvenCheck(test1);

            //assert
            Assert.AreEqual(expectedResult1, actualResult1);
            
        }
        [TestMethod]
        public void IsEven_02()
        {
            //3A Approach
            //arrange
            int test1 = -1;
            var expectedResult1 = false;

            //act
            OddEven oddeven1 = new OddEven();
            var actualResult1 = oddeven1.OddOrEvenCheck(test1);

            //assert
            Assert.AreEqual(expectedResult1, actualResult1);

        }

        [TestMethod]
        public void IsEven_03()
        {
            //3A Approach
            //arrange
            double test1 = 54.08;
            var expectedResult1 = false;

            //act
            OddEven oddeven1 = new OddEven();
            var actualResult1 = oddeven1.OddOrEvenCheck(test1);

            //assert
            Assert.AreEqual(expectedResult1, actualResult1);

        }
        

        [TestMethod]
        public void IsOdd_01()
        {
            //3A Approach
            //arrange
            double test1 = 1;
            var expectedResult1 = false;

            //act
            OddEven oddeven1 = new OddEven();
            var actualResult1 = oddeven1.OddOrEvenCheck(test1);

            //assert
            Assert.AreEqual(expectedResult1, actualResult1);
        }

        [TestMethod]
        public void IsOdd_02()
        {
            //3A Approach
            //arrange
            int test1 = -11;
            var expectedResult1 = false;

            //act
            OddEven oddeven1 = new OddEven();
            var actualResult1 = oddeven1.OddOrEvenCheck(test1);

            //assert
            Assert.AreEqual(expectedResult1, actualResult1);
        }

        [TestMethod]
        public void IsOdd_03()
        {
            //3A Approach
            //arrange
            double test1 = 0;
            var expectedResult1 = true;

            //act
            OddEven oddeven1 = new OddEven();
            var actualResult1 = oddeven1.OddOrEvenCheck(test1);

            //assert
            Assert.AreEqual(expectedResult1, actualResult1);
            
        }

        [TestMethod]
        public void IsOdd_04()
        {
            //3A Approach
            //arrange
            double test1 = -22;
            var expectedResult1 = true;

            //act
            OddEven oddeven1 = new OddEven();
            var actualResult1 = oddeven1.OddOrEvenCheck(test1);

            //assert
            Assert.AreEqual(expectedResult1, actualResult1);
            
        }

        [TestMethod]
        public void IsOdd_05()
        {
            //3A Approach
            //arrange
            double test1 = -1.1;
            var expectedResult1 = false;

            //act
            OddEven oddeven1 = new OddEven();
            var actualResult1 = oddeven1.OddOrEvenCheck(test1);

            //assert
            Assert.AreEqual(expectedResult1, actualResult1);
        }

        [TestMethod]
        public void IsOdd_06()
        {
            //3A Approach
            //arrange
            //double test1 = 'g';
            char test = 'k';
            //string test = "hello";
            var expectedResult1 = false;

            //act
            OddEven oddeven1 = new OddEven();
            var actualResult1 = oddeven1.OddOrEvenCheck(test);

            //assert
            Assert.AreEqual(expectedResult1, actualResult1);
        }
    }
}
