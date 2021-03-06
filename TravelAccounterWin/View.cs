﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAccounterWin.Forms;
using TravelAccounting.Model;

namespace TravelAccounterWin {
    internal class View {
        public View() {
            this.MainForm = new MainForm();

            this.MainForm.buttonStartNewTravel.Click += buttonStartNewTravel_Click;
            this.MainForm.buttonOpen.Click += buttonOpen_Click;
            this.MainForm.buttonOpenTravel.Click += buttonOpen_Click;
            this.MainForm.buttonSaveTravel.Click += buttonSaveTravel_Click;
            this.MainForm.transactionsControl.buttonAddTransaction.Click += buttonAddTransaction_Click;
            this.MainForm.toolStripButtonCalculateClaims.Click += toolStripButtonCalculateClaims_Click;
            this.MainForm.toolStripButtonPayClaims.Click += toolStripButtonPayClaims_Click;

            this.MainForm.travelControl.accountBindingSource.AddingNew += accountBindingSource_AddingNew;

            this.MainForm.panelMainPanel.Visible = false;
            this.MainForm.panelMainPanel.SendToBack();

            this.MainForm.panelTableStart.Visible = true;
            this.MainForm.panelTableStart.BringToFront();
        }

        public MainForm MainForm { get; protected set; }

        public event EventHandler<NameDetailsEventArgs> OnCreateNewTravel;
        public event EventHandler<NameDetailsEventArgs> OnCreateNewAccount;
        public event EventHandler<NewTransactionEventArgs> OnCreateNewTransaction;
        public event EventHandler OnCalculateClaims;
        public event EventHandler<PayClaimsEventArgs> OnPayClaims;
        public event EventHandler<FileEventArgs> OnOpenTravel;
        public event EventHandler<FileEventArgs> OnSaveTravel;

        public event EventHandler<AccountEventArgs> OnAccountCreating;

        public void BindTravel(Travel travel) {
            this.MainForm.travelControl.travelBindingSource.DataSource = travel;
            this.MainForm.travelControl.baseCurrencyBindingSource.DataSource = travel.BaseCurrency;
            this.MainForm.travelControl.accountBindingSource.DataSource = travel.Accounts;
            this.MainForm.travelControl.currencyBindingSource.DataSource = travel.Currencies;
            this.MainForm.transactionsControl.accountBindingSourceCreditor.DataSource = travel.Accounts;
            this.MainForm.transactionsControl.transactionLineBindingSource.DataSource = travel.TransactionLines;
            this.MainForm.transactionsControl.currencyBindingSource.DataSource = travel.Currencies;
            this.MainForm.transactionsControl.baseCurrencyBindingSource.DataSource = travel.BaseCurrency;
        }

        public void RefreshTransactions() {
            this.MainForm.transactionsControl.transactionLineBindingSource.ResetBindings(false);
        }
        public void RefreshClaims(ICollection<Claim> claims) {
            this.MainForm.claimBindingSource.DataSource = (from c in claims
                                                           orderby c.Creditor, c.ActualAmount
                                                           select c).ToArray();
            this.MainForm.claimBindingSource.ResetBindings(false);
        }

        void accountBindingSource_AddingNew(object sender, System.ComponentModel.AddingNewEventArgs e) {
            var accEventArgs = new AccountEventArgs();
            if (OnAccountCreating != null) {
                OnAccountCreating.Invoke(this, accEventArgs);
            }
            e.NewObject = accEventArgs.Account;
        }

        
        void buttonStartNewTravel_Click(object sender, EventArgs e) {
            var form = new NewTravelForm();
            var res = form.ShowDialog(MainForm);
            if (res == System.Windows.Forms.DialogResult.OK) {
                if (OnCreateNewTravel != null) {
                    OnCreateNewTravel.Invoke(this, new NameDetailsEventArgs() {
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
        void buttonOpen_Click(object sender, EventArgs e) {
            OpenFileDialog frm = new OpenFileDialog();
            frm.Filter = "Travel budget files | *.trv";
            frm.DefaultExt = "trv";
            frm.Multiselect = false;
            var res = frm.ShowDialog(this.MainForm);
            if (res == System.Windows.Forms.DialogResult.OK) {
                if (OnOpenTravel != null) {
                    OnOpenTravel.Invoke(this, new FileEventArgs() {
                        FileName = frm.FileName
                    }
                    );
                }

                this.MainForm.panelTableStart.Visible = false;
                this.MainForm.panelMainPanel.Visible = true;
                this.MainForm.panelMainPanel.BringToFront();

                this.MainForm.TurnOnAccountsView();
            }
        }
        void buttonSaveTravel_Click(object sender, EventArgs e) {
            SaveFileDialog frm = new SaveFileDialog();
            frm.Filter = "Travel budget files | *.trv";
            frm.DefaultExt = "trv";

            var res = frm.ShowDialog(this.MainForm);
            if (res == System.Windows.Forms.DialogResult.OK) {
                if (OnSaveTravel != null) {
                    OnSaveTravel.Invoke(this, new FileEventArgs() {
                        FileName = frm.FileName
                    }
                    );
                }
            }
        }

        void toolStripButtonNewAccount_Click(object sender, EventArgs e) {
            var form = new NewAccountForm();
            var res = form.ShowDialog(MainForm);
            if (res == System.Windows.Forms.DialogResult.OK) {
                if (OnCreateNewAccount != null) {
                    OnCreateNewAccount.Invoke(this, new NameDetailsEventArgs() {
                        Name = form.textName.Text
                    });
                }
            }
        }
        void toolStripButtonDeleteAccount_Click(object sender, EventArgs e) {
        }

        void buttonAddTransaction_Click(object sender, EventArgs e) {
            if (OnCreateNewTransaction != null) {
                var eventArgs = new NewTransactionEventArgs() {
                    Details = this.MainForm.transactionsControl.textTransactionDetails.Text,
                    Amount = decimal.Parse(this.MainForm.transactionsControl.textAmount.Text),
                    Currency = (Currency)this.MainForm.transactionsControl.comboCurrency.SelectedItem,
                    ExchangeRate = decimal.Parse(this.MainForm.transactionsControl.textExchangeRate.Text),
                    Date = this.MainForm.transactionsControl.datePickerTransactionDate.Value,
                    Creditor = (Account)this.MainForm.transactionsControl.comboCreditor.SelectedItem
                };

                if (this.MainForm.transactionsControl.radioSingleExpense.Checked)
                    eventArgs.Type = TransactionType.SingleExpense;
                else if (this.MainForm.transactionsControl.radioInternal.Checked) {
                    eventArgs.Type = TransactionType.InternalTransaction;
                    eventArgs.Debtors = new Account[] { (Account)this.MainForm.transactionsControl.comboInternal.SelectedItem };
                }
                else if (this.MainForm.transactionsControl.radioCollectiveExpense.Checked) {
                    eventArgs.Type = TransactionType.CollectiveExpense;
                    eventArgs.Debtors = this.MainForm.transactionsControl.checkedListForWhom.CheckedItems.Cast<Account>().ToArray();
                }

                OnCreateNewTransaction.Invoke(this, eventArgs);
            }
            this.MainForm.transactionsControl.ClearTransactionEntryPanel();
        }

        void toolStripButtonCalculateClaims_Click(object sender, EventArgs e) {
            if (OnCalculateClaims != null)
                OnCalculateClaims.Invoke(this, new EventArgs());
        }
        void toolStripButtonPayClaims_Click(object sender, EventArgs e) {
            if (OnPayClaims != null) {
                PayClaimsEventArgs eventArgs = new PayClaimsEventArgs();
                foreach (DataGridViewRow row in this.MainForm.dataGridClaims.SelectedRows) {
                    Claim claim = (Claim)row.DataBoundItem;
                    eventArgs.Claims.Add(claim);
                }
                OnPayClaims.Invoke(this, eventArgs);
            }
        }
    }
}