using System;

namespace BankAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BankAccount account = new BankAccount(1000, "Сберегательный"))
            {
                Console.WriteLine("Задание 9.3");
                /* В классе банковский счет создать метод Dispose, который данные о
                проводках из очереди запишет в файл. Не забудьте внутри метода Dispose вызвать метод
                GC.SuppressFinalize, который сообщает системе, что она не должна вызывать метод
                завершения для указанного объекта. */
                account.Deposit(666);
                account.Withdraw(888);
                Console.WriteLine($"Номер счета: {account.AccountNumber}");
                Console.WriteLine($"Баланс: {account.Balance}");
                Console.WriteLine($"Тип счета: {account.AccountType}");
                Console.WriteLine("Транзакции:");
                foreach (var transaction in account.Transactions)
                {
                    Console.WriteLine($"{transaction.TransactionDate}: {transaction.Amount}");
                }
            }
            Console.WriteLine("Данные о транзакциях записаны в файл.");
        }
    }
}
