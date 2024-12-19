using System;

namespace BankAccountApp
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;
        private readonly int accountNumber;
        private decimal balance;
        private string accountType;
        public BankAccount()
        {
            accountNumber = GenerateAccountNumber();
            balance = 0;
            accountType = "Стандартный";
        }
        public BankAccount(decimal initialBalance) : this()
        {
            balance = initialBalance;
        }
        public BankAccount(string type) : this()
        {
            accountType = type;
        }
        public BankAccount(decimal initialBalance, string type) : this()
        {
            balance = initialBalance; 
            accountType = type;
        }
        private int GenerateAccountNumber()
        {
            return accountNumberSeed++;
        }
        public int AccountNumber => accountNumber;
        public decimal Balance => balance;
        public string AccountType => accountType; 
    }
}
