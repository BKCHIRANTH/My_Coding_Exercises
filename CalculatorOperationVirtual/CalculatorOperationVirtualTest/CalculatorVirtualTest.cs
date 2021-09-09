using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorOperationVirtual;
namespace CalculatorOperationVirtualTest
{
    [TestClass]
    public class CalculatorVirtualTest
    {
        [TestMethod]
        public void CalculatorVirtualTest_01()
        {
            double op1 = 10;
            double op2 = 1;
            double expectedResult = 11;

            Addition add = new Addition();
            double actualResult = add.CalculatorOperations(op1, op2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalculatorVirtualTest_02()
        {
            double op1 = 10;
            double op2 = 1;
            double expectedResult = 9;

            Subtraction sub = new Subtraction();
            double actualResult = sub.CalculatorOperations(op1, op2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalculatorVirtualTest_03()
        {
            double op1 = 10;
            double op2 = 1;
            double expectedResult = 10;

            Multiplication mul = new Multiplication();
            double actualResult = mul.CalculatorOperations(op1, op2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalculatorVirtualTest_04()
        {
            double op1 = 10;
            double op2 = 0;
            double expectedResult = 0;

            Division div = new Division();
            double actualResult = div.CalculatorOperations(op1, op2);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
