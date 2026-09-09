using ObserverPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    internal class SMSSubscriber : ISubscriber
    {
        public void Update(Transaction transaction)
        {
            Console.WriteLine($"📱 SMS Service: Transaction {transaction.Amount:C}");
        }
    }
}
