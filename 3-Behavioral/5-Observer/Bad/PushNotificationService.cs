using ObserverPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Bad
{
    public class PushNotificationService
    {
        public void SendPushNotification(Transaction transaction)
        {
            Console.WriteLine($"🔔 Push Service: Transaction {transaction.Amount:C}");
        }
    }
}
