using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunctionOverloadOverride;
namespace FunctionOverloadOverrideTest
{
    [TestClass]
    public class OverloadOverrideTest
    {
        [TestMethod]
        public void overloadtest_01()
        {
            //arrange
            int side = 10;
            int expectedResult = 100;

            //act
            OverloadingDemo overload = new OverloadingDemo();
            int actualresult = overload.area(side);

            //assert
            Assert.AreEqual(expectedResult, actualresult);
        }

        [TestMethod]
        public void overloadtest_02()
        {
            //arrange
            int side1 = 10;
            int side2 = 20;
            int expectedResult = 30;

            //act
            OverloadingDemo overload = new OverloadingDemo();
            int actualresult = overload.area(side1, side2);

            //assert
            Assert.AreEqual(expectedResult, actualresult);
        }

        [TestMethod]
        public void overridetest_01()
        {
            //arrange
            int parameter = 10;
            int expectedResult = 100;

            //act
            OverridingDemo overrider = new OverridingDemo();
            int actualresult = overrider.Volume(parameter);

            //assert
            Assert.AreEqual(expectedResult, actualresult);
        }

        [TestMethod]
        public void overloadtest_03()
        {
            //arrange
            int parameter = 10;
            int expectedResult = 10;

            //act
            OverloadingDemo overload = new OverloadingDemo();
            int actualresult = overload.Volume(parameter);

            //assert
            Assert.AreEqual(expectedResult, actualresult);
        }
    }
}
