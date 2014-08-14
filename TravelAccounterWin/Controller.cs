using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAccounting;
using TravelAccounting.Contracts;
using TravelAccounting.Model;

namespace TravelAccounterWin
{
    public class Controller : ApplicationContext
    {
        public Controller()
        {
            view = new View();
            MainForm = view.MainForm;

            view.OnCreateNewTravel += view_OnCreateNewTravel;
            view.OnCreateNewAccount += view_OnCreateNewAccount;
            view.OnCreateNewTransaction += view_OnCreateNewTransaction;
        }

        private View view;

        private Travel travel;

        private IPaymentsEngine paymentsEngine;
        private IClaimEngine claimEngine;

        void view_OnCreateNewTravel(object sender, NameDetailsEventArgs e)
        {
            travel = new Travel()
            {
                Name = e.Name,
                Details = e.Details
            };

            paymentsEngine = new PaymentsEngine(travel);
            claimEngine = new ClaimEngine(travel);
        }

        void view_OnCreateNewAccount(object sender, NameDetailsEventArgs e)
        {
            var account = travel.CreateAccount(e.Name);
            view.RefreshAccounts(travel.Accounts);
        }

        void view_OnCreateNewTransaction(object sender, NewTransactionEventArgs e)
        {
            var t = travel.CreateTransaction(e.Details);
            switch (e.Type)
            {
                case TransactionType.SingleExpense:
                    paymentsEngine.Expense(t, e.Creditor, e.Amount);
                    break;
                case TransactionType.CollectiveExpense:
                    paymentsEngine.PayEquallyFor(t, e.Creditor, true, e.Amount, e.Debtors.ToArray());
                    break;
                case TransactionType.InternalTransaction:
                    paymentsEngine.GiveMoneyTo(t, e.Creditor, e.Debtors.First(), e.Amount);
                    break;
            }

            view.RefreshTransactions(travel.TransactionLines);
        }
    }
}
