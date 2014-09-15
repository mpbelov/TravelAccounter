using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAccounting.Model {
    public class TransactionLine {
        public TransactionLine(Transaction transaction) {
            Transaction = transaction;
        }

        public virtual Account Creditor { get; set; }
        public virtual Account Debtor { get; set; }

        public virtual Transaction Transaction { get; protected set; }
        public virtual Currency Currency { get { return Transaction.Currency; } }
        public virtual decimal BaseAmount { get { return ActualAmount * Currency.ExchangeRate; } }
        public virtual decimal ActualAmount { get; set; }

        public virtual DateTime Date { get { return Transaction.Date; } }

        public override string ToString() {
            return string.Format("Creditor {0}, Debtor {1}, Amount {2}",
                Creditor == null ? "--" : Creditor.Name,
                Debtor == null ? "--" : Debtor.Name,
                BaseAmount);
        }
    }
}