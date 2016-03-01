using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
   public class Accounts
    {
        decimal balance=0;
        decimal depositAmt = 0;
        decimal withDrawAmt = 0;

        public decimal Balance { get; set; }
        public decimal DepositAmt { get; set; }
        public decimal WithDrawAmt { get; set; }

        public Accounts ()
        {
            Balance = balance;
            DepositAmt = depositAmt;
            WithDrawAmt = withDrawAmt;
        }

        public void WithdrawFunds (decimal WithDrawAmt)
        {
            Balance = Math.Round((Balance - WithDrawAmt),2);
            Console.WriteLine("Balance:" +"$" +Balance);
        }
        public void DepositFunds ( decimal DepositAmt)
        {
            Balance= Math.Round( (Balance + DepositAmt),2);
            Console.WriteLine("Balance: "+"$" +Balance);
        }
        public decimal GetWithDrawAmt ()
        {
            while (true)
            {
                Console.WriteLine("Enter the ammount to Withdraw");
                string wa = Console.ReadLine();
                if (decimal.TryParse(wa, out withDrawAmt) == true)
                {
                    return withDrawAmt;
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                    continue;
                }
            }
        }
        public decimal GetDepositAmt ()
        { 
        while (true)
            {
                Console.WriteLine("Enter the ammount to Deposit");
                string da = Console.ReadLine();
                if (decimal.TryParse(da, out depositAmt) == true)
                {
                    return depositAmt;
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                    continue;
                }
            }
        }
    }
}
