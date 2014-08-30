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

namespace TravelAccounterWin.Forms {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        public void TurnOnAccountsView() {
            this.transactionsControl.Visible = false;
            this.panelClaims.Visible = false;
            this.travelControl.Visible = true;
            this.travelControl.BringToFront();
        }
        public void TurnOnTransactionsView() {
            this.transactionsControl.UpdateCreditorsList();
            this.transactionsControl.UpdateCurrenciesList();

            this.travelControl.Visible = false;
            this.panelClaims.Visible = false;
            this.transactionsControl.Visible = true;
            this.transactionsControl.BringToFront();

            this.transactionsControl.radioSingleExpense.Checked = true;

        }
        public void TurnOnClaimsView() {
            this.transactionsControl.Visible = false;
            this.travelControl.Visible = false;
            this.panelClaims.Visible = true;
            this.panelClaims.BringToFront();
        }

        private void buttonAccounts_Click(object sender, EventArgs e) {
            TurnOnAccountsView();
        }

        private void buttonTransaction_Click(object sender, EventArgs e) {
            TurnOnTransactionsView();
        }

        private void buttonClaims_Click(object sender, EventArgs e) {
            TurnOnClaimsView();
        }
    }
}