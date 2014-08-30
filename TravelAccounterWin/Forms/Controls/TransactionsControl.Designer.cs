namespace TravelAccounterWin.Forms.Controls {
    partial class TransactionsControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.comboInternal = new System.Windows.Forms.ComboBox();
            this.buttonCheckNone = new System.Windows.Forms.Button();
            this.buttonCheckAll = new System.Windows.Forms.Button();
            this.checkedListForWhom = new System.Windows.Forms.CheckedListBox();
            this.buttonAddTransaction = new System.Windows.Forms.Button();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.radioInternal = new System.Windows.Forms.RadioButton();
            this.labelForWhom = new System.Windows.Forms.Label();
            this.radioCollectiveExpense = new System.Windows.Forms.RadioButton();
            this.radioSingleExpense = new System.Windows.Forms.RadioButton();
            this.comboCreditor = new System.Windows.Forms.ComboBox();
            this.labelCreditor = new System.Windows.Forms.Label();
            this.textTransactionDetails = new System.Windows.Forms.TextBox();
            this.labelTransactionDetails = new System.Windows.Forms.Label();
            this.errorProviderNewTransaction = new System.Windows.Forms.ErrorProvider(this.components);
            this.accountBindingSourceWho = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTableNewTransaction = new System.Windows.Forms.TableLayoutPanel();
            this.groupTransactionType = new System.Windows.Forms.GroupBox();
            this.panelTableTransactionType = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutCheckAllNone = new System.Windows.Forms.TableLayoutPanel();
            this.textExchangeRate = new System.Windows.Forms.TextBox();
            this.labelExchangeRate = new System.Windows.Forms.Label();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSourceWho)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTableNewTransaction.SuspendLayout();
            this.groupTransactionType.SuspendLayout();
            this.panelTableTransactionType.SuspendLayout();
            this.tableLayoutCheckAllNone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboInternal
            // 
            this.comboInternal.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboInternal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInternal.FormattingEnabled = true;
            this.comboInternal.Location = new System.Drawing.Point(87, 49);
            this.comboInternal.Name = "comboInternal";
            this.comboInternal.Size = new System.Drawing.Size(167, 21);
            this.comboInternal.TabIndex = 3;
            // 
            // buttonCheckNone
            // 
            this.buttonCheckNone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCheckNone.Location = new System.Drawing.Point(89, 0);
            this.buttonCheckNone.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonCheckNone.Name = "buttonCheckNone";
            this.buttonCheckNone.Size = new System.Drawing.Size(80, 34);
            this.buttonCheckNone.TabIndex = 1;
            this.buttonCheckNone.Text = "Check none";
            this.buttonCheckNone.UseVisualStyleBackColor = true;
            // 
            // buttonCheckAll
            // 
            this.buttonCheckAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCheckAll.Location = new System.Drawing.Point(0, 0);
            this.buttonCheckAll.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.buttonCheckAll.Name = "buttonCheckAll";
            this.buttonCheckAll.Size = new System.Drawing.Size(79, 34);
            this.buttonCheckAll.TabIndex = 0;
            this.buttonCheckAll.Text = "Check all";
            this.buttonCheckAll.UseVisualStyleBackColor = true;
            // 
            // checkedListForWhom
            // 
            this.checkedListForWhom.CheckOnClick = true;
            this.checkedListForWhom.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListForWhom.FormattingEnabled = true;
            this.checkedListForWhom.Location = new System.Drawing.Point(93, 214);
            this.checkedListForWhom.Name = "checkedListForWhom";
            this.checkedListForWhom.Size = new System.Drawing.Size(169, 89);
            this.checkedListForWhom.TabIndex = 10;
            // 
            // buttonAddTransaction
            // 
            this.panelTableNewTransaction.SetColumnSpan(this.buttonAddTransaction, 2);
            this.buttonAddTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddTransaction.Location = new System.Drawing.Point(5, 416);
            this.buttonAddTransaction.Margin = new System.Windows.Forms.Padding(5, 10, 2, 3);
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.Size = new System.Drawing.Size(258, 59);
            this.buttonAddTransaction.TabIndex = 15;
            this.buttonAddTransaction.Text = "Add transaction";
            this.buttonAddTransaction.UseVisualStyleBackColor = true;
            // 
            // textAmount
            // 
            this.textAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.textAmount.Location = new System.Drawing.Point(93, 131);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(169, 22);
            this.textAmount.TabIndex = 4;
            // 
            // labelAmount
            // 
            this.labelAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(5, 135);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(48, 13);
            this.labelAmount.TabIndex = 3;
            this.labelAmount.Text = "Amount";
            // 
            // radioInternal
            // 
            this.radioInternal.AutoSize = true;
            this.radioInternal.Location = new System.Drawing.Point(3, 49);
            this.radioInternal.Name = "radioInternal";
            this.radioInternal.Size = new System.Drawing.Size(66, 17);
            this.radioInternal.TabIndex = 2;
            this.radioInternal.Text = "Transfer";
            this.radioInternal.UseVisualStyleBackColor = true;
            // 
            // labelForWhom
            // 
            this.labelForWhom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelForWhom.AutoSize = true;
            this.labelForWhom.Location = new System.Drawing.Point(5, 252);
            this.labelForWhom.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.labelForWhom.Name = "labelForWhom";
            this.labelForWhom.Size = new System.Drawing.Size(77, 13);
            this.labelForWhom.TabIndex = 9;
            this.labelForWhom.Text = "Who is payed";
            // 
            // radioCollectiveExpense
            // 
            this.radioCollectiveExpense.AutoSize = true;
            this.panelTableTransactionType.SetColumnSpan(this.radioCollectiveExpense, 2);
            this.radioCollectiveExpense.Location = new System.Drawing.Point(3, 26);
            this.radioCollectiveExpense.Name = "radioCollectiveExpense";
            this.radioCollectiveExpense.Size = new System.Drawing.Size(119, 17);
            this.radioCollectiveExpense.TabIndex = 1;
            this.radioCollectiveExpense.Text = "Collective expense";
            this.radioCollectiveExpense.UseVisualStyleBackColor = true;
            // 
            // radioSingleExpense
            // 
            this.radioSingleExpense.AutoSize = true;
            this.panelTableTransactionType.SetColumnSpan(this.radioSingleExpense, 2);
            this.radioSingleExpense.Location = new System.Drawing.Point(3, 3);
            this.radioSingleExpense.Name = "radioSingleExpense";
            this.radioSingleExpense.Size = new System.Drawing.Size(102, 17);
            this.radioSingleExpense.TabIndex = 0;
            this.radioSingleExpense.Text = "Single expense";
            this.radioSingleExpense.UseVisualStyleBackColor = true;
            // 
            // comboCreditor
            // 
            this.comboCreditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboCreditor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCreditor.FormattingEnabled = true;
            this.comboCreditor.Location = new System.Drawing.Point(93, 104);
            this.comboCreditor.Name = "comboCreditor";
            this.comboCreditor.Size = new System.Drawing.Size(169, 21);
            this.comboCreditor.TabIndex = 2;
            // 
            // labelCreditor
            // 
            this.labelCreditor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCreditor.AutoSize = true;
            this.labelCreditor.Location = new System.Drawing.Point(5, 108);
            this.labelCreditor.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.labelCreditor.Name = "labelCreditor";
            this.labelCreditor.Size = new System.Drawing.Size(58, 13);
            this.labelCreditor.TabIndex = 1;
            this.labelCreditor.Text = "Who pays";
            // 
            // textTransactionDetails
            // 
            this.textTransactionDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.textTransactionDetails.Location = new System.Drawing.Point(93, 347);
            this.textTransactionDetails.Multiline = true;
            this.textTransactionDetails.Name = "textTransactionDetails";
            this.textTransactionDetails.Size = new System.Drawing.Size(169, 56);
            this.textTransactionDetails.TabIndex = 13;
            // 
            // labelTransactionDetails
            // 
            this.labelTransactionDetails.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTransactionDetails.AutoSize = true;
            this.labelTransactionDetails.Location = new System.Drawing.Point(5, 368);
            this.labelTransactionDetails.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.labelTransactionDetails.Name = "labelTransactionDetails";
            this.labelTransactionDetails.Size = new System.Drawing.Size(42, 13);
            this.labelTransactionDetails.TabIndex = 12;
            this.labelTransactionDetails.Text = "Details";
            // 
            // errorProviderNewTransaction
            // 
            this.errorProviderNewTransaction.ContainerControl = this;
            // 
            // accountBindingSourceWho
            // 
            this.accountBindingSourceWho.DataSource = typeof(TravelAccounting.Model.Account);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelTableNewTransaction, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelTableNewTransaction
            // 
            this.panelTableNewTransaction.ColumnCount = 2;
            this.panelTableNewTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.panelTableNewTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTableNewTransaction.Controls.Add(this.groupTransactionType, 0, 0);
            this.panelTableNewTransaction.Controls.Add(this.textTransactionDetails, 1, 7);
            this.panelTableNewTransaction.Controls.Add(this.tableLayoutCheckAllNone, 1, 6);
            this.panelTableNewTransaction.Controls.Add(this.labelTransactionDetails, 0, 7);
            this.panelTableNewTransaction.Controls.Add(this.labelCreditor, 0, 1);
            this.panelTableNewTransaction.Controls.Add(this.comboCreditor, 1, 1);
            this.panelTableNewTransaction.Controls.Add(this.textExchangeRate, 1, 4);
            this.panelTableNewTransaction.Controls.Add(this.checkedListForWhom, 1, 5);
            this.panelTableNewTransaction.Controls.Add(this.labelAmount, 0, 2);
            this.panelTableNewTransaction.Controls.Add(this.labelForWhom, 0, 5);
            this.panelTableNewTransaction.Controls.Add(this.textAmount, 1, 2);
            this.panelTableNewTransaction.Controls.Add(this.labelExchangeRate, 0, 4);
            this.panelTableNewTransaction.Controls.Add(this.labelCurrency, 0, 3);
            this.panelTableNewTransaction.Controls.Add(this.comboBox1, 1, 3);
            this.panelTableNewTransaction.Controls.Add(this.buttonAddTransaction, 1, 8);
            this.panelTableNewTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTableNewTransaction.Location = new System.Drawing.Point(3, 3);
            this.panelTableNewTransaction.Name = "panelTableNewTransaction";
            this.panelTableNewTransaction.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.panelTableNewTransaction.RowCount = 9;
            this.panelTableNewTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTableNewTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTableNewTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTableNewTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTableNewTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTableNewTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTableNewTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTableNewTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTableNewTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTableNewTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTableNewTransaction.Size = new System.Drawing.Size(267, 513);
            this.panelTableNewTransaction.TabIndex = 0;
            // 
            // groupTransactionType
            // 
            this.panelTableNewTransaction.SetColumnSpan(this.groupTransactionType, 2);
            this.groupTransactionType.Controls.Add(this.panelTableTransactionType);
            this.groupTransactionType.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTransactionType.Location = new System.Drawing.Point(3, 3);
            this.groupTransactionType.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.groupTransactionType.Name = "groupTransactionType";
            this.groupTransactionType.Padding = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.groupTransactionType.Size = new System.Drawing.Size(261, 95);
            this.groupTransactionType.TabIndex = 0;
            this.groupTransactionType.TabStop = false;
            this.groupTransactionType.Text = "Transaction type";
            // 
            // panelTableTransactionType
            // 
            this.panelTableTransactionType.AutoSize = true;
            this.panelTableTransactionType.ColumnCount = 2;
            this.panelTableTransactionType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.panelTableTransactionType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTableTransactionType.Controls.Add(this.comboInternal, 1, 2);
            this.panelTableTransactionType.Controls.Add(this.radioSingleExpense, 0, 0);
            this.panelTableTransactionType.Controls.Add(this.radioCollectiveExpense, 0, 1);
            this.panelTableTransactionType.Controls.Add(this.radioInternal, 0, 2);
            this.panelTableTransactionType.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTableTransactionType.Location = new System.Drawing.Point(3, 18);
            this.panelTableTransactionType.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.panelTableTransactionType.Name = "panelTableTransactionType";
            this.panelTableTransactionType.RowCount = 3;
            this.panelTableTransactionType.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTableTransactionType.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTableTransactionType.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTableTransactionType.Size = new System.Drawing.Size(257, 73);
            this.panelTableTransactionType.TabIndex = 0;
            // 
            // tableLayoutCheckAllNone
            // 
            this.tableLayoutCheckAllNone.ColumnCount = 2;
            this.tableLayoutCheckAllNone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutCheckAllNone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutCheckAllNone.Controls.Add(this.buttonCheckAll, 0, 0);
            this.tableLayoutCheckAllNone.Controls.Add(this.buttonCheckNone, 1, 0);
            this.tableLayoutCheckAllNone.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutCheckAllNone.Location = new System.Drawing.Point(93, 307);
            this.tableLayoutCheckAllNone.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.tableLayoutCheckAllNone.Name = "tableLayoutCheckAllNone";
            this.tableLayoutCheckAllNone.RowCount = 1;
            this.tableLayoutCheckAllNone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutCheckAllNone.Size = new System.Drawing.Size(169, 34);
            this.tableLayoutCheckAllNone.TabIndex = 11;
            // 
            // textExchangeRate
            // 
            this.textExchangeRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.textExchangeRate.Location = new System.Drawing.Point(93, 186);
            this.textExchangeRate.Name = "textExchangeRate";
            this.textExchangeRate.Size = new System.Drawing.Size(169, 22);
            this.textExchangeRate.TabIndex = 8;
            // 
            // labelExchangeRate
            // 
            this.labelExchangeRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelExchangeRate.AutoSize = true;
            this.labelExchangeRate.Location = new System.Drawing.Point(5, 190);
            this.labelExchangeRate.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.labelExchangeRate.Name = "labelExchangeRate";
            this.labelExchangeRate.Size = new System.Drawing.Size(79, 13);
            this.labelExchangeRate.TabIndex = 7;
            this.labelExchangeRate.Text = "Exchange rate";
            // 
            // labelCurrency
            // 
            this.labelCurrency.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Location = new System.Drawing.Point(5, 163);
            this.labelCurrency.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(52, 13);
            this.labelCurrency.TabIndex = 5;
            this.labelCurrency.Text = "Currency";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(276, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(715, 513);
            this.dataGridView1.TabIndex = 1;
            // 
            // TransactionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "TransactionsControl";
            this.Size = new System.Drawing.Size(994, 519);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSourceWho)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTableNewTransaction.ResumeLayout(false);
            this.panelTableNewTransaction.PerformLayout();
            this.groupTransactionType.ResumeLayout(false);
            this.groupTransactionType.PerformLayout();
            this.panelTableTransactionType.ResumeLayout(false);
            this.panelTableTransactionType.PerformLayout();
            this.tableLayoutCheckAllNone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ComboBox comboInternal;
        private System.Windows.Forms.Button buttonCheckNone;
        private System.Windows.Forms.Button buttonCheckAll;
        internal System.Windows.Forms.CheckedListBox checkedListForWhom;
        internal System.Windows.Forms.Button buttonAddTransaction;
        internal System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.Label labelAmount;
        internal System.Windows.Forms.RadioButton radioInternal;
        private System.Windows.Forms.Label labelForWhom;
        internal System.Windows.Forms.RadioButton radioCollectiveExpense;
        internal System.Windows.Forms.RadioButton radioSingleExpense;
        internal System.Windows.Forms.ComboBox comboCreditor;
        private System.Windows.Forms.Label labelCreditor;
        internal System.Windows.Forms.TextBox textTransactionDetails;
        private System.Windows.Forms.Label labelTransactionDetails;
        private System.Windows.Forms.ErrorProvider errorProviderNewTransaction;
        internal System.Windows.Forms.BindingSource accountBindingSourceWho;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupTransactionType;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textExchangeRate;
        private System.Windows.Forms.Label labelExchangeRate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutCheckAllNone;
        private System.Windows.Forms.TableLayoutPanel panelTableNewTransaction;
        private System.Windows.Forms.TableLayoutPanel panelTableTransactionType;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
