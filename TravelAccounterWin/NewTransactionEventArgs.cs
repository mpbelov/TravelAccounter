using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAccounting.Model;

namespace TravelAccounterWin
{
    public class NewTransactionEventArgs : EventArgs
    {
        public string Details { get; set; }
        public decimal Amount { get; set; }

        public Account Creditor { get; set; }

        public TransactionType Type { get; set; }

        public ICollection<Account> Debtors { get; set; }
    }

    public enum TransactionType
    {
        SingleExpense,
        CollectiveExpense,
        InternalTransaction
    }
}
