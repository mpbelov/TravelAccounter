using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAccounting.Model
{
    public class Account : IComparable<Account>
    {
        public Account(Travel travel)
        {
            this.travel = travel;
        }

        private Travel travel;

        public string Name { get; set; }

        public decimal Credit
        {
            get
            {
                var theyOweToMe = travel.TransactionLines.Where(t => t.Creditor == this && t.Debtor != null).Sum(t => t.Amount);
                var iOweThem = travel.TransactionLines.Where(t => t.Debtor == this).Sum(t => t.Amount);
                var result = theyOweToMe - iOweThem;
                return result < 0 ? decimal.Zero : result;
            }
        }
        public decimal Debt
        {
            get
            {
                var theyOweToMe = travel.TransactionLines.Where(t => t.Creditor == this && t.Debtor != null).Sum(t => t.Amount);
                var iOweThem = travel.TransactionLines.Where(t => t.Debtor == this).Sum(t => t.Amount);
                var result = iOweThem - theyOweToMe;
                return result < 0 ? decimal.Zero : result;
            }
        }
        public decimal Expense
        {
            get
            {
                var myExpense = travel.TransactionLines.Where(t => t.Creditor == this && t.Debtor == null).Sum(t => t.Amount);
                return myExpense;
            }
        }

        public override string ToString()
        {
            //return string.Format("{0}. Credit {1}; Debt {2}; Expense {3}", Name, Credit, Debt, Expense);
            return Name;
        }

        public int CompareTo(Account other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}