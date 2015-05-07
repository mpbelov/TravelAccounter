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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.labelCreditor = new System.Windows.Forms.Label();
            this.textTransactionDetails = new System.Windows.Forms.TextBox();
            this.labelTransactionDetails = new System.Windows.Forms.Label();
            this.errorProviderNewTransaction = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTableTransactions = new System.Windows.Forms.TableLayoutPanel();
            this.panelTableNewTransaction = new System.Windows.Forms.TableLayoutPanel();
            this.groupTransactionType = new System.Windows.Forms.GroupBox();
            this.panelTableTransactionType = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutCheckAllNone = new System.Windows.Forms.TableLayoutPanel();
            this.textExchangeRate = new System.Windows.Forms.TextBox();
            this.labelExchangeRate = new System.Windows.Forms.Label();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.comboCurrency = new System.Windows.Forms.ComboBox();
            this.comboCreditor = new System.Windows.Forms.ComboBox();
            this.accountBindingSourceCreditor = new System.Windows.Forms.BindingSource(this.components);
            this.labelTransactionDate = new System.Windows.Forms.Label();
            this.datePickerTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridTransactionLines = new System.Windows.Forms.DataGridView();
            this.creditorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseCurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewTransaction)).BeginInit();
            this.panelTableTransactions.SuspendLayout();
            this.panelTableNewTransaction.SuspendLayout();
            this.groupTransactionType.SuspendLayout();
            this.panelTableTransactionType.SuspendLayout();
            this.tableLayoutCheckAllNone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSourceCreditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseCurrencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboInternal
            // 
            this.comboInternal.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboInternal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInternal.FormattingEnabled = true;
            this.comboInternal.Location = new System.Drawing.Point(97, 49);
            this.comboInternal.Name = "comboInternal";
            this.comboInternal.Size = new System.Drawing.Size(186, 21);
            this.comboInternal.TabIndex = 3;
            // 
            // buttonCheckNone
            // 
            this.buttonCheckNone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCheckNone.Location = new System.Drawing.Point(99, 0);
            this.buttonCheckNone.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonCheckNone.Name = "buttonCheckNone";
            this.buttonCheckNone.Size = new System.Drawing.Size(89, 34);
            this.buttonCheckNone.TabIndex = 1;
            this.buttonCheckNone.Text = "Check none";
            this.buttonCheckNone.UseVisualStyleBackColor = true;
            this.buttonCheckNone.Click += new System.EventHandler(this.buttonCheckNone_Click);
            // 
            // buttonCheckAll
            // 
            this.buttonCheckAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCheckAll.Location = new System.Drawing.Point(0, 0);
            this.buttonCheckAll.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.buttonCheckAll.Name = "buttonCheckAll";
            this.buttonCheckAll.Size = new System.Drawing.Size(89, 34);
            this.buttonCheckAll.TabIndex = 0;
            this.buttonCheckAll.Text = "Check all";
            this.buttonCheckAll.UseVisualStyleBackColor = true;
            this.buttonCheckAll.Click += new System.EventHandler(this.buttonCheckAll_Click);
            // 
            // checkedListForWhom
            // 
            this.checkedListForWhom.CheckOnClick = true;
            this.checkedListForWhom.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListForWhom.FormattingEnabled = true;
            this.checkedListForWhom.Location = new System.Drawing.Point(103, 242);
            this.checkedListForWhom.Name = "checkedListForWhom";
            this.checkedListForWhom.Size = new System.Drawing.Size(188, 89);
            this.checkedListForWhom.TabIndex = 10;
            // 
            // buttonAddTransaction
            // 
            this.panelTableNewTransaction.SetColumnSpan(this.buttonAddTransaction, 2);
            this.buttonAddTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddTransaction.Location = new System.Drawing.Point(5, 444);
            this.buttonAddTransaction.Margin = new System.Windows.Forms.Padding(5, 10, 2, 3);
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.Size = new System.Drawing.Size(287, 57);
            this.buttonAddTransaction.TabIndex = 15;
            this.buttonAddTransaction.Text = "Add transaction";
            this.buttonAddTransaction.UseVisualStyleBackColor = true;
            // 
            // textAmount
            // 
            this.textAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.textAmount.Location = new System.Drawing.Point(103, 131);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(188, 22);
            this.textAmount.TabIndex = 4;
            this.textAmount.TextChanged += new System.EventHandler(this.textAmount_TextChanged);
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
            this.radioInternal.CheckedChanged += new System.EventHandler(this.radioInternal_CheckedChanged);
            // 
            // labelForWhom
            // 
            this.labelForWhom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelForWhom.AutoSize = true;
            this.labelForWhom.Location = new System.Drawing.Point(5, 280);
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
            this.radioCollectiveExpense.CheckedChanged += new System.EventHandler(this.radioCollectiveExpense_CheckedChanged);
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
            this.radioSingleExpense.CheckedChanged += new System.EventHandler(this.radioSingleExpense_CheckedChanged);
            // 
            // labelCreditor
            // 
            this.labelCreditor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCreditor.AutoSize = true;
            this.labelCreditor.Location = new System.Drawing.Point(5, 7);
            this.labelCreditor.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.labelCreditor.Name = "labelCreditor";
            this.labelCreditor.Size = new System.Drawing.Size(58, 13);
            this.labelCreditor.TabIndex = 0;
            this.labelCreditor.Text = "Who pays";
            // 
            // textTransactionDetails
            // 
            this.textTransactionDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.textTransactionDetails.Location = new System.Drawing.Point(103, 375);
            this.textTransactionDetails.Multiline = true;
            this.textTransactionDetails.Name = "textTransactionDetails";
            this.textTransactionDetails.Size = new System.Drawing.Size(188, 56);
            this.textTransactionDetails.TabIndex = 13;
            // 
            // labelTransactionDetails
            // 
            this.labelTransactionDetails.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTransactionDetails.AutoSize = true;
            this.labelTransactionDetails.Location = new System.Drawing.Point(5, 396);
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
            // panelTableTransactions
            // 
            this.panelTableTransactions.ColumnCount = 2;
            this.panelTableTransactions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 302F));
            this.panelTableTransactions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTableTransactions.Controls.Add(this.panelTableNewTransaction, 0, 0);
            this.panelTableTransactions.Controls.Add(this.dataGridTransactionLines, 1, 0);
            this.panelTableTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTableTransactions.Location = new System.Drawing.Point(0, 0);
            this.panelTableTransactions.Name = "panelTableTransactions";
            this.panelTableTransactions.RowCount = 1;
            this.panelTableTransactions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTableTransactions.Size = new System.Drawing.Size(1053, 556);
            this.panelTableTransactions.TabIndex = 0;
            // 
            // panelTableNewTransaction
            // 
            this.panelTableNewTransaction.ColumnCount = 2;
            this.panelTableNewTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.panelTableNewTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTableNewTransaction.Controls.Add(this.groupTransactionType, 0, 1);
            this.panelTableNewTransaction.Controls.Add(this.textTransactionDetails, 1, 8);
            this.panelTableNewTransaction.Controls.Add(this.tableLayoutCheckAllNone, 1, 7);
            this.panelTableNewTransaction.Controls.Add(this.labelTransactionDetails, 0, 8);
            this.panelTableNewTransaction.Controls.Add(this.textExchangeRate, 1, 4);
            this.panelTableNewTransaction.Controls.Add(this.checkedListForWhom, 1, 6);
            this.panelTableNewTransaction.Controls.Add(this.labelAmount, 0, 2);
            this.panelTableNewTransaction.Controls.Add(this.labelForWhom, 0, 6);
            this.panelTableNewTransaction.Controls.Add(this.textAmount, 1, 2);
            this.panelTableNewTransaction.Controls.Add(this.labelExchangeRate, 0, 4);
            this.panelTableNewTransaction.Controls.Add(this.labelCurrency, 0, 3);
            this.panelTableNewTransaction.Controls.Add(this.comboCurrency, 1, 3);
            this.panelTableNewTransaction.Controls.Add(this.buttonAddTransaction, 1, 9);
            this.panelTableNewTransaction.Controls.Add(this.labelCreditor, 0, 0);
            this.panelTableNewTransaction.Controls.Add(this.comboCreditor, 1, 0);
            this.panelTableNewTransaction.Controls.Add(this.labelTransactionDate, 0, 5);
            this.panelTableNewTransaction.Controls.Add(this.datePickerTransactionDate, 1, 5);
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
            this.panelTableNewTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTableNewTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTableNewTransaction.Size = new System.Drawing.Size(296, 550);
            this.panelTableNewTransaction.TabIndex = 0;
            // 
            // groupTransactionType
            // 
            this.panelTableNewTransaction.SetColumnSpan(this.groupTransactionType, 2);
            this.groupTransactionType.Controls.Add(this.panelTableTransactionType);
            this.groupTransactionType.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTransactionType.Location = new System.Drawing.Point(3, 30);
            this.groupTransactionType.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.groupTransactionType.Name = "groupTransactionType";
            this.groupTransactionType.Padding = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.groupTransactionType.Size = new System.Drawing.Size(290, 95);
            this.groupTransactionType.TabIndex = 2;
            this.groupTransactionType.TabStop = false;
            this.groupTransactionType.Text = "Transaction type";
            // 
            // panelTableTransactionType
            // 
            this.panelTableTransactionType.AutoSize = true;
            this.panelTableTransactionType.ColumnCount = 2;
            this.panelTableTransactionType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
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
            this.panelTableTransactionType.Size = new System.Drawing.Size(286, 73);
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
            this.tableLayoutCheckAllNone.Location = new System.Drawing.Point(103, 335);
            this.tableLayoutCheckAllNone.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.tableLayoutCheckAllNone.Name = "tableLayoutCheckAllNone";
            this.tableLayoutCheckAllNone.RowCount = 1;
            this.tableLayoutCheckAllNone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutCheckAllNone.Size = new System.Drawing.Size(188, 34);
            this.tableLayoutCheckAllNone.TabIndex = 11;
            // 
            // textExchangeRate
            // 
            this.textExchangeRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.textExchangeRate.Location = new System.Drawing.Point(103, 186);
            this.textExchangeRate.Name = "textExchangeRate";
            this.textExchangeRate.Size = new System.Drawing.Size(188, 22);
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
            // comboCurrency
            // 
            this.comboCurrency.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCurrency.FormattingEnabled = true;
            this.comboCurrency.Location = new System.Drawing.Point(103, 159);
            this.comboCurrency.Name = "comboCurrency";
            this.comboCurrency.Size = new System.Drawing.Size(188, 21);
            this.comboCurrency.TabIndex = 6;
            this.comboCurrency.SelectedIndexChanged += new System.EventHandler(this.comboCurrency_SelectedIndexChanged);
            // 
            // comboCreditor
            // 
            this.comboCreditor.DataSource = this.accountBindingSourceCreditor;
            this.comboCreditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboCreditor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCreditor.FormattingEnabled = true;
            this.comboCreditor.Location = new System.Drawing.Point(103, 3);
            this.comboCreditor.Name = "comboCreditor";
            this.comboCreditor.Size = new System.Drawing.Size(188, 21);
            this.comboCreditor.TabIndex = 1;
            this.comboCreditor.SelectedIndexChanged += new System.EventHandler(this.comboCreditor_SelectedIndexChanged);
            // 
            // accountBindingSourceCreditor
            // 
            this.accountBindingSourceCreditor.DataSource = typeof(TravelAccounting.Model.Account);
            // 
            // labelTransactionDate
            // 
            this.labelTransactionDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTransactionDate.AutoSize = true;
            this.labelTransactionDate.Location = new System.Drawing.Point(3, 218);
            this.labelTransactionDate.Name = "labelTransactionDate";
            this.labelTransactionDate.Size = new System.Drawing.Size(92, 13);
            this.labelTransactionDate.TabIndex = 16;
            this.labelTransactionDate.Text = "Transaction date";
            // 
            // datePickerTransactionDate
            // 
            this.datePickerTransactionDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.datePickerTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerTransactionDate.Location = new System.Drawing.Point(103, 214);
            this.datePickerTransactionDate.Name = "datePickerTransactionDate";
            this.datePickerTransactionDate.Size = new System.Drawing.Size(188, 22);
            this.datePickerTransactionDate.TabIndex = 17;
            // 
            // dataGridTransactionLines
            // 
            this.dataGridTransactionLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridTransactionLines.AutoGenerateColumns = false;
            this.dataGridTransactionLines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridTransactionLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransactionLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.creditorDataGridViewTextBoxColumn,
            this.debtorDataGridViewTextBoxColumn,
            this.transactionDataGridViewTextBoxColumn,
            this.baseAmountDataGridViewTextBoxColumn,
            this.actualAmountDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridTransactionLines.DataSource = this.transactionLineBindingSource;
            this.dataGridTransactionLines.Location = new System.Drawing.Point(305, 3);
            this.dataGridTransactionLines.Name = "dataGridTransactionLines";
            this.dataGridTransactionLines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridTransactionLines.Size = new System.Drawing.Size(745, 550);
            this.dataGridTransactionLines.TabIndex = 1;
            // 
            // creditorDataGridViewTextBoxColumn
            // 
            this.creditorDataGridViewTextBoxColumn.DataPropertyName = "Creditor";
            this.creditorDataGridViewTextBoxColumn.HeaderText = "Creditor";
            this.creditorDataGridViewTextBoxColumn.Name = "creditorDataGridViewTextBoxColumn";
            // 
            // debtorDataGridViewTextBoxColumn
            // 
            this.debtorDataGridViewTextBoxColumn.DataPropertyName = "Debtor";
            this.debtorDataGridViewTextBoxColumn.HeaderText = "Debtor";
            this.debtorDataGridViewTextBoxColumn.Name = "debtorDataGridViewTextBoxColumn";
            // 
            // transactionDataGridViewTextBoxColumn
            // 
            this.transactionDataGridViewTextBoxColumn.DataPropertyName = "Transaction";
            this.transactionDataGridViewTextBoxColumn.HeaderText = "Transaction";
            this.transactionDataGridViewTextBoxColumn.Name = "transactionDataGridViewTextBoxColumn";
            this.transactionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // baseAmountDataGridViewTextBoxColumn
            // 
            this.baseAmountDataGridViewTextBoxColumn.DataPropertyName = "BaseAmount";
            this.baseAmountDataGridViewTextBoxColumn.HeaderText = "Base Currency Amount";
            this.baseAmountDataGridViewTextBoxColumn.Name = "baseAmountDataGridViewTextBoxColumn";
            this.baseAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actualAmountDataGridViewTextBoxColumn
            // 
            this.actualAmountDataGridViewTextBoxColumn.DataPropertyName = "ActualAmount";
            this.actualAmountDataGridViewTextBoxColumn.HeaderText = "Real Currency Amount";
            this.actualAmountDataGridViewTextBoxColumn.Name = "actualAmountDataGridViewTextBoxColumn";
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "Real Currency";
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            this.currencyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionLineBindingSource
            // 
            this.transactionLineBindingSource.DataSource = typeof(TravelAccounting.Model.TransactionLine);
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(TravelAccounting.Model.Currency);
            // 
            // baseCurrencyBindingSource
            // 
            this.baseCurrencyBindingSource.DataSource = typeof(TravelAccounting.Model.Currency);
            // 
            // TransactionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTableTransactions);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "TransactionsControl";
            this.Size = new System.Drawing.Size(1053, 556);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewTransaction)).EndInit();
            this.panelTableTransactions.ResumeLayout(false);
            this.panelTableNewTransaction.ResumeLayout(false);
            this.panelTableNewTransaction.PerformLayout();
            this.groupTransactionType.ResumeLayout(false);
            this.groupTransactionType.PerformLayout();
            this.panelTableTransactionType.ResumeLayout(false);
            this.panelTableTransactionType.PerformLayout();
            this.tableLayoutCheckAllNone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSourceCreditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseCurrencyBindingSource)).EndInit();
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
        private System.Windows.Forms.Label labelCreditor;
        internal System.Windows.Forms.TextBox textTransactionDetails;
        private System.Windows.Forms.Label labelTransactionDetails;
        private System.Windows.Forms.ErrorProvider errorProviderNewTransaction;
        private System.Windows.Forms.TableLayoutPanel panelTableTransactions;
        private System.Windows.Forms.GroupBox groupTransactionType;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.Label labelExchangeRate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutCheckAllNone;
        private System.Windows.Forms.TableLayoutPanel panelTableNewTransaction;
        private System.Windows.Forms.TableLayoutPanel panelTableTransactionType;
        private System.Windows.Forms.DataGridView dataGridTransactionLines;
        internal System.Windows.Forms.ComboBox comboCreditor;
        internal System.Windows.Forms.BindingSource accountBindingSourceCreditor;
        internal System.Windows.Forms.BindingSource transactionLineBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        internal System.Windows.Forms.ComboBox comboCurrency;
        internal System.Windows.Forms.TextBox textExchangeRate;
        internal System.Windows.Forms.BindingSource currencyBindingSource;
        internal System.Windows.Forms.BindingSource baseCurrencyBindingSource;
        private System.Windows.Forms.Label labelTransactionDate;
        internal System.Windows.Forms.DateTimePicker datePickerTransactionDate;
    }
}
