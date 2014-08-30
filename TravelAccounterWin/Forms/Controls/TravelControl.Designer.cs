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
            this.tablePanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.labelTravelName = new System.Windows.Forms.Label();
            this.textTravelName = new System.Windows.Forms.TextBox();
            this.labelTravelDetails = new System.Windows.Forms.Label();
            this.textTravelDetails = new System.Windows.Forms.TextBox();
            this.labelTravelGeneral = new System.Windows.Forms.Label();
            this.travelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelAccounts = new System.Windows.Forms.Panel();
            this.labelAccounts = new System.Windows.Forms.Label();
            this.panelCurrencies = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tablePanelMain.SuspendLayout();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelBindingSource)).BeginInit();
            this.panelAccounts.SuspendLayout();
            this.panelCurrencies.SuspendLayout();
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
            this.tablePanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tablePanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelMain.Size = new System.Drawing.Size(801, 467);
            this.tablePanelMain.TabIndex = 0;
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.labelTravelGeneral);
            this.panelDetails.Controls.Add(this.textTravelDetails);
            this.panelDetails.Controls.Add(this.labelTravelDetails);
            this.panelDetails.Controls.Add(this.textTravelName);
            this.panelDetails.Controls.Add(this.labelTravelName);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(3, 3);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(795, 144);
            this.panelDetails.TabIndex = 0;
            // 
            // labelTravelName
            // 
            this.labelTravelName.AutoSize = true;
            this.labelTravelName.Location = new System.Drawing.Point(20, 36);
            this.labelTravelName.Name = "labelTravelName";
            this.labelTravelName.Size = new System.Drawing.Size(67, 13);
            this.labelTravelName.TabIndex = 0;
            this.labelTravelName.Text = "Travel name";
            // 
            // textTravelName
            // 
            this.textTravelName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.travelBindingSource, "Name", true));
            this.textTravelName.Location = new System.Drawing.Point(99, 33);
            this.textTravelName.Name = "textTravelName";
            this.textTravelName.Size = new System.Drawing.Size(319, 22);
            this.textTravelName.TabIndex = 1;
            // 
            // labelTravelDetails
            // 
            this.labelTravelDetails.AutoSize = true;
            this.labelTravelDetails.Location = new System.Drawing.Point(20, 64);
            this.labelTravelDetails.Name = "labelTravelDetails";
            this.labelTravelDetails.Size = new System.Drawing.Size(73, 13);
            this.labelTravelDetails.TabIndex = 0;
            this.labelTravelDetails.Text = "Travel details";
            // 
            // textTravelDetails
            // 
            this.textTravelDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.travelBindingSource, "Details", true));
            this.textTravelDetails.Location = new System.Drawing.Point(99, 61);
            this.textTravelDetails.Multiline = true;
            this.textTravelDetails.Name = "textTravelDetails";
            this.textTravelDetails.Size = new System.Drawing.Size(319, 74);
            this.textTravelDetails.TabIndex = 1;
            // 
            // labelTravelGeneral
            // 
            this.labelTravelGeneral.AutoSize = true;
            this.labelTravelGeneral.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTravelGeneral.Location = new System.Drawing.Point(3, 3);
            this.labelTravelGeneral.Margin = new System.Windows.Forms.Padding(3);
            this.labelTravelGeneral.Name = "labelTravelGeneral";
            this.labelTravelGeneral.Size = new System.Drawing.Size(122, 21);
            this.labelTravelGeneral.TabIndex = 2;
            this.labelTravelGeneral.Text = "General settings";
            // 
            // travelBindingSource
            // 
            this.travelBindingSource.DataSource = typeof(TravelAccounting.Model.Travel);
            // 
            // panelAccounts
            // 
            this.panelAccounts.AutoScroll = true;
            this.panelAccounts.Controls.Add(this.labelAccounts);
            this.panelAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAccounts.Location = new System.Drawing.Point(3, 153);
            this.panelAccounts.Name = "panelAccounts";
            this.panelAccounts.Size = new System.Drawing.Size(795, 152);
            this.panelAccounts.TabIndex = 3;
            // 
            // labelAccounts
            // 
            this.labelAccounts.AutoSize = true;
            this.labelAccounts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAccounts.Location = new System.Drawing.Point(3, 3);
            this.labelAccounts.Margin = new System.Windows.Forms.Padding(3);
            this.labelAccounts.Name = "labelAccounts";
            this.labelAccounts.Size = new System.Drawing.Size(73, 21);
            this.labelAccounts.TabIndex = 2;
            this.labelAccounts.Text = "Accounts";
            // 
            // panelCurrencies
            // 
            this.panelCurrencies.AutoScroll = true;
            this.panelCurrencies.Controls.Add(this.label1);
            this.panelCurrencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCurrencies.Location = new System.Drawing.Point(3, 311);
            this.panelCurrencies.Name = "panelCurrencies";
            this.panelCurrencies.Size = new System.Drawing.Size(795, 153);
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
            this.label1.TabIndex = 2;
            this.label1.Text = "Currency settings";
            // 
            // TravelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tablePanelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "TravelControl";
            this.Size = new System.Drawing.Size(801, 467);
            this.tablePanelMain.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelBindingSource)).EndInit();
            this.panelAccounts.ResumeLayout(false);
            this.panelAccounts.PerformLayout();
            this.panelCurrencies.ResumeLayout(false);
            this.panelCurrencies.PerformLayout();
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
    }
}
