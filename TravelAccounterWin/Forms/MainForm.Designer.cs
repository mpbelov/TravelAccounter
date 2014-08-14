namespace TravelAccounterWin.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelTableStart = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonStartNewTravel = new System.Windows.Forms.Button();
            this.panelMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonTransaction = new System.Windows.Forms.Button();
            this.buttonAccounts = new System.Windows.Forms.Button();
            this.panelWorkArea = new System.Windows.Forms.Panel();
            this.panelTransactions = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioInternal = new System.Windows.Forms.RadioButton();
            this.labelForWhom = new System.Windows.Forms.Label();
            this.radioCollectiveExpense = new System.Windows.Forms.RadioButton();
            this.radioSingleExpense = new System.Windows.Forms.RadioButton();
            this.comboCreditor = new System.Windows.Forms.ComboBox();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelCreditor = new System.Windows.Forms.Label();
            this.textTransactionDetails = new System.Windows.Forms.TextBox();
            this.labelTransactionDetails = new System.Windows.Forms.Label();
            this.panelAccounts = new System.Windows.Forms.Panel();
            this.dataGridAccounts = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripAccounts = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNewAccount = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteAccount = new System.Windows.Forms.ToolStripButton();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.buttonAddTransaction = new System.Windows.Forms.Button();
            this.accountBindingSourceWho = new System.Windows.Forms.BindingSource(this.components);
            this.checkedListForWhom = new System.Windows.Forms.CheckedListBox();
            this.buttonCheckAll = new System.Windows.Forms.Button();
            this.buttonCheckNone = new System.Windows.Forms.Button();
            this.comboInternal = new System.Windows.Forms.ComboBox();
            this.dataGridTransactions = new System.Windows.Forms.DataGridView();
            this.transactionLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creditorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTableStart.SuspendLayout();
            this.panelMainPanel.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelWorkArea.SuspendLayout();
            this.panelTransactions.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.panelAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccounts)).BeginInit();
            this.toolStripAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSourceWho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTableStart
            // 
            this.panelTableStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTableStart.ColumnCount = 1;
            this.panelTableStart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTableStart.Controls.Add(this.buttonOpen, 0, 1);
            this.panelTableStart.Controls.Add(this.buttonStartNewTravel, 0, 0);
            this.panelTableStart.Location = new System.Drawing.Point(258, 182);
            this.panelTableStart.Name = "panelTableStart";
            this.panelTableStart.RowCount = 2;
            this.panelTableStart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.panelTableStart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.panelTableStart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTableStart.Size = new System.Drawing.Size(275, 116);
            this.panelTableStart.TabIndex = 4;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOpen.Enabled = false;
            this.buttonOpen.Location = new System.Drawing.Point(100, 81);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonStartNewTravel
            // 
            this.buttonStartNewTravel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStartNewTravel.Location = new System.Drawing.Point(77, 11);
            this.buttonStartNewTravel.Name = "buttonStartNewTravel";
            this.buttonStartNewTravel.Size = new System.Drawing.Size(121, 46);
            this.buttonStartNewTravel.TabIndex = 0;
            this.buttonStartNewTravel.Text = "New travel";
            this.buttonStartNewTravel.UseVisualStyleBackColor = true;
            // 
            // panelMainPanel
            // 
            this.panelMainPanel.ColumnCount = 1;
            this.panelMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMainPanel.Controls.Add(this.panelTop, 0, 0);
            this.panelMainPanel.Controls.Add(this.panelWorkArea, 0, 1);
            this.panelMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainPanel.Location = new System.Drawing.Point(0, 0);
            this.panelMainPanel.Margin = new System.Windows.Forms.Padding(1);
            this.panelMainPanel.Name = "panelMainPanel";
            this.panelMainPanel.RowCount = 2;
            this.panelMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.panelMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMainPanel.Size = new System.Drawing.Size(791, 480);
            this.panelMainPanel.TabIndex = 5;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.buttonTransaction);
            this.panelTop.Controls.Add(this.buttonAccounts);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(1, 1);
            this.panelTop.Margin = new System.Windows.Forms.Padding(1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(789, 68);
            this.panelTop.TabIndex = 0;
            // 
            // buttonTransaction
            // 
            this.buttonTransaction.Location = new System.Drawing.Point(86, 3);
            this.buttonTransaction.Name = "buttonTransaction";
            this.buttonTransaction.Size = new System.Drawing.Size(77, 62);
            this.buttonTransaction.TabIndex = 0;
            this.buttonTransaction.Text = "Transaction";
            this.buttonTransaction.UseVisualStyleBackColor = true;
            this.buttonTransaction.Click += new System.EventHandler(this.buttonTransaction_Click);
            // 
            // buttonAccounts
            // 
            this.buttonAccounts.Location = new System.Drawing.Point(3, 3);
            this.buttonAccounts.Name = "buttonAccounts";
            this.buttonAccounts.Size = new System.Drawing.Size(77, 62);
            this.buttonAccounts.TabIndex = 0;
            this.buttonAccounts.Text = "Accounts";
            this.buttonAccounts.UseVisualStyleBackColor = true;
            this.buttonAccounts.Click += new System.EventHandler(this.buttonAccounts_Click);
            // 
            // panelWorkArea
            // 
            this.panelWorkArea.Controls.Add(this.panelTransactions);
            this.panelWorkArea.Controls.Add(this.panelAccounts);
            this.panelWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkArea.Location = new System.Drawing.Point(1, 71);
            this.panelWorkArea.Margin = new System.Windows.Forms.Padding(1);
            this.panelWorkArea.Name = "panelWorkArea";
            this.panelWorkArea.Size = new System.Drawing.Size(789, 408);
            this.panelWorkArea.TabIndex = 1;
            // 
            // panelTransactions
            // 
            this.panelTransactions.ColumnCount = 1;
            this.panelTransactions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTransactions.Controls.Add(this.panel1, 0, 0);
            this.panelTransactions.Controls.Add(this.dataGridTransactions, 0, 1);
            this.panelTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTransactions.Location = new System.Drawing.Point(0, 0);
            this.panelTransactions.Name = "panelTransactions";
            this.panelTransactions.RowCount = 2;
            this.panelTransactions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.panelTransactions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTransactions.Size = new System.Drawing.Size(789, 408);
            this.panelTransactions.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboInternal);
            this.panel1.Controls.Add(this.buttonCheckNone);
            this.panel1.Controls.Add(this.buttonCheckAll);
            this.panel1.Controls.Add(this.checkedListForWhom);
            this.panel1.Controls.Add(this.buttonAddTransaction);
            this.panel1.Controls.Add(this.textAmount);
            this.panel1.Controls.Add(this.labelAmount);
            this.panel1.Controls.Add(this.radioInternal);
            this.panel1.Controls.Add(this.labelForWhom);
            this.panel1.Controls.Add(this.radioCollectiveExpense);
            this.panel1.Controls.Add(this.radioSingleExpense);
            this.panel1.Controls.Add(this.comboCreditor);
            this.panel1.Controls.Add(this.labelCreditor);
            this.panel1.Controls.Add(this.textTransactionDetails);
            this.panel1.Controls.Add(this.labelTransactionDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 128);
            this.panel1.TabIndex = 0;
            // 
            // radioInternal
            // 
            this.radioInternal.AutoSize = true;
            this.radioInternal.Location = new System.Drawing.Point(184, 106);
            this.radioInternal.Name = "radioInternal";
            this.radioInternal.Size = new System.Drawing.Size(60, 17);
            this.radioInternal.TabIndex = 8;
            this.radioInternal.Text = "Internal";
            this.radioInternal.UseVisualStyleBackColor = true;
            this.radioInternal.CheckedChanged += new System.EventHandler(this.radioInternal_CheckedChanged);
            // 
            // labelForWhom
            // 
            this.labelForWhom.AutoSize = true;
            this.labelForWhom.Location = new System.Drawing.Point(417, 10);
            this.labelForWhom.Name = "labelForWhom";
            this.labelForWhom.Size = new System.Drawing.Size(72, 13);
            this.labelForWhom.TabIndex = 9;
            this.labelForWhom.Text = "Who is payed";
            // 
            // radioCollectiveExpense
            // 
            this.radioCollectiveExpense.AutoSize = true;
            this.radioCollectiveExpense.Location = new System.Drawing.Point(184, 83);
            this.radioCollectiveExpense.Name = "radioCollectiveExpense";
            this.radioCollectiveExpense.Size = new System.Drawing.Size(114, 17);
            this.radioCollectiveExpense.TabIndex = 7;
            this.radioCollectiveExpense.Text = "Collective expense";
            this.radioCollectiveExpense.UseVisualStyleBackColor = true;
            this.radioCollectiveExpense.CheckedChanged += new System.EventHandler(this.radioCollectiveExpense_CheckedChanged);
            // 
            // radioSingleExpense
            // 
            this.radioSingleExpense.AutoSize = true;
            this.radioSingleExpense.Location = new System.Drawing.Point(184, 60);
            this.radioSingleExpense.Name = "radioSingleExpense";
            this.radioSingleExpense.Size = new System.Drawing.Size(97, 17);
            this.radioSingleExpense.TabIndex = 6;
            this.radioSingleExpense.Text = "Single expense";
            this.radioSingleExpense.UseVisualStyleBackColor = true;
            this.radioSingleExpense.CheckedChanged += new System.EventHandler(this.radioSingleExpense_CheckedChanged);
            // 
            // comboCreditor
            // 
            this.comboCreditor.DataSource = this.accountBindingSourceWho;
            this.comboCreditor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCreditor.FormattingEnabled = true;
            this.comboCreditor.Location = new System.Drawing.Point(250, 7);
            this.comboCreditor.Name = "comboCreditor";
            this.comboCreditor.Size = new System.Drawing.Size(140, 21);
            this.comboCreditor.TabIndex = 3;
            this.comboCreditor.SelectedIndexChanged += new System.EventHandler(this.comboCreditor_SelectedIndexChanged);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.AllowNew = false;
            this.accountBindingSource.DataSource = typeof(TravelAccounting.Model.Account);
            // 
            // labelCreditor
            // 
            this.labelCreditor.AutoSize = true;
            this.labelCreditor.Location = new System.Drawing.Point(181, 10);
            this.labelCreditor.Name = "labelCreditor";
            this.labelCreditor.Size = new System.Drawing.Size(55, 13);
            this.labelCreditor.TabIndex = 2;
            this.labelCreditor.Text = "Who pays";
            // 
            // textTransactionDetails
            // 
            this.textTransactionDetails.Location = new System.Drawing.Point(10, 26);
            this.textTransactionDetails.Multiline = true;
            this.textTransactionDetails.Name = "textTransactionDetails";
            this.textTransactionDetails.Size = new System.Drawing.Size(148, 97);
            this.textTransactionDetails.TabIndex = 1;
            // 
            // labelTransactionDetails
            // 
            this.labelTransactionDetails.AutoSize = true;
            this.labelTransactionDetails.Location = new System.Drawing.Point(10, 10);
            this.labelTransactionDetails.Name = "labelTransactionDetails";
            this.labelTransactionDetails.Size = new System.Drawing.Size(39, 13);
            this.labelTransactionDetails.TabIndex = 0;
            this.labelTransactionDetails.Text = "Details";
            // 
            // panelAccounts
            // 
            this.panelAccounts.Controls.Add(this.dataGridAccounts);
            this.panelAccounts.Controls.Add(this.toolStripAccounts);
            this.panelAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAccounts.Location = new System.Drawing.Point(0, 0);
            this.panelAccounts.Margin = new System.Windows.Forms.Padding(1);
            this.panelAccounts.Name = "panelAccounts";
            this.panelAccounts.Size = new System.Drawing.Size(789, 408);
            this.panelAccounts.TabIndex = 0;
            // 
            // dataGridAccounts
            // 
            this.dataGridAccounts.AutoGenerateColumns = false;
            this.dataGridAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn,
            this.debtDataGridViewTextBoxColumn,
            this.expenseDataGridViewTextBoxColumn});
            this.dataGridAccounts.DataSource = this.accountBindingSource;
            this.dataGridAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAccounts.Location = new System.Drawing.Point(0, 25);
            this.dataGridAccounts.Name = "dataGridAccounts";
            this.dataGridAccounts.RowHeadersVisible = false;
            this.dataGridAccounts.Size = new System.Drawing.Size(789, 383);
            this.dataGridAccounts.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "Credit";
            this.creditDataGridViewTextBoxColumn.HeaderText = "Credit";
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            this.creditDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // debtDataGridViewTextBoxColumn
            // 
            this.debtDataGridViewTextBoxColumn.DataPropertyName = "Debt";
            this.debtDataGridViewTextBoxColumn.HeaderText = "Debt";
            this.debtDataGridViewTextBoxColumn.Name = "debtDataGridViewTextBoxColumn";
            this.debtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseDataGridViewTextBoxColumn
            // 
            this.expenseDataGridViewTextBoxColumn.DataPropertyName = "Expense";
            this.expenseDataGridViewTextBoxColumn.HeaderText = "Expense";
            this.expenseDataGridViewTextBoxColumn.Name = "expenseDataGridViewTextBoxColumn";
            this.expenseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toolStripAccounts
            // 
            this.toolStripAccounts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewAccount,
            this.toolStripButtonDeleteAccount});
            this.toolStripAccounts.Location = new System.Drawing.Point(0, 0);
            this.toolStripAccounts.Name = "toolStripAccounts";
            this.toolStripAccounts.Size = new System.Drawing.Size(789, 25);
            this.toolStripAccounts.TabIndex = 0;
            this.toolStripAccounts.Text = "Accounts";
            // 
            // toolStripButtonNewAccount
            // 
            this.toolStripButtonNewAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonNewAccount.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNewAccount.Image")));
            this.toolStripButtonNewAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewAccount.Name = "toolStripButtonNewAccount";
            this.toolStripButtonNewAccount.Size = new System.Drawing.Size(81, 22);
            this.toolStripButtonNewAccount.Text = "New account";
            // 
            // toolStripButtonDeleteAccount
            // 
            this.toolStripButtonDeleteAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDeleteAccount.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteAccount.Image")));
            this.toolStripButtonDeleteAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteAccount.Name = "toolStripButtonDeleteAccount";
            this.toolStripButtonDeleteAccount.Size = new System.Drawing.Size(90, 22);
            this.toolStripButtonDeleteAccount.Text = "Delete account";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(181, 37);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(43, 13);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Amount";
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(250, 34);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(140, 20);
            this.textAmount.TabIndex = 5;
            // 
            // buttonAddTransaction
            // 
            this.buttonAddTransaction.Location = new System.Drawing.Point(696, 10);
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.Size = new System.Drawing.Size(75, 112);
            this.buttonAddTransaction.TabIndex = 13;
            this.buttonAddTransaction.Text = "Add transaction";
            this.buttonAddTransaction.UseVisualStyleBackColor = true;
            // 
            // accountBindingSourceWho
            // 
            this.accountBindingSourceWho.DataSource = typeof(TravelAccounting.Model.Account);
            // 
            // checkedListForWhom
            // 
            this.checkedListForWhom.CheckOnClick = true;
            this.checkedListForWhom.FormattingEnabled = true;
            this.checkedListForWhom.Location = new System.Drawing.Point(420, 28);
            this.checkedListForWhom.Name = "checkedListForWhom";
            this.checkedListForWhom.Size = new System.Drawing.Size(169, 94);
            this.checkedListForWhom.TabIndex = 10;
            // 
            // buttonCheckAll
            // 
            this.buttonCheckAll.Location = new System.Drawing.Point(595, 28);
            this.buttonCheckAll.Name = "buttonCheckAll";
            this.buttonCheckAll.Size = new System.Drawing.Size(75, 39);
            this.buttonCheckAll.TabIndex = 11;
            this.buttonCheckAll.Text = "Check all";
            this.buttonCheckAll.UseVisualStyleBackColor = true;
            this.buttonCheckAll.Click += new System.EventHandler(this.buttonCheckAll_Click);
            // 
            // buttonCheckNone
            // 
            this.buttonCheckNone.Location = new System.Drawing.Point(595, 83);
            this.buttonCheckNone.Name = "buttonCheckNone";
            this.buttonCheckNone.Size = new System.Drawing.Size(75, 39);
            this.buttonCheckNone.TabIndex = 12;
            this.buttonCheckNone.Text = "Check none";
            this.buttonCheckNone.UseVisualStyleBackColor = true;
            this.buttonCheckNone.Click += new System.EventHandler(this.buttonCheckNone_Click);
            // 
            // comboInternal
            // 
            this.comboInternal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInternal.FormattingEnabled = true;
            this.comboInternal.Location = new System.Drawing.Point(250, 102);
            this.comboInternal.Name = "comboInternal";
            this.comboInternal.Size = new System.Drawing.Size(140, 21);
            this.comboInternal.TabIndex = 14;
            // 
            // dataGridTransactions
            // 
            this.dataGridTransactions.AllowUserToAddRows = false;
            this.dataGridTransactions.AllowUserToDeleteRows = false;
            this.dataGridTransactions.AutoGenerateColumns = false;
            this.dataGridTransactions.ColumnHeadersHeight = 25;
            this.dataGridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.creditorDataGridViewTextBoxColumn,
            this.debtorDataGridViewTextBoxColumn,
            this.transactionDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridTransactions.DataSource = this.transactionLineBindingSource;
            this.dataGridTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTransactions.Location = new System.Drawing.Point(3, 133);
            this.dataGridTransactions.Name = "dataGridTransactions";
            this.dataGridTransactions.ReadOnly = true;
            this.dataGridTransactions.RowHeadersVisible = false;
            this.dataGridTransactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTransactions.Size = new System.Drawing.Size(783, 272);
            this.dataGridTransactions.TabIndex = 1;
            // 
            // transactionLineBindingSource
            // 
            this.transactionLineBindingSource.DataSource = typeof(TravelAccounting.Model.TransactionLine);
            // 
            // creditorDataGridViewTextBoxColumn
            // 
            this.creditorDataGridViewTextBoxColumn.DataPropertyName = "Creditor";
            this.creditorDataGridViewTextBoxColumn.HeaderText = "Creditor";
            this.creditorDataGridViewTextBoxColumn.Name = "creditorDataGridViewTextBoxColumn";
            this.creditorDataGridViewTextBoxColumn.ReadOnly = true;
            this.creditorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // debtorDataGridViewTextBoxColumn
            // 
            this.debtorDataGridViewTextBoxColumn.DataPropertyName = "Debtor";
            this.debtorDataGridViewTextBoxColumn.HeaderText = "Debtor";
            this.debtorDataGridViewTextBoxColumn.Name = "debtorDataGridViewTextBoxColumn";
            this.debtorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionDataGridViewTextBoxColumn
            // 
            this.transactionDataGridViewTextBoxColumn.DataPropertyName = "Transaction";
            this.transactionDataGridViewTextBoxColumn.HeaderText = "Transaction";
            this.transactionDataGridViewTextBoxColumn.Name = "transactionDataGridViewTextBoxColumn";
            this.transactionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(791, 480);
            this.Controls.Add(this.panelMainPanel);
            this.Controls.Add(this.panelTableStart);
            this.MaximumSize = new System.Drawing.Size(807, 519);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel accounter";
            this.panelTableStart.ResumeLayout(false);
            this.panelMainPanel.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelWorkArea.ResumeLayout(false);
            this.panelTransactions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.panelAccounts.ResumeLayout(false);
            this.panelAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccounts)).EndInit();
            this.toolStripAccounts.ResumeLayout(false);
            this.toolStripAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSourceWho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLineBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        internal System.Windows.Forms.Button buttonStartNewTravel;
        internal System.Windows.Forms.TableLayoutPanel panelTableStart;
        internal System.Windows.Forms.TableLayoutPanel panelMainPanel;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonAccounts;
        private System.Windows.Forms.Button buttonTransaction;
        private System.Windows.Forms.Panel panelWorkArea;
        private System.Windows.Forms.ToolStrip toolStripAccounts;
        internal System.Windows.Forms.Panel panelAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseDataGridViewTextBoxColumn;
        internal System.Windows.Forms.BindingSource accountBindingSource;
        internal System.Windows.Forms.ToolStripButton toolStripButtonNewAccount;
        internal System.Windows.Forms.ToolStripButton toolStripButtonDeleteAccount;
        internal System.Windows.Forms.DataGridView dataGridAccounts;
        private System.Windows.Forms.TableLayoutPanel panelTransactions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTransactionDetails;
        private System.Windows.Forms.Label labelCreditor;
        private System.Windows.Forms.Label labelForWhom;
        private System.Windows.Forms.Label labelAmount;
        internal System.Windows.Forms.BindingSource accountBindingSourceWho;
        private System.Windows.Forms.Button buttonCheckNone;
        private System.Windows.Forms.Button buttonCheckAll;
        internal System.Windows.Forms.TextBox textTransactionDetails;
        internal System.Windows.Forms.TextBox textAmount;
        internal System.Windows.Forms.Button buttonAddTransaction;
        internal System.Windows.Forms.RadioButton radioCollectiveExpense;
        internal System.Windows.Forms.RadioButton radioSingleExpense;
        internal System.Windows.Forms.RadioButton radioInternal;
        internal System.Windows.Forms.ComboBox comboCreditor;
        internal System.Windows.Forms.ComboBox comboInternal;
        internal System.Windows.Forms.CheckedListBox checkedListForWhom;
        private System.Windows.Forms.DataGridView dataGridTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        internal System.Windows.Forms.BindingSource transactionLineBindingSource;

    }
}

