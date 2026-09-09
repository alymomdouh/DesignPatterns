using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Models
{
    public class Transaction
    {
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
        public DateTime Timestamp { get; set; }
        public string Description { get; set; }
        public string ToAccount { get; set; } 
        public decimal CurrentBalance { get; set; }
    }
}
