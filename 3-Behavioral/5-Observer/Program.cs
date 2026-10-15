using ObserverPattern.Models;
using ObserverPattern.Observer;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //var bad = new BankingSystem();

            //Console.Write("User group (A/B/ALL): ");
            //var group = (Console.ReadLine() ?? "ALL").Trim().ToUpperInvariant();

            //Console.Write("Initial balance: ");
            //int balance = int.Parse(Console.ReadLine() ?? "0");

            //Console.WriteLine("\n--- Enter transactions (Q to quit) ---");

            //while (true)
            //{
            //    Console.Write("\nType (1=Deposit, 2=Withdrawal, Q=quit): ");
            //    var c = Console.ReadLine();
            //    if (string.Equals(c, "q", StringComparison.OrdinalIgnoreCase)) break;
            //    if (c != "1" && c != "2") { Console.WriteLine("Invalid"); continue; }

            //    var type = c == "1" ? TransactionType.Deposit : TransactionType.Withdrawal;

            //    Console.Write("Amount: ");
            //    if (!int.TryParse(Console.ReadLine(), out var amount) || amount < 0)
            //    { Console.WriteLine("Invalid"); continue; }

            //    if (type == TransactionType.Withdrawal && amount > balance)
            //    { Console.WriteLine($"❌ Insufficient funds. Balance: {balance:N0}"); continue; }

            //    balance = type == TransactionType.Deposit ? balance + amount : balance - amount;

            //    var tx = new Transaction
            //    {
            //        AccountNumber = "ACC-001",
            //        Amount = amount,
            //        Type = type,
            //        Timestamp = DateTime.Now,
            //        CurrentBalance = balance
            //    };

            //    bad.ProcessTransaction(tx, group);
            //}

            //Console.WriteLine("\n👋 Bye!");



            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Enter initial balance: ");
            decimal initialBalance = decimal.Parse(Console.ReadLine());

            var bankingSystem = new NewBankingSystem(initialBalance);

            Console.WriteLine("\nSelect notification channels (comma separated):");
            Console.WriteLine("1. Email");
            Console.WriteLine("2. SMS");
            Console.WriteLine("3. Push");
            Console.WriteLine("4. WhatsApp");
            var choices = Console.ReadLine().Split(',');

            foreach (var choice in choices)
            {
                switch (choice.Trim())
                {
                    case "1": bankingSystem.Subscribe(new EmailSubscriber()); break;
                    case "2": bankingSystem.Subscribe(new SMSSubscriber()); break;
                    case "3": bankingSystem.Subscribe(new PushNotificationSubscriber()); break;
                    case "4": bankingSystem.Subscribe(new WhatAppSubscriber()); break;
                }
            }

            Console.WriteLine("\n--- Enter transactions (Q to quit) ---");
            while (true)
            {
                Console.Write("Type (1=Deposit, 2=Withdrawal, Q=quit): ");
                var typeInput = Console.ReadLine();
                if (typeInput?.ToUpper() == "Q") break;

                Console.Write("Amount: ");
                decimal amount = decimal.Parse(Console.ReadLine());

                var tx = new Transaction
                {
                    AccountNumber = "12345",
                    Amount = amount,
                    Type = (TransactionType)int.Parse(typeInput)
                };

                bankingSystem.ProcessTransaction(tx);
            }
        }
    }
}
