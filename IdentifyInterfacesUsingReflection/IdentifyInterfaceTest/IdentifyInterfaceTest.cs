using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using IdentifyInterfacesUsingReflection;

namespace IdentifyInterfaceTest
{
    [TestClass]
    public class IdentifyInterfaceTest
    {
        [TestMethod]
        public void IdentifyInterfaceTest_01()
        {
            Type t = typeof(Identify);
            ArrayList expectedResult = new ArrayList() { "IAnimal", "IBirds" };

            Identify idObj = new Identify();
            ArrayList actualResult = idObj.getInterfaces(t);

            for(int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }

        [TestMethod]
        public void IdentifyInterfaceTest_02()
        {
            Type t = typeof(TestClass);
            ArrayList expectedResult = new ArrayList() { };

            Identify idObj = new Identify();
            ArrayList actualResult = idObj.getInterfaces(t);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }

        [TestMethod]
        public void IdentifyInterfaceTest_03()
        {
            Type t = typeof(IdentifyInterfaceTest);
            ArrayList expectedResult = new ArrayList() { };

            Identify idObj = new Identify();
            ArrayList actualResult = idObj.getInterfaces(t);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }
    }
}
