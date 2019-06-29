namespace eOrder.Win.Forms.FormsRequest
{
    partial class frmCountryRequest
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
            this.gbxCountryData = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrimaryCurrency = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbxCountryData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCountryData
            // 
            this.gbxCountryData.Controls.Add(this.label3);
            this.gbxCountryData.Controls.Add(this.txtPrimaryCurrency);
            this.gbxCountryData.Controls.Add(this.btnSave);
            this.gbxCountryData.Controls.Add(this.label2);
            this.gbxCountryData.Controls.Add(this.txtCode);
            this.gbxCountryData.Controls.Add(this.label1);
            this.gbxCountryData.Controls.Add(this.txtName);
            this.gbxCountryData.Location = new System.Drawing.Point(3, 3);
            this.gbxCountryData.Name = "gbxCountryData";
            this.gbxCountryData.Size = new System.Drawing.Size(242, 260);
            this.gbxCountryData.TabIndex = 0;
            this.gbxCountryData.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Primary currency";
            // 
            // txtPrimaryCurrency
            // 
            this.txtPrimaryCurrency.Location = new System.Drawing.Point(10, 158);
            this.txtPrimaryCurrency.Name = "txtPrimaryCurrency";
            this.txtPrimaryCurrency.Size = new System.Drawing.Size(211, 20);
            this.txtPrimaryCurrency.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(148, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(12, 100);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(211, 20);
            this.txtCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(10, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 20);
            this.txtName.TabIndex = 0;
            // 
            // frmCountryRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 275);
            this.Controls.Add(this.gbxCountryData);
            this.Name = "frmCountryRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Country";
            this.Load += new System.EventHandler(this.frmCountryRequest_Load);
            this.gbxCountryData.ResumeLayout(false);
            this.gbxCountryData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCountryData;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrimaryCurrency;
    }
}