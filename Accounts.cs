using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
   public class Accounts
    {
        int balance=0;
        int depositAmt = 0;
        int withDrawAmt = 0;

        public int Balance { get; set; }
        public int DepositAmt { get; set; }
        public int WithDrawAmt { get; set; }

        public Accounts ()
        {
            Balance = balance;
            DepositAmt = depositAmt;
            WithDrawAmt = withDrawAmt;
        }

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
        public static int GetWithDrawAmt ()
        {
            Console.WriteLine("Enter the ammount to Withdraw");
            int WithDrawAmt = int.Parse(Console.ReadLine());
            return WithDrawAmt;
        }
        public static int GetDepositAmt ()
        {
            Console.WriteLine("Enter the ammount to Deposit");
            int DepositAmt = int.Parse(Console.ReadLine());
            return DepositAmt;
        }
    }
}
