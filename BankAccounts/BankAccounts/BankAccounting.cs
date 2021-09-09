using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class BankAccounting
    {
         static string depName="N/A";
         static double depAcc=0;
         static string depAcctype="";
         static double depBalance=0;
        
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                BankAccounting bank = new BankAccounting();
                Console.WriteLine("\n"+"Enter the choice: 1.Create 2.Deposit 3.Withdraw 4.Display");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: Console.WriteLine("Enter the name of the depositor");
                            string Name = Console.ReadLine();
                            Console.WriteLine("Enter the account number");
                            double accno = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the account type");
                            string acctype = Console.ReadLine();
                            Console.WriteLine("Enter the account balance");
                            double bal = Convert.ToInt32(Console.ReadLine());
                            bank.AssigningValues(Name, accno, acctype, bal);
                            break;

                    case 2: Console.WriteLine("Enter the deposit amount");
                            double depositAmt = Convert.ToInt32(Console.ReadLine());
                            double balanceRet = bank.DepositAmount(depositAmt);
                            break;

                    case 3: Console.WriteLine("Enter the withdrawing amount");
                            double withdraw = Convert.ToInt32(Console.ReadLine());
                            bank.WithDrawAmount(withdraw);
                            break;

                    case 4: bank.DisplayDepositor();
                            break;

                    default: Environment.Exit(0);
                             break;

                }
            }
           
        }

        public string[] AssigningValues(string name, double accNo, string type, double balance)
        {
            depName = name;
            depAcc = accNo;
            depAcctype = type;
            depBalance = balance;

            string[] result = { depName, depAcc.ToString(), depAcctype, depBalance.ToString() };
            return result;
        }

        public double DepositAmount(double deposit)
        {
            depBalance = depBalance + deposit;
            Console.WriteLine("Available Balance: " + depBalance);
            return depBalance;
        }
        public double WithDrawAmount(double withdrawAmt)
        {
            if (depBalance >= withdrawAmt)
            {
                depBalance = depBalance - withdrawAmt;
                Console.WriteLine("Available Balance: " + depBalance);
                return depBalance;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
                return 0;
            }
        }

        public string[] DisplayDepositor()
        {
            Console.WriteLine("Account holder name : "+depName);
            Console.WriteLine("Account holder balance : " + depBalance);

            string[] nameBalance = new string[] { depName, depBalance.ToString() };
            return nameBalance;
        }
    }
}
