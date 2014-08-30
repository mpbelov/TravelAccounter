using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAccounting.Model {
    public class Account : IComparable<Account> {
        public Account(Travel travel) {
            this.Travel = travel;
        }

        public virtual Travel Travel { get; protected set; }

        public virtual string Name { get; set; }

        public virtual decimal Credit {
            get {
                var theyOweToMe = Travel.TransactionLines.Where(t => t.Creditor == this && t.Debtor != null).Sum(t => t.BaseAmount);
                var iOweThem = Travel.TransactionLines.Where(t => t.Debtor == this).Sum(t => t.BaseAmount);
                var result = theyOweToMe - iOweThem;
                return result < 0 ? decimal.Zero : result;
            }
        }
        public virtual decimal Debt {
            get {
                var theyOweToMe = Travel.TransactionLines.Where(t => t.Creditor == this && t.Debtor != null).Sum(t => t.BaseAmount);
                var iOweThem = Travel.TransactionLines.Where(t => t.Debtor == this).Sum(t => t.BaseAmount);
                var result = iOweThem - theyOweToMe;
                return result < 0 ? decimal.Zero : result;
            }
        }
        public virtual decimal Expense {
            get {
                var myExpense = Travel.TransactionLines.Where(t => t.Creditor == this && t.Debtor == null).Sum(t => t.BaseAmount);
                return myExpense;
            }
        }

        public override string ToString() {
            //return string.Format("{0}. Credit {1}; Debt {2}; Expense {3}", Name, Credit, Debt, Expense);
            return Name;
        }

        public int CompareTo(Account other) {
            return this.Name.CompareTo(other.Name);
        }
    }
}