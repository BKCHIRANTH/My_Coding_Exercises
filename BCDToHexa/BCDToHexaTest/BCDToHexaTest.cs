using System;
using System.Collections.Generic;
using BCDToHexa;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BCDToHexaTest
{
    [TestClass]
    public class BCDToHexaTest
    {
        [TestMethod]
        public void BCDToHexaTest_01()
        {
            String bcd = "10100100";
            String expectedResult =  " 68";


            BCDHexa hex = new BCDHexa();
            String binary = hex.bcdToBinary(bcd);

            String actualResult = hex.binaryToHexaDecimal(binary.ToCharArray());

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BCDToHexaTest_02()
        {
            String bcd = "1000";
            String expectedResult = " 8";


            BCDHexa hex = new BCDHexa();
            String binary = hex.bcdToBinary(bcd);

            String actualResult = hex.binaryToHexaDecimal(binary.ToCharArray());

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BCDToHexaTest_03()
        {
            String bcd = "10#0";
            String expectedResult = " ";


            BCDHexa hex = new BCDHexa();
            String binary = hex.bcdToBinary(bcd);

            String actualResult = hex.binaryToHexaDecimal(binary.ToCharArray());

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
    
}
