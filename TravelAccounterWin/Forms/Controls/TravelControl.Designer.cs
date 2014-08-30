namespace TravelAccounterWin.Forms.Controls {
    partial class TravelControl {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablePanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelCurrencies = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAccounts = new System.Windows.Forms.Panel();
            this.dataGridAccounts = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelAccounts = new System.Windows.Forms.Label();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.textBaseCurrencyShortName = new System.Windows.Forms.TextBox();
            this.baseCurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelBaseCurrencyShortName = new System.Windows.Forms.Label();
            this.textBaseCurrencyName = new System.Windows.Forms.TextBox();
            this.labelBaseCurrencyName = new System.Windows.Forms.Label();
            this.labelTravelGeneral = new System.Windows.Forms.Label();
            this.textTravelDetails = new System.Windows.Forms.TextBox();
            this.travelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelTravelDetails = new System.Windows.Forms.Label();
            this.textTravelName = new System.Windows.Forms.TextBox();
            this.labelTravelName = new System.Windows.Forms.Label();
            this.dataGridCcurrencies = new System.Windows.Forms.DataGridView();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangeRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablePanelMain.SuspendLayout();
            this.panelCurrencies.SuspendLayout();
            this.panelAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseCurrencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCcurrencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanelMain
            // 
            this.tablePanelMain.ColumnCount = 1;
            this.tablePanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelMain.Controls.Add(this.panelCurrencies, 0, 2);
            this.tablePanelMain.Controls.Add(this.panelAccounts, 0, 1);
            this.tablePanelMain.Controls.Add(this.panelDetails, 0, 0);
            this.tablePanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelMain.Location = new System.Drawing.Point(0, 0);
            this.tablePanelMain.Name = "tablePanelMain";
            this.tablePanelMain.RowCount = 3;
            this.tablePanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tablePanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelMain.Size = new System.Drawing.Size(933, 567);
            this.tablePanelMain.TabIndex = 0;
            // 
            // panelCurrencies
            // 
            this.panelCurrencies.AutoScroll = true;
            this.panelCurrencies.Controls.Add(this.dataGridCcurrencies);
            this.panelCurrencies.Controls.Add(this.label1);
            this.panelCurrencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCurrencies.Location = new System.Drawing.Point(3, 350);
            this.panelCurrencies.Name = "panelCurrencies";
            this.panelCurrencies.Size = new System.Drawing.Size(927, 214);
            this.panelCurrencies.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency settings";
            // 
            // panelAccounts
            // 
            this.panelAccounts.AutoScroll = true;
            this.panelAccounts.Controls.Add(this.dataGridAccounts);
            this.panelAccounts.Controls.Add(this.labelAccounts);
            this.panelAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAccounts.Location = new System.Drawing.Point(3, 131);
            this.panelAccounts.Name = "panelAccounts";
            this.panelAccounts.Size = new System.Drawing.Size(927, 213);
            this.panelAccounts.TabIndex = 3;
            // 
            // dataGridAccounts
            // 
            this.dataGridAccounts.AllowUserToResizeRows = false;
            this.dataGridAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAccounts.AutoGenerateColumns = false;
            this.dataGridAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn,
            this.debtDataGridViewTextBoxColumn,
            this.expenseDataGridViewTextBoxColumn});
            this.dataGridAccounts.DataSource = this.accountBindingSource;
            this.dataGridAccounts.Location = new System.Drawing.Point(23, 32);
            this.dataGridAccounts.MultiSelect = false;
            this.dataGridAccounts.Name = "dataGridAccounts";
            this.dataGridAccounts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridAccounts.Size = new System.Drawing.Size(884, 181);
            this.dataGridAccounts.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle2.NullValue = null;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "Credit";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.creditDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.creditDataGridViewTextBoxColumn.HeaderText = "Credit";
            this.creditDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            this.creditDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // debtDataGridViewTextBoxColumn
            // 
            this.debtDataGridViewTextBoxColumn.DataPropertyName = "Debt";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.debtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.debtDataGridViewTextBoxColumn.HeaderText = "Debt";
            this.debtDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.debtDataGridViewTextBoxColumn.Name = "debtDataGridViewTextBoxColumn";
            this.debtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseDataGridViewTextBoxColumn
            // 
            this.expenseDataGridViewTextBoxColumn.DataPropertyName = "Expense";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.expenseDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.expenseDataGridViewTextBoxColumn.HeaderText = "Expense";
            this.expenseDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.expenseDataGridViewTextBoxColumn.Name = "expenseDataGridViewTextBoxColumn";
            this.expenseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.AllowNew = true;
            this.accountBindingSource.DataSource = typeof(TravelAccounting.Model.Account);
            // 
            // labelAccounts
            // 
            this.labelAccounts.AutoSize = true;
            this.labelAccounts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAccounts.Location = new System.Drawing.Point(3, 3);
            this.labelAccounts.Margin = new System.Windows.Forms.Padding(3);
            this.labelAccounts.Name = "labelAccounts";
            this.labelAccounts.Size = new System.Drawing.Size(73, 21);
            this.labelAccounts.TabIndex = 0;
            this.labelAccounts.Text = "Accounts";
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.textBaseCurrencyShortName);
            this.panelDetails.Controls.Add(this.labelBaseCurrencyShortName);
            this.panelDetails.Controls.Add(this.textBaseCurrencyName);
            this.panelDetails.Controls.Add(this.labelBaseCurrencyName);
            this.panelDetails.Controls.Add(this.labelTravelGeneral);
            this.panelDetails.Controls.Add(this.textTravelDetails);
            this.panelDetails.Controls.Add(this.labelTravelDetails);
            this.panelDetails.Controls.Add(this.textTravelName);
            this.panelDetails.Controls.Add(this.labelTravelName);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(3, 3);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(927, 122);
            this.panelDetails.TabIndex = 0;
            // 
            // textBaseCurrencyShortName
            // 
            this.textBaseCurrencyShortName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseCurrencyBindingSource, "ShortName", true));
            this.textBaseCurrencyShortName.Location = new System.Drawing.Point(164, 89);
            this.textBaseCurrencyShortName.Name = "textBaseCurrencyShortName";
            this.textBaseCurrencyShortName.Size = new System.Drawing.Size(266, 22);
            this.textBaseCurrencyShortName.TabIndex = 6;
            // 
            // baseCurrencyBindingSource
            // 
            this.baseCurrencyBindingSource.DataSource = typeof(TravelAccounting.Model.Currency);
            // 
            // labelBaseCurrencyShortName
            // 
            this.labelBaseCurrencyShortName.AutoSize = true;
            this.labelBaseCurrencyShortName.Location = new System.Drawing.Point(20, 92);
            this.labelBaseCurrencyShortName.Name = "labelBaseCurrencyShortName";
            this.labelBaseCurrencyShortName.Size = new System.Drawing.Size(138, 13);
            this.labelBaseCurrencyShortName.TabIndex = 5;
            this.labelBaseCurrencyShortName.Text = "Base currency short name";
            // 
            // textBaseCurrencyName
            // 
            this.textBaseCurrencyName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baseCurrencyBindingSource, "Name", true));
            this.textBaseCurrencyName.Location = new System.Drawing.Point(164, 61);
            this.textBaseCurrencyName.Name = "textBaseCurrencyName";
            this.textBaseCurrencyName.Size = new System.Drawing.Size(266, 22);
            this.textBaseCurrencyName.TabIndex = 4;
            // 
            // labelBaseCurrencyName
            // 
            this.labelBaseCurrencyName.AutoSize = true;
            this.labelBaseCurrencyName.Location = new System.Drawing.Point(20, 64);
            this.labelBaseCurrencyName.Name = "labelBaseCurrencyName";
            this.labelBaseCurrencyName.Size = new System.Drawing.Size(108, 13);
            this.labelBaseCurrencyName.TabIndex = 3;
            this.labelBaseCurrencyName.Text = "Base currency name";
            // 
            // labelTravelGeneral
            // 
            this.labelTravelGeneral.AutoSize = true;
            this.labelTravelGeneral.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTravelGeneral.Location = new System.Drawing.Point(3, 3);
            this.labelTravelGeneral.Margin = new System.Windows.Forms.Padding(3);
            this.labelTravelGeneral.Name = "labelTravelGeneral";
            this.labelTravelGeneral.Size = new System.Drawing.Size(122, 21);
            this.labelTravelGeneral.TabIndex = 0;
            this.labelTravelGeneral.Text = "General settings";
            // 
            // textTravelDetails
            // 
            this.textTravelDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.travelBindingSource, "Details", true));
            this.textTravelDetails.Location = new System.Drawing.Point(547, 33);
            this.textTravelDetails.Multiline = true;
            this.textTravelDetails.Name = "textTravelDetails";
            this.textTravelDetails.Size = new System.Drawing.Size(319, 78);
            this.textTravelDetails.TabIndex = 8;
            // 
            // travelBindingSource
            // 
            this.travelBindingSource.DataSource = typeof(TravelAccounting.Model.Travel);
            // 
            // labelTravelDetails
            // 
            this.labelTravelDetails.AutoSize = true;
            this.labelTravelDetails.Location = new System.Drawing.Point(468, 36);
            this.labelTravelDetails.Name = "labelTravelDetails";
            this.labelTravelDetails.Size = new System.Drawing.Size(73, 13);
            this.labelTravelDetails.TabIndex = 7;
            this.labelTravelDetails.Text = "Travel details";
            // 
            // textTravelName
            // 
            this.textTravelName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.travelBindingSource, "Name", true));
            this.textTravelName.Location = new System.Drawing.Point(164, 33);
            this.textTravelName.Name = "textTravelName";
            this.textTravelName.Size = new System.Drawing.Size(266, 22);
            this.textTravelName.TabIndex = 2;
            // 
            // labelTravelName
            // 
            this.labelTravelName.AutoSize = true;
            this.labelTravelName.Location = new System.Drawing.Point(20, 36);
            this.labelTravelName.Name = "labelTravelName";
            this.labelTravelName.Size = new System.Drawing.Size(67, 13);
            this.labelTravelName.TabIndex = 1;
            this.labelTravelName.Text = "Travel name";
            // 
            // dataGridCcurrencies
            // 
            this.dataGridCcurrencies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCcurrencies.AutoGenerateColumns = false;
            this.dataGridCcurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCcurrencies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.shortNameDataGridViewTextBoxColumn,
            this.exchangeRateDataGridViewTextBoxColumn});
            this.dataGridCcurrencies.DataSource = this.currencyBindingSource;
            this.dataGridCcurrencies.Location = new System.Drawing.Point(23, 30);
            this.dataGridCcurrencies.Name = "dataGridCcurrencies";
            this.dataGridCcurrencies.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridCcurrencies.Size = new System.Drawing.Size(884, 172);
            this.dataGridCcurrencies.TabIndex = 1;
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.AllowNew = true;
            this.currencyBindingSource.DataSource = typeof(TravelAccounting.Model.Currency);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // shortNameDataGridViewTextBoxColumn
            // 
            this.shortNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.shortNameDataGridViewTextBoxColumn.DataPropertyName = "ShortName";
            this.shortNameDataGridViewTextBoxColumn.HeaderText = "Short Name";
            this.shortNameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.shortNameDataGridViewTextBoxColumn.Name = "shortNameDataGridViewTextBoxColumn";
            // 
            // exchangeRateDataGridViewTextBoxColumn
            // 
            this.exchangeRateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.exchangeRateDataGridViewTextBoxColumn.DataPropertyName = "ExchangeRate";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.exchangeRateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.exchangeRateDataGridViewTextBoxColumn.HeaderText = "Exchange Rate";
            this.exchangeRateDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.exchangeRateDataGridViewTextBoxColumn.Name = "exchangeRateDataGridViewTextBoxColumn";
            this.exchangeRateDataGridViewTextBoxColumn.Width = 120;
            // 
            // TravelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tablePanelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(933, 567);
            this.Name = "TravelControl";
            this.Size = new System.Drawing.Size(933, 567);
            this.tablePanelMain.ResumeLayout(false);
            this.panelCurrencies.ResumeLayout(false);
            this.panelCurrencies.PerformLayout();
            this.panelAccounts.ResumeLayout(false);
            this.panelAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseCurrencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCcurrencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePanelMain;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.TextBox textTravelName;
        private System.Windows.Forms.Label labelTravelName;
        private System.Windows.Forms.TextBox textTravelDetails;
        private System.Windows.Forms.Label labelTravelDetails;
        private System.Windows.Forms.Label labelTravelGeneral;
        internal System.Windows.Forms.BindingSource travelBindingSource;
        private System.Windows.Forms.Panel panelCurrencies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAccounts;
        private System.Windows.Forms.Label labelAccounts;
        private System.Windows.Forms.DataGridView dataGridAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBaseCurrencyShortName;
        private System.Windows.Forms.Label labelBaseCurrencyShortName;
        private System.Windows.Forms.TextBox textBaseCurrencyName;
        private System.Windows.Forms.Label labelBaseCurrencyName;
        internal System.Windows.Forms.BindingSource accountBindingSource;
        internal System.Windows.Forms.BindingSource baseCurrencyBindingSource;
        private System.Windows.Forms.DataGridView dataGridCcurrencies;
        internal System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exchangeRateDataGridViewTextBoxColumn;
    }
}
