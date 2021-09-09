using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMOperations
{
    interface IOperations
    {
        double Withdraw(double withAmt);
        double Deposit(double depAmt);
        double MobileRecharge(double rechAmt);
        double BalanceCheck();
        bool CheckDeposit(char consent);

    }
}
