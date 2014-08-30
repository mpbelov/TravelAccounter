using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAccounting;
using TravelAccounting.Contracts;
using TravelAccounting.Model;

namespace TravelAccounterWin {
    public class Controller : ApplicationContext {
        public Controller() {
            view = new View();
            MainForm = view.MainForm;

            view.OnCreateNewTravel += view_OnCreateNewTravel;
            view.OnOpenTravel += view_OnOpenTravel;
            view.OnSaveTravel += view_OnSaveTravel;
            view.OnCreateNewAccount += view_OnCreateNewAccount;
            view.OnCreateNewTransaction += view_OnCreateNewTransaction;
            view.OnCalculateClaims += view_OnCalculateClaims;
            view.OnPayClaims += view_OnPayClaims;
            view.OnAccountCreating += view_OnAccountCreating;

            externalStorage = new FileStorage.FileStorage();
        }

        void view_OnAccountCreating(object sender, AccountEventArgs e) {
            e.Account = new Account(travel);
        }

        private View view;
        private Travel travel;

        private IPaymentsEngine paymentsEngine;
        private IClaimEngine claimEngine;
        private IExternalStorage externalStorage;

        void view_OnCreateNewTravel(object sender, NameDetailsEventArgs e) {
            travel = new Travel() {
                Name = e.Name,
                Details = e.Details
            };

            view.BindTravel(travel);

            paymentsEngine = new PaymentsEngine(travel);
            claimEngine = new ClaimEngine(travel);
        }
        void view_OnOpenTravel(object sender, FileEventArgs e) {
            travel = externalStorage.ImportTravel(e.FileName);

            paymentsEngine = new PaymentsEngine(travel);
            claimEngine = new ClaimEngine(travel);

            view.BindTravel(travel);

            view.RefreshTransactions();
        }
        void view_OnSaveTravel(object sender, FileEventArgs e) {
            if (File.Exists(e.FileName))
                File.Delete(e.FileName);

            externalStorage.ExportTravel(travel, e.FileName);
        }

        void view_OnCreateNewAccount(object sender, NameDetailsEventArgs e) {
            var account = travel.CreateAccount(e.Name);
        }

        void view_OnCreateNewTransaction(object sender, NewTransactionEventArgs e) {
            var t = travel.CreateTransaction(e.Details, e.Currency);
            t.Currency.ExchangeRate = e.ExchangeRate;
            switch (e.Type) {
                case TransactionType.SingleExpense:
                    paymentsEngine.Expense(t, e.Creditor, e.Amount, travel.BaseCurrency);
                    break;
                case TransactionType.CollectiveExpense:
                    bool includeCreditor = e.Debtors.Contains(e.Creditor);
                    paymentsEngine.PayEquallyFor(t, e.Creditor, includeCreditor, e.Amount, travel.BaseCurrency, e.Debtors.Where(d => d != e.Creditor).ToArray());
                    break;
                case TransactionType.InternalTransaction:
                    paymentsEngine.GiveMoneyTo(t, e.Creditor, e.Debtors.First(), e.Amount, travel.BaseCurrency);
                    break;
            }

            view.RefreshTransactions();
        }
        
        void view_OnCalculateClaims(object sender, EventArgs e) {
            var claims = claimEngine.CalcClaims();
            this.view.RefreshClaims(claims);
        }
        void view_OnPayClaims(object sender, PayClaimsEventArgs e) {
            foreach (var claim in e.Claims)
                paymentsEngine.PayClaim(claim);

            view.RefreshTransactions();

            var claims = claimEngine.CalcClaims();
            this.view.RefreshClaims(claims);
        }
    }
}