using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccounts;

namespace BankAccountTest
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void BankAccountTest_01()
        {
            //arrange
            string name = "Example_Name";
            double accNo = 54751455804;
            string type = "Savings";
            double balance = 34000;
            string[] expectedResult = { "Example_Name", "54751455804", "Savings", "34000" };

            //act
            BankAccounting acc = new BankAccounting();
            string[] actualResult = acc.AssigningValues(name, accNo, type, balance);

            //assert
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void BankAccountTest_02()
        {
            //arrange
            
            double deposit = 34000;
            double expectedResult = 68000;

            //act
            
            BankAccounting acc = new BankAccounting();
            string name = "Example_Name";
            double accNo = 54751455804;
            string type = "Savings";
            double balance = 34000;
            acc.AssigningValues(name, accNo, type, balance);

            double actualResult = acc.DepositAmount(deposit);

            //assert
            
                Assert.AreEqual(expectedResult, actualResult);
            
        }

        [TestMethod]
        public void BankAccountTest_03()
        {
            //arrange
            double deposit = 34000;
            double withdraw = 4000;
            double expectedResult = 30000;

            //act
            BankAccounting acc = new BankAccounting();
            acc.DepositAmount(deposit);
            double actualResult = acc.WithDrawAmount(withdraw);

            //assert

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void BankAccountTest_04()
        {
            //arrange
            string name = "Account Holder Name";
            double accNo = 58744112;
            string type = "Savings";
            double balance = 10000;
            string[] expectedResult = { "Account Holder Name",  "10000" };

            //act
            BankAccounting acc = new BankAccounting();
            acc.AssigningValues(name, accNo, type, balance);
            string[] actualResult  = acc.DisplayDepositor();

            //assert

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }
    }
}
