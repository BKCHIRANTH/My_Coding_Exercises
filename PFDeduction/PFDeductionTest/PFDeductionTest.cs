using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PFDeduction;
namespace PFDeductionTest
{
    [TestClass]
    public class PFDeductionTest
    {
        [TestMethod]
        public void PFDeductTest_01()
        {
            double salary = 30000;
            double expectedResult = 27000;
            
            EventRaise raise = new EventRaise();
            raise.SalaryPaid += EventRaise.PFDeduct;
            raise.Salary(salary);
            double actualResult = EventRaise.empSalary;

            Assert.AreEqual(expectedResult, actualResult);
            
        }
    }
}
