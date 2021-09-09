using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using StackList;

namespace StackTest
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void TestStack_01()
        {
            string fname = "Tony";
            string mname = "Brady";
            string lname = "Gonsalves";
            String[] expectedResult = { "Gonsalves", "Brady",  "Tony" };


            Stacks st = new Stacks();
            st.addItems(fname);
            st.addItems(mname);
            st.addItems(lname);
            String[] actualResult = st.display();

            for(int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
            
        }

        [TestMethod]
        public void TestStack_02()
        {
            string fname = "Tony";
            string mname = "Brady";
            string lname = "Gonsalves";
            String[] expectedResult = {  "Brady", "Tony" };


            Stacks st = new Stacks();
            st.addItems(fname);
            st.addItems(mname);
            st.addItems(lname);
            st.removeItems();
            String[] actualResult = st.display();

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }

        [TestMethod]
        public void TestStack_03()
        {
            string fname = "Tony";
            string mname = "Brady";
            string lname = "Gonsalves";
            bool expectedResult = false;


            Stacks st = new Stacks();
            st.addItems(fname);
            st.addItems(mname);
            st.addItems(lname);
            st.removeItems();
            bool actualResult = st.stack1.Contains("CSE");

            
            Assert.AreEqual(expectedResult, actualResult);
            

        }
    }
}
