using System;
using GenericStackOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace StackOperationsTest
{
    [TestClass]
    public class StackOperationsTest
    {
        [TestMethod]
        public void StackOperationsTest_01()
        {
            String val1 = "Fime";
            int num1 = 332;
            double dob = 12.31;
            char ch = 'S';

            ArrayList expectedResult = new ArrayList{ 'S', 12.31, 332, "Fime" };

            StackOp stackObj = new StackOp();
            stackObj.insertStack(val1);
            stackObj.insertStack(num1);
            stackObj.insertStack(dob);
            stackObj.insertStack(ch);

            ArrayList actualResult = stackObj.displayStack();

            for(int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void StackOperationsTest_02()
        {
            String val1 = "";
            int num1 = 332;
            double dob = 12.31;
            char ch = 'S';

            ArrayList expectedResult = new ArrayList { };

            StackOp stackObj = new StackOp();
            stackObj.insertStack(val1);
            stackObj.insertStack(num1);
            stackObj.insertStack(dob);
            stackObj.insertStack(ch);

            ArrayList actualResult = stackObj.displayStack();

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void StackOperationsTest_03()
        {
            String val1 = "Fime";
            int num1 = 332;
            double dob = 12.31;
            char ch = 'S';

            ArrayList expectedResult = new ArrayList { 12.31, 332, "Fime" };

            StackOp stackObj = new StackOp();
            stackObj.insertStack(val1);
            stackObj.insertStack(num1);
            stackObj.insertStack(dob);
            stackObj.insertStack(ch);
            stackObj.deleteStack();
            ArrayList actualResult = stackObj.displayStack();

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void StackOperationsTest_04()
        {
            String val1 = "Fime";
            int num1 = 332;
            double dob = 12.31;
            char ch = 'S';

            var expectedResult = 12.31;

            StackOp stackObj = new StackOp();
            stackObj.insertStack(val1);
            stackObj.insertStack(num1);
            stackObj.insertStack(dob);
            stackObj.insertStack(ch);

            stackObj.deleteStack();
            var actualResult = stackObj.topStack();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void StackOperationsTest_05()
        {
            String val1 = "Fime";
            int num1 = 332;
            double dob = 12.31;
            char ch = 'S';

            ArrayList expectedResult = new ArrayList{  };

            StackOp stackObj = new StackOp();
            stackObj.insertStack(val1);
            stackObj.insertStack(num1);
            stackObj.insertStack(dob);
            stackObj.insertStack(ch);

            stackObj.clearOut();
            ArrayList actualResult = stackObj.displayStack();

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
