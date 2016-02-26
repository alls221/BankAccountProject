using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
   public class Clients
    {
        string Name;
        int AccountNumber;

        public string name { get { return this.Name; } set { this.name = value; } }
        int accountNumber { get { return this.AccountNumber; } set { this.accountNumber = value; } }

        public Clients ()
        {
            this.name ="Jane Doe";
            this.accountNumber = GetAccountnumber();
        }
        public int GetAccountnumber ()
        {
            Random randomNumber = new Random();
            int accountNum=randomNumber.Next(100000, 1000000);
            return accountNum;
        }
    }
}
