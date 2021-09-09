using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResizeArrayReflection;

namespace ResizeArrayTest
{
    [TestClass]
    public class ResizeArrayTest
    {
        [TestMethod]
        public void ResizeArrayTest_01()
        {
            Array someArray = new string[1];
            int resize = 3;
            int expectedResult = 3;

            ResizeArray resizeObj = new ResizeArray();
            int actualResult = resizeObj.resizearrays(ref someArray,resize);

            Assert.AreEqual(expectedResult, actualResult);
            
        }

        [TestMethod]
        public void ResizeArrayTest_02()
        {
            Array someArray = new string[1];
            int resize = -12;
            int expectedResult = -1;

            ResizeArray resizeObj = new ResizeArray();
            int actualResult = resizeObj.resizearrays(ref someArray, resize);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void ResizeArrayTest_03()
        {
            Array someArray = new string[1];
            int resize = 0;
            int expectedResult = 0;

            ResizeArray resizeObj = new ResizeArray();
            int actualResult = resizeObj.resizearrays(ref someArray, resize);

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
