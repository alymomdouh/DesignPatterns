using ObserverPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    public class EmailSubscriber : ISubscriber
    {
        public void Update(Transaction transaction)
        {
            Console.WriteLine($"📧 Email Service: Transaction {transaction.Amount:C}");
        }
    }
}
