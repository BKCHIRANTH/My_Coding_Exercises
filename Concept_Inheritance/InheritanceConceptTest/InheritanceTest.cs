using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Concept_Inheritance;

namespace InheritanceConceptTest
{
    [TestClass]
    public class InheritanceTest
    {
        [TestMethod]
        public void InheritanceTest_01()
        {
            //arrange
            string workType = "Principal";
            string expectedResult = "Principal";

            //act
            Professor prof = new Professor();
            string actualResult = prof.Duty(workType);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void InheritanceTest_02()
        {
            //arrange
            int workHours = 10;
            int expectedResult = 10;

            //act
            Employee emp = new Employee();
            int actualResult = emp.workHour(workHours);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void InheritanceTest_03()
        {
            //arrange
            string majorSub = "Networks";
            string expectedResult = "Networks";

            //act
            Student student = new Student();
            string actualResult = student.Major(majorSub);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
