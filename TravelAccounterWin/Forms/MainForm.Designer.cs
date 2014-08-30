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
            this.buttonTravel = new System.Windows.Forms.Button();
            this.panelWorkArea = new System.Windows.Forms.Panel();
            this.panelClaims = new System.Windows.Forms.Panel();
            this.dataGridClaims = new System.Windows.Forms.DataGridView();
            this.toolStripClaims = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCalculateClaims = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPayClaims = new System.Windows.Forms.ToolStripButton();
            this.creditorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsControl = new TravelAccounterWin.Forms.Controls.TransactionsControl();
            this.travelControl = new TravelAccounterWin.Forms.Controls.TravelControl();
            this.panelTableStart.SuspendLayout();
            this.panelMainPanel.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelWorkArea.SuspendLayout();
            this.panelClaims.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClaims)).BeginInit();
            this.toolStripClaims.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.claimBindingSource)).BeginInit();
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
            this.panelTableStart.Location = new System.Drawing.Point(384, 285);
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
            this.panelMainPanel.Size = new System.Drawing.Size(1042, 687);
            this.panelMainPanel.TabIndex = 5;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.buttonOpenTravel);
            this.panelTop.Controls.Add(this.buttonSaveTravel);
            this.panelTop.Controls.Add(this.buttonClaims);
            this.panelTop.Controls.Add(this.buttonTransaction);
            this.panelTop.Controls.Add(this.buttonTravel);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(1, 1);
            this.panelTop.Margin = new System.Windows.Forms.Padding(1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1040, 68);
            this.panelTop.TabIndex = 0;
            // 
            // buttonOpenTravel
            // 
            this.buttonOpenTravel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonOpenTravel.Location = new System.Drawing.Point(869, 3);
            this.buttonOpenTravel.Name = "buttonOpenTravel";
            this.buttonOpenTravel.Size = new System.Drawing.Size(77, 62);
            this.buttonOpenTravel.TabIndex = 3;
            this.buttonOpenTravel.Text = "Open travel";
            this.buttonOpenTravel.UseVisualStyleBackColor = true;
            // 
            // buttonSaveTravel
            // 
            this.buttonSaveTravel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSaveTravel.Location = new System.Drawing.Point(952, 3);
            this.buttonSaveTravel.Name = "buttonSaveTravel";
            this.buttonSaveTravel.Size = new System.Drawing.Size(77, 62);
            this.buttonSaveTravel.TabIndex = 4;
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
            // buttonTravel
            // 
            this.buttonTravel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonTravel.Location = new System.Drawing.Point(3, 3);
            this.buttonTravel.Name = "buttonTravel";
            this.buttonTravel.Size = new System.Drawing.Size(77, 62);
            this.buttonTravel.TabIndex = 0;
            this.buttonTravel.Text = "Travel";
            this.buttonTravel.UseVisualStyleBackColor = true;
            this.buttonTravel.Click += new System.EventHandler(this.buttonAccounts_Click);
            // 
            // panelWorkArea
            // 
            this.panelWorkArea.Controls.Add(this.transactionsControl);
            this.panelWorkArea.Controls.Add(this.panelClaims);
            this.panelWorkArea.Controls.Add(this.travelControl);
            this.panelWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkArea.Location = new System.Drawing.Point(1, 71);
            this.panelWorkArea.Margin = new System.Windows.Forms.Padding(1);
            this.panelWorkArea.Name = "panelWorkArea";
            this.panelWorkArea.Size = new System.Drawing.Size(1040, 615);
            this.panelWorkArea.TabIndex = 1;
            // 
            // panelClaims
            // 
            this.panelClaims.Controls.Add(this.dataGridClaims);
            this.panelClaims.Controls.Add(this.toolStripClaims);
            this.panelClaims.Location = new System.Drawing.Point(0, 84);
            this.panelClaims.Name = "panelClaims";
            this.panelClaims.Size = new System.Drawing.Size(572, 324);
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
            this.debtorDataGridViewTextBoxColumn1});
            this.dataGridClaims.DataSource = this.claimBindingSource;
            this.dataGridClaims.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridClaims.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridClaims.Location = new System.Drawing.Point(0, 25);
            this.dataGridClaims.Name = "dataGridClaims";
            this.dataGridClaims.RowHeadersVisible = false;
            this.dataGridClaims.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClaims.Size = new System.Drawing.Size(572, 299);
            this.dataGridClaims.TabIndex = 1;
            // 
            // toolStripClaims
            // 
            this.toolStripClaims.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCalculateClaims,
            this.toolStripButtonPayClaims});
            this.toolStripClaims.Location = new System.Drawing.Point(0, 0);
            this.toolStripClaims.Name = "toolStripClaims";
            this.toolStripClaims.Size = new System.Drawing.Size(572, 25);
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
            // claimBindingSource
            // 
            this.claimBindingSource.AllowNew = false;
            this.claimBindingSource.DataSource = typeof(TravelAccounting.Model.Claim);
            // 
            // transactionLineBindingSource
            // 
            this.transactionLineBindingSource.DataSource = typeof(TravelAccounting.Model.TransactionLine);
            // 
            // transactionsControl
            // 
            this.transactionsControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transactionsControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transactionsControl.Location = new System.Drawing.Point(97, 3);
            this.transactionsControl.Name = "transactionsControl";
            this.transactionsControl.Size = new System.Drawing.Size(914, 549);
            this.transactionsControl.TabIndex = 4;
            // 
            // travelControl
            // 
            this.travelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.travelControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.travelControl.Location = new System.Drawing.Point(4, 3);
            this.travelControl.MinimumSize = new System.Drawing.Size(933, 567);
            this.travelControl.Name = "travelControl";
            this.travelControl.Size = new System.Drawing.Size(933, 567);
            this.travelControl.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1042, 687);
            this.Controls.Add(this.panelMainPanel);
            this.Controls.Add(this.panelTableStart);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.toolStripClaims.ResumeLayout(false);
            this.toolStripClaims.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.claimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLineBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button buttonStartNewTravel;
        internal System.Windows.Forms.TableLayoutPanel panelTableStart;
        internal System.Windows.Forms.TableLayoutPanel panelMainPanel;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonTravel;
        private System.Windows.Forms.Button buttonTransaction;
        private System.Windows.Forms.Panel panelWorkArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        internal System.Windows.Forms.BindingSource transactionLineBindingSource;
        private System.Windows.Forms.Button buttonClaims;
        private System.Windows.Forms.Panel panelClaims;
        private System.Windows.Forms.ToolStrip toolStripClaims;
        internal System.Windows.Forms.ToolStripButton toolStripButtonCalculateClaims;
        internal System.Windows.Forms.ToolStripButton toolStripButtonPayClaims;
        internal System.Windows.Forms.DataGridView dataGridClaims;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        internal System.Windows.Forms.BindingSource claimBindingSource;
        internal System.Windows.Forms.Button buttonOpen;
        internal System.Windows.Forms.Button buttonOpenTravel;
        internal System.Windows.Forms.Button buttonSaveTravel;
        internal Controls.TravelControl travelControl;
        internal Controls.TransactionsControl transactionsControl;

    }
}

