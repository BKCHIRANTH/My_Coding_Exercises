using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExceptionHandling;
namespace ExceptionHandlingTest
{
    [TestClass]
    public class ExceptionHandletest
    {
        [TestMethod]
        public void ExceptionHandleTest_01()
        {
            //arrange
            int param1 = 8;
            int param2 = 2;
            int[] expectedResult = { 4 };

            //act
            ExceptionHandle except = new ExceptionHandle();
            int[] actualResult = except.Divideby(param1, param2);

            //assert
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ExceptionHandleTest_02()
        {
            //arrange
            int param1 = 8;
            int param2 = 0;
            int[] expectedResult = {  };

            //act
            ExceptionHandle except = new ExceptionHandle();
            int[] actualResult = except.Divideby(param1, param2);

            //assert
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ExceptionHandleTest_03()
        {
            //arrange
            int param1 = 0;
            int param2 = 4;
            int[] expectedResult = { };

            //act
            ExceptionHandle except = new ExceptionHandle();
            int[] actualResult = except.Divideby(param1, param2);

            //assert
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ExceptionHandleTest_04()
        {
            //arrange
            int param1 = -8;
            int param2 = 7;
            int[] expectedResult = { };

            //act
            ExceptionHandle except = new ExceptionHandle();
            int[] actualResult = except.Divideby(param1, param2);

            //assert
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ExceptionHandleTest_05()
        {
            //arrange
            int param1 = 8;
            int param2 = -2;
            int[] expectedResult = { -4 };

            //act
            ExceptionHandle except = new ExceptionHandle();
            int[] actualResult = except.Divideby(param1, param2);

            //assert
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
