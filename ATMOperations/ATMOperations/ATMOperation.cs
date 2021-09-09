using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMOperations
{
   public class ATMOperation : IOperations
    {
        public struct ATM
        {
            public static double balance;
            public static bool checkConsent;
        }

        ATM atm = new ATM();
        public double Withdraw(double withAmt)
        {
            if (withAmt > ATM.balance)
            {
                Console.WriteLine("Insufficient Balance");
                return 0;
            }

            ATM.balance -= withAmt;
            Console.WriteLine("Withdrawal Successful");
            Console.WriteLine("Available Balance: {0}", ATM.balance);
            return ATM.balance;
        }

        public double MobileRecharge(double rechAmt)
        {
            if(rechAmt > ATM.balance)
            {
                Console.WriteLine("Insufficient Balance");
                return 0;
            }
            ATM.balance -= rechAmt;
            Console.WriteLine("Recharge Successful");
            Console.WriteLine("Available Balance: {0}", ATM.balance);
            return ATM.balance;
        }

        public double BalanceCheck()
        {
            Console.WriteLine("Available Balance: {0}", ATM.balance);
            return ATM.balance;
        }

        public double Deposit(double depAmt)
        {
            
            ATM.balance += depAmt;
            Console.WriteLine("Deposit Successful");
            Console.WriteLine("Available Balance: {0}", ATM.balance);
            return ATM.balance;
        }

        public bool CheckDeposit(char consent)
        {
            if(consent == 'y' || consent == 'Y')
            {
                Console.WriteLine("Approval Given!");
                //Console.WriteLine("Enter the amount to be deposited:");
                //double amt = Convert.ToInt32(Console.ReadLine());
                //Deposit(amt);
                ATM.checkConsent = true;
                return ATM.checkConsent;
            }

            Console.WriteLine("Consent declined");
            ATM.checkConsent = false;
            return ATM.checkConsent;
        }
    }
}
