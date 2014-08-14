using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAccounting.Model
{
    public class TransactionLine
    {
        public TransactionLine(Transaction transaction)
        {
            Date = DateTime.UtcNow;
            this.Transaction = transaction;
        }

        public Account Creditor { get; set; }
        public Account Debtor { get; set; }

        public Transaction Transaction { get; protected set; }
        public decimal Amount { get; set; }

        public DateTime Date { get; protected set; }

        public override string ToString()
        {
            return string.Format("Creditor {0}, Debtor {1}, Amount {2}",
                Creditor == null ? "--" : Creditor.Name,
                Debtor == null ? "--" : Debtor.Name,
                Amount);
        }
    }
}