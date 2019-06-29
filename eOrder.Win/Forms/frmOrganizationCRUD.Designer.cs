namespace eOrder.Win.Forms
{
    partial class frmOrganizationCRUD
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
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab3 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            this.ultraTabPageControl3 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.gbxProductFilters = new System.Windows.Forms.GroupBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtproductName = new System.Windows.Forms.TextBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOrganizationsTable = new Infragistics.Win.UltraWinTabControl.UltraTabControl();
            this.ultraTabSharedControlsPage1 = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
            this.ultraTabPageControl3.SuspendLayout();
            this.gbxProductFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizationsTable)).BeginInit();
            this.dgvOrganizationsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraTabPageControl3
            // 
            this.ultraTabPageControl3.Controls.Add(this.gbxProductFilters);
            this.ultraTabPageControl3.Controls.Add(this.dgvProduct);
            this.ultraTabPageControl3.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraTabPageControl3.Name = "ultraTabPageControl3";
            this.ultraTabPageControl3.Size = new System.Drawing.Size(785, 564);
            // 
            // gbxProductFilters
            // 
            this.gbxProductFilters.AutoSize = true;
            this.gbxProductFilters.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxProductFilters.Controls.Add(this.btnProductAdd);
            this.gbxProductFilters.Controls.Add(this.btnProductSearch);
            this.gbxProductFilters.Controls.Add(this.label2);
            this.gbxProductFilters.Controls.Add(this.txtproductName);
            this.gbxProductFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxProductFilters.Location = new System.Drawing.Point(0, 0);
            this.gbxProductFilters.Margin = new System.Windows.Forms.Padding(0);
            this.gbxProductFilters.Name = "gbxProductFilters";
            this.gbxProductFilters.Padding = new System.Windows.Forms.Padding(0);
            this.gbxProductFilters.Size = new System.Drawing.Size(785, 61);
            this.gbxProductFilters.TabIndex = 1;
            this.gbxProductFilters.TabStop = false;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductAdd.Location = new System.Drawing.Point(702, 9);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProductAdd.TabIndex = 8;
            this.btnProductAdd.Text = "Add new";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.BtnProductAdd_Click);
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductSearch.Location = new System.Drawing.Point(621, 9);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(75, 23);
            this.btnProductSearch.TabIndex = 7;
            this.btnProductSearch.Text = "Search";
            this.btnProductSearch.UseVisualStyleBackColor = true;
            this.btnProductSearch.Click += new System.EventHandler(this.BtnProductSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // txtproductName
            // 
            this.txtproductName.Location = new System.Drawing.Point(5, 25);
            this.txtproductName.Name = "txtproductName";
            this.txtproductName.Size = new System.Drawing.Size(419, 20);
            this.txtproductName.TabIndex = 5;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProduct.Location = new System.Drawing.Point(0, 113);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.Size = new System.Drawing.Size(785, 451);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduct_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(-93, -210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1092, 1129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.dgvOrganizationsTable);
            this.groupBox2.Location = new System.Drawing.Point(94, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(902, 870);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // dgvOrganizationsTable
            // 
            this.dgvOrganizationsTable.Controls.Add(this.ultraTabSharedControlsPage1);
            this.dgvOrganizationsTable.Controls.Add(this.ultraTabPageControl3);
            this.dgvOrganizationsTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvOrganizationsTable.Location = new System.Drawing.Point(3, 16);
            this.dgvOrganizationsTable.Name = "dgvOrganizationsTable";
            this.dgvOrganizationsTable.SharedControlsPage = this.ultraTabSharedControlsPage1;
            this.dgvOrganizationsTable.Size = new System.Drawing.Size(896, 568);
            this.dgvOrganizationsTable.TabIndex = 0;
            this.dgvOrganizationsTable.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop;
            ultraTab3.Key = "tabProduct";
            ultraTab3.TabPage = this.ultraTabPageControl3;
            ultraTab3.Text = "Products";
            this.dgvOrganizationsTable.Tabs.AddRange(new Infragistics.Win.UltraWinTabControl.UltraTab[] {
            ultraTab3});
            this.dgvOrganizationsTable.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal;
            // 
            // ultraTabSharedControlsPage1
            // 
            this.ultraTabSharedControlsPage1.Location = new System.Drawing.Point(58, 1);
            this.ultraTabSharedControlsPage1.Name = "ultraTabSharedControlsPage1";
            this.ultraTabSharedControlsPage1.Size = new System.Drawing.Size(835, 564);
            // 
            // frmOrganizationCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 709);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOrganizationCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organization records ";
            this.Load += new System.EventHandler(this.FrmOrganizationCRUD_Load);
            this.ultraTabPageControl3.ResumeLayout(false);
            this.ultraTabPageControl3.PerformLayout();
            this.gbxProductFilters.ResumeLayout(false);
            this.gbxProductFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizationsTable)).EndInit();
            this.dgvOrganizationsTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Infragistics.Win.UltraWinTabControl.UltraTabControl dgvOrganizationsTable;
        private Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage ultraTabSharedControlsPage1;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl3;
        private System.Windows.Forms.GroupBox gbxProductFilters;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtproductName;
        private System.Windows.Forms.DataGridView dgvProduct;
    }
}