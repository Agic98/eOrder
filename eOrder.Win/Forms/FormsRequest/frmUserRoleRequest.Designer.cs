namespace eOrder.Win.Forms.FormsRequest
{
    partial class frmUserRoleRequest
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
            this.gbxUserRoleData = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxUserId = new System.Windows.Forms.ComboBox();
            this.cbxRoleId = new System.Windows.Forms.ComboBox();
            this.gbxUserRoleData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxUserRoleData
            // 
            this.gbxUserRoleData.Controls.Add(this.cbxRoleId);
            this.gbxUserRoleData.Controls.Add(this.cbxUserId);
            this.gbxUserRoleData.Controls.Add(this.btnSave);
            this.gbxUserRoleData.Controls.Add(this.Description);
            this.gbxUserRoleData.Controls.Add(this.label1);
            this.gbxUserRoleData.Location = new System.Drawing.Point(3, 2);
            this.gbxUserRoleData.Name = "gbxUserRoleData";
            this.gbxUserRoleData.Size = new System.Drawing.Size(310, 199);
            this.gbxUserRoleData.TabIndex = 0;
            this.gbxUserRoleData.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(21, 84);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(29, 13);
            this.Description.TabIndex = 3;
            this.Description.Text = "Role";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(205, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxUserId
            // 
            this.cbxUserId.FormattingEnabled = true;
            this.cbxUserId.Location = new System.Drawing.Point(24, 50);
            this.cbxUserId.Name = "cbxUserId";
            this.cbxUserId.Size = new System.Drawing.Size(256, 21);
            this.cbxUserId.TabIndex = 5;
            // 
            // cbxRoleId
            // 
            this.cbxRoleId.FormattingEnabled = true;
            this.cbxRoleId.Location = new System.Drawing.Point(24, 100);
            this.cbxRoleId.Name = "cbxRoleId";
            this.cbxRoleId.Size = new System.Drawing.Size(256, 21);
            this.cbxRoleId.TabIndex = 6;
            // 
            // frmUserRoleRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 205);
            this.Controls.Add(this.gbxUserRoleData);
            this.Name = "frmUserRoleRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User roles";
            this.Load += new System.EventHandler(this.frmUserRoleRequest_Load);
            this.gbxUserRoleData.ResumeLayout(false);
            this.gbxUserRoleData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUserRoleData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxRoleId;
        private System.Windows.Forms.ComboBox cbxUserId;
    }
}