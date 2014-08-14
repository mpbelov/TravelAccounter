using System;
using TravelAccounting.Model;

namespace TravelAccounting.Contracts
{
    public interface IPaymentsEngine
    {
        void ApplyClaim(Claim claim);
        void Expense(Transaction trans, Account payer, decimal amount);
        void GiveMoneyTo(Transaction trans, Account fromWho, Account toWhom, decimal amount);
        void PayBack(Transaction trans, Account creditor, Account whoReturns, decimal amount);
        void PayEquallyFor(Transaction trans, Account payer, bool includingPayer, decimal amount, params Account[] accounts);
        void PayEquallyForAll(Transaction trans, Account payer, decimal amount);
        void PayFor(Transaction trans, Account payer, Account forWhom, decimal amount);
        void PaySameFor(Transaction trans, Account payer, decimal amount, params Account[] forWhom);
        void PaySameForAll(Transaction trans, Account payer, decimal amount);
    }
}
