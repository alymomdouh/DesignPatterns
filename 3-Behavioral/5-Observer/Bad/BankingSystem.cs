using ObserverPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Bad
{
    public class BankingSystem
    {
        private readonly SMSService _smsService = new();
        private readonly EmailService _emailService = new();
        private readonly PushNotificationService _pushService = new();
        private readonly TransactionLogger _logger = new();
        private readonly WhatsAppService _whatsApp = new();



        public void ProcessTransaction(Transaction transaction, string userGroup)
        {

            if (userGroup == "A")
            {
                _smsService.SendSMS(transaction);
                _emailService.SendEmail(transaction);
            }
            else if (userGroup == "B") 
            {
                _smsService.SendSMS(transaction);
                _pushService.SendPushNotification(transaction);
                _whatsApp.SendMessage(transaction);
            }
            else
            {
                _smsService.SendSMS(transaction);
                _emailService.SendEmail(transaction);
                _pushService.SendPushNotification(transaction);
                _logger.LogTransaction(transaction);
                _whatsApp.SendMessage(transaction);
            }
               
            

            Console.WriteLine($"💰 Current Balance: {transaction.CurrentBalance:N0}");
        }
    }
}
