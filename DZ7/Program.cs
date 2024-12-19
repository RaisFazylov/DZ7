using System;

namespace BankAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 9.1");
            /* В классе банковский счет, созданном в предыдущих упражнениях, удалить
            методы заполнения полей. Вместо этих методов создать конструкторы. Переопределить
            конструктор по умолчанию, создать конструктор для заполнения поля баланс, конструктор
            для заполнения поля тип банковского счета, конструктор для заполнения баланса и типа
            банковского счета. Каждый конструктор должен вызывать метод, генерирующий номер
            счета.*/
            BankAccount defaultAccount = new BankAccount();
            Console.WriteLine($"Номер счета (по умолчанию): {defaultAccount.AccountNumber}, " +
                              $"Баланс: {defaultAccount.Balance}, " +
                              $"Тип счета: {defaultAccount.AccountType}");
            BankAccount balanceAccount = new BankAccount(666);
            Console.WriteLine($"Номер счета (с балансом): {balanceAccount.AccountNumber}, " +
                              $"Баланс: {balanceAccount.Balance}, " +
                              $"Тип счета: {balanceAccount.AccountType}");
            BankAccount typeAccount = new BankAccount("Сберегательный");
            Console.WriteLine($"Номер счета (с типом): {typeAccount.AccountNumber}, " +
                              $"Баланс: {typeAccount.Balance}, " +
                              $"Тип счета: {typeAccount.AccountType}");
            BankAccount fullAccount = new BankAccount(777, "Текущий");
            Console.WriteLine($"Номер счета (с балансом и типом): {fullAccount.AccountNumber}, " +
                              $"Баланс: {fullAccount.Balance}, " +
                              $"Тип счета: {fullAccount.AccountType}");
        }
    }
}
