using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ATMOperations;
namespace ATMOperationsTest
{
    [TestClass]
    public class ATMOperationsTest
    {
        [TestMethod]
        public void ATMOpsTest_01()
        {
            double deposit = 20000;
            double expectedResult = 20000;
            char consent = 'y';

            ATMOperation atmOp = new ATMOperation();
            bool status = atmOp.CheckDeposit(consent);
            double actualResult = 0;
            if (status == true)
            {
                actualResult = atmOp.Deposit(deposit);
            }

            Assert.AreEqual(expectedResult, actualResult);
            
        }

        [TestMethod]
        public void ATMOpsTest_02()
        {
            double withdraw = 2000;
            double expectedResult = 1000;
            

            ATMOperation atmOp = new ATMOperation();
            atmOp.Deposit(3000);
            double actualResult = atmOp.Withdraw(withdraw);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void ATMOpsTest_03()
        {
            double deposit = 52000;
            double expectedResult = 0;
            char consent = 'n';

            ATMOperation atmOp = new ATMOperation();
            bool status = atmOp.CheckDeposit(consent);
            double actualResult = 0;
            if (status == true)
            {
                actualResult = atmOp.Deposit(deposit);
            }

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void ATMOpsTest_04()
        {
            double recharge = 200;
            double expectedResult = 3800;


            ATMOperation atmOp = new ATMOperation();
            atmOp.Deposit(4000);
            double actualResult = atmOp.MobileRecharge(recharge);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void ATMOpsTest_05()
        {
            double withdraw = 500;
            double deposit = 5000;
            double recharge = 300;
            double expectedResult = 4200;


            ATMOperation atmOp = new ATMOperation();
            atmOp.Deposit(deposit);
            atmOp.MobileRecharge(recharge);
            atmOp.Withdraw(withdraw);
            double actualResult = atmOp.BalanceCheck();

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
