using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Accounts
{
    class SavingsAcct : Account
    {
        // Constants
        const int EXCESS_WITHDRAWALS = 2;
        
        // Fields
        private decimal _interestRate;
        private int _withdrawalsRemaining = 3;

        // Constructor
        public SavingsAcct(string accountOwnerFirst, string accountOwnerLast, decimal balance, decimal interest) : base(accountOwnerFirst, accountOwnerLast, balance) 
        {
            _interestRate = interest;
        }

        // Methods
        public override void Withdraw(decimal amount)
        {
            // Do not allow withdrawal if it will go into debt
            if (this.Balance - amount < 0)
            {
                return;
            }

            // Charge $2 for every withdrawal over 3
            if (_withdrawalsRemaining > 0)
            {
                base.Withdraw(amount);
                _withdrawalsRemaining--;
            }
            else
            {
                base.Withdraw(amount + EXCESS_WITHDRAWALS);
            }
        }

        public void ApplyInterest()
        {
            this.Balance += this.Balance * _interestRate;
        }
    }
}
