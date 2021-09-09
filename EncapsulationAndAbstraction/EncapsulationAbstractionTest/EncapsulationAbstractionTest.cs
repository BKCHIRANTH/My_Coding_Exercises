using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EncapsulationAndAbstraction;
namespace EncapsulationAbstractionTest
{
    [TestClass]
    public class EncapsulationAbstractionTest
    {
        [TestMethod]
        public void EnCapAbstactTest_01()
        {
            //arrange
            int salary = 55000;
            int expectedResult = 55000;

            //act
            Manager manager = new Manager();
            manager.SetSalary(salary);
            int actualResult = manager.GettingSalary();

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
