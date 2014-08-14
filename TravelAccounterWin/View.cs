using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAccounterWin.Forms;
using TravelAccounting.Model;

namespace TravelAccounterWin
{
    internal class View
    {
        public View()
        {
            this.MainForm = new MainForm();

            this.MainForm.buttonStartNewTravel.Click += buttonStartNewTravel_Click;
            this.MainForm.toolStripButtonNewAccount.Click += toolStripButtonNewAccount_Click;
            this.MainForm.toolStripButtonDeleteAccount.Click += toolStripButtonDeleteAccount_Click;
            this.MainForm.buttonAddTransaction.Click += buttonAddTransaction_Click;

            this.MainForm.panelMainPanel.Visible = false;
            this.MainForm.panelMainPanel.SendToBack();

            this.MainForm.panelTableStart.Visible = true;
            this.MainForm.panelTableStart.BringToFront();
        }

        public MainForm MainForm { get; protected set; }

        public event EventHandler<NameDetailsEventArgs> OnCreateNewTravel;
        public event EventHandler<NameDetailsEventArgs> OnCreateNewAccount;
        public event EventHandler<NewTransactionEventArgs> OnCreateNewTransaction;

        public void RefreshAccounts(ICollection<Account> accounts)
        {
            this.MainForm.accountBindingSource.DataSource = accounts.ToArray();
            this.MainForm.accountBindingSource.ResetBindings(false);

            this.MainForm.accountBindingSourceWho.DataSource = accounts.ToArray();
            this.MainForm.accountBindingSourceWho.ResetBindings(false);

            this.MainForm.UpdateForWhomList();
        }
        public void RefreshTransactions(ICollection<TransactionLine> transactions)
        {
            this.MainForm.transactionLineBindingSource.DataSource = transactions.ToArray();
            this.MainForm.transactionLineBindingSource.ResetBindings(false);
        }

        void buttonStartNewTravel_Click(object sender, EventArgs e)
        {
            var form = new NewTravelForm();
            var res = form.ShowDialog(MainForm);
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                if (OnCreateNewTravel != null)
                {
                    OnCreateNewTravel.Invoke(this, new NameDetailsEventArgs()
                        {
                            Name = form.textName.Text,
                            Details = form.textDetails.Text
                        }
                    );
                }

                this.MainForm.panelTableStart.Visible = false;
                this.MainForm.panelMainPanel.Visible = true;
                this.MainForm.panelMainPanel.BringToFront();

                this.MainForm.TurnOnAccountsView();
            }
        }

        void toolStripButtonNewAccount_Click(object sender, EventArgs e)
        {
            var form = new NewAccountForm();
            var res = form.ShowDialog(MainForm);
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                if (OnCreateNewAccount != null)
                {
                    OnCreateNewAccount.Invoke(this, new NameDetailsEventArgs()
                    {
                        Name = form.textName.Text
                    });
                }
            }
        }

        void toolStripButtonDeleteAccount_Click(object sender, EventArgs e)
        {
        }

        void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            if (OnCreateNewTransaction != null)
            {
                var eventArgs = new NewTransactionEventArgs()
                {
                    Details = this.MainForm.textTransactionDetails.Text,
                    Amount = decimal.Parse(this.MainForm.textAmount.Text),
                    Creditor = (Account)this.MainForm.comboCreditor.SelectedItem
                };

                if (this.MainForm.radioSingleExpense.Checked)
                    eventArgs.Type = TransactionType.SingleExpense;
                else if (this.MainForm.radioInternal.Checked)
                {
                    eventArgs.Type = TransactionType.InternalTransaction;
                    eventArgs.Debtors = new Account[] { (Account)this.MainForm.comboInternal.SelectedItem };
                }
                else if (this.MainForm.radioCollectiveExpense.Checked)
                {
                    eventArgs.Type = TransactionType.CollectiveExpense;
                    eventArgs.Debtors = this.MainForm.checkedListForWhom.CheckedItems.Cast<Account>().ToArray();
                }

                OnCreateNewTransaction.Invoke(this, eventArgs);
            }
        }

    }
}
