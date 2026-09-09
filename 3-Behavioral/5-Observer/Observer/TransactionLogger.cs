using ObserverPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    internal class TransactionLogger : ISubscriber
    {
        public void Update(Transaction transaction)
        {
            Console.WriteLine($"📝  Logger: Transaction {transaction.Amount:C}");
        }
    }
}
