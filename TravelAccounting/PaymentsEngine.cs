using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAccounting.Contracts;
using TravelAccounting.Model;

namespace TravelAccounting {
    public class PaymentsEngine: IPaymentsEngine {
        public PaymentsEngine(Travel travel) {
            this.travel = travel;
        }
        protected Travel travel { get; set; }


        public void PayFor(Transaction trans, Account payer, Account forWhom, decimal amount, Currency currency) {
            GiveMoneyTo(trans, payer, forWhom, amount, currency);
            Expense(trans, forWhom, amount, currency);
        }

        public void PayEquallyForAll(Transaction trans, Account payer, decimal amount, Currency currency) {
            PayEquallyFor(trans, payer, true, amount, currency, travel.Accounts.Where(a => a != payer).ToArray());
        }
        public void PayEquallyFor(Transaction trans, Account payer, bool includingPayer, decimal amount, Currency currency, params Account[] accounts) {
            decimal amountPerAccount;
            if (includingPayer) {
                amountPerAccount = amount / (accounts.Length + 1);
                Expense(trans, payer, amountPerAccount, currency);
            }
            else {
                amountPerAccount = amount / accounts.Length;
            }

            PaySameFor(trans, payer, amountPerAccount, currency, accounts);
        }

        public void PaySameForAll(Transaction trans, Account payer, decimal amount, Currency currency) {
            foreach (var account in travel.Accounts.Where(a => a != payer))
                PayFor(trans, payer, account, amount, currency);
        }
        public void PaySameFor(Transaction trans, Account payer, decimal amount, Currency currency, params Account[] forWhom) {
            foreach (var account in forWhom)
                PayFor(trans, payer, account, amount, currency);
        }

        public void PayBack(Transaction trans, Account creditor, Account whoReturns, decimal amount, Currency currency) {
            GiveMoneyTo(trans, whoReturns, creditor, amount, currency);
        }

        public void Expense(Transaction trans, Account payer, decimal amount, Currency currency) {
            GiveMoneyTo(trans, payer, null, amount, currency);
        }

        public void GiveMoneyTo(Transaction trans, Account fromWho, Account toWhom, decimal amount, Currency currency) {
            travel.TransactionLines.Add(new TransactionLine(trans) {
                Creditor = fromWho,
                Debtor = toWhom,
                ActualAmount = amount,
            });
        }

        public void PayClaim(Claim claim) {
            Transaction claimTransaction = new Transaction(travel) {
                Details = claim.ToString()
            };
            GiveMoneyTo(claimTransaction, claim.Debtor, claim.Creditor, claim.ActualAmount, claim.Currency);
        }
    }
}