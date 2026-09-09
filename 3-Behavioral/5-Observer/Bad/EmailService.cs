using ObserverPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Bad
{
    public class EmailService
    {
        public void SendEmail(Transaction transaction)
        {
            Console.WriteLine($"📧 Email Service: Transaction {transaction.Amount:C}");
        }
    }
}
