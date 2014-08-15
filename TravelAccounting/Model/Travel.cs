using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAccounting.Model
{
    public class Travel
    {
        public Travel()
        {
            Accounts = new List<Account>();
            TransactionLines = new List<TransactionLine>();
            Transactions = new List<Transaction>();
        }

        public string Name { get; set; }
        public string Details { get; set; }

        public IList<Account> Accounts { get; protected set; }
        public IList<TransactionLine> TransactionLines { get; protected set; }
        public IList<Transaction> Transactions { get; protected set; }

        public Account CreateAccount(string name)
        {
            Account a = new Account(this)
            {
                Name = name
            };
            Accounts.Add(a);
            return a;
        }

        public Transaction CreateTransaction(string details)
        {
            Transaction t = new Transaction(this)
            {
                Details = details
            };
            Transactions.Add(t);
            return t;
        }
    }
}
