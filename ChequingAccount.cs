using System;
namespace ClientBankAccount
{
    public class ChequingAccount: BankAccount {
        public ChequingAccount(string AccountOwner, double InterestRate): 
            base(AccountOwner, InterestRate, 0.0M) {
        }
        public ChequingAccount(string AccountOwner, double InterestRate, decimal AccountBalance):
            base(AccountOwner, InterestRate, AccountBalance) {
        }

        // Method Balance is inherited
        // Method Deposit is inherited
        // Method AddInterests is inherited

        public override void Withdraw(decimal amount) {
            base.Withdraw(amount);
            if(amount < AccountBalance)
            InterestRate = -0.10;
        }
        public override string ToString() {
            return AccountOwner + "'s cheque account holds " + AccountBalance + " dollars";
        }

    }
}