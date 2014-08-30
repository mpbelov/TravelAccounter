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
            this.buttonOpenTravel = new System.Windows.Forms.Button();
            this.buttonSaveTravel = new System.Windows.Forms.Button();
            this.buttonClaims = new System.Windows.Forms.Button();
            this.buttonTransaction = new System.Windows.Forms.Button();
            this.buttonAccounts = new System.Windows.Forms.Button();
            this.panelWorkArea = new System.Windows.Forms.Panel();
            this.panelClaims = new System.Windows.Forms.Panel();
            this.dataGridClaims = new System.Windows.Forms.DataGridView();
            this.creditorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripClaims = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCalculateClaims = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPayClaims = new System.Windows.Forms.ToolStripButton();
            this.panelTransactions = new System.Windows.Forms.TableLayoutPanel();
            this.panelNewTransaction = new System.Windows.Forms.Panel();
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
            this.accountBindingSourceWho = new System.Windows.Forms.BindingSource(this.components);
            this.labelCreditor = new System.Windows.Forms.Label();
            this.textTransactionDetails = new System.Windows.Forms.TextBox();
            this.labelTransactionDetails = new System.Windows.Forms.Label();
            this.dataGridTransactions = new System.Windows.Forms.DataGridView();
            this.creditorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelAccounts = new System.Windows.Forms.Panel();
            this.dataGridAccounts = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripAccounts = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNewAccount = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteAccount = new System.Windows.Forms.ToolStripButton();
            this.errorProviderNewTransaction = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTableStart.SuspendLayout();
            this.panelMainPanel.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelWorkArea.SuspendLayout();
            this.panelClaims.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClaims)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimBindingSource)).BeginInit();
            this.toolStripClaims.SuspendLayout();
            this.panelTransactions.SuspendLayout();
            this.panelNewTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSourceWho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLineBindingSource)).BeginInit();
            this.panelAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.toolStripAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewTransaction)).BeginInit();
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
            this.panelTop.Controls.Add(this.buttonOpenTravel);
            this.panelTop.Controls.Add(this.buttonSaveTravel);
            this.panelTop.Controls.Add(this.buttonClaims);
            this.panelTop.Controls.Add(this.buttonTransaction);
            this.panelTop.Controls.Add(this.buttonAccounts);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(1, 1);
            this.panelTop.Margin = new System.Windows.Forms.Padding(1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(789, 68);
            this.panelTop.TabIndex = 0;
            // 
            // buttonOpenTravel
            // 
            this.buttonOpenTravel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonOpenTravel.Location = new System.Drawing.Point(618, 3);
            this.buttonOpenTravel.Name = "buttonOpenTravel";
            this.buttonOpenTravel.Size = new System.Drawing.Size(77, 62);
            this.buttonOpenTravel.TabIndex = 2;
            this.buttonOpenTravel.Text = "Open travel";
            this.buttonOpenTravel.UseVisualStyleBackColor = true;
            // 
            // buttonSaveTravel
            // 
            this.buttonSaveTravel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSaveTravel.Location = new System.Drawing.Point(701, 3);
            this.buttonSaveTravel.Name = "buttonSaveTravel";
            this.buttonSaveTravel.Size = new System.Drawing.Size(77, 62);
            this.buttonSaveTravel.TabIndex = 2;
            this.buttonSaveTravel.Text = "Save travel";
            this.buttonSaveTravel.UseVisualStyleBackColor = true;
            // 
            // buttonClaims
            // 
            this.buttonClaims.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonClaims.Location = new System.Drawing.Point(169, 3);
            this.buttonClaims.Name = "buttonClaims";
            this.buttonClaims.Size = new System.Drawing.Size(77, 62);
            this.buttonClaims.TabIndex = 2;
            this.buttonClaims.Text = "Claims";
            this.buttonClaims.UseVisualStyleBackColor = true;
            this.buttonClaims.Click += new System.EventHandler(this.buttonClaims_Click);
            // 
            // buttonTransaction
            // 
            this.buttonTransaction.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonTransaction.Location = new System.Drawing.Point(86, 3);
            this.buttonTransaction.Name = "buttonTransaction";
            this.buttonTransaction.Size = new System.Drawing.Size(77, 62);
            this.buttonTransaction.TabIndex = 1;
            this.buttonTransaction.Text = "Transaction";
            this.buttonTransaction.UseVisualStyleBackColor = true;
            this.buttonTransaction.Click += new System.EventHandler(this.buttonTransaction_Click);
            // 
            // buttonAccounts
            // 
            this.buttonAccounts.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.panelWorkArea.Controls.Add(this.panelClaims);
            this.panelWorkArea.Controls.Add(this.panelTransactions);
            this.panelWorkArea.Controls.Add(this.panelAccounts);
            this.panelWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkArea.Location = new System.Drawing.Point(1, 71);
            this.panelWorkArea.Margin = new System.Windows.Forms.Padding(1);
            this.panelWorkArea.Name = "panelWorkArea";
            this.panelWorkArea.Size = new System.Drawing.Size(789, 408);
            this.panelWorkArea.TabIndex = 1;
            // 
            // panelClaims
            // 
            this.panelClaims.Controls.Add(this.dataGridClaims);
            this.panelClaims.Controls.Add(this.toolStripClaims);
            this.panelClaims.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClaims.Location = new System.Drawing.Point(0, 0);
            this.panelClaims.Name = "panelClaims";
            this.panelClaims.Size = new System.Drawing.Size(789, 408);
            this.panelClaims.TabIndex = 2;
            // 
            // dataGridClaims
            // 
            this.dataGridClaims.AllowUserToAddRows = false;
            this.dataGridClaims.AllowUserToDeleteRows = false;
            this.dataGridClaims.AllowUserToResizeRows = false;
            this.dataGridClaims.AutoGenerateColumns = false;
            this.dataGridClaims.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridClaims.ColumnHeadersHeight = 30;
            this.dataGridClaims.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.creditorDataGridViewTextBoxColumn1,
            this.debtorDataGridViewTextBoxColumn1,
            this.amountDataGridViewTextBoxColumn1});
            this.dataGridClaims.DataSource = this.claimBindingSource;
            this.dataGridClaims.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridClaims.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridClaims.Location = new System.Drawing.Point(0, 25);
            this.dataGridClaims.Name = "dataGridClaims";
            this.dataGridClaims.RowHeadersVisible = false;
            this.dataGridClaims.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClaims.Size = new System.Drawing.Size(789, 383);
            this.dataGridClaims.TabIndex = 1;
            // 
            // creditorDataGridViewTextBoxColumn1
            // 
            this.creditorDataGridViewTextBoxColumn1.DataPropertyName = "Creditor";
            this.creditorDataGridViewTextBoxColumn1.HeaderText = "Creditor";
            this.creditorDataGridViewTextBoxColumn1.Name = "creditorDataGridViewTextBoxColumn1";
            this.creditorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // debtorDataGridViewTextBoxColumn1
            // 
            this.debtorDataGridViewTextBoxColumn1.DataPropertyName = "Debtor";
            this.debtorDataGridViewTextBoxColumn1.HeaderText = "Debtor";
            this.debtorDataGridViewTextBoxColumn1.Name = "debtorDataGridViewTextBoxColumn1";
            this.debtorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            this.amountDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // claimBindingSource
            // 
            this.claimBindingSource.AllowNew = false;
            this.claimBindingSource.DataSource = typeof(TravelAccounting.Model.Claim);
            // 
            // toolStripClaims
            // 
            this.toolStripClaims.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCalculateClaims,
            this.toolStripButtonPayClaims});
            this.toolStripClaims.Location = new System.Drawing.Point(0, 0);
            this.toolStripClaims.Name = "toolStripClaims";
            this.toolStripClaims.Size = new System.Drawing.Size(789, 25);
            this.toolStripClaims.TabIndex = 0;
            this.toolStripClaims.Text = "toolStrip1";
            // 
            // toolStripButtonCalculateClaims
            // 
            this.toolStripButtonCalculateClaims.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCalculateClaims.Image")));
            this.toolStripButtonCalculateClaims.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCalculateClaims.Name = "toolStripButtonCalculateClaims";
            this.toolStripButtonCalculateClaims.Size = new System.Drawing.Size(76, 22);
            this.toolStripButtonCalculateClaims.Text = "Calculate";
            // 
            // toolStripButtonPayClaims
            // 
            this.toolStripButtonPayClaims.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPayClaims.Image")));
            this.toolStripButtonPayClaims.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPayClaims.Name = "toolStripButtonPayClaims";
            this.toolStripButtonPayClaims.Size = new System.Drawing.Size(83, 22);
            this.toolStripButtonPayClaims.Text = "Pay claims";
            // 
            // panelTransactions
            // 
            this.panelTransactions.ColumnCount = 1;
            this.panelTransactions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTransactions.Controls.Add(this.panelNewTransaction, 0, 0);
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
            // panelNewTransaction
            // 
            this.panelNewTransaction.Controls.Add(this.comboInternal);
            this.panelNewTransaction.Controls.Add(this.buttonCheckNone);
            this.panelNewTransaction.Controls.Add(this.buttonCheckAll);
            this.panelNewTransaction.Controls.Add(this.checkedListForWhom);
            this.panelNewTransaction.Controls.Add(this.buttonAddTransaction);
            this.panelNewTransaction.Controls.Add(this.textAmount);
            this.panelNewTransaction.Controls.Add(this.labelAmount);
            this.panelNewTransaction.Controls.Add(this.radioInternal);
            this.panelNewTransaction.Controls.Add(this.labelForWhom);
            this.panelNewTransaction.Controls.Add(this.radioCollectiveExpense);
            this.panelNewTransaction.Controls.Add(this.radioSingleExpense);
            this.panelNewTransaction.Controls.Add(this.comboCreditor);
            this.panelNewTransaction.Controls.Add(this.labelCreditor);
            this.panelNewTransaction.Controls.Add(this.textTransactionDetails);
            this.panelNewTransaction.Controls.Add(this.labelTransactionDetails);
            this.panelNewTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewTransaction.Location = new System.Drawing.Point(1, 1);
            this.panelNewTransaction.Margin = new System.Windows.Forms.Padding(1);
            this.panelNewTransaction.Name = "panelNewTransaction";
            this.panelNewTransaction.Size = new System.Drawing.Size(787, 128);
            this.panelNewTransaction.TabIndex = 0;
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
            // checkedListForWhom
            // 
            this.checkedListForWhom.CheckOnClick = true;
            this.checkedListForWhom.FormattingEnabled = true;
            this.checkedListForWhom.Location = new System.Drawing.Point(420, 28);
            this.checkedListForWhom.Name = "checkedListForWhom";
            this.checkedListForWhom.Size = new System.Drawing.Size(169, 94);
            this.checkedListForWhom.TabIndex = 10;
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
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(250, 34);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(140, 20);
            this.textAmount.TabIndex = 5;
            this.textAmount.TextChanged += new System.EventHandler(this.textAmount_TextChanged);
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
            // radioInternal
            // 
            this.radioInternal.AutoSize = true;
            this.radioInternal.Location = new System.Drawing.Point(184, 106);
            this.radioInternal.Name = "radioInternal";
            this.radioInternal.Size = new System.Drawing.Size(64, 17);
            this.radioInternal.TabIndex = 8;
            this.radioInternal.Text = "Transfer";
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
            // accountBindingSourceWho
            // 
            this.accountBindingSourceWho.DataSource = typeof(TravelAccounting.Model.Account);
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
            // transactionLineBindingSource
            // 
            this.transactionLineBindingSource.DataSource = typeof(TravelAccounting.Model.TransactionLine);
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
            this.nameDataGridViewTextBoxColumn.Frozen = true;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "Credit";
            this.creditDataGridViewTextBoxColumn.Frozen = true;
            this.creditDataGridViewTextBoxColumn.HeaderText = "Credit";
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            this.creditDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // debtDataGridViewTextBoxColumn
            // 
            this.debtDataGridViewTextBoxColumn.DataPropertyName = "Debt";
            this.debtDataGridViewTextBoxColumn.Frozen = true;
            this.debtDataGridViewTextBoxColumn.HeaderText = "Debt";
            this.debtDataGridViewTextBoxColumn.Name = "debtDataGridViewTextBoxColumn";
            this.debtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseDataGridViewTextBoxColumn
            // 
            this.expenseDataGridViewTextBoxColumn.DataPropertyName = "Expense";
            this.expenseDataGridViewTextBoxColumn.Frozen = true;
            this.expenseDataGridViewTextBoxColumn.HeaderText = "Expense";
            this.expenseDataGridViewTextBoxColumn.Name = "expenseDataGridViewTextBoxColumn";
            this.expenseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.AllowNew = false;
            this.accountBindingSource.DataSource = typeof(TravelAccounting.Model.Account);
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
            // errorProviderNewTransaction
            // 
            this.errorProviderNewTransaction.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(791, 480);
            this.Controls.Add(this.panelMainPanel);
            this.Controls.Add(this.panelTableStart);
            this.MinimumSize = new System.Drawing.Size(807, 519);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel accounter";
            this.panelTableStart.ResumeLayout(false);
            this.panelMainPanel.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelWorkArea.ResumeLayout(false);
            this.panelClaims.ResumeLayout(false);
            this.panelClaims.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClaims)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimBindingSource)).EndInit();
            this.toolStripClaims.ResumeLayout(false);
            this.toolStripClaims.PerformLayout();
            this.panelTransactions.ResumeLayout(false);
            this.panelNewTransaction.ResumeLayout(false);
            this.panelNewTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSourceWho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLineBindingSource)).EndInit();
            this.panelAccounts.ResumeLayout(false);
            this.panelAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.toolStripAccounts.ResumeLayout(false);
            this.toolStripAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button buttonStartNewTravel;
        internal System.Windows.Forms.TableLayoutPanel panelTableStart;
        internal System.Windows.Forms.TableLayoutPanel panelMainPanel;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonAccounts;
        private System.Windows.Forms.Button buttonTransaction;
        private System.Windows.Forms.Panel panelWorkArea;
        private System.Windows.Forms.ToolStrip toolStripAccounts;
        internal System.Windows.Forms.Panel panelAccounts;
        internal System.Windows.Forms.BindingSource accountBindingSource;
        internal System.Windows.Forms.ToolStripButton toolStripButtonNewAccount;
        internal System.Windows.Forms.ToolStripButton toolStripButtonDeleteAccount;
        internal System.Windows.Forms.DataGridView dataGridAccounts;
        private System.Windows.Forms.TableLayoutPanel panelTransactions;
        private System.Windows.Forms.Panel panelNewTransaction;
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
        private System.Windows.Forms.ErrorProvider errorProviderNewTransaction;
        private System.Windows.Forms.Button buttonClaims;
        private System.Windows.Forms.Panel panelClaims;
        private System.Windows.Forms.ToolStrip toolStripClaims;
        internal System.Windows.Forms.ToolStripButton toolStripButtonCalculateClaims;
        internal System.Windows.Forms.ToolStripButton toolStripButtonPayClaims;
        internal System.Windows.Forms.DataGridView dataGridClaims;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        internal System.Windows.Forms.BindingSource claimBindingSource;
        internal System.Windows.Forms.Button buttonOpen;
        internal System.Windows.Forms.Button buttonOpenTravel;
        internal System.Windows.Forms.Button buttonSaveTravel;

    }
}

