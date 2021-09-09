using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImplementInterface;
namespace ImplementInterfaceTest
{
    [TestClass]
    public class ImplementInterfaceTest
    {
        [TestMethod]
        public void ImplementTest_01()
        {
            //arrange
            string name = "Ted";
            string dept = "Physics";
            string sport = "Football";
            string[] expectedResult = { "Ted", "Physics", "Football" };

            //act
            SportsStudent sports = new SportsStudent();
            string[] actualResult = sports.SportsStudents(name, dept, sport);

            //assert
            for(int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ImplementTest_02()
        {
            //arrange
            string name = "Tony";
            string dept = "Chemistry";
            string major = "Inorganic Chemistry";
            string[] expectedResult = { "Tony", "Chemistry", "Inorganic Chemistry" };

            //act
            NormalStudent normal = new NormalStudent();
            string[] actualResult = normal.NormalStudents(name, dept, major);

            //assert
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ImplementTest_03()
        {
            //arrange
            int numberofHours = 3;
            int expectedResult = 13;

            //act
            NormalStudent normal = new NormalStudent();
            int actualResult = normal.GraceCalculate(numberofHours);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
            

        }
    }
}
