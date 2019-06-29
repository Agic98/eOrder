namespace eOrder.Win.Forms.FormsDetails
{
    partial class frmOrderDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.gbxAdditionalDescriptionProduct = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbxAdditionalDescriptionOrder = new System.Windows.Forms.GroupBox();
            this.gbxDeliveryLocation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.cbxIsPayed = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.dgvProducts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(7, 20);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(548, 204);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProducts_CellDoubleClick);
            // 
            // gbxAdditionalDescriptionProduct
            // 
            this.gbxAdditionalDescriptionProduct.Location = new System.Drawing.Point(12, 263);
            this.gbxAdditionalDescriptionProduct.Name = "gbxAdditionalDescriptionProduct";
            this.gbxAdditionalDescriptionProduct.Size = new System.Drawing.Size(561, 100);
            this.gbxAdditionalDescriptionProduct.TabIndex = 1;
            this.gbxAdditionalDescriptionProduct.TabStop = false;
            this.gbxAdditionalDescriptionProduct.Text = "Additional description for selected product";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTotal.Location = new System.Drawing.Point(7, 688);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(113, 26);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total: 3.14";
            // 
            // gbxAdditionalDescriptionOrder
            // 
            this.gbxAdditionalDescriptionOrder.Location = new System.Drawing.Point(12, 369);
            this.gbxAdditionalDescriptionOrder.Name = "gbxAdditionalDescriptionOrder";
            this.gbxAdditionalDescriptionOrder.Size = new System.Drawing.Size(561, 100);
            this.gbxAdditionalDescriptionOrder.TabIndex = 2;
            this.gbxAdditionalDescriptionOrder.TabStop = false;
            this.gbxAdditionalDescriptionOrder.Text = "Additional description for complete order";
            // 
            // gbxDeliveryLocation
            // 
            this.gbxDeliveryLocation.Location = new System.Drawing.Point(12, 475);
            this.gbxDeliveryLocation.Name = "gbxDeliveryLocation";
            this.gbxDeliveryLocation.Size = new System.Drawing.Size(561, 100);
            this.gbxDeliveryLocation.TabIndex = 3;
            this.gbxDeliveryLocation.TabStop = false;
            this.gbxDeliveryLocation.Text = "Delivery location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Payment type: ";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPaymentType.Location = new System.Drawing.Point(90, 582);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(39, 13);
            this.lblPaymentType.TabIndex = 5;
            this.lblPaymentType.Text = "Paypal";
            // 
            // cbxIsPayed
            // 
            this.cbxIsPayed.AutoSize = true;
            this.cbxIsPayed.Enabled = false;
            this.cbxIsPayed.Location = new System.Drawing.Point(42, 609);
            this.cbxIsPayed.Name = "cbxIsPayed";
            this.cbxIsPayed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxIsPayed.Size = new System.Drawing.Size(64, 17);
            this.cbxIsPayed.TabIndex = 7;
            this.cbxIsPayed.Text = "IsPayed";
            this.cbxIsPayed.UseVisualStyleBackColor = true;
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 723);
            this.Controls.Add(this.cbxIsPayed);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxDeliveryLocation);
            this.Controls.Add(this.gbxAdditionalDescriptionOrder);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gbxAdditionalDescriptionProduct);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order details";
            this.Load += new System.EventHandler(this.FrmOrderDetails_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbxAdditionalDescriptionProduct;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox gbxAdditionalDescriptionOrder;
        private System.Windows.Forms.GroupBox gbxDeliveryLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.CheckBox cbxIsPayed;
    }
}