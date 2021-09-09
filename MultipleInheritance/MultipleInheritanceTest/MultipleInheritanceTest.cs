using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultipleInheritance;
namespace MultipleInheritanceTest
{
    [TestClass]
    public class MultipleInheritanceTest
    {
        [TestMethod]
        public void MultipleInheritanceTest_01()
        {
            //arrange
            string name = "Student_Name";
            string dept = "CSE";
            string[] expectedResult = { "Student_Name", "CSE" };

            //act
            College clg = new College();
            string[] actualResult = clg.StudentDetails(name, dept);

            //assert
            for(int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void MultipleInheritanceTest_02()
        {
            //arrange
            string name = "Staff_Name";
            string shift = "Night";
            string[] expectedResult = { "Staff_Name", "Night" };

            //act
            College clg = new College();
            string[] actualResult = clg.StaffDetails(name, shift);

            //assert
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
