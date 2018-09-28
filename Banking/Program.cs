using Banking.Models.Domain;
using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object Initializer
            //BankAccount anotherBA = new BankAccount()
            //{
            //    AccountNumber = "123-12312334-990",
            //    Balance = 200
            //};

            BankAccount myBa = new BankAccount("123-12312312-99", 50);

            Console.WriteLine($"Account number is {myBa.AccountNumber}.");
            
            Console.WriteLine($"Balance is {myBa.Balance} Euro");
            myBa.Deposit(200);
            Console.WriteLine($"Balance is {myBa.Balance} Euro");
            myBa.Withdraw(50);
            Console.WriteLine($"Balance is {myBa.Balance} Euro");
            Console.ReadKey();

        }
    }
}
