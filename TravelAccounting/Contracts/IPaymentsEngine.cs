using System;
using TravelAccounting.Model;

namespace TravelAccounting.Contracts {
    public interface IPaymentsEngine {
        void Expense(Transaction trans, Account payer, decimal amount, Currency currency);
        void GiveMoneyTo(Transaction trans, Account fromWho, Account toWhom, decimal amount, Currency currency);
        void PayBack(Transaction trans, Account creditor, Account whoReturns, decimal amount, Currency currency);
        void PayClaim(Claim claim);
        void PayEquallyFor(Transaction trans, Account payer, bool includingPayer, decimal amount, Currency currency, params Account[] accounts);
        void PayEquallyForAll(Transaction trans, Account payer, decimal amount, Currency currency);
        void PayFor(Transaction trans, Account payer, Account forWhom, decimal amount, Currency currency);
        void PaySameFor(Transaction trans, Account payer, decimal amount, Currency currency, params Account[] forWhom);
        void PaySameForAll(Transaction trans, Account payer, decimal amount, Currency currency);
    }
}