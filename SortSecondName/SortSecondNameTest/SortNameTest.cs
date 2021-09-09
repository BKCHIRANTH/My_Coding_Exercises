using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortSecondName;

namespace SortSecondNameTest
{
    [TestClass]
    public class SortNameTest
    {
        [TestMethod]
        public void SortSecondNameTest_01()
        {
            List<Student> names = new List<Student>(){
                new Student() { Studentfname = "Riya", StudentSecname = "Jack" } ,
                new Student() { Studentfname = "Zoya", StudentSecname = "Daniels" } ,
                new Student() { Studentfname = "Ananya", StudentSecname = "Anand"  } ,

            };
            

            String[] expectedResult = { "Ananya Anand", "Zoya Daniels", "Riya Jack" };

            SortSecond sort = new SortSecond();
            String[] actualResult = sort.sortSecName(names);

            for(int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
