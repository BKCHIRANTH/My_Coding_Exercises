using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Delegates;
namespace DelegatesTest
{
    [TestClass]
    public class DelegatesTest
    {
        [TestMethod]
        public void DelegatesTest_01()
        {
            int param1 = 20;
            int param2 = 10;
            int expectedResult = 30;

            DelegateDemo deldemo = new DelegateDemo();
            Number num1 = new Number(deldemo.Add);
            int actualResult = num1(param1, param2);
           
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void DelegatesTest_02()
        {
            int param1 = 20;
            int param2 = 10;
            int[] expectedResult = { 30, 200 };

            DelegateDemo deldemo = new DelegateDemo();
            Number num1 = new Number(deldemo.Add);
            Number num2 = new Number(deldemo.Multiply);
            

            int[] actual1 = new int[2];
            actual1[0] = num1(param1, param2);
            actual1[1] = num2(param1, param2);

            int[] actualResult = new int[] { actual1[0], actual1[1] };

            
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }

        [TestMethod]
        public void DelegatesTest_03()
        {
            int param1 = 50;
            int param2 = 10;
            int[] expectedResult = { 60, 40, 500 };

            DelegateDemo deldemo = new DelegateDemo();
            Number num1 = new Number(deldemo.Add);
            Number num2 = new Number(deldemo.Subtract);
            Number num3 = new Number(deldemo.Multiply);


            int[] actual1 = new int[3];
            actual1[0] = num1(param1, param2);
            actual1[1] = num2(param1, param2);
            actual1[2] = num3(param1, param2);

            int[] actualResult = new int[] { actual1[0], actual1[1], actual1[2] };


            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }
    }
}
