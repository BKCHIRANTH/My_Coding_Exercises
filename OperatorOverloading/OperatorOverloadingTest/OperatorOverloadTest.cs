using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperatorOverloading;
namespace OperatorOverloadingTest
{
    [TestClass]
    public class OperatorOverloadTest
    {
        [TestMethod]
        public void OperatorOverloadTest_01()
        {
            int input1 = 10;
            int input2 = 20;
            int expectedResult = 30;


            OpOverload opObj1 = new OpOverload(input1);
            OpOverload opObj2 = new OpOverload(input2);
            OpOverload opObj3 = opObj1 + opObj2;
            int actualResult = opObj3.GetValue();

            Assert.AreEqual(expectedResult, actualResult);
        }
    

        [TestMethod]
        public void OperatorOverloadTest_02()
        {
        string str1 = "ABC";
        string str2 = "XYZ";
        string expectedResult = "AXBYCZ";


        OpOverloadString opString1 = new OpOverloadString(str1);
        OpOverloadString opString2 = new OpOverloadString(str2);

        OpOverloadString opString3 = opString1 + opString2;
        string actualResult = opString3.GetString();

        Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void OperatorOverloadTest_03()
        {
            string str1 = "ABC";
            string str2 = " ";
            string expectedResult = " ";

            OpOverloadString opString1 = new OpOverloadString(str1);
            OpOverloadString opString2 = new OpOverloadString(str2);

            OpOverloadString opString3 = opString1 + opString2;
            string actualResult = opString3.GetString();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }

}

