using System;

namespace ClientBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ComIT Client Bank Account\n");
            BankAccount [] accounts = new BankAccount[3] {
                new ChequingAccount("Bill", 0.02, 1000.0M),
                new SavingsAccount("Charlie", 0.07, 1500.0M),
                new ChequingAccount("Thomas", 0.02, 3000.0M)
            };

            // Console.WriteLine("Please enter d - for deposit request; a - to add interest; w - withdraw; and q - quit");
            //     string userInput = Console.ReadLine();

            //     if(userInput == "d")
            //     Console.WriteLine("Please enter account owner: ");
            //     string AccountOwner = Console.ReadLine();
            //     foreach(BankAccount acc in accounts) {
            //     acc.Deposit(1000.0M);
            //     }   

            //     accounts[2].Withdraw(1050.0M);

            //     foreach(BankAccount acc in accounts) {
            //     acc.AddInterests();
            //     }
            
            //     foreach(BankAccount acc in accounts) {
            //     Console.WriteLine("{0}", acc);
            //     }

            foreach(BankAccount acc in accounts) {
                acc.Deposit(1000.0M);
            }

            accounts[2].Withdraw(1050.0M);

            foreach(BankAccount acc in accounts) {
                acc.AddInterests();
            }

            foreach(BankAccount acc in accounts) {
                Console.WriteLine("{0}", acc);
            }
            
        }
    }
}
