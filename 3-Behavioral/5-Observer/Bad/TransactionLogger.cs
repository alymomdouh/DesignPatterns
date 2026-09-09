using ObserverPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Bad
{
    public class TransactionLogger
    {
        public void LogTransaction(Transaction transaction)
        {
            Console.WriteLine($"📝  Logger: Transaction {transaction.Amount:C}");
        }
    }
}
