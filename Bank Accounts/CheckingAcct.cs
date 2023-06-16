using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Accounts
{
    class CheckingAcct : Account
    {
        // Constants
        const int OVERDRAFT = 35;
        
        // Constructor
        public CheckingAcct(string accountOwnerFirst, string accountOwnerLast, decimal balance) : base(accountOwnerFirst, accountOwnerLast, balance) { }
        
        public override void Withdraw(decimal amount)
        {
            if (this.Balance - amount > 0)
            {
                base.Withdraw(amount);
            }
            else
            {
                base.Withdraw(amount - OVERDRAFT);
            }
        }
    }
}
