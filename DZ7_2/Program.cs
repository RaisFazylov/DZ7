using System;

namespace BankAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 9.2");
            /*Создать новый класс BankTransaction, который будет хранить информацию
            о всех банковских операциях. При изменении баланса счета создается новый объект класса
            BankTransaction, который содержит текущую дату и время, добавленную или снятую со
            счета сумму. Поля класса должны быть только для чтения (readonly). Конструктору класса
            передается один параметр – сумма. В классе банковский счет добавить закрытое поле типа
            System.Collections.Queue, которое будет хранить объекты класса BankTransaction для
            данного банковского счета; изменить методы снятия со счета и добавления на счет так,
            чтобы в них создавался объект класса BankTransaction и каждый объект добавлялся в
            переменную типа System.Collections.Queue.*/
            BankAccount account = new BankAccount(666, "Сберегательный");
            account.Deposit(500);
            account.Withdraw(200);
            Console.WriteLine($"Номер счета: {account.AccountNumber}");
            Console.WriteLine($"Баланс: {account.Balance}");
            Console.WriteLine($"Тип счета: {account.AccountType}");
            Console.WriteLine("Транзакции:");
            foreach (var transaction in account.Transactions) 
            {
                Console.WriteLine($"{transaction.TransactionDate}: {transaction.Amount}");
            }
        }
    }
}
