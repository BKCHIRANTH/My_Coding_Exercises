using System;
using GenericAndSpecificExceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericAndSpecificExceptionTest
{
    [TestClass]
    public class ExceptionsTest
    {
        [TestMethod]
        public void ExceptionsTest_01()
        {
            double inp1 = 6;
            double inp2 = 1;
            double[] expectedResult = { 6 };


            Division div = new Division();
            double[] actualResult = div.Divide(inp1, inp2);

            for(int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ExceptionsTest_02()
        {
            double inp1 = 6;
            double inp2 = 0;
            double[] expectedResult = {  };


            Division div = new Division();
            double[] actualResult = div.Divide(inp1, inp2);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ExceptionsTest_03()
        {
            double inp1 = 0;
            double inp2 = 4;
            double[] expectedResult = { 0 };


            Division div = new Division();
            double[] actualResult = div.Divide(inp1, inp2);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
