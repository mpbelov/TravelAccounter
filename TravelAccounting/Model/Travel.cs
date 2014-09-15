using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAccounting.Model {
    public class Travel {
        public Travel() {
            Accounts = new List<Account>();
            TransactionLines = new List<TransactionLine>();
            Transactions = new List<Transaction>();
            Currencies = new List<Currency>();
            BaseCurrency = new Currency.BaseCurrency();
        }

        public virtual string Name { get; set; }
        public virtual string Details { get; set; }

        public virtual IList<Account> Accounts { get; protected set; }
        public virtual IList<TransactionLine> TransactionLines { get; protected set; }
        public virtual IList<Transaction> Transactions { get; protected set; }
        public virtual IList<Currency> Currencies { get; protected set; }
        public virtual Currency BaseCurrency { get; protected set; }

        public virtual Account CreateAccount(string name) {
            Account a = new Account(this) {
                Name = name
            };
            Accounts.Add(a);
            return a;
        }

        public virtual Transaction CreateTransaction(string details) {
            return CreateTransaction(details, this.BaseCurrency);
        }
        public virtual Transaction CreateTransaction(string details, Currency currency) {
            return CreateTransaction(details, this.BaseCurrency, DateTime.Now.Date);
        }
        public virtual Transaction CreateTransaction(string details, Currency currency, DateTime date) {
            Transaction t = new Transaction(this) {
                Details = details,
                Currency = new Currency(currency),
                Date = date
            };
            Transactions.Add(t);
            return t;
        }


        public virtual Currency CreateCurrency(string name, string shortName) {
            var c = new Currency(name, shortName);
            this.Currencies.Add(c);
            return c;
        }
    }
}