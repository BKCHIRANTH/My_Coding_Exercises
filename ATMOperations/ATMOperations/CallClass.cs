using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMOperations
{
   public class CallClass
    {
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                ATMOperation atmOp = new ATMOperation();
                Console.WriteLine("\n" + "Enter the choice: 1.Withdraw 2.Deposit 3.Mobile Recharge 4.View Balance");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: Console.WriteLine("Enter the amount to be withdrawn");
                            double withdr = Convert.ToInt32(Console.ReadLine());
                            atmOp.Withdraw(withdr);
                            break;

                    case 2: Console.WriteLine("Waiting for the approval....");
                            Console.WriteLine("\n");
                            Console.WriteLine("Approval for deposit required!");
                            Console.WriteLine("To approve: y/Y or To decline: any key");
                            char approve = Convert.ToChar(Console.ReadLine());
                            bool consent = atmOp.CheckDeposit(approve);
                            if(consent == true)
                            {
                            Console.WriteLine("Enter the amount to be deposited:");
                            double amt = Convert.ToInt32(Console.ReadLine());
                            atmOp.Deposit(amt);
                            }
                            break;

                    case 3: Console.WriteLine("Enter the recharge amount");
                            double recharge = Convert.ToInt32(Console.ReadLine());
                            atmOp.MobileRecharge(recharge);
                            break;

                    case 4: atmOp.BalanceCheck();
                            break;

                    default:Environment.Exit(0);
                            break;
                }
            }
        }
    }
}
