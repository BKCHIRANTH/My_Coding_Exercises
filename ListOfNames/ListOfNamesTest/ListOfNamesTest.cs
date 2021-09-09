using System;
using ListOfNames;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListOfNamesTest
{
    [TestClass]
    public class ListOfNamesTest
    {
        [TestMethod]
        public void NamesListTest_01()
        {
            
            List<String> input = new List<String>();
            input.Add("lionel");
            input.Add("Zen");
            input.Add("Gracia");
            input.Add("Zen");

            String[] expectedResult = { "lionel", "Zen", "Gracia" };

            NamesList names = new NamesList();
            String[] actualResult = names.removeDuplicate(input);

            for(int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void NamesListTest_02()
        {

            List<String> input = new List<String>();
            input.Add("lionel");
            input.Add("Zen");
            input.Add("123");


            String[] expectedResult = { "null" };

            NamesList names = new NamesList();
            String[] actualResult = names.removeDuplicate(input);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void NamesListTest_03()
        {

            List<String> input = new List<String>();
            input.Add("lionel");
            input.Add("Zen");
            input.Add("Grace123");


            String[] expectedResult = { "null" };

            NamesList names = new NamesList();
            String[] actualResult = names.removeDuplicate(input);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
