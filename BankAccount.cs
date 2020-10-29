using System;

namespace ClientBankAccount
{
    public class BankAccount
    {
        protected string AccountOwner { get; set; }
        protected double InterestRate { get; set; }
        protected decimal AccountBalance { get; set; }

        public BankAccount(string accountOwner, double interestRate, decimal accountBalance) {
            AccountOwner = accountOwner;
            InterestRate = interestRate;
            AccountBalance = accountBalance;
        }

        public BankAccount(string accountOwner, double interestRate) {
            AccountOwner = accountOwner;
            InterestRate = interestRate;
            AccountBalance = 0.0M;
        }

        public virtual decimal Balance{
            get {return AccountBalance; }
        }

        public virtual void Withdraw(decimal amount) {
            AccountBalance -= amount;
        }

        // Bank account deposit
        public virtual void Deposit(decimal amount) {
            AccountBalance += amount;
        }

        // Calculating bank account interestRate
        public virtual void AddInterests() {
            AccountBalance += AccountBalance * (decimal)InterestRate;
        }

        public override string ToString() {
            return AccountOwner + "'s account holds " + AccountBalance + " dollars";
        }
    }
}