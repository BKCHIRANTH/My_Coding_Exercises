using System;
using InvokeMethodReflections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InvokeMethodReflectionTest
{
    [TestClass]
    public class InvokeMethodTest
    {
        [TestMethod]
        public void InvokeMethodTest_01()
        {
            String roll = "12";
            String name = "Rob";
            String expectedResult = "12 Rob";

            StudentFunc func = new StudentFunc();
            String actualResult = func.operation(roll, name);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void InvokeMethodTest_02()
        {
            String roll = null;
            String name = "Rob";
            String expectedResult = null;

            StudentFunc func = new StudentFunc();
            String actualResult = func.operation(roll, name);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void InvokeMethodTest_03()
        {
            String roll = "18";
            String name = "Joe2";
            String expectedResult = null;

            StudentFunc func = new StudentFunc();
            String actualResult = func.operation(roll, name);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }

}

