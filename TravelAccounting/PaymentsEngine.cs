using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAccounting.Contracts;
using TravelAccounting.Model;

namespace TravelAccounting
{
    public class PaymentsEngine : IPaymentsEngine
    {
        public PaymentsEngine(Travel travel)
        {
            this.travel = travel;
        }
        protected Travel travel { get; set; }


        public void PayFor(Transaction trans, Account payer, Account forWhom, decimal amount)
        {
            GiveMoneyTo(trans, payer, forWhom, amount);
            Expense(trans, forWhom, amount);
        }

        public void PayEquallyForAll(Transaction trans, Account payer, decimal amount)
        {
            PayEquallyFor(trans, payer, true, amount, travel.Accounts.Where(a => a != payer).ToArray());
        }
        public void PayEquallyFor(Transaction trans, Account payer, bool includingPayer, decimal amount, params Account[] accounts)
        {
            decimal amountPerAccount;
            if (includingPayer)
            {
                amountPerAccount = amount / (accounts.Length + 1);
                Expense(trans, payer, amountPerAccount);
            }
            else
            {
                amountPerAccount = amount / accounts.Length;
            }

            PaySameFor(trans, payer, amountPerAccount, accounts);
        }

        public void PaySameForAll(Transaction trans, Account payer, decimal amount)
        {
            foreach (var account in travel.Accounts.Where(a => a != payer))
                PayFor(trans, payer, account, amount);
        }
        public void PaySameFor(Transaction trans, Account payer, decimal amount, params Account[] forWhom)
        {
            foreach (var account in forWhom)
                PayFor(trans, payer, account, amount);
        }

        public void PayBack(Transaction trans, Account creditor, Account whoReturns, decimal amount)
        {
            GiveMoneyTo(trans, whoReturns, creditor, amount);
        }

        public void Expense(Transaction trans, Account payer, decimal amount)
        {
            GiveMoneyTo(trans, payer, null, amount);
        }

        public void GiveMoneyTo(Transaction trans, Account fromWho, Account toWhom, decimal amount)
        {
            travel.TransactionLines.Add(new TransactionLine(trans)
            {
                Creditor = fromWho,
                Debtor = toWhom,
                Amount = amount
            });
        }

        public void ApplyClaim(Claim claim)
        {
            Transaction claimTransaction = new Transaction(travel){
                 Details = claim.ToString()
            };
            GiveMoneyTo(claimTransaction, claim.Debtor, claim.Creditor, claim.Amount);
        }
    }
}
