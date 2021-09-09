using System;
using ArrayListFunctions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace ArrayListTest
{
    [TestClass]
    public class ArrayListTest
    {
        [TestMethod]
        public void ArrayListTest_01()
        {
            string fname = "Raja";
            string mname = "Ram";
            string lname = "Mohan";

            ArrayList expectedResult = new ArrayList{ "Raja", "Ram", "Mohan" };
             

            ExpandableArray arr = new ExpandableArray();
            arr.add(fname);
            arr.add(mname);
            arr.add(lname);

            ArrayList actualResult = arr.arlist1;

            for(int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
            
        }

        [TestMethod]
        public void ArrayListTest_02()
        {
            string fname = "Raja";
            string mname = "Ram";
            string lname = "Mohan";
            string tlname = "Raj";

            ArrayList expectedResult = new ArrayList { "Raja", "Ram", "Mohan", "Roy" };


            ExpandableArray arr = new ExpandableArray();
            arr.add(fname);
            arr.add(mname);
            arr.add(lname);
            arr.add(tlname);
            arr.set(3, "Roy");

            ArrayList actualResult = arr.arlist1;

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }

        [TestMethod]
        public void ArrayListTest_03()
        {
            string fname = "Hello";
            string mname = "World";
            string lname = "CSE";
            

            string expectedResult = "CSE" ;


            ExpandableArray arr = new ExpandableArray();
            arr.add(fname);
            arr.add(mname);
            arr.add(lname);
            

            String actualResult = arr.get(2);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }

        [TestMethod]
        public void ArrayListTest_04()
        {
            string fname = "Hello";
            string mname = "World";
            string lname = "CSE";
            string lname1 = "ISE";


            ArrayList expectedResult = new ArrayList{ "Hello", "World", "ISE" } ;


            ExpandableArray arr = new ExpandableArray();
            arr.add(fname);
            arr.add(mname);
            arr.add(lname);
            arr.set(2, lname1);

            ArrayList actualResult = arr.print();

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }
    }
}
