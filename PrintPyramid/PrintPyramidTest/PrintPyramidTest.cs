using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintPyramid;
namespace PrintPyramidTest
{
    [TestClass]
    public class PrintPyramidTest
    {
        [TestMethod]
        public void PyramidTest_01()
        {
            //arrange
            int lines = 2;
            string[] expectedResult = {" "," ","*" ," ","*","*"};

            //act
            PrintAPyramid print = new PrintAPyramid();
            string[] actualResult = print.PrintingPyramid(lines);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);

            }
        }

            [TestMethod]
        public void PyramidTest_02()
        {
            //arrange
            int lines = 0;
            string[] expectedResult = {  };

            //act
            PrintAPyramid print = new PrintAPyramid();
            string[] actualResult = print.PrintingPyramid(lines);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);

            }
        }

        [TestMethod]
        public void PyramidTest_03()
        {
            //arrange
            int lines = -4;
            string[] expectedResult = { };

            //act
            PrintAPyramid print = new PrintAPyramid();
            string[] actualResult = print.PrintingPyramid(lines);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);

            }
        }
    }
}
