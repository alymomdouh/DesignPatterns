using ObserverPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Bad
{
    internal class WhatsAppService
    {
        public void SendMessage(Transaction transaction)
        {
            Console.WriteLine($"💬 WhatsApp Service: Transaction {transaction.Amount:C} - HARD CODED");
          
        }
    }
}
