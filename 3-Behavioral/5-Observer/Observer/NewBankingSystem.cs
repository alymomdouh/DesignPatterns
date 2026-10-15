using ObserverPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    public class NewBankingSystem
    {
        private readonly List<ISubscriber> _subscribers= new();

        private decimal _balance;

        public NewBankingSystem(decimal IntialBalance)
        {
            _balance = IntialBalance;
        }


        public void Subscribe(ISubscriber subscriber) => _subscribers.Add(subscriber);
        public void UnSubscribe(ISubscriber subscriber) => _subscribers.Remove(subscriber);


        public void ProcessTransaction(Transaction transaction)
        {
            if (transaction.Type == TransactionType.Deposit)
                _balance += transaction.Amount;

            else if(transaction.Type == TransactionType.Withdrawal)
                _balance -= transaction.Amount;

            transaction.CurrentBalance = _balance;

            Notify(transaction);

            Console.WriteLine($"💰 Current Balance: {transaction.CurrentBalance:N0}");
        }

        private void Notify(Transaction transaction)
        {
            foreach(var subscriber in _subscribers)
            {
                subscriber.Update(transaction);
            }
        }
    }
}
