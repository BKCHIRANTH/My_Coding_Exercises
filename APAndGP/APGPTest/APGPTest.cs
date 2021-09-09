using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using APAndGP;
namespace APGPTest
{
    [TestClass]
    public class APGPTest
    {
        [TestMethod]
        public void APGPTest_01()
        {
            //arrange
            int first = 2;
            int ratio = 2;
            int terms = 4;
            int[] expectedResult = { 2, 4, 8, 16 };

            //act
            APGP apgp = new APGP();
            int[] actualResult = apgp.GeometricProgression(first, ratio, terms);

            //assert
            int leng = expectedResult.Length;
            for(int i=0; i < leng; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void APGPTest_02()
        {
            //arrange
            int first = 0;
            int ratio = '%';
            int terms = 4;
            int[] expectedResult = { };

            //act
            APGP apgp = new APGP();
            int[] actualResult = apgp.GeometricProgression(first, ratio, terms);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void APGPTest_03()
        {
            //arrange
            int first = 'a';
            int ratio = 0;
            int terms = 4;
            int[] expectedResult = { };

            //act
            APGP apgp = new APGP();
            int[] actualResult = apgp.GeometricProgression(first, ratio, terms);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void APGPTest_04()
        {
            //arrange
            int first = 2;
            int difference = 2;
            int terms = 4;
            int[] expectedResult = { 2, 4, 6, 8 };

            //act
            APGP apgp = new APGP();
            int[] actualResult = apgp.ArithmeticProgression(first, difference, terms);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void APGPTest_05()
        {
            //arrange
            int first = 0;
            int difference = '%';
            int terms = 4;
            int[] expectedResult = { };

            //act
            APGP apgp = new APGP();
            int[] actualResult = apgp.ArithmeticProgression(first, difference, terms);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void APGPTest_06()
        {
            //arrange
            int first = 0;
            int difference = 2;
            int terms = 4;
            int[] expectedResult = { 0, 2, 4, 6 };

            //act
            APGP apgp = new APGP();
            int[] actualResult = apgp.ArithmeticProgression(first, difference, terms);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void APGPTest_07()
        {
            //arrange
            char first = '$';
            char difference = 'u';
            int terms = 4;
            int[] expectedResult = { };

            //act
            APGP apgp = new APGP();
            int[] actualResult = apgp.ArithmeticProgression(first, difference, terms);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
