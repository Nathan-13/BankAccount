using System;
namespace ClientBankAccount
{
    public class SavingsAccount: BankAccount {
        public SavingsAccount(string AccountOwner, double InterestRate): 
            base(AccountOwner, InterestRate, 0.0M) {
        }
        public SavingsAccount(string AccountOwner, double InterestRate, decimal AccountBalance) :
            base(AccountOwner, InterestRate, AccountBalance) {
        }

        // Method Balance is inherited
        // Method Deposit is inherited

        public override void Withdraw (decimal amount) {
            if (amount < AccountBalance) {
                base.Withdraw(amount);
            } else {
                throw new Exception("Cannot withdraw");
            }
        }

        public override void AddInterests() {
            AccountBalance = AccountBalance + AccountBalance * (decimal)InterestRate - 100.0M;
        }    

        public override string ToString() {
            return AccountOwner + "'s saving account holds " +
            + AccountBalance + " dollar";
        }
    }
}
    
