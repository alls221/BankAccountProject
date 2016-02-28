using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
   public class Clients
    {
        string name = "Jane Doe";
        int accountNumber = GetAccountnumber();

        public string Name { get; set; }
        public int AccountNumber { get; set; }

        public Clients()
        {
            Name = name;
            AccountNumber = accountNumber;
        }
        public static int GetAccountnumber ()
        {
            Random randomNumber = new Random();
            int accountNum=randomNumber.Next(100000, 1000000);
            return accountNum;
        }
    }
}
