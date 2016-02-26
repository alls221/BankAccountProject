using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Accounts
    {
        int Balance;
        int DepositAmt;
        int WithDrawAmt;

        public int balance { get { return this.balance; } set { this.balance = value; } }

        public static int WithdrawFunds (int Balance, int WithDrawAmt)
        {
            int balance = (Balance - WithDrawAmt);
            return balance;
        }
        public static int DepositFunds (int Balance, int DepositAmt)
        {
            int balance= (Balance + DepositAmt);
            return balance;
        }
    }
}
