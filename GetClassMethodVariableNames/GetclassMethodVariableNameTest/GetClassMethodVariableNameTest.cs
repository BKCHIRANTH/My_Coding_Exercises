using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using GetClassMethodVariableNames;

namespace GetclassMethodVariableNameTest
{
    [TestClass]
    public class GetClassMethodVariableNameTest
    {
        [TestMethod]
        public void GetInfoTest_01()
        {
            ArrayList expectedResult = new ArrayList() { "randomVariable", "someString" };

            ReflectionDemo demo = new ReflectionDemo();
            ArrayList actualResult = demo.getVariables();

            for(int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void GetInfoTest_02()
        {
            ArrayList expectedResult = new ArrayList() { "myMethod1", "myMethod2", "getThisClassName" };

            ReflectionDemo demo = new ReflectionDemo();
            ArrayList actualResult = demo.getMethodsName();

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void GetInfoTest_03()
        {
            String expectedResult = "Operations";

            Operations op = new Operations();
            String actualResult = op.getThisClassName();

            
            Assert.AreEqual(expectedResult, actualResult);
           
        }
    }
}
