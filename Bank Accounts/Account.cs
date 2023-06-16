using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Accounts
{
    abstract class Account
    {
        // Fields
        private decimal _balance;
        private string _accountOwnerFirst;
        private string _accountOwnerLast;

        // Constructor
        public Account (string accountOwnerFirst, string accountOwnerLast, decimal balance) 
        { 
            _accountOwnerFirst = accountOwnerFirst;
            _accountOwnerLast = accountOwnerLast;
            _balance = balance;
        }

        // Properties
        public decimal Balance
        {  
            get => _balance;
            set => _balance = value;
        }

        public string AccountOwner
        {
            get => this._accountOwnerFirst + " " + this._accountOwnerLast;
        }
        
        // Methods
        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
