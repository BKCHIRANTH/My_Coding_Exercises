using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiLevelInheritance;
namespace MultiLevelInheritanceTest
{
    [TestClass]
    public class MultiLevelInheritanceTest
    {
        [TestMethod]
        public void MultiLevelInheritTest_01()
        {
            //arrange
            string name = "Junior_Name";
            int age = 21;
            string job = "Intern";
            string[] expectedResult = { "Junior_Name", "21", "Intern" };

            //act
            JuniorEmployee junEmp = new JuniorEmployee();
            string[] actualResult = junEmp.juniordisplay(name,age,job);

            //assert
            int leng = expectedResult.Length;
            for(int i = 0; i < leng; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void MultiLevelInheritTest_02()
        {
            //arrange
            string name = "Senior_Name";
            int age = 31;
            string job = "Manager";
            string[] expectedResult = { "Senior_Name", "31", "Manager" };

            //act
            SeniorEmployee seniorEmp = new SeniorEmployee();
            string[] actualResult = seniorEmp.juniordisplay(name, age, job);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void MultiLevelInheritTest_03()
        {
            //arrange
            string name = "Senior_Employee";
            string expectedResult = "Senior_Employee";

            //act
            SeniorEmployee seniorEmp = new SeniorEmployee();
            string actualResult = seniorEmp.ExampleMethod(name);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
            
        }
    }
}
