using System;

namespace Banking.Models.Domain
{
    class BankAccount
    {
        // private string _accountNumber;
        #region Fields
   
        private decimal _balance;

        #endregion


        #region Properties
        public string AccountNumber { get;  set; }


        public decimal Balance
        {
            get
            {
                return _balance;
            }
             set
            {
                if (value < 0)
                    throw new ArgumentException("No negative Balance!");
                _balance = value;
            }

        }
        #endregion
        #region Constructors
        public BankAccount()
        {

        }
        
        public BankAccount(String accountNumber)
        {
            AccountNumber = accountNumber;
        }
        public BankAccount(String accountNumber, decimal balance) : this(accountNumber)
        {
            Balance = balance;
        } 
        #endregion

        #region Methods
        public void Deposit(decimal amount, int nrOfTimes=1)
        {
            Balance += amount * nrOfTimes;
        }
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        } 
        #endregion
    }
}
