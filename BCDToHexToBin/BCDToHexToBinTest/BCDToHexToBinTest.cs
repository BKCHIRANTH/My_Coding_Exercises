using System;
using BCDToHexToBin;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BCDToHexToBinTest
{
    [TestClass]
    public class BCDToHexToBinTest
    {
        [TestMethod]
        public void BCDToHexaToBinTest_01()
        {
            String bcd = "10100100";
            String expectedResult = " 68";


            BCDHexBin hex = new BCDHexBin();
            String binary = hex.bcdToBinary(bcd);

            String actualResult = hex.binaryToHexaDecimal(binary.ToCharArray());

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BCDToHexaToBinTest_02()
        {
            String bcd = "1000";
            String expectedResult = " 8";


            BCDHexBin hex = new BCDHexBin();
            String binary = hex.bcdToBinary(bcd);

            String actualResult = hex.binaryToHexaDecimal(binary.ToCharArray());

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BCDToHexaToBinTest_03()
        {
            String bcd = "10#0";
            String expectedResult = " ";


            BCDHexBin hex = new BCDHexBin();

            String binary = hex.bcdToBinary(bcd);

            String actualResult = hex.binaryToHexaDecimal(binary.ToCharArray());

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BCDToHexaToBinTest_04()
        {
            String bcd = "100000000";
            String expectedResultBinary = "1100100";


            BCDHexBin hex = new BCDHexBin();
            String actualResult = hex.bcdToBinary(bcd);

            Assert.AreEqual(expectedResultBinary, actualResult);
        }
    }
}
