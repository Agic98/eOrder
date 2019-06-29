namespace eOrder.Win.Forms
{
    partial class frmOrganizationHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrganizationHome));
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPendingOrders = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvActiveOrders = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvOrderHistory = new System.Windows.Forms.DataGridView();
            this.gbxSelectedOrderDetails = new System.Windows.Forms.GroupBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.gbxOrderDetailsData = new System.Windows.Forms.GroupBox();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnDelegate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefreshData = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingOrders)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveOrders)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).BeginInit();
            this.gbxSelectedOrderDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Location = new System.Drawing.Point(145, 36);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(72, 72);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1292, 811);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPendingOrders);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1284, 785);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pending orders";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPendingOrders
            // 
            this.dgvPendingOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPendingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPendingOrders.Location = new System.Drawing.Point(3, 3);
            this.dgvPendingOrders.Name = "dgvPendingOrders";
            this.dgvPendingOrders.Size = new System.Drawing.Size(1278, 779);
            this.dgvPendingOrders.TabIndex = 0;
            this.dgvPendingOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPendingOrders_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvActiveOrders);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1284, 785);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Active orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvActiveOrders
            // 
            this.dgvActiveOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvActiveOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvActiveOrders.Location = new System.Drawing.Point(3, 3);
            this.dgvActiveOrders.Name = "dgvActiveOrders";
            this.dgvActiveOrders.Size = new System.Drawing.Size(1278, 779);
            this.dgvActiveOrders.TabIndex = 1;
            this.dgvActiveOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActiveOrders_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvOrderHistory);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1284, 785);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Order history";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvOrderHistory
            // 
            this.dgvOrderHistory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvOrderHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderHistory.Name = "dgvOrderHistory";
            this.dgvOrderHistory.Size = new System.Drawing.Size(1284, 782);
            this.dgvOrderHistory.TabIndex = 1;
            this.dgvOrderHistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderHistory_CellDoubleClick);
            // 
            // gbxSelectedOrderDetails
            // 
            this.gbxSelectedOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSelectedOrderDetails.Controls.Add(this.btnTotal);
            this.gbxSelectedOrderDetails.Controls.Add(this.gbxOrderDetailsData);
            this.gbxSelectedOrderDetails.Controls.Add(this.btnOrderDetails);
            this.gbxSelectedOrderDetails.Controls.Add(this.btnDelegate);
            this.gbxSelectedOrderDetails.Controls.Add(this.btnCancel);
            this.gbxSelectedOrderDetails.Controls.Add(this.btnProcess);
            this.gbxSelectedOrderDetails.Location = new System.Drawing.Point(1310, 115);
            this.gbxSelectedOrderDetails.Name = "gbxSelectedOrderDetails";
            this.gbxSelectedOrderDetails.Size = new System.Drawing.Size(217, 708);
            this.gbxSelectedOrderDetails.TabIndex = 2;
            this.gbxSelectedOrderDetails.TabStop = false;
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTotal.Location = new System.Drawing.Point(0, 491);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(217, 50);
            this.btnTotal.TabIndex = 6;
            this.btnTotal.UseVisualStyleBackColor = false;
            // 
            // gbxOrderDetailsData
            // 
            this.gbxOrderDetailsData.Location = new System.Drawing.Point(0, 9);
            this.gbxOrderDetailsData.Name = "gbxOrderDetailsData";
            this.gbxOrderDetailsData.Size = new System.Drawing.Size(217, 476);
            this.gbxOrderDetailsData.TabIndex = 4;
            this.gbxOrderDetailsData.TabStop = false;
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOrderDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrderDetails.Location = new System.Drawing.Point(0, 547);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(217, 50);
            this.btnOrderDetails.TabIndex = 5;
            this.btnOrderDetails.Text = "Details";
            this.btnOrderDetails.UseVisualStyleBackColor = false;
            this.btnOrderDetails.Click += new System.EventHandler(this.BtnOrderDetails_Click);
            // 
            // btnDelegate
            // 
            this.btnDelegate.Location = new System.Drawing.Point(0, 603);
            this.btnDelegate.Name = "btnDelegate";
            this.btnDelegate.Size = new System.Drawing.Size(217, 50);
            this.btnDelegate.TabIndex = 3;
            this.btnDelegate.Text = "Delegate";
            this.btnDelegate.UseVisualStyleBackColor = true;
            this.btnDelegate.Click += new System.EventHandler(this.BtnDelegate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(0, 659);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 50);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(113, 659);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(104, 50);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.Location = new System.Drawing.Point(73, 36);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(72, 72);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnRefreshData);
            this.groupBox2.Controls.Add(this.btnSettings);
            this.groupBox2.Controls.Add(this.btnLogout);
            this.groupBox2.Location = new System.Drawing.Point(1310, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 111);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshData.BackgroundImage")));
            this.btnRefreshData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshData.Location = new System.Drawing.Point(0, 36);
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.Size = new System.Drawing.Size(72, 72);
            this.btnRefreshData.TabIndex = 4;
            this.btnRefreshData.UseVisualStyleBackColor = true;
            this.btnRefreshData.Click += new System.EventHandler(this.BtnRefreshData_Click);
            // 
            // frmOrganizationHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1539, 835);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxSelectedOrderDetails);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrganizationHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrganizationHome_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingOrders)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveOrders)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).EndInit();
            this.gbxSelectedOrderDetails.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbxSelectedOrderDetails;
        private System.Windows.Forms.Button btnDelegate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPendingOrders;
        private System.Windows.Forms.Button btnRefreshData;
        private System.Windows.Forms.DataGridView dgvActiveOrders;
        private System.Windows.Forms.DataGridView dgvOrderHistory;
        private System.Windows.Forms.GroupBox gbxOrderDetailsData;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Button btnTotal;
    }
}