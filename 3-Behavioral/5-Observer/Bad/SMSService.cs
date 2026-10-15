using ObserverPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Bad
{
    public class SMSService
    {
        public void SendSMS(Transaction transaction)
        {
            Console.WriteLine($"📱 SMS Service: Transaction {transaction.Amount:C}");
        }
    }

}
