using System;
using CalculatorOperation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorOperationTest
{
    [TestClass]
    public class CalculatorOperationTest
    {
        [TestMethod]
        public void CalculatorOperationsTest_01()
        {
            double op1 = 10;
            double op2 = 20;
            double expectedResult = 30;

            CallCalci cal = new CallCalci();
            double actualResult = cal.Add(op1, op2);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void CalculatorOperationsTest_02()
        {
            double op1 = 10;
            double op2 = 20;
            double expectedResult = -10;

            CallCalci cal = new CallCalci();
            double actualResult = cal.Subtract(op1, op2);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void CalculatorOperationsTest_03()
        {
            double op1 = 10;
            double op2 = 20;
            double expectedResult = 200;

            CallCalci cal = new CallCalci();
            double actualResult = cal.Multiply(op1, op2);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void CalculatorOperationsTest_04()
        {
            double op1 = 10;
            double op2 = 0;

            double expectedResult = 0;

            CallCalci cal = new CallCalci();
            double actualResult = cal.Division(op1, op2);
            
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
