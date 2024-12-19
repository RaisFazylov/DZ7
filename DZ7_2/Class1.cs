﻿using System;
using System.Collections.Generic;

namespace BankAccountApp
{
    public class BankAccount
    {
        private static int accountNumberSeed = 6666666;
        private readonly int accountNumber; 
        private decimal balance; 
        private string accountType;
        private Queue<BankTransaction> transactions;
        public BankAccount()
        {
            accountNumber = GenerateAccountNumber();
            balance = 0; 
            accountType = "Стандартный";
            transactions = new Queue<BankTransaction>();
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
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Сумма должна быть положительной.");
            }

            balance += amount; 
            transactions.Enqueue(new BankTransaction(amount));
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Сумма должна быть положительной.");
            }

            if (balance < amount)
            {
                throw new InvalidOperationException("Недостаточно средств на счете.");
            }

            balance -= amount; 
            transactions.Enqueue(new BankTransaction(-amount));
        }
        public int AccountNumber => accountNumber; 
        public decimal Balance => balance;
        public string AccountType => accountType;
        public Queue<BankTransaction> Transactions => transactions; 
    }
}