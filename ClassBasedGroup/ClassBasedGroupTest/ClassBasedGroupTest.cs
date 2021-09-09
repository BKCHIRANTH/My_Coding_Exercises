using System;
using ClassBasedGroup;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
namespace ClassBasedGroupTest
{
    [TestClass]
    public class ClassBasedGroupTest
    {
        [TestMethod]
        public void ClassGroupTest_01()
        {
            string standard = "1";
            ArrayList expectedResult = new ArrayList{ "{ student = Maya }", "{ student = Stanley }" };

            ClassGroup group = new ClassGroup();
            group.InsertStudents("Maya", "1");
            group.InsertStudents("Rose", "2");
            group.InsertStudents("Stanley", "1");

            ArrayList actualResult = group.getNames(standard);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ClassGroupTest_02()
        {
            string standard = "8";
            ArrayList expectedResult = new ArrayList{};

            ClassGroup group = new ClassGroup();
            group.InsertStudents("Stanley", "1");
            ArrayList actualResult = group.getNames(standard);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ClassGroupTest_03()
        {
            string standard = " ";
            ArrayList expectedResult = new ArrayList{ };

            ClassGroup group = new ClassGroup();
            ArrayList actualResult = group.getNames(standard);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
