using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAccounting.Model;

namespace TravelAccounterWin.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void TurnOnAccountsView()
        {
            this.panelTransactions.Visible = false;
            this.panelClaims.Visible = false;
            this.panelAccounts.Visible = true;
            this.panelAccounts.BringToFront();
        }
        public void TurnOnTransactionsView()
        {
            this.panelAccounts.Visible = false;
            this.panelClaims.Visible = false;
            this.panelTransactions.Visible = true;
            this.panelTransactions.BringToFront();

            this.radioSingleExpense.Checked = true;
        }
        public void TurnOnClaimsView()
        {
            this.panelTransactions.Visible = false;
            this.panelAccounts.Visible = false;
            this.panelClaims.Visible = true;
            this.panelClaims.BringToFront();
        }

        public void UpdateForWhomList()
        {
            ICollection<Account> accounts = accountBindingSourceWho.DataSource as ICollection<Account>;
            if (accounts != null)
            {
                if (radioCollectiveExpense.Checked)
                {
                    checkedListForWhom.Items.Clear();
                    checkedListForWhom.Items.Add(accounts.Where(a => a == (Account)comboCreditor.SelectedItem).First());
                    checkedListForWhom.Items.AddRange(accounts.Where(a => a != (Account)comboCreditor.SelectedItem).OrderBy(a => a.Name).ToArray());
                }
                else if (radioInternal.Checked)
                {
                    comboInternal.Items.Clear();
                    comboInternal.Items.AddRange(accounts.Where(a => a != (Account)comboCreditor.SelectedItem).OrderBy(a => a.Name).ToArray());
                }
            }
        }

        public void ClearTransactionEntryPanel()
        {
            this.textAmount.Text = string.Empty;
            this.textTransactionDetails.Text = string.Empty;
        }

        private void buttonAccounts_Click(object sender, EventArgs e)
        {
            TurnOnAccountsView();
        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {
            TurnOnTransactionsView();
        }

        private void buttonClaims_Click(object sender, EventArgs e)
        {
            TurnOnClaimsView();
        }

        private void comboCreditor_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateForWhomList();
        }

        private void radioSingleExpense_CheckedChanged(object sender, EventArgs e)
        {
            this.labelForWhom.Enabled = false;
            this.checkedListForWhom.Enabled = false;
            this.buttonCheckAll.Enabled = false;
            this.buttonCheckNone.Enabled = false;

            this.comboInternal.Enabled = false;
        }

        private void radioCollectiveExpense_CheckedChanged(object sender, EventArgs e)
        {
            this.labelForWhom.Enabled = true;
            this.checkedListForWhom.Enabled = true;
            this.buttonCheckAll.Enabled = true;
            this.buttonCheckNone.Enabled = true;

            this.comboInternal.Enabled = false;

            UpdateForWhomList();
        }

        private void radioInternal_CheckedChanged(object sender, EventArgs e)
        {
            this.labelForWhom.Enabled = false;
            this.checkedListForWhom.Enabled = false;
            this.buttonCheckAll.Enabled = false;
            this.buttonCheckNone.Enabled = false;

            this.comboInternal.Enabled = true;

            UpdateForWhomList();
        }

        private void buttonCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.checkedListForWhom.Items.Count; i++)
                this.checkedListForWhom.SetItemChecked(i, true);
        }

        private void buttonCheckNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.checkedListForWhom.Items.Count; i++)
                this.checkedListForWhom.SetItemChecked(i, false);
        }

        private void textAmount_TextChanged(object sender, EventArgs e)
        {
            var amount = this.textAmount.Text;
            decimal d;
            if (!string.IsNullOrEmpty(amount) && !decimal.TryParse(amount, out d))
            {
                string errorText = string.Format("Amount should be decimal value. Field accepts only digits and '{0}' symbol as decimal separator.", 
                    NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
                this.errorProviderNewTransaction.SetError(this.textAmount, errorText);
            }
            else
            {
                errorProviderNewTransaction.SetError(this.textAmount, string.Empty);
            }
        }

        private void dataGridClaims_Leave(object sender, EventArgs e)
        {

        }
    }
}
